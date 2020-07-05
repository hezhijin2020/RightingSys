using RightingSys.WinForm.Utility.cls;
using System;

namespace RightingSys.WinForm.SubForm.pageJob
{
    public partial class StickyBookForm : BaseForm
    {
        /// <summary>
        /// 声明变量
        /// </summary>
        BLL.StikyBookManager manager = new BLL.StikyBookManager();
        BLL.JobManager jobManager = new BLL.JobManager();
        Models.ys_StickyBook model = new Models.ys_StickyBook();

        /// <summary>
        /// 构造函数
        /// </summary>
        public StickyBookForm()
        {
            InitializeComponent();
            
            lkpBranch.Properties.DataSource = jobManager.GetDtBranch();
            lkpBranch.EditValue = "GAHN_BM";
        }

        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        public StickyBookForm(Models.ys_StickyBook md) : this()
        {
            model = md;
            if (model != null)
            {
                lkpBranch.EditValue = model.BranchId;
                cbCategory.EditValue = model.CategoryName;
                txtStickyName.Text = model.StickyName;
                txtEditTime.Text = model.CreateTime.ToString();
                txtOperatorName.Text = model.StaffName;
                myRichEidt.TextEdit = model.StickyXML;
            }
        }

        /// <summary>
        /// 初始化功能
        /// </summary>
        public override void InitFeatureButton()
        {
            base.SetFeatureButton( new FeatureButton[]{
                FeatureButton.Add,
                FeatureButton.Delete,
                FeatureButton.Query,
                FeatureButton.Print});
        }

        /// <summary>
        /// 新增功能
        /// </summary>
        public override void AddNew()
        {
            model = new Models.ys_StickyBook();
            model.Id = Guid.Empty;
            model.StaffId = model.OperatorId = Models.SqlHelper.Session._UserId;
            model.OperatorName = model.StaffName = Models.SqlHelper.Session._FullName;
            txtEditTime.Text = DateTime.Now.ToString();
            txtOperatorName.Text = model.StaffName;
            txtStickyName.Text = "";
            lkpBranch.EditValue = "GAHN_BM";
            myRichEidt.TextEdit = "";
        }

        public override void Delete()
        {
            if (gvData.FocusedRowHandle >= 0)
            {
                Guid Id = clsPublic.GetObjGUID(gvData.GetFocusedRowCellValue("Id"));
                if (clsPublic.GetMessageBoxYesNoResult("是否删除该信息记录?", Text))
                {
                    if (manager.Delete(Id))
                    {
                        clsPublic.ShowMessage("删除成功", Text);
                    }
                    else
                    {
                        clsPublic.ShowMessage("删除失败", Text);
                    }
                    Query();
                }
            
            }
        }

        /// <summary>
        /// 查询功能
        /// </summary>
        public override void Query()
        {
            gcData.DataSource = manager.GetAllList();
        }

        /// <summary>
        /// 打印功能
        /// </summary>
        public override void Print()
        {
            base.Print();
        }

        /// <summary>
        /// 保存功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lkpBranch.EditValue != null && txtStickyName.Text.Trim().Length > 0 && myRichEidt.TextEdit.Trim() != "")
            {
                model.BranchId =clsPublic.GetObjectString(lkpBranch.EditValue);
                model.BranchName = lkpBranch.Text;
                model.CategoryName = cbCategory.EditValue.ToString();
                model.StickyName = txtStickyName.Text;
                model.StickyXML = myRichEidt.TextEdit;
                model.EditTime = DateTime.Now;
                model.OperatorId = Models.SqlHelper.Session._UserId;
                model.OperatorName = Models.SqlHelper.Session._FullName ;
                if (model.Id == Guid.Empty)
                {
                    model.Id = Guid.NewGuid();
                    if (manager.AddNew(model))
                    {
                        clsPublic.ShowMessage("新增成功", Text);
                    }
                    else
                    {
                        clsPublic.ShowMessage("新增失败", Text);
                    }
                }
                else
                {
                    if (manager.Modify(model))
                    {
                        clsPublic.ShowMessage("修改成功", Text);
                    }
                    else
                    {
                        clsPublic.ShowMessage("修改失败", Text);
                    }
                }
               
                Query();
            }
            else
            {
                clsPublic.ShowMessage("信息输入不完整", Text);
            }

        }
        

        /// <summary>
        /// 选择的记录改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvData_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                Guid Id = clsPublic.GetObjGUID(gvData.GetFocusedRowCellValue("Id"));
                model = manager.GetOneById(Id);
                if (model != null)
                {
                    lkpBranch.EditValue = model.BranchId;
                    cbCategory.EditValue = model.CategoryName;
                    txtStickyName.Text = model.StickyName;
                    txtEditTime.Text = model.CreateTime.ToString();
                    txtOperatorName.Text = model.OperatorName;
                    myRichEidt.TextEdit= model.StickyXML;
                }
            }
        }
    }
}
