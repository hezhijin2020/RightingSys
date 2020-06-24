using RightingSys.WinForm.Utility.cls;
using System;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageJob
{
    public partial class JobFilesForm : BaseForm
    {

        BLL.JobFilesManager manager = new BLL.JobFilesManager();
        BLL.UserManager userManager = new BLL.UserManager();
        public JobFilesForm()
        {
            InitializeComponent();
            tlCategory.Properties.DataSource = manager.GetAllListCategory();
            lkupStaff.Properties.DataSource = userManager.GetAllList();
            dStartday.DateTime = DateTime.Now.Date.AddDays(-15);
            dEndday.DateTime = DateTime.Now.Date;
            dStartday.Properties.MaxValue = dEndday.Properties.MaxValue = DateTime.Now;
            dStartday.Properties.MinValue = dEndday.Properties.MinValue = DateTime.Parse("2000-01-01");

        }
        
        /// <summary>
        /// 功能初始化
        /// </summary>
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(FeatureButton.Add, FeatureButton.Delete, FeatureButton.Query,FeatureButton.Preview,FeatureButton.Print);
        }

        /// <summary>
        /// 新增功能
        /// </summary>
        public override void AddNew()
        {
            JobFilesEditForm sub = new JobFilesEditForm();
            if (sub.ShowDialog() ==DialogResult.OK)
            {
                Query();
            }
        }

        /// <summary>
        /// 查询功能
        /// </summary>
        public override void Query()
        {
            gcData.DataSource = manager.GetList(
                clsPublic.GetObjGUID(tlCategory.EditValue),
                clsPublic.GetObjGUID(lkupStaff.EditValue),
                dStartday.DateTime,
                dEndday.DateTime.Date.AddDays(1));

        }
        
        /// <summary>
        /// 删除功能
        /// </summary>
        public override void Delete()
        {
            if (gvData.FocusedRowHandle >= 0)
            {
                Guid Id = clsPublic.GetObjGUID(gvData.GetFocusedRowCellValue("Id"));
                if (clsPublic.GetMessageBoxYesNoResult("是否删除该档案信息?", Text))
                {
                    if (manager.Delete(Id))
                        clsPublic.ShowMessage("删除成功", Text);
                    else
                        clsPublic.ShowMessage("删除失败", Text);
                }
            }
            else
            {
                clsPublic.ShowMessage("没有可供删除的记录", Text);
            }
        }

        /// <summary>
        /// 预览
        /// </summary>
        public override void Preview()
        {
            if (gvData.FocusedRowHandle >= 0)
            {
                Guid Id = clsPublic.GetObjGUID(gvData.GetFocusedRowCellValue("Id"));
                Models.ys_JobFiles md= manager.GetOneById(Id);
                if (md != null)
                {
                    JobFilesEditForm sub = new JobFilesEditForm(md);
                    sub.ShowDialog();
                }
               
            }
            else
            {
                clsPublic.ShowMessage("没有可供预览的记录", Text);
            }
        }



        public override void Print()
        {
           
        }
    }
}
