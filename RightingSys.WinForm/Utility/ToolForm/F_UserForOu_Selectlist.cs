using DevExpress.XtraTreeList.Nodes;
using System;
using System.Data;
using System.Windows.Forms;

namespace RightingSys.WinForm.Utility.ToolForm
{
    public partial class F_UserForOu_Selectlist : Form
    {
        RightingSys.BLL.DepartmentManager deptMg = new RightingSys.BLL.DepartmentManager();
        DataTable dtAll = null;
        private Guid _OUID=Guid.Empty;
        public F_UserForOu_Selectlist(Guid OUID)
        {
            InitializeComponent();
            _OUID = OUID;
            Initial();
        }

        private void Initial()
        {
            //tl_OU.DataSource = bll.GetOUInfo();
            //tl_Role.DataSource = bll.GetRoleInfo();
            //dtAll = bll.FillTableUserForOu(_OUID);
            //gcUser.DataSource = dtAll;
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

      
        
        private void sbtnClose_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

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

            //  if(dept(_OUID, UserList))
            //    {
            //        base.DialogResult = DialogResult.OK;return;
            //    }
            //}
            //base.DialogResult = DialogResult.Cancel;
        }
    }
}
