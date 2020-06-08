namespace RightingSys.WinForm.Utility.ToolForm
{
    partial class F_UserForBlackIP_Selectlist
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tabPaneView = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabpage_Dept = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tl_OU = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tabpage_Role = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tl_Role = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcUser = new DevExpress.XtraGrid.GridControl();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkBoxColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.sbtnFinish = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneView)).BeginInit();
            this.tabPaneView.SuspendLayout();
            this.tabpage_Dept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tl_OU)).BeginInit();
            this.tabpage_Role.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tl_Role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(10, 8);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tabPaneView);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcUser);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(790, 313);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 2;
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
            this.tabPaneView.RegularSize = new System.Drawing.Size(229, 313);
            this.tabPaneView.SelectedPage = this.tabpage_Dept;
            this.tabPaneView.Size = new System.Drawing.Size(229, 313);
            this.tabPaneView.TabIndex = 0;
            this.tabPaneView.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPaneView_SelectedPageChanged);
            // 
            // tabpage_Dept
            // 
            this.tabpage_Dept.Caption = "tabpage_Dept";
            this.tabpage_Dept.Controls.Add(this.tl_OU);
            this.tabpage_Dept.Name = "tabpage_Dept";
            this.tabpage_Dept.PageText = "按组织机构查看";
            this.tabpage_Dept.Size = new System.Drawing.Size(211, 267);
            // 
            // tl_OU
            // 
            this.tl_OU.Caption = "组织机构列表";
            this.tl_OU.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.tl_OU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_OU.Location = new System.Drawing.Point(0, 0);
            this.tl_OU.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tl_OU.LookAndFeel.UseWindowsXPTheme = true;
            this.tl_OU.Name = "tl_OU";
            this.tl_OU.OptionsBehavior.Editable = false;
            this.tl_OU.OptionsView.ShowCaption = true;
            this.tl_OU.OptionsView.ShowColumns = false;
            this.tl_OU.ParentFieldName = "PID";
            this.tl_OU.Size = new System.Drawing.Size(211, 267);
            this.tl_OU.TabIndex = 0;
            this.tl_OU.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tl_OU_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "机构名称";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // tabpage_Role
            // 
            this.tabpage_Role.Caption = "tabNavigationPage2";
            this.tabpage_Role.Controls.Add(this.tl_Role);
            this.tabpage_Role.Name = "tabpage_Role";
            this.tabpage_Role.PageText = "按角色查看";
            this.tabpage_Role.Size = new System.Drawing.Size(211, 267);
            // 
            // tl_Role
            // 
            this.tl_Role.Caption = "角色分类";
            this.tl_Role.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.tl_Role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_Role.Location = new System.Drawing.Point(0, 0);
            this.tl_Role.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tl_Role.LookAndFeel.UseWindowsXPTheme = true;
            this.tl_Role.Name = "tl_Role";
            this.tl_Role.OptionsBehavior.Editable = false;
            this.tl_Role.OptionsView.ShowCaption = true;
            this.tl_Role.OptionsView.ShowColumns = false;
            this.tl_Role.ParentFieldName = "PID";
            this.tl_Role.Size = new System.Drawing.Size(211, 267);
            this.tl_Role.TabIndex = 0;
            this.tl_Role.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tl_Role_FocusedNodeChanged);
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "角色名称";
            this.treeListColumn2.FieldName = "Name";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // gcUser
            // 
            this.gcUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUser.Location = new System.Drawing.Point(1, 38);
            this.gcUser.MainView = this.gvUser;
            this.gcUser.Name = "gcUser";
            this.gcUser.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemCheckEdit2});
            this.gcUser.Size = new System.Drawing.Size(549, 267);
            this.gcUser.TabIndex = 0;
            this.gcUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUser});
            // 
            // gvUser
            // 
            this.gvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.checkBoxColumn,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17});
            this.gvUser.GridControl = this.gcUser;
            this.gvUser.Name = "gvUser";
            this.gvUser.OptionsView.ColumnAutoWidth = false;
            this.gvUser.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUser.OptionsView.EnableAppearanceOddRow = true;
            this.gvUser.OptionsView.ShowGroupPanel = false;
            this.gvUser.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvUser_CustomColumnDisplayText);
            // 
            // checkBoxColumn
            // 
            this.checkBoxColumn.Caption = " ";
            this.checkBoxColumn.ColumnEdit = this.repositoryItemCheckEdit2;
            this.checkBoxColumn.FieldName = "IsCheck";
            this.checkBoxColumn.Name = "checkBoxColumn";
            this.checkBoxColumn.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.checkBoxColumn.OptionsColumn.AllowIncrementalSearch = false;
            this.checkBoxColumn.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.checkBoxColumn.OptionsColumn.AllowMove = false;
            this.checkBoxColumn.OptionsColumn.AllowSize = false;
            this.checkBoxColumn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.checkBoxColumn.Visible = true;
            this.checkBoxColumn.VisibleIndex = 0;
            this.checkBoxColumn.Width = 40;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "用户编码";
            this.gridColumn1.FieldName = "HandNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "用户名";
            this.gridColumn2.FieldName = "LoginName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "真实姓名";
            this.gridColumn3.FieldName = "FullName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "职务";
            this.gridColumn4.FieldName = "Job";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "手机";
            this.gridColumn5.FieldName = "MobilePhone";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "邮箱";
            this.gridColumn6.FieldName = "Email";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "审核状态";
            this.gridColumn7.FieldName = "Enabled";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "性别";
            this.gridColumn8.FieldName = "Gender";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "身份证号";
            this.gridColumn9.FieldName = "CardNo";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "是否删除";
            this.gridColumn10.FieldName = "Deleted";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 10;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "入职日期";
            this.gridColumn11.FieldName = "JoinDay";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 11;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "出生日期";
            this.gridColumn12.FieldName = "Birthday";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 12;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "最后登录时间";
            this.gridColumn13.FieldName = "LastLoginTime";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 13;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "最后登录IP";
            this.gridColumn14.FieldName = "LastLoginIP";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 14;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "最后登录Mac地址";
            this.gridColumn15.FieldName = "LastLoginMac";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 15;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "UserID";
            this.gridColumn16.FieldName = "UserID";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "所属部门";
            this.gridColumn17.FieldName = "OUName";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 16;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // sbtnFinish
            // 
            this.sbtnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnFinish.Location = new System.Drawing.Point(673, 327);
            this.sbtnFinish.Name = "sbtnFinish";
            this.sbtnFinish.Size = new System.Drawing.Size(64, 23);
            this.sbtnFinish.TabIndex = 3;
            this.sbtnFinish.Text = "完成选择";
            this.sbtnFinish.Click += new System.EventHandler(this.sbtnFinish_Click);
            // 
            // sbtnClose
            // 
            this.sbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnClose.Location = new System.Drawing.Point(743, 327);
            this.sbtnClose.Name = "sbtnClose";
            this.sbtnClose.Size = new System.Drawing.Size(54, 23);
            this.sbtnClose.TabIndex = 5;
            this.sbtnClose.Text = "关闭";
            this.sbtnClose.Click += new System.EventHandler(this.sbtnClose_Click);
            // 
            // F_UserForRole_Selectlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 360);
            this.Controls.Add(this.sbtnClose);
            this.Controls.Add(this.sbtnFinish);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "F_UserForRole_Selectlist";
            this.Text = "人员选择";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneView)).EndInit();
            this.tabPaneView.ResumeLayout(false);
            this.tabpage_Dept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tl_OU)).EndInit();
            this.tabpage_Role.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tl_Role)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPaneView;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabpage_Dept;
        private DevExpress.XtraTreeList.TreeList tl_OU;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabpage_Role;
        private DevExpress.XtraTreeList.TreeList tl_Role;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraGrid.GridControl gcUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn checkBoxColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.SimpleButton sbtnFinish;
        private DevExpress.XtraEditors.SimpleButton sbtnClose;
    }
}