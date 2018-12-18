using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HursingManage.AL.ZhiLiangKongZhi;
using HursingManage.DBModel;

namespace NursingManage.Win.ZhiLiangKongZhi
{
    public partial class FrmVZhiKongKeShiHeGeLv : BaseListForm
    {
        public FrmVZhiKongKeShiHeGeLv()
        {
            InitializeComponent();
        }
        
        ALVZhiKongKeShiHeGeLv _AL;

        void BindDataSource()
        {
            var dt = _AL.GetData(tsTxtSearchValue.Text);
            dgv.DataSource = dt;
        }

        private void FrmVZhiKongKeShiHeGeLv_Load(object sender, EventArgs e)
        {
            _AL = new ALVZhiKongKeShiHeGeLv();
        }

        private void tsBtnSearch_Click(object sender, EventArgs e)
        {
            BindDataSource();
        }

        private void tsbtnADSearch_Click(object sender, EventArgs e)
        {
            AdvanceSearchConfig.ShowAdvanceSearchForm<V_ZHIKONG_HEGELV>(this, _AL, dgv);
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}