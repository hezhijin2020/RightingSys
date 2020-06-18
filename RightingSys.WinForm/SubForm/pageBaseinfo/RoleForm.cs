using DevExpress.XtraTreeList.Nodes;
using RightingSys.WinForm.Utility.cls;
using RightingSys.WinForm.Utility.ToolForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    public partial class RoleForm : BaseForm
    {
        RightingSys.BLL.RoleManager roleMg = new RightingSys.BLL.RoleManager();
        Models.ACL_Role model = new Models.ACL_Role();
        private Guid RoleId = Guid.Empty;
        private bool RightIsChange = false;
        private List<Models.ACL_Role> RoleList;
        private DataTable tbAllFunc;

        private List<Models.ACL_Department> DeptList = new List<Models.ACL_Department>();


        public RoleForm()
        {
            InitializeComponent();Query();
        }

        #region 功能菜单初始化
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[]{
           FeatureButton.Add,
           FeatureButton.Query,
           FeatureButton.Delete,
            });
        }
        public override void AddNew()
        {
            txtID.Text = "新ID";
            txtSortCode.Text = "";
            txtName.Text = "";
            sbtnSave.Enabled = true;
            model = new Models.ACL_Role();
        }
        public override void Query()
        {
            gcRole.DataSource = RoleList = roleMg.GetAllList();
            tlFunc.ExpandAll(); 
        }
        public override void Delete()
        {
            if (gvRole.FocusedRowHandle >= 0)
            {
                Guid Id = (Guid)gvRole.GetFocusedRowCellValue("Id");
                if (roleMg.ExistsUserOrDepartmentById(Id))
                {
                    clsPublic.ShowMessage("该角色包含用户或部门，不能删除！");
                    return;
                }
                else
                {
                    if (clsPublic.GetMessageBoxYesNoResult("是否删除该角色，删除将不能恢复？", "提示"))
                    {
                        if (roleMg.Delete(Id))
                        {
                            tlFunc.RefreshDataSource(); Query();
                            clsPublic.ShowMessage("删除成功！");
                        }
                        else
                        {
                            clsPublic.ShowMessage("删除失败！");
                        }
                    }
                }
            }
        }
        #endregion

     
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                clsPublic.ShowMessage("角色名不能为空", "提示");
                txtName.Focus();
                return;
            }
            else
            {
                model.RoleName = txtName.Text.Trim();
                model.ParentId = Guid.Empty;
                model.SortCode = txtSortCode.Text;
                model.CreateTime = DateTime.Now;

                if (!clsPublic.IsGuid(txtID.Text))
                {
                    if (roleMg.ExistsRoleByName(txtName.Text.Trim()))
                    {
                        clsPublic.ShowMessage("角色名已存在，请重新输入！", "提示");
                        txtName.Focus();
                        return;
                    }
                    model.Id = Guid.NewGuid();
                    if (roleMg.AddNew(model))
                    {
                        tlFunc.RefreshDataSource();
                        Query();
                        clsPublic.ShowMessage("新增成功", "提示");
                    }
                    else
                    {
                        clsPublic.ShowMessage("修改失败", "提示");
                    }
                }
                else
                {
                    model.Id = clsPublic.GetObjGUID(txtID.Text);
                    if (roleMg.Modify(model))
                    {
                        tlFunc.RefreshDataSource();Query();
                        clsPublic.ShowMessage("修改成功", "提示");
                    }
                    else
                    {
                        clsPublic.ShowMessage("修改失败", "提示");
                    }
                }
            }
        }

        private void gvRole_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (RightIsChange && clsPublic.GetMessageBoxYesNoResult("授权信息改变是否保存？", "提示"))
            {
                sbtnSaveFunc_Click(null, null);
            }
            RightIsChange = false;
            if (gvRole.FocusedRowHandle>=0)
            {
                RoleId = (Guid)gvRole.GetFocusedRowCellValue("Id");
                model = RoleList.FirstOrDefault(s => s.Id == RoleId);
                gcUser.DataSource = roleMg.GetTbUsersByRoleId(RoleId); 
                gcOU.DataSource = roleMg.GetTbDepartmentsByRoleId(RoleId);

                BuiderFuncTree(RoleId);
                
                sbtnSaveFunc.Enabled = sbtnReLoadFunc.Enabled = true;
                tlFunc.Caption = string.Format("当前选择的角色为：{0}",gvRole.GetFocusedRowCellValue("RoleName"));
                txtID.Text = model.Id.ToString();
                txtName.Text = model.RoleName;
                txtSortCode.Text = model.SortCode;

            }
        }
     


        #region 权限树的初始化
        private void BuiderFuncTree(Guid RoleId)
        {
            tlFunc.DataSource = tbAllFunc = roleMg.GetTbAllFunctionByRoleId(RoleId);
            SetNodeChecked(tlFunc.Nodes);
            tlFunc.ExpandAll();
        }
        private void SetNodeChecked(TreeListNodes Nodes)
        {
            foreach (TreeListNode node in Nodes)
            {
                object Enabled = node.GetValue("Enabled");
                if (Enabled.ToString().Equals("1"))
                {
                    node.CheckState = CheckState.Checked;
                    SetParentNodeChecked(node, node.CheckState);
                }
                if (node.Nodes.Count > 0)
                {
                    SetNodeChecked(node.Nodes);
                }
            }
        }
        private void SetParentNodeChecked(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                if (b)
                {
                    node.ParentNode.CheckState = CheckState.Indeterminate;
                }
                else
                {
                    node.ParentNode.CheckState = check;
                }
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }
        private void sbtnReLoadFunc_Click(object sender, EventArgs e)
        {
            BuiderFuncTree(RoleId);
        }
        #endregion

        #region 节点联动
        private void tlFunc_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            if (e.PrevState == CheckState.Checked)
            {
                e.State = CheckState.Unchecked;
            }
            else
            {
                e.State = CheckState.Checked;
            }
        }
        private void tlFunc_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            RightIsChange = true;
            SetCheckedChildNodes(e.Node, e.Node.CheckState);
            SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }

        //region 设置子节点状态跟随父结点
        private void SetCheckedChildNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }

        //region 设置父节点状态，如果它的孩子都被选中，则状态是check(由上下文件环境传递)，否则是CheckState.Indeterminate
        private void SetCheckedParentNodes(DevExpress.XtraTreeList.Nodes.TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                if (b)
                {
                    node.ParentNode.CheckState = CheckState.Indeterminate;
                }
                else
                {
                    node.ParentNode.CheckState = check;
                }
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }

        #endregion

        #region 授权
        private void sbtnSaveFunc_Click(object sender, EventArgs e)
        {
            DataTable dt = tbAllFunc.Clone();
            RecursionNodes(tlFunc.Nodes, ref dt);
            dt.AcceptChanges();
            if (roleMg.SaveRighting(dt, RoleId.ToString()))
            { clsPublic.ShowMessage("授权成功！"); }
            else
            { clsPublic.ShowMessage("授权失败！"); }
            RightIsChange = false;
        }

        private void RecursionNodes(TreeListNodes Nodes,ref DataTable dtRights)
        {
            foreach (TreeListNode node in Nodes)
            {
                
                if (node.CheckState == CheckState.Indeterminate||node.CheckState==CheckState.Checked)
                {
                    dtRights.Rows.Add(node.GetValue("Id"), node.GetValue("ParentId"), node.GetValue("FuncName"), node.GetValue("FuncHandle"), node.GetValue("SortCode"), node.GetValue("TypeId"));
                }
                if (node.Nodes.Count > 0)
                {
                    RecursionNodes(node.Nodes,ref dtRights);
                }
            }
        }
        #endregion

        #region 角色用户授权

        private void sbtnUserRemove_Click(object sender, EventArgs e)
        {
            Guid UserId = clsPublic.GetObjGUID(gvUser.GetFocusedRowCellValue("UserId"));
            if (RoleId != Guid.Empty && UserId != Guid.Empty)
            {
                if (roleMg.DeleteUserByRoleId( RoleId,UserId))
                {
                    gcUser.DataSource = roleMg.GetTbUsersByRoleId(RoleId);
                }
            }
        }

        private void sbtnUserAdd_Click(object sender, EventArgs e)
        {
            if (RoleId != null && RoleId != Guid.Empty)
            {
                RoleByUser_Selectlist sub = new RoleByUser_Selectlist(RoleId);
                if (sub.ShowDialog() == DialogResult.OK)
                {
                    gcUser.DataSource = roleMg.GetTbUsersByRoleId(RoleId);
                }
            }
            else
            {
                clsPublic.ShowMessage("当前没有选择任何角色！");
            }
        }
        #endregion

        #region 角色机构授权
        private void sbtnOUAdd_Click(object sender, EventArgs e)
        {
            if (RoleId != null && RoleId != Guid.Empty)
            {
                RoleByDepartment_SelectList sub = new RoleByDepartment_SelectList(RoleId);
                if (sub.ShowDialog() == DialogResult.OK)
                {
                    gcOU.DataSource = roleMg.GetTbDepartmentsByRoleId(RoleId);
                }
            }
            else
            {
                clsPublic.ShowMessage("当前没有选择任何角色！");
            }
        }

        private void sbtnOURemove_Click(object sender, EventArgs e)
        {
            Guid DepartmentId = clsPublic.GetObjGUID(gvOU.GetFocusedRowCellValue("DepartmentId"));
            if (RoleId != Guid.Empty && DepartmentId != Guid.Empty)
            {
                if (roleMg.DeleteDepartmentByRoleId(RoleId, DepartmentId))
                {
                    gcOU.DataSource = roleMg.GetTbDepartmentsByRoleId(RoleId);
                }
            }
        }

        #endregion

      
    }
}
