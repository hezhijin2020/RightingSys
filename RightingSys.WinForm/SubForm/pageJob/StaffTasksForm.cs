
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Menu;

namespace RightingSys.WinForm.SubForm.pageJob
{
    public partial class StaffTasksForm : BaseForm
    {
        enum NodeMenuItemID { 下一级 = 3, 上一级 = 2 }

        BLL.StaffTasksManager manager = new BLL.StaffTasksManager();

        public StaffTasksForm()
        {
            InitializeComponent();

            treeList1.DataSource = manager.GetAllList();
            repositoryItemPriorityComboBox.AddImages(imageCollection);
            repositoryItemDescriptionComboBox.Items.Add("", true, 1);
            repositoryItemCompletedComboBox.Items.Add("", true, 0);
            treeList1.MouseDown += OnMouseDown;
            treeList1.NodeCellStyle += OnNodeCellStyle;
            treeList1.PopupMenuShowing += OnPopupMenuShowing;
        }


        private  void OnPopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.Menu is DevExpress.XtraTreeList.Menu.TreeListNodeMenu)
            {
                AddItem(e.Menu, NodeMenuItemID.下一级, treeList1.CanIndentNodes(treeList1.Selection));
                AddItem(e.Menu, NodeMenuItemID.上一级, treeList1.CanOutdentNodes(treeList1.Selection));
                e.Allow = true;
            }
        }

        private void AddItem(TreeListMenu menu, NodeMenuItemID id, bool enabled)
        {
            DevExpress.Utils.Menu.DXMenuItem item = new DevExpress.Utils.Menu.DXMenuItem(id.ToString());
            item.Tag = id;
            item.ImageOptions.Image = imageCollection.Images[(int)id];
            item.Enabled = enabled;
            item.Click += OnMenuItemClick;
            menu.Items.Add(item);
        }

        private void OnMenuItemClick(object sender, System.EventArgs e)
        {
            var item = sender as DevExpress.Utils.Menu.DXMenuItem;
            if ((NodeMenuItemID)item.Tag == NodeMenuItemID.下一级)
                treeList1.IndentNodes(treeList1.Selection, false);
            if ((NodeMenuItemID)item.Tag == NodeMenuItemID.上一级)
                treeList1.OutdentNodes(treeList1.Selection, false);
        }

        /// <summary>
        /// 完成的任务加入删除线
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnNodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            Models.ys_StaffTasks task = treeList1.GetRow(e.Node.Id) as Models.ys_StaffTasks;
            if (task == null || !task.IsCompleted)
                return;
            e.Appearance.FontStyleDelta = (FontStyle.Italic | FontStyle.Strikeout);
        }

        /// <summary>
        /// 右键显示描述信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            var hitInfo = treeList1.CalcHitInfo(e.Location);
            if (hitInfo.InRowCell && hitInfo.Column.FieldName == "IsDescription")
            {
                Models.ys_StaffTasks task = treeList1.GetRow(hitInfo.Node.Id) as Models.ys_StaffTasks;
                if (task == null || string.IsNullOrEmpty(task.Description))
                    return;
                ToolTipController.DefaultController.ShowHint(task.Description, ToolTipLocation.RightCenter);
            }
        }


        /// <summary>
        /// 显示行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeList1_CustomDrawNodeIndicator(object sender, CustomDrawNodeIndicatorEventArgs e)
        {
            DevExpress.XtraTreeList.TreeList tmpTree = sender as DevExpress.XtraTreeList.TreeList;
            DevExpress.Utils.Drawing.IndicatorObjectInfoArgs args = e.ObjectArgs as DevExpress.Utils.Drawing.IndicatorObjectInfoArgs;
            if (args != null)
            {
                int rowNum = tmpTree.GetVisibleIndexByNode(e.Node) + 1;
                args.DisplayText = rowNum.ToString();
            }
            e.ImageIndex = -1;
        }
    }
}
