using DevExpress.XtraTreeList.Nodes;
using RightingSys.WinForm.Utility.cls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RightingSys.WinForm.Utility.ToolForm
{
    public partial class RoleByDepartment_SelectList : Form
    {
        private Guid _RoleId = Guid.Empty;
        private DataTable dtAll = null;
        private RightingSys.BLL.RoleManager roleMg = new RightingSys.BLL.RoleManager();

        public RoleByDepartment_SelectList(Guid RoleId)
        {
            InitializeComponent();
            _RoleId = RoleId;
            Initial();
        }

        private void Initial()
        {
            dtAll = roleMg.GetTbAllDepartmentsByRoleId(_RoleId);
            tl_OU.DataSource = dtAll;
            tl_OU.ExpandAll();
            SetRecursionNodesChecked(tl_OU.Nodes);

        }

        private void SetRecursionNodesChecked(TreeListNodes Nodes)
        {
            foreach (TreeListNode node in Nodes)
            {
                bool isCheck =bool.Parse( node.GetValue("IsCheck").ToString());
                node.Checked = isCheck;
                if (node.Nodes.Count > 0)
                {
                    SetRecursionNodesChecked(node.Nodes);
                }
            }
        }

        private void SetTreeListNodesCheckeed(TreeListNodes Nodes,ref List<string> OuList)
        {
            foreach (TreeListNode node in Nodes)
            {
                if (node.Checked)
                {
                    OuList.Add(node.GetValue("Id").ToString());
                }
                if (node.Nodes.Count > 0)
                {
                    SetTreeListNodesCheckeed(node.Nodes,ref OuList);
                }
            }
        }

        private void sbtnOK_Click(object sender, EventArgs e)
        {
            tl_OU.RefreshDataSource();
            List<string> list = new List<string>();
            SetTreeListNodesCheckeed(tl_OU.Nodes,ref list);
            if (roleMg.AddNewDepartmentByRoleId(_RoleId, list))
            {
                clsPublic.ShowMessage("完成！", Text);
                base.DialogResult = DialogResult.OK;
            }
            else
            {
                clsPublic.ShowMessage("失败！", Text);
                base.DialogResult = DialogResult.Cancel;
            }
        }

        private void sbtnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }
    }
}
