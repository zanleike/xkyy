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
    public partial class FrmVZhiKongWenTiHuiZong : BaseListForm
    {
        public FrmVZhiKongWenTiHuiZong()
        {
            InitializeComponent();
        }
        ALVZhiKongWenTiHuiZong _AL;

        private void FrmVZhiKongWenTiHuiZong_Load(object sender, EventArgs e)
        {
            _AL = new ALVZhiKongWenTiHuiZong();
        }

        private void tsBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchByJiHua_Click(object sender, EventArgs e)
        {
            var dt = _AL.GetZhiKongJiHua();
            FrmZhiKongJiHuaXuanZe frm = new FrmZhiKongJiHuaXuanZe(dt);
            frm.OnSelectedHandle += new Action<List<T_ZHIKONGJIHUA>>(frm_OnSelectedHandle);
            frm.ShowDialog();
        }

        void frm_OnSelectedHandle(List<HursingManage.DBModel.T_ZHIKONGJIHUA> obj)
        {
            var jiHuaMingChengs = obj.Select(s => s.MINGCHENG).ToArray();            
            //txtSearchByJiHua.Text = string.Join(",", jiHuaMingChengs);
            tslbJiHua.Text = string.Join(",", jiHuaMingChengs); 
            var jiHuaIds = obj.Select(s=>s.ID).ToArray();
            var dt = _AL.GetData(jiHuaIds);
            dgv.DataSource = dt;
        }
        
    }
}