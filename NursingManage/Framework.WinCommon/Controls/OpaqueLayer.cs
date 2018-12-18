using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Framework.WinCommon.Controls
{
    /// <summary>
    /// 透明遮罩类
    /// </summary>
    public class OpaqueLayer : System.Windows.Forms.Control
    {
        private bool _transparentBG = true;//是否使用透明
        private int _alpha = 125;//设置透明度

        private System.ComponentModel.Container components = new System.ComponentModel.Container();
        Label progressLabel;

        public OpaqueLayer()
            : this(125, true)
        { }

        public OpaqueLayer(int Alpha, bool IsShowLoadingImage)
        {
            SetStyle(System.Windows.Forms.ControlStyles.Opaque, true);
            base.CreateControl();
            this._alpha = Alpha;
            if (IsShowLoadingImage)
            {
                PictureBox pictureBox_Loading = new PictureBox();
                pictureBox_Loading.BackColor = System.Drawing.Color.White;
                pictureBox_Loading.Image = Properties.Resources.loading;
                pictureBox_Loading.Name = "pictureBox_Loading";
                pictureBox_Loading.Size = new System.Drawing.Size(48, 48);
                pictureBox_Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                Point Location = new Point(this.Location.X + (this.Width - pictureBox_Loading.Width) / 2, this.Location.Y + (this.Height - pictureBox_Loading.Height) / 2);//居中
                pictureBox_Loading.Location = Location;
                pictureBox_Loading.Anchor = AnchorStyles.None;
                this.Controls.Add(pictureBox_Loading);

                progressLabel = new Label();
                progressLabel.Location = new Point(Location.X + 2, Location.Y + pictureBox_Loading.Size.Height);
                progressLabel.Size = new System.Drawing.Size(44, 15);
                progressLabel.Text = "99%";
                progressLabel.Anchor = AnchorStyles.None;
                progressLabel.TextAlign = ContentAlignment.MiddleCenter;
                progressLabel.BackColor = Color.Ivory;
                progressLabel.ForeColor = Color.Red;
                progressLabel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular);
                progressLabel.Visible = false;
                this.Controls.Add(progressLabel);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!((components == null)))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// 自定义绘制窗体
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            float vlblControlWidth;
            float vlblControlHeight;

            Pen labelBorderPen;
            SolidBrush labelBackColorBrush;

            if (_transparentBG)
            {
                Color drawColor = Color.FromArgb(this._alpha, this.BackColor);
                labelBorderPen = new Pen(drawColor, 0);
                labelBackColorBrush = new SolidBrush(drawColor);
            }
            else
            {
                labelBorderPen = new Pen(this.BackColor, 0);
                labelBackColorBrush = new SolidBrush(this.BackColor);
            }
            base.OnPaint(e);
            vlblControlWidth = this.Size.Width;
            vlblControlHeight = this.Size.Height;
            e.Graphics.DrawRectangle(labelBorderPen, 0, 0, vlblControlWidth, vlblControlHeight);
            e.Graphics.FillRectangle(labelBackColorBrush, 0, 0, vlblControlWidth, vlblControlHeight);
        }

        protected override CreateParams CreateParams//v1.10 
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; //0x20;  // 开启 WS_EX_TRANSPARENT,使控件支持透明
                return cp;
            }
        }

        /*
         * [Category("myOpaqueLayer"), Description("是否使用透明,默认为True")]
         * 一般用于说明你自定义控件的属性（Property）。
         * Category用于说明该属性属于哪个分类，Description自然就是该属性的含义解释。
         */
        [Category("MyOpaqueLayer"), Description("是否使用透明,默认为True")]
        public bool TransparentBG
        {
            get
            {
                return _transparentBG;
            }
            set
            {
                _transparentBG = value;
                this.Invalidate();
            }
        }

        [Category("MyOpaqueLayer"), Description("设置透明度")]
        public int Alpha
        {
            get
            {
                return _alpha;
            }
            set
            {
                _alpha = value;
                this.Invalidate();
            }
        }        
        /// <summary>
        /// 显示遮罩层
        /// </summary>
        /// <param name="control">控件</param>
        /// <param name="alpha">透明度</param>
        /// <param name="isShowLoadingImage">是否显示图标</param>
        public void ShowOpaqueLayer(Control control)
        {
            ShowOpaqueLayer(control, 0);
        }

        //暂时不用,今天脑子不太灵光,先不改
        private void ShowOpaqueLayer(Control control, int progressMax)
        {
            try
            {
                if (progressMax > 0)
                {
                    progressLabel.Text = string.Format("0%");
                    progressLabel.Visible = true;
                    _ProgressValue = 0;
                    _ProgressMaxValue = progressMax;
                }

                control.Controls.Add(this);
                //this.Dock = DockStyle.Fill;
                this.Size = control.Size;
                this.BringToFront();
                this.Enabled = true;
                this.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        int _ProgressValue = 0;
        int _ProgressMaxValue = 0;
        public void SetProgressAdd()
        {
            if (this.InvokeRequired)
            {
                Action<object> act = (obj) => { SetProgressAdd(); };
                this.Invoke(act, string.Empty);
            }
            else
            {
                _ProgressValue++;
                int prog = _ProgressValue * 100 / _ProgressMaxValue ;

                progressLabel.Text = string.Format("{0}%", prog);
            }
        }
        /// <summary>
        /// 隐藏遮罩层
        /// </summary>
        public void HideOpaqueLayer()
        {
            try
            {
                this.Visible = false;
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
