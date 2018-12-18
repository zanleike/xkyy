using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZCJH.HursingManage.AL.DangAnGuanLi;

namespace ZCJH.NursingManage.Win.DangAnGuanLi
{
    public partial class FrmDangAnNewEdit : BaseEditForm
    {
        public FrmDangAnNewEdit()
        {
            InitializeComponent();
        }
        ALDangAnExConfig _AL;
        private void button1_Click(object sender, EventArgs e)
        {
            InputEditConfig config = new InputEditConfig();
            config.ControlHeight = 40;
            config.ControlWidht = 450;
            config.CaptionControlLen = 200;
            config.ControlType = (int)ControlType.Text;
            ucInput uc = new ucInput(config, dcm1, comboxList1);
            //flowLayoutPanel1.Controls.Add(uc);
        }

        private void FrmDangAnNewEdit_Load(object sender, EventArgs e)
        {
            _AL = new ALDangAnExConfig();
            //tabControl1.TabPages.Clear();

            //var group = _AL.GetExGroup();
            //foreach (var item in group.Keys)
            //{
            //    var columnConfigs = _AL.GetExColumns(item);
            //    if (columnConfigs == null) continue;

            //    TabPage tp = new TabPage();
            //    tp.Name = item;
            //    tp.Text = group[item];
            //    FlowLayoutPanel flp = new FlowLayoutPanel();
            //    flp.Dock = DockStyle.Fill;
            //    tp.Controls.Add(flp);
                
            //    foreach (var config in columnConfigs)
            //    {
            //        ucInput uc = new ucInput(config, dcm1, comboxList1);
            //        flp.Controls.Add(uc);
            //    }
            //    //tabControl1.TabPages.Add(tp);
            //}
        }
    }
}
