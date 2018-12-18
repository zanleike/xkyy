using Framework.Common;
using Framework.Common.Helpers;
using System;
using System.IO;
using System.Windows.Forms;

namespace NursingManage.Win.PeiXunGuanLi
{
    public partial class FrmFileMgr : BaseEditForm
    {
        FTPHelper ftp = null;
        public object Ａrray { get; private set; }

        public FrmFileMgr()
        {
            InitializeComponent();
            Configurations.FTPUrl = "127.0.0.1/";
            ftp = new FTPHelper(Configurations.FTPUrl, "", "", "");
        }

        private void btnGo_Click(object sender, System.EventArgs e)
        {

        }

        private void FrmFileMgr_Load(object sender, System.EventArgs e)
        {
            string[] ses = ftp.GetFilesDetailList();
            lstView.Items.Clear();
            foreach (string item in ses)
            {
                string tmp = item.Replace("<DIR>", "文件夹");
                string temp = tmp.Substring(tmp.LastIndexOf(" "));
                string s = Path.Combine(ftp.ftpURI, temp);
                ListViewItem im = new ListViewItem();
                im.Name = temp;
                im.Tag = s;
                im.Text = tmp;
                lstView.Items.Add(im);
            }
        }

        private void lstView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void lstView_DragDrop(object sender, DragEventArgs e)
        {
            Array obj = (Array)e.Data.GetData(DataFormats.FileDrop);
            string path = obj.GetValue(0).ToString();
            this.Text = path;
        }

        private void menuItemUploadFile_Click(object sender, EventArgs e)
        {
            ofd.Filter = "所有文件|*.*";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ftp.Upload(ofd.FileName);
            }
        }

        private void menuItemDownloadFile_Click(object sender, EventArgs e)
        {
            ListViewItem item = lstView.SelectedItems[0];
            if (!string.IsNullOrWhiteSpace(item.Text))
            {
                sfd.Filter = "所有文件|*.*";
                sfd.FilterIndex = 0;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ftp.Download(Path.GetDirectoryName(sfd.FileName), item.Name);
                }
            }
        }
    }
}
