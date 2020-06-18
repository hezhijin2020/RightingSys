namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tabPaneView = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabpage_Dept = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tlDepartment = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tabpage_Role = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tlRole = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcData = new RightingSys.WinForm.Utility.CustomControls.CustomGridControl();
            this.gvData = new RightingSys.WinForm.Utility.CustomControls.CustomGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UserMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuFingerAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFingerClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFingerVerification = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFingerMatching = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneView)).BeginInit();
            this.tabPaneView.SuspendLayout();
            this.tabpage_Dept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDepartment)).BeginInit();
            this.tabpage_Role.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.UserMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tabPaneView);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcData);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(676, 244);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tabPaneView
            // 
            this.tabPaneView.Controls.Add(this.tabpage_Dept);
            this.tabPaneView.Controls.Add(this.tabpage_Role);
            this.tabPaneView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaneView.Location = new System.Drawing.Point(0, 0);
            this.tabPaneView.Name = "tabPaneView";
            this.tabPaneView.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabpage_Dept,
            this.tabpage_Role});
            this.tabPaneView.RegularSize = new System.Drawing.Size(229, 244);
            this.tabPaneView.SelectedPage = this.tabpage_Dept;
            this.tabPaneView.Size = new System.Drawing.Size(229, 244);
            this.tabPaneView.TabIndex = 0;
            this.tabPaneView.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPaneView_SelectedPageChanged);
            // 
            // tabpage_Dept
            // 
            this.tabpage_Dept.Caption = "tabpage_Dept";
            this.tabpage_Dept.Controls.Add(this.tlDepartment);
            this.tabpage_Dept.Name = "tabpage_Dept";
            this.tabpage_Dept.PageText = "按部门查看";
            this.tabpage_Dept.Size = new System.Drawing.Size(211, 198);
            // 
            // tlDepartment
            // 
            this.tlDepartment.Caption = "部门列表";
            this.tlDepartment.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.tlDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDepartment.KeyFieldName = "Id";
            this.tlDepartment.Location = new System.Drawing.Point(0, 0);
            this.tlDepartment.Name = "tlDepartment";
            this.tlDepartment.OptionsBehavior.Editable = false;
            this.tlDepartment.OptionsView.EnableAppearanceEvenRow = true;
            this.tlDepartment.OptionsView.EnableAppearanceOddRow = true;
            this.tlDepartment.OptionsView.ShowCaption = true;
            this.tlDepartment.OptionsView.ShowColumns = false;
            this.tlDepartment.ParentFieldName = "ParentId";
            this.tlDepartment.Size = new System.Drawing.Size(211, 198);
            this.tlDepartment.TabIndex = 0;
            this.tlDepartment.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlDepartment_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "机构名称";
            this.treeListColumn1.FieldName = "DepartmentName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // tabpage_Role
            // 
            this.tabpage_Role.Caption = "tabNavigationPage2";
            this.tabpage_Role.Controls.Add(this.tlRole);
            this.tabpage_Role.Name = "tabpage_Role";
            this.tabpage_Role.PageText = "按角色查看";
            this.tabpage_Role.Size = new System.Drawing.Size(211, 198);
            // 
            // tlRole
            // 
            this.tlRole.Caption = "角色分类";
            this.tlRole.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.tlRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlRole.KeyFieldName = "Id";
            this.tlRole.Location = new System.Drawing.Point(0, 0);
            this.tlRole.Name = "tlRole";
            this.tlRole.OptionsBehavior.Editable = false;
            this.tlRole.OptionsView.EnableAppearanceEvenRow = true;
            this.tlRole.OptionsView.EnableAppearanceOddRow = true;
            this.tlRole.OptionsView.ShowCaption = true;
            this.tlRole.OptionsView.ShowColumns = false;
            this.tlRole.ParentFieldName = "ParentId";
            this.tlRole.Size = new System.Drawing.Size(211, 198);
            this.tlRole.TabIndex = 0;
            this.tlRole.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tl_Role_FocusedNodeChanged);
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "角色名称";
            this.treeListColumn2.FieldName = "RoleName";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // gcData
            // 
            this.gcData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcData.EmbeddedNavigator.TextStringFormat = "记录 {0} / {1}";
            this.gcData.Location = new System.Drawing.Point(0, 0);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(442, 244);
            this.gcData.TabIndex = 1;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvData.Appearance.Row.Options.UseTextOptions = true;
            this.gvData.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvData.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvData.EmptyForegroundText = null;
            this.gvData.GridControl = this.gcData;
            this.gvData.IndicatorWidth = 28;
            this.gvData.LocatedColumn = null;
            this.gvData.Name = "gvData";
            this.gvData.OptionsBehavior.Editable = false;
            this.gvData.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.gvData.OptionsCustomization.AllowColumnMoving = false;
            this.gvData.OptionsDetail.EnableMasterViewMode = false;
            this.gvData.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic;
            this.gvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvData.OptionsPrint.AutoWidth = false;
            this.gvData.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gvData.OptionsSelection.MultiSelect = true;
            this.gvData.OptionsSelection.UseIndicatorForSelection = false;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.EnableAppearanceOddRow = true;
            this.gvData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvData.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "编号";
            this.gridColumn1.FieldName = "SimpleCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "用户";
            this.gridColumn2.FieldName = "LoginName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "姓名";
            this.gridColumn3.FieldName = "FullName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "部门";
            this.gridColumn4.FieldName = "DepartmentName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // UserMenu
            // 
            this.UserMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFingerAdd,
            this.MenuFingerClear,
            this.MenuFingerVerification,
            this.MenuFingerMatching});
            this.UserMenu.Name = "contextMenuStrip1";
            this.UserMenu.Size = new System.Drawing.Size(125, 92);
            // 
            // MenuFingerAdd
            // 
            this.MenuFingerAdd.Name = "MenuFingerAdd";
            this.MenuFingerAdd.Size = new System.Drawing.Size(124, 22);
            this.MenuFingerAdd.Text = "登记指纹";
            this.MenuFingerAdd.Click += new System.EventHandler(this.MenuFingerAdd_Click);
            // 
            // MenuFingerClear
            // 
            this.MenuFingerClear.Name = "MenuFingerClear";
            this.MenuFingerClear.Size = new System.Drawing.Size(124, 22);
            this.MenuFingerClear.Text = "清除指纹";
            this.MenuFingerClear.Click += new System.EventHandler(this.MenuFingerClear_Click);
            // 
            // MenuFingerVerification
            // 
            this.MenuFingerVerification.Name = "MenuFingerVerification";
            this.MenuFingerVerification.Size = new System.Drawing.Size(124, 22);
            this.MenuFingerVerification.Text = "指纹验证";
            this.MenuFingerVerification.Click += new System.EventHandler(this.MenuFingerVerification_Click);
            // 
            // MenuFingerMatching
            // 
            this.MenuFingerMatching.Name = "MenuFingerMatching";
            this.MenuFingerMatching.Size = new System.Drawing.Size(124, 22);
            this.MenuFingerMatching.Text = "指纹匹配";
            this.MenuFingerMatching.Click += new System.EventHandler(this.MenuFingerMatching_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 244);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "UserForm";
            this.Text = "用户信息";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneView)).EndInit();
            this.tabPaneView.ResumeLayout(false);
            this.tabpage_Dept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlDepartment)).EndInit();
            this.tabpage_Role.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.UserMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPaneView;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabpage_Dept;
        private DevExpress.XtraTreeList.TreeList tlDepartment;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabpage_Role;
        private DevExpress.XtraTreeList.TreeList tlRole;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private System.Windows.Forms.ContextMenuStrip UserMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFingerAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuFingerClear;
        private System.Windows.Forms.ToolStripMenuItem MenuFingerVerification;
        private System.Windows.Forms.ToolStripMenuItem MenuFingerMatching;
        private Utility.CustomControls.CustomGridControl gcData;
        private Utility.CustomControls.CustomGridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}