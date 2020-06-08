using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace RightingSys.WinForm.Utility.CustomControls
{
    [UserRepositoryItem("RegisterCustomGridLookUpEdit")]
    [DXCategory("Properties")]
    public class RepositoryItemCustomGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        static RepositoryItemCustomGridLookUpEdit() { RegisterCustomGridLookUpEdit(); }

        public RepositoryItemCustomGridLookUpEdit() {
            TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            AutoComplete = true;
        }
        [Browsable(false)]
        public override DevExpress.XtraEditors.Controls.TextEditStyles TextEditStyle { get { return base.TextEditStyle; } set { base.TextEditStyle = value; } }

        /// <summary>
        /// 编辑器的名称
        /// </summary>
        public const string CustomGridLookUpEditName = "CustomGridLookUpEdit";

        /// <summary>
        /// 编辑器名称
        /// </summary>
        public override string EditorTypeName { get { return CustomGridLookUpEditName; } }

        /// <summary>
        /// 注册编辑器
        /// </summary>
        public static void RegisterCustomGridLookUpEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomGridLookUpEditName,
              typeof(CustomGridLookUpEdit), typeof(RepositoryItemCustomGridLookUpEdit),
              typeof(GridLookUpEditBaseViewInfo), new ButtonEditPainter(), true));
        }

        /// <summary>
        /// 创建自定义GridView
        /// </summary>
        /// <returns></returns>
        protected override ColumnView CreateViewInstance() { return new CustomGridView(); }
        
        /// <summary>
        /// 创建自定义GridControl
        /// </summary>
        /// <returns></returns>
        protected override GridControl CreateGrid() { return new CustomGridControl(); }
    }

    public class CustomGridLookUpPopupForm : PopupGridLookUpEditForm
    {
        public CustomGridLookUpPopupForm(GridLookUpEdit ownerEdit): base(ownerEdit)
        {
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                this.OwnerEdit.EditValue = QueryResultValue();
                this.OwnerEdit.SendKey(e);
            }

            base.OnKeyDown(e);
        }
    }

    [ToolboxItem(true)]
    public class CustomGridLookUpEdit : GridLookUpEdit
    {
        /// <summary>
        /// 自动注册下拉框编辑器
        /// </summary>
        static CustomGridLookUpEdit() { RepositoryItemCustomGridLookUpEdit.RegisterCustomGridLookUpEdit(); }

        /// <summary>
        /// 创建自定义GridLookupEdit
        /// </summary>
        public CustomGridLookUpEdit() : base() {
            Initialize();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Initialize()
        {
            this.Tag = false;   // 设置全选标记
            this.Properties.AllowMouseWheel = false;
            this.EnterMoveNextControl = true;
            this.Properties.ImmediatePopup = true;
            this.Properties.TextEditStyle = TextEditStyles.Standard;
            this.Properties.NullText = "";
            this.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;

            #region 编辑框默认自动全选

            // 鼠标移入文本编辑框触发事件
            this.Enter += (sender, e) =>
            {
                // 设置全选标记
                this.Tag = true;
                this.SelectAll();
            };
            // 获取输入焦点时自动全选
            this.MouseUp += (sender, e) =>
            {
                // 如果鼠标左键操作并且标记存在，则执行全选
                if (e.Button == System.Windows.Forms.MouseButtons.Left && (bool)this.Tag)
                {
                    this.SelectAll();
                }

                // 取消全选标记
                this.Tag = false;
            };
            // 双击输入框时自动全选
            this.DoubleClick += (sender, e) =>
            {
                this.SelectAll();
            };

            #endregion

            this.KeyDown += this.CustomGridLookUpEdit_KeyDown;
        }

        /// <summary>
        /// 自定义键盘事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomGridLookUpEdit_KeyDown(object sender, KeyEventArgs e)
       {
          if (e.KeyCode == Keys.Delete) {
            var control = sender as BaseEdit;
            if (control.ReadOnly) { return; }
            control.EditValue = null;
            e.Handled = true;
          } else if (e.KeyCode == Keys.Down) {
            this.ShowPopup();
            e.Handled = true;
          } else  if (e.KeyCode == Keys.Back) {
            if (this.IsPopupOpen == false) {
                    var control = sender as BaseEdit;
                    if (control.ReadOnly) { return; }
                    control.EditValue = null;
                    e.Handled = true;
                }
          }
        }

        /// <summary>
        ///自定义编辑器名称
        /// </summary>
        public override string EditorTypeName { get { return RepositoryItemCustomGridLookUpEdit.CustomGridLookUpEditName; } }

        /// <summary>
        /// 重写下拉框编辑器
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemCustomGridLookUpEdit Properties { get { return base.Properties as RepositoryItemCustomGridLookUpEdit; } }

        //
        // 摘要:
        //     Gets or sets whether focus is moved to the next control (according to the tab
        //     order) when an end-user presses ENTER.
        [DefaultValue(true)]
        [DXCategory("Behavior")]
        public override bool EnterMoveNextControl { get; set; } = true;
    
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override PopupBaseForm CreatePopupForm() {
          return new CustomGridLookUpPopupForm(this);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name = "e" ></ param >
        /// < returns ></ returns >
        public override bool IsNeededKey(KeyEventArgs e)
        {
            return this.Properties.IsNeededKey(e.KeyData);
        }

      

        /// <summary>
        /// 正常情况下，在输入第一个字符（主要是数字及字母）后，虽然自动弹出了下拉框并过滤了数据，
        /// 但是此时光标并未定位到下拉框中，导致回车后并未返回匹配到的首行记录
        /// 此处就是为了解决以上问题，展开下拉框时自动定位到首行
        /// </summary>
        protected override void OnPopupShown()
       {
            base.OnPopupShown();
            BeginInvoke(new Action(() =>
            {
                if (this.GetSelectedDataRow() == null)
                {
                   this.Properties.View.FocusedRowHandle = 0;
                }
            }));
        }
    }
}
