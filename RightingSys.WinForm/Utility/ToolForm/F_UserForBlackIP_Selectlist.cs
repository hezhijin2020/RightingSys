using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RightingSys.WinForm.Utility.cls;

namespace RightingSys.WinForm.Utility.ToolForm
{
    public partial class F_UserForBlackIP_Selectlist : Form
    {
        BLL.BlackIPManager manager = new BLL.BlackIPManager();
        BLL.RightingSysManager rightingSysManager = new BLL.RightingSysManager();
        DataTable dtAll = null;
        private Guid _BlackIPId = Guid.Empty;
        public F_UserForBlackIP_Selectlist(Guid BlackIPId)
        {
            InitializeComponent();
            _BlackIPId = BlackIPId;
            Initial();
        }

        private void Initial()
        {
           // tl_OU.DataSource = rightingSysManager;
           // tl_Role.DataSource = bll.GetRoleInfo();
            //dtAll = bll.FillTableUserForBlackIP(_BlackIP_ID);
            gcUser.DataSource = dtAll;
        }
        
        #region 组织机构和角色树焦点改变事件,筛选用户信息
        private void tl_OU_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null && dtAll != null)
            {
                dtAll.DefaultView.RowFilter = string.Format("OUID='{0}' or IsCheck=True ", e.Node.GetValue("ID"));
                gcUser.DataSource = dtAll.DefaultView;
            }
        }

        private void tl_Role_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null && dtAll != null)
            {
                dtAll.DefaultView.RowFilter = string.Format("RoleID='{0}' or IsCheck=True", e.Node.GetValue("ID"));
                gcUser.DataSource = dtAll.DefaultView;
            }
        }

        private void GetNodChildrenID(TreeListNode node, ref string strListID)
        {
            strListID = strListID + ",'" + node.GetValue("ID") + "'";

            foreach (TreeListNode n in node.Nodes)
            {
                GetNodChildrenID(n, ref strListID);
            }
        }
        #endregion

        private void tabPaneView_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (e.Page.PageText == "tabpage_Dept")
            {
                tl_OU.FocusedNode = null;
            }
            else
            {
                tl_Role.FocusedNode = null;
            }
        }

        private void gvUser_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Value == null) return;

            if (e.Column.FieldName == "Deleted")
            {
                if (e.Value.ToString() == "0")
                { e.DisplayText = ""; }
                else
                { e.DisplayText = "已删除"; }
            }
            if (e.Column.FieldName == "Enabled")
            {
                if (e.Value.ToString() == "0")
                { e.DisplayText = "未启用"; }
                else
                { e.DisplayText = "已启用"; }
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
            //DataRow[] rows=  dtAll.Select("IsCheck=True");
            //if (rows.Count() > 0)
            //{
            //    List<string> UserList = new List<string>();
            //    foreach (DataRow r in rows)
            //    {
            //        UserList.Add(r["UserID"].ToString());
            //    }

            //  if( bll.AddUserForBlackIP(_BlackIP_ID, UserList))
            //    {
            //        base.DialogResult = DialogResult.OK;
            //        clsPublic.ShowMessage("成功", Text);
            //        return;
            //    }
            //}
            //base.DialogResult = DialogResult.Cancel;
        }
    }
}
