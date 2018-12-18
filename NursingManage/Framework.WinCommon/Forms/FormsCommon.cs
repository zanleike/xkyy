using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace Framework.WinCommon.Forms
{
    public delegate FrmBase CreateBaseFormHandle();

    public class FormsCommon
    {
        /// <summary>
        /// 将Form窗体加入到控件中,
        /// parentControl为null或者form为null引发一场
        /// </summary>
        /// <param name="parentControl">放窗体的控件</param>
        /// <param name="form">窗体对象</param>
        public static void FormToControl(Control parentControl, Form form)
        {
            if (parentControl == null || form == null)
            {
                throw new Exception("将Form加入控件时出现异常,父控件或窗体为null!");
            }
            form.TopLevel = false;
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            parentControl.Controls.Add(form);
            form.Show();
        }

        static Dictionary<Type, FrmBase> _baseFormList = null;
        /// <summary>
        /// 获取或设置主窗体加载的单例窗体集合
        /// </summary>
        public static Dictionary<Type, FrmBase> BaseFormList
        {
            set { _baseFormList = value; }
            get
            {
                if (_baseFormList == null)
                {
                    _baseFormList = new Dictionary<Type, FrmBase>();
                }
                return _baseFormList;
            }
        }

        /// <summary>
        /// 创建单例窗体
        /// </summary>
        /// <typeparam name="T">继承FrmBase的窗体类型</typeparam>
        /// <returns>返回一个单例窗体</returns>
        public static T CreateSingletonForm<T>() where T : FrmBase, new()
        {
            return CreateSingletonForm<T>(() => { return new T(); });
        }
        /// <summary>
        /// 创建单例窗体，使用自定义方法初始化，可自定义构造函数来使用
        /// </summary>
        public static T CreateSingletonForm<T>(CreateBaseFormHandle NewForm) where T : FrmBase, new()
        {            
            Type frmType = typeof(T);
            if (!FormsCommon.BaseFormList.ContainsKey(frmType))
            {
                FrmBase frm = NewForm();
                FormsCommon.BaseFormList.Add(frmType, frm);
                frm.FormClosed += new FormClosedEventHandler(delegate(object sender, FormClosedEventArgs e)
                {
                    //关闭时从字典列表中删除
                    FormsCommon.BaseFormList.Remove(frmType);
                });
                return (T)frm;
            }
            return (T)FormsCommon.BaseFormList[frmType];
        }

        /// <summary>
        /// 利用反射动态创建FrmBase窗体或FrmBase子类窗体
        /// </summary>
        /// <param name="classlib">项目名称</param>
        /// <param name="className">包含完成命名空间的类名</param>
        public static FrmBase DynamicCreateForm(string classlib, string classFullName)
        {
            Assembly asm = Assembly.LoadFrom(classlib);
            Type t = asm.GetType(classFullName);
            if (BaseFormList.ContainsKey(t))
            {
                return BaseFormList[t];
            }
            Type formT = typeof(FormsCommon);
            MethodInfo method = formT.GetMethod("CreateSingletonForm");
            if (method.IsGenericMethod)
            {
                object frmObj = method.MakeGenericMethod(t).Invoke(null, null);
                FrmBase frm = frmObj as FrmBase;
                return frm;
            }
            return null;
        }
    }
}