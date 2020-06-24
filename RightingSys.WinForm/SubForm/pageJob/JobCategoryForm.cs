using RightingSys.WinForm.Utility.cls;
using System;
using System.Collections.Generic;

namespace RightingSys.WinForm.SubForm.pageJob
{
    public partial class JobCategoryForm : BaseForm
    {
        /// <summary>
        /// 明声明变量
        /// </summary>
        private Models.ys_JobCategory model = new Models.ys_JobCategory();
        private BLL.JobManager manager = new BLL.JobManager();
        private bool IsNewAdd = false;
        private List<Models.ys_JobCategory> Datalist = new List<Models.ys_JobCategory>();

        /// <summary>
        ///构造函数
        /// </summary>
        public JobCategoryForm()
        {
            InitializeComponent(); Query();
        }

        /// <summary>
        /// 工具菜单的初始化
        /// </summary>
        public override void InitFeatureButton()
        {
 	         base.SetFeatureButton(new FeatureButton[]{
                 FeatureButton.Add,
                 FeatureButton.Query,
                 FeatureButton.Delete
             });
        }

        /// <summary>
        /// 新增功能
        /// </summary>
        public override void AddNew()
        {
            IsNewAdd = true;
            txtFullName.Text ="";
            model = new Models.ys_JobCategory();
        }

        /// <summary>
        /// 查询功能
        /// </summary>
        public override void Query()
        {
            Datalist = manager.GetAllListCategory();
            tl_PID.Properties.DataSource = tl_Type.DataSource = Datalist;
            tl_Type.ExpandAll();
        }

        /// <summary>
        /// 类别删除方法
        /// </summary>
        public override void Delete()
        {
            object obj = tl_Type.FocusedNode.GetValue("Id");
            if (obj != null)
            {
                if (tl_Type.FocusedNode.Nodes.Count> 0)
                {
                    clsPublic.ShowMessage("节点下面有子节点，不能删除！", Text);
                    return;
                }
                if (clsPublic.GetMessageBoxYesNoResult("是否删除该类别?", Text))
                {
                    if (manager.DeleteCategory((Guid)obj))
                    {
                        Query();
                    }
                }
            }
        }
     
        /// <summary>
        /// 新增和修改保存方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if (tl_PID.EditValue == null || txtFullName.Text.Trim() == "")
            {
                return;
            }
            model.JobCategoryName = txtFullName.Text.Trim();
            model.ParentId = clsPublic.GetObjGUID(tl_PID.EditValue);
            if (IsNewAdd )
            {
                model.Id = Guid.NewGuid();
                if (manager.AddNewCategory(model))
                {
                    Query();
                    clsPublic.ShowMessage("成功", Text);
                }
            }
            else
            {

                if(model.Id==model.ParentId)
                {
                    clsPublic.ShowMessage("节点的父节点不能为当前节点！", Text); return;
                }
                if (manager.ModifyCategory(model))
                {
                    Query();
                    clsPublic.ShowMessage("成功", Text);
                }
            }
        }

        /// <summary>
        ///类别树焦点改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tl_Type_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                IsNewAdd = false;
                model = Datalist.Find(s => s.Id == (Guid)e.Node.GetValue("Id"));
                tl_PID.EditValue = model.ParentId;
                txtFullName.Text = model.JobCategoryName;
            }
        }
    }
}
