using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RightingSys.WinForm.Utility.ToolForm
{
    public partial class RoleByUser_Selectlist : Form
    {
        RightingSys.BLL.RoleManager roleMg = new RightingSys.BLL.RoleManager();
        RightingSys.BLL.DepartmentManager deptMg = new RightingSys.BLL.DepartmentManager();
        DataTable   dtAll;
        private Guid _RoleId= Guid.Empty;
        public RoleByUser_Selectlist(Guid RoleId)
        {
            InitializeComponent();
            _RoleId = RoleId;
            InitialForm();
        }

        private void InitialForm()
        {
            tlDepartment.DataSource = deptMg.GetAllList();
            dtAll = roleMg.GetTbAllUsersByRoleId(_RoleId);
            gcUser.DataSource = dtAll;
        }
        
        #region 组织机构和角色树焦点改变事件,筛选用户信息
        private void tl_OU_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null && dtAll != null)
            {
                dtAll.DefaultView.RowFilter = string.Format("DepartmentId='{0}' or IsCheck=True ", e.Node.GetValue("Id"));
                gcUser.DataSource = dtAll.DefaultView;
               
            }
        }
        

        private void GetNodChildrenID(TreeListNode node, ref string strListID)
        {
            strListID = strListID + ",'" + node.GetValue("Id") + "'";

            foreach (TreeListNode n in node.Nodes)
            {
                GetNodChildrenID(n, ref strListID);
            }
        }
        #endregion

      
        
        private void sbtnClose_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        private void sbtnFinish_Click(object sender, EventArgs e)
        {
            DataRow[] rows = dtAll.Select("IsCheck=True");
            if (rows.Count() > 0)
            {
                List<Guid> UserList = new List<Guid>();
                foreach (DataRow r in rows)
                {
                    UserList.Add((Guid)r["Id"]);
                }

                if (roleMg.AddNewUserByRoleId(_RoleId, UserList))
                {
                    base.DialogResult = DialogResult.OK; return;
                }
            }
            base.DialogResult = DialogResult.Cancel;
        }
    }
}
