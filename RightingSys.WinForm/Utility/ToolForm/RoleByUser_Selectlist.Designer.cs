namespace RightingSys.WinForm.Utility.ToolForm
{
    partial class RoleByUser_Selectlist
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
            this.gcUser = new DevExpress.XtraGrid.GridControl();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.checkBoxColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.sbtnFinish = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.tabpage_Dept = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tlDepartment = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tabPaneView = new DevExpress.XtraBars.Navigation.TabPane();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.tabpage_Dept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneView)).BeginInit();
            this.tabPaneView.SuspendLayout();
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
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn4});
            this.gvUser.GridControl = this.gcUser;
            this.gvUser.Name = "gvUser";
            this.gvUser.OptionsView.ColumnAutoWidth = false;
            this.gvUser.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUser.OptionsView.EnableAppearanceOddRow = true;
            this.gvUser.OptionsView.ShowGroupPanel = false;
//            this.gvUser.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvUser_CustomColumnDisplayText);
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
            this.gridColumn1.FieldName = "SimpleCode";
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
            this.gridColumn4.Caption = "部门";
            this.gridColumn4.FieldName = "DepartmentName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
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
            // tabpage_Dept
            // 
            this.tabpage_Dept.Caption = "tabpage_Dept";
            this.tabpage_Dept.Controls.Add(this.tlDepartment);
            this.tabpage_Dept.Name = "tabpage_Dept";
            this.tabpage_Dept.PageText = "按组织机构查看";
            this.tabpage_Dept.Size = new System.Drawing.Size(211, 267);
            // 
            // tlDepartment
            // 
            this.tlDepartment.Caption = "部门列表";
            this.tlDepartment.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.tlDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDepartment.KeyFieldName = "Id";
            this.tlDepartment.Location = new System.Drawing.Point(0, 0);
            this.tlDepartment.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tlDepartment.LookAndFeel.UseWindowsXPTheme = true;
            this.tlDepartment.Name = "tlDepartment";
            this.tlDepartment.OptionsBehavior.Editable = false;
            this.tlDepartment.OptionsView.ShowCaption = true;
            this.tlDepartment.OptionsView.ShowColumns = false;
            this.tlDepartment.ParentFieldName = "ParentId";
            this.tlDepartment.Size = new System.Drawing.Size(211, 267);
            this.tlDepartment.TabIndex = 0;
            this.tlDepartment.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tl_OU_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "部门名称";
            this.treeListColumn1.FieldName = "DepartmentName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // tabPaneView
            // 
            this.tabPaneView.Controls.Add(this.tabpage_Dept);
            this.tabPaneView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaneView.Location = new System.Drawing.Point(0, 0);
            this.tabPaneView.Name = "tabPaneView";
            this.tabPaneView.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabpage_Dept});
            this.tabPaneView.RegularSize = new System.Drawing.Size(229, 313);
            this.tabPaneView.SelectedPage = this.tabpage_Dept;
            this.tabPaneView.Size = new System.Drawing.Size(229, 313);
            this.tabPaneView.TabIndex = 0;
            //this.tabPaneView.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabPaneView_SelectedPageChanged);
            // 
            // RoleByUser_Selectlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 360);
            this.Controls.Add(this.sbtnClose);
            this.Controls.Add(this.sbtnFinish);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "RoleByUser_Selectlist";
            this.Text = "人员选择";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.tabpage_Dept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneView)).EndInit();
            this.tabPaneView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gcUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn checkBoxColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.SimpleButton sbtnFinish;
        private DevExpress.XtraEditors.SimpleButton sbtnClose;
        private DevExpress.XtraBars.Navigation.TabPane tabPaneView;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabpage_Dept;
        private DevExpress.XtraTreeList.TreeList tlDepartment;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}