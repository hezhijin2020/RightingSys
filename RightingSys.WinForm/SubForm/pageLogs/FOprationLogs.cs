using RightingSys.WinForm.Utility.cls;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageLogs
{
    public partial class FOprationLogs : BaseForm
    {
        /// <summary>
        /// 声明变量
        /// </summary>
        BLL.OperationLogManager  LogManager = new BLL.OperationLogManager();

        public FOprationLogs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 功能初始化
        /// </summary>
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[] {FeatureButton.Query,FeatureButton.Export});
        }

        /// <summary>
        /// 查询操作日志
        /// </summary>
        public override void Query()
        {
            gcData.DataSource = LogManager.GetAllList();
        }
    
        /// <summary>
        /// 导出操作日志
        /// </summary>
        public override void Export()
        {
            clsPublic.DevExprot(gcData);
        }
    }
}
