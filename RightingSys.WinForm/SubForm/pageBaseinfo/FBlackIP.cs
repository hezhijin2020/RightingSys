using RightingSys.WinForm.Utility.cls;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    public partial class FBlackIP : BaseForm
    {
        BLL.BlackIPManager blackIPManager = new BLL.BlackIPManager();
        List<Models.ACL_BlackIP> lsSource = new List<Models.ACL_BlackIP>();
        public FBlackIP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 功能初始化
        /// </summary>
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[] { FeatureButton.Add,FeatureButton.Modify,FeatureButton.Delete, FeatureButton.Query });
        }

        /// <summary>
        /// 新增规则
        /// </summary>
        public override void AddNew()
        {
            FBlackIP_User sub = new FBlackIP_User();
            if (sub.ShowDialog() == DialogResult.OK)
            {
                Query();
            }
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        public override void Modify()
        {
            object id = gvData.GetFocusedRowCellValue("Id");
            if (id != null)
            {
                var BlackIPId = clsPublic.GetObjGUID(id);
                Models.ACL_BlackIP md = lsSource.FirstOrDefault(a => a.Id == BlackIPId);

                FBlackIP_User sub = new FBlackIP_User(md);
                if (sub.ShowDialog() == DialogResult.OK)
                {
                    Query();
                }
            }
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        public override void Delete()
        {
            object id = gvData.GetFocusedRowCellValue("Id");
            if (id != null)
            {
                if (blackIPManager.Delete(clsPublic.GetObjGUID(id)))
                {
                    if (clsPublic.GetMessageBoxYesNoResult("是否删除该记录？", Text))
                    {
                        clsPublic.ShowMessage("删除成功", Text);
                    }
                }
            }
        }

        /// <summary>
        /// 查询规则
        /// </summary>
        public override void Query()
        {
            gcData.DataSource = lsSource= blackIPManager.GetAllList();
        }

    }
}
