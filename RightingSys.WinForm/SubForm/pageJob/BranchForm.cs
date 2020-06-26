using RightingSys.WinForm.Utility.cls;
using System;

namespace RightingSys.WinForm.SubForm.pageJob
{
    public partial class BranchForm : BaseForm
    {
        public BranchForm()
        {
            InitializeComponent(); Query();
        }

        /// <summary>
        /// 功能初始化
        /// </summary>
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[]{ FeatureButton.Query,FeatureButton.Export});
        }

        /// <summary>
        /// 筛选
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            gvData.FindFilterText = txtFind.Text;
        }
        /// <summary>
        /// 查询
        /// </summary>
        public override void Query()
        {
            BLL.JobManager manager = new BLL.JobManager();
            gcData.DataSource = manager.GetDtBranch();
        }

        /// <summary>
        /// 导出
        /// </summary>
        public override void Export()
        {
            clsPublic.DevExprot(gcData);
        }
    }
}
