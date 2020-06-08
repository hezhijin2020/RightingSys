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
            this.gcUser = new DevExpress.XtraGrid.GridControl();
            this.UserMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuFingerAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFingerClear = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFingerVerification = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFingerMatching = new System.Windows.Forms.ToolStripMenuItem();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneView)).BeginInit();
            this.tabPaneView.SuspendLayout();
            this.tabpage_Dept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDepartment)).BeginInit();
            this.tabpage_Role.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
            this.UserMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tabPaneView);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcUser);
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
            this.tabpage_Dept.PageText = "按组织机构查看";
            this.tabpage_Dept.Size = new System.Drawing.Size(211, 198);
            // 
            // tlDepartment
            // 
            this.tlDepartment.Caption = "组织机构列表";
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
            this.tlDepartment.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tl_OU_FocusedNodeChanged);
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
            // gcUser
            // 
            this.gcUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUser.ContextMenuStrip = this.UserMenu;
            this.gcUser.Location = new System.Drawing.Point(1, 3);
            this.gcUser.MainView = this.gvUser;
            this.gcUser.Name = "gcUser";
            this.gcUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcUser.Size = new System.Drawing.Size(435, 232);
            this.gcUser.TabIndex = 0;
            this.gcUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUser});
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
            // gvUser
            // 
            this.gvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvUser.GridControl = this.gcUser;
            this.gvUser.Name = "gvUser";
            this.gvUser.OptionsBehavior.Editable = false;
            this.gvUser.OptionsView.ColumnAutoWidth = false;
            this.gvUser.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUser.OptionsView.EnableAppearanceOddRow = true;
            this.gvUser.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "考勤编号";
            this.gridColumn1.FieldName = "SimpleCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SimpleCode", "{0}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 50;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "用户名";
            this.gridColumn2.FieldName = "LoginName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 60;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "姓名";
            this.gridColumn3.FieldName = "FullName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 60;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "部门";
            this.gridColumn4.FieldName = "DepartmentName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
            this.UserMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPaneView;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabpage_Dept;
        private DevExpress.XtraTreeList.TreeList tlDepartment;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabpage_Role;
        private DevExpress.XtraTreeList.TreeList tlRole;
        private DevExpress.XtraGrid.GridControl gcUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.ContextMenuStrip UserMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFingerAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuFingerClear;
        private System.Windows.Forms.ToolStripMenuItem MenuFingerVerification;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.ToolStripMenuItem MenuFingerMatching;
    }
}