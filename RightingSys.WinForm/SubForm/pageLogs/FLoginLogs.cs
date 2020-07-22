
using RightingSys.WinForm.Utility.cls;
using System;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageLogs
{
    public partial class FLoginLogs : BaseForm
    {
        BLL.LoginLogManager LoginLog = new BLL.LoginLogManager();
        BLL.SystemManager system = new BLL.SystemManager();
        BLL.UserManager user = new BLL.UserManager();


        public FLoginLogs()
        {
            InitializeComponent();
            customPageControl1.OnPageChanged += OnPageChangeds;

            #region 控件初始化

            lkupSystem.Properties.DataSource = system.GetAllSystems();
            lkupUser.Properties.DataSource = user.GetAllList();
            dStartday.DateTime = DateTime.Now.Date.AddDays(-15);
            dEndday.DateTime = DateTime.Now.Date;
            dStartday.Properties.MaxValue=  dEndday.Properties.MaxValue = DateTime.Now;
            dStartday.Properties.MinValue = dEndday.Properties.MinValue = DateTime.Parse("2020-01-01");

            #endregion

        }

        public void OnPageChangeds(object sender, EventArgs args)
        {
            Query();
        }

        /// <summary>
        /// 功能初始化
        /// </summary>
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[] {FeatureButton.Query,FeatureButton.Delete,FeatureButton.Export});
        }

        /// <summary>
        /// 查询所有的登录记录
        /// </summary>
        public override void Query()
        {
            Guid systemId = clsPublic.GetObjGUID(lkupSystem.EditValue);
            Guid userId = clsPublic.GetObjGUID(lkupUser.EditValue);

            customPageControl1.DrawControl(LoginLog.GetList(systemId, userId, dStartday.DateTime.Date, dEndday.DateTime.AddDays(1)).Count);
            gcData.DataSource = LoginLog.GetListByPage(systemId, userId, dStartday.DateTime.Date, dEndday.DateTime.AddDays(1), customPageControl1.PageSize, customPageControl1.PageIndex); ;
        }

        /// <summary>
        /// 删除前90天的日志
        /// </summary>
        public override void Delete()
        {
            if (clsPublic.GetMessageBoxYesNoResult("您确定删除90天前的日志吗？", "询问"))
            {
                if (LoginLog.DeleteByDayNum(-90))
                {
                    clsPublic.ShowMessage("删除成功", "提示");
                }
                else
                {
                    clsPublic.ShowMessage("90天前没有日志供删除", "提示");
                }
            }
        }

        /// <summary>
        /// 导出到Excel表
        /// </summary>
        public override void Export()
        {
            clsPublic.DevExprot(gcData);
        }
        
    }
}
