using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RightingSys.WinForm.Utility.ToolForm
{
    /// <summary>
    /// 防火墙过滤规则用户选择框
    /// </summary>
    public partial class F_UserForBlackIP_Selectlist : Form
    {
        /// <summary>
        /// 声明变量
        /// </summary>
        BLL.BlackIPManager manager = new BLL.BlackIPManager();
        BLL.DepartmentManager deptMg = new BLL.DepartmentManager();
        BLL.UserManager userMg = new BLL.UserManager();
        List<Models.ACL_User> ltSource = new List<Models.ACL_User>();

        public List<Models.ACL_User> selectData { get; private set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public F_UserForBlackIP_Selectlist()
        {
            InitializeComponent();
            tlDepartment.DataSource = deptMg.GetAllList();
            gcData.DataSource = ltSource = userMg.GetAllList();
        }

        /// <summary>
        /// 带参构造函数
        /// </summary>
        /// <param name="BlackIPId">规则Id</param>
        public F_UserForBlackIP_Selectlist(Guid BlackIPId):this()
        {
            gvData.SetSelectRow(manager.GetUserByBlackIP(BlackIPId).ToList<object>());//设置以前选择的行
        }
        
        /// <summary>
        /// 部门焦点改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlDepartment_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null && ltSource != null)
            {
                List<object> objlt = gvData.GetSelectRowToObject();
                gcData.DataSource = ltSource.FindAll(a => a.DepartmentId == (Guid)e.Node.GetValue("Id")).Concat(objlt).Distinct();
                gvData.SetSelectRow(objlt);
            }
        }
        
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnClose_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnFinish_Click(object sender, EventArgs e)
        {
            List<object> ltObjs= gvData.GetSelectRowToObject();
            selectData = new List<Models.ACL_User>();
            if (ltObjs != null && ltObjs.Count > 0)
            {
                foreach (object item in ltObjs)
                {
                    selectData.Add((Models.ACL_User)item);
                }
                base.DialogResult = DialogResult.OK;
                return;
            }
            base.DialogResult = DialogResult.Cancel;
        }
    }
}
