using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HursingManage.DBModel;
using System.Data;

namespace HursingManage.AL.XiTongGuanLi
{
    public class T_MENU2
    {
        public string Id { set; get; }
        public string MenuCaption { set; get; }
        public string MenuName { set; get; } //下拉菜单的名称
        public string PId { set; get; }
    }

    public class ALJueSeGuanLi : ALBase
    {
        public List<T_MENU2> GetMenus()
        {
            List<T_MENU2> rList = new List<T_MENU2>();
            #region 系统管理

            rList.Add(new T_MENU2()
            {
                Id = "00",
                MenuCaption = "系统管理",
                MenuName = "tsMenuXiTongGuanLi"
            });
            rList.Add(new T_MENU2()
            {
                Id = "0001",
                MenuCaption = "用户管理",
                PId = "00",
                MenuName = "tsMYongHuGuanLi"
            });
            rList.Add(new T_MENU2()
            {
                Id = "0002",
                MenuCaption = "科室管理",
                MenuName = "tsmKeShiGuanLi",
                PId = "00"
            });
            rList.Add(new T_MENU2()
            {
                Id = "0003",
                MenuCaption = "角色权限管理",
                PId = "00",
                MenuName = "tsmiRoleRight"
            });

            #endregion
            #region 档案管理

            rList.Add(new T_MENU2()
            {
                Id = "01",
                MenuCaption = "档案管理",
                MenuName = "tsmiDangAnGuanLi"
            });
            rList.Add(new T_MENU2()
            {
                Id = "0101",
                MenuCaption = "员工档案管理",
                PId = "01",
                MenuName = "tsmiDangAn"
            });

            #endregion
            #region 考勤管理

            rList.Add(new T_MENU2()
            {
                Id = "02",
                MenuCaption = "考勤管理",
                MenuName = "tsmiKaoQinGuanLi"
            });

            #endregion
            #region 培训管理

            rList.Add(new T_MENU2()
            {
                Id = "03",
                MenuCaption = "培训管理",
                MenuName = "tsMenuPeiXunGuanLi"
            });
            rList.Add(new T_MENU2()
            {
                Id = "0301",
                MenuCaption = "题库管理",
                MenuName = "tsMenuTiKuGuanLi"
            });

            #endregion
            return rList;
        }

        public List<T_MENU> GetMenuData()
        {
            var query = DB.QueryWhere<T_MENU>(s => true);
            return query.ToList();
        }

        public List<T_ROLE> GetRoleData(string serValue)
        {
            serValue = string.Format("%{0}%", serValue);
            var query = DB.QueryWhere<T_ROLE>(s => s.WEx_Like(s.ROLE_NAME, serValue) || s.WEx_Like(s.ROLE_NAME_PY, serValue));
            return query.ToList();
        }
        public bool VerifyModel(T_ROLE model, out string errMsg)
        {
            if (string.IsNullOrWhiteSpace(model.ROLE_NAME))
            {
                errMsg = "角色名称不能为空。";
                return false;
            }
            if (DB.QueryExist<T_ROLE>(s => s.ROLE_NAME == model.ROLE_NAME && s.ID != model.ID))
            {
                errMsg = "该角色名称不能为空。";
                return false;
            }
            errMsg = null;
            return true;
        }
        public bool AddRole(T_ROLE model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg)) return false;
            DB.Insert(model);
            return true;
        }
        public bool UpdateRole(T_ROLE model, out string errMsg)
        {
            if (!VerifyModel(model, out errMsg)) return false;
            DB.Update(model);
            return true;
        }
        public bool DeleteRole(T_ROLE model, out string errMsg)
        {
            try
            {
                DB.TransStart();
                T_USER_INFO userModel = new T_USER_INFO();
                userModel.ROLE_ID = string.Empty;
                userModel.ROLE_NAME = string.Empty;
                DB.Update<T_USER_INFO>(userModel, s => s.ROLE_ID == model.ID);
                DB.Delete<T_ROLE_MENU>(s => s.ROLE_ID == model.ID);
                DB.Delete<T_ROLE>(model);
                errMsg = null;
                DB.TransCommit();
                return true;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                DB.TransRollback();
                return false;
            }
        }

        /// <summary>
        /// 根据指定角色的用户数据
        /// </summary>
        /// <param name="keShiId">科室Id</param>
        /// <param name="isSelected">true:查询已选择的用户数据,false:查询未选择的用户信息</param>
        /// <returns></returns>
        public DataTable GetUserData(T_ROLE roleModel, bool isSelected = false, string serValue = null)
        {
            if (isSelected)
            {
                var query = DB.QueryWhere<T_USER_INFO>(s => s.ROLE_ID == roleModel.ID);
                return query.ToDataTable();
            }
            else
            {
                var query = DB.QueryWhere<T_USER_INFO>(s => s.ROLE_ID != roleModel.ID || s.ROLE_ID == null);
                return query.ToDataTable();
            }
        }

        public void RemoveUser(T_ROLE roleModel, T_USER_INFO userModel)
        {
            userModel.ClearChangedState();
            userModel.ROLE_ID = string.Empty;
            userModel.ROLE_NAME = string.Empty;
            DB.Update<T_USER_INFO>(userModel);
        }

        public void SaveUserToRole(T_ROLE roleModel, List<T_USER_INFO> users)
        {
            foreach (var item in users)
            {
                item.ClearChangedState();
                item.ROLE_ID = roleModel.ID;
                item.ROLE_NAME = roleModel.ROLE_NAME;
                DB.Update(item);
            }
        }
        public List<T_ROLE_MENU> GetRoleMenu(T_ROLE roleModel)
        {
            var query = DB.QueryWhere<T_ROLE_MENU>(s => s.ROLE_ID == roleModel.ID);
            return query.ToList();
        }
        public void SaveMenuToRole(T_ROLE roleModel, List<T_MENU> menuList)
        {
            DB.Delete<T_ROLE_MENU>(s => s.ROLE_ID == roleModel.ID);
            foreach (var item in menuList)
            {
                T_ROLE_MENU roleMenu = new T_ROLE_MENU();
                roleMenu.ROLE_ID = roleModel.ID;
                roleMenu.MENUID = item.ID;
                roleMenu.MENUNAME = item.MENUNAME;
                roleMenu.MENUCAPTION = item.MENUCAPTION;
                roleMenu.BUTTONNAME = item.BUTTONNAME;
                DB.Insert(roleMenu);
            }
        }
    }
}