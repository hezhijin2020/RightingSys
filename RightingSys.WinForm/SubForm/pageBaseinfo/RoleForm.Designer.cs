namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    partial class RoleForm
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
            this.gcRole = new DevExpress.XtraGrid.GridControl();
            this.gvRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.sbtnUserRemove = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnUserAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gcUser = new DevExpress.XtraGrid.GridControl();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.sbtnOURemove = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnOUAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gcOU = new DevExpress.XtraGrid.GridControl();
            this.gvOU = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.sbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtSortCode = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.sbtnReLoadFunc = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnSaveFunc = new DevExpress.XtraEditors.SimpleButton();
            this.tlFunc = new DevExpress.XtraTreeList.TreeList();
            this.col1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcOU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSortCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcRole);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.tabPane1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1021, 488);
            this.splitContainerControl1.SplitterPosition = 245;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcRole
            // 
            this.gcRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcRole.Location = new System.Drawing.Point(3, 12);
            this.gcRole.MainView = this.gvRole;
            this.gcRole.Name = "gcRole";
            this.gcRole.Size = new System.Drawing.Size(241, 468);
            this.gcRole.TabIndex = 1;
            this.gcRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRole});
            // 
            // gvRole
            // 
            this.gvRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8});
            this.gvRole.GridControl = this.gcRole;
            this.gvRole.Name = "gvRole";
            this.gvRole.OptionsBehavior.Editable = false;
            this.gvRole.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRole.OptionsView.EnableAppearanceOddRow = true;
            this.gvRole.OptionsView.ShowGroupPanel = false;
            this.gvRole.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvRole_FocusedRowChanged);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "RoleId";
            this.gridColumn7.FieldName = "Id";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "角色列表";
            this.gridColumn8.FieldName = "RoleName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(771, 488);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(771, 488);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "角色基础信息";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "角色基础信息";
            this.tabNavigationPage1.Controls.Add(this.groupControl3);
            this.tabNavigationPage1.Controls.Add(this.groupControl2);
            this.tabNavigationPage1.Controls.Add(this.groupControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(753, 442);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.sbtnUserRemove);
            this.groupControl3.Controls.Add(this.sbtnUserAdd);
            this.groupControl3.Controls.Add(this.gcUser);
            this.groupControl3.Location = new System.Drawing.Point(522, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(227, 439);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "包含的用户信息";
            // 
            // sbtnUserRemove
            // 
            this.sbtnUserRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnUserRemove.Location = new System.Drawing.Point(165, 403);
            this.sbtnUserRemove.Name = "sbtnUserRemove";
            this.sbtnUserRemove.Size = new System.Drawing.Size(57, 23);
            this.sbtnUserRemove.TabIndex = 5;
            this.sbtnUserRemove.Text = "移除";
            this.sbtnUserRemove.Click += new System.EventHandler(this.sbtnUserRemove_Click);
            // 
            // sbtnUserAdd
            // 
            this.sbtnUserAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnUserAdd.Location = new System.Drawing.Point(102, 403);
            this.sbtnUserAdd.Name = "sbtnUserAdd";
            this.sbtnUserAdd.Size = new System.Drawing.Size(57, 23);
            this.sbtnUserAdd.TabIndex = 4;
            this.sbtnUserAdd.Text = "添加";
            this.sbtnUserAdd.Click += new System.EventHandler(this.sbtnUserAdd_Click);
            // 
            // gcUser
            // 
            this.gcUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUser.Location = new System.Drawing.Point(2, 21);
            this.gcUser.MainView = this.gvUser;
            this.gcUser.Name = "gcUser";
            this.gcUser.Size = new System.Drawing.Size(223, 373);
            this.gcUser.TabIndex = 0;
            this.gcUser.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUser});
            // 
            // gvUser
            // 
            this.gvUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvUser.GridControl = this.gcUser;
            this.gvUser.Name = "gvUser";
            this.gvUser.OptionsBehavior.Editable = false;
            this.gvUser.OptionsView.EnableAppearanceEvenRow = true;
            this.gvUser.OptionsView.EnableAppearanceOddRow = true;
            this.gvUser.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "RoleID";
            this.gridColumn1.FieldName = "RoleId";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "UserID";
            this.gridColumn2.FieldName = "UserId";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "用户";
            this.gridColumn3.FieldName = "FullName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.sbtnOURemove);
            this.groupControl2.Controls.Add(this.sbtnOUAdd);
            this.groupControl2.Controls.Add(this.gcOU);
            this.groupControl2.Location = new System.Drawing.Point(3, 189);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(511, 253);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "包含的机构信息";
            // 
            // sbtnOURemove
            // 
            this.sbtnOURemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnOURemove.Location = new System.Drawing.Point(437, 217);
            this.sbtnOURemove.Name = "sbtnOURemove";
            this.sbtnOURemove.Size = new System.Drawing.Size(57, 23);
            this.sbtnOURemove.TabIndex = 3;
            this.sbtnOURemove.Text = "移除";
            this.sbtnOURemove.Click += new System.EventHandler(this.sbtnOURemove_Click);
            // 
            // sbtnOUAdd
            // 
            this.sbtnOUAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnOUAdd.Location = new System.Drawing.Point(374, 217);
            this.sbtnOUAdd.Name = "sbtnOUAdd";
            this.sbtnOUAdd.Size = new System.Drawing.Size(57, 23);
            this.sbtnOUAdd.TabIndex = 2;
            this.sbtnOUAdd.Text = "添加";
            this.sbtnOUAdd.Click += new System.EventHandler(this.sbtnOUAdd_Click);
            // 
            // gcOU
            // 
            this.gcOU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcOU.Location = new System.Drawing.Point(2, 21);
            this.gcOU.MainView = this.gvOU;
            this.gcOU.Name = "gcOU";
            this.gcOU.Size = new System.Drawing.Size(507, 187);
            this.gcOU.TabIndex = 1;
            this.gcOU.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOU});
            // 
            // gvOU
            // 
            this.gvOU.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvOU.GridControl = this.gcOU;
            this.gvOU.Name = "gvOU";
            this.gvOU.OptionsBehavior.Editable = false;
            this.gvOU.OptionsView.EnableAppearanceEvenRow = true;
            this.gvOU.OptionsView.EnableAppearanceOddRow = true;
            this.gvOU.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "OU_ID";
            this.gridColumn4.FieldName = "DepartmentId";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Role_ID";
            this.gridColumn5.FieldName = "RoleId";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "机构";
            this.gridColumn6.FieldName = "DepartmentName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.sbtnSave);
            this.groupControl1.Controls.Add(this.txtSortCode);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(511, 167);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "角色信息";
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(104, 32);
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(390, 20);
            this.txtID.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(59, 35);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 14);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "角色ID";
            // 
            // sbtnSave
            // 
            this.sbtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnSave.Location = new System.Drawing.Point(407, 125);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new System.Drawing.Size(87, 27);
            this.sbtnSave.TabIndex = 10;
            this.sbtnSave.Text = "保存";
            this.sbtnSave.Click += new System.EventHandler(this.sbtnSave_Click);
            // 
            // txtSortCode
            // 
            this.txtSortCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSortCode.Location = new System.Drawing.Point(104, 99);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(390, 20);
            this.txtSortCode.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(104, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(390, 20);
            this.txtName.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(59, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "排序码";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "角色名称(*)";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "角色可操作的权限";
            this.tabNavigationPage2.Controls.Add(this.sbtnReLoadFunc);
            this.tabNavigationPage2.Controls.Add(this.sbtnSaveFunc);
            this.tabNavigationPage2.Controls.Add(this.tlFunc);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(753, 442);
            // 
            // sbtnReLoadFunc
            // 
            this.sbtnReLoadFunc.Location = new System.Drawing.Point(121, 14);
            this.sbtnReLoadFunc.Name = "sbtnReLoadFunc";
            this.sbtnReLoadFunc.Size = new System.Drawing.Size(103, 27);
            this.sbtnReLoadFunc.TabIndex = 4;
            this.sbtnReLoadFunc.Text = "重新加载功能";
            this.sbtnReLoadFunc.Click += new System.EventHandler(this.sbtnReLoadFunc_Click);
            // 
            // sbtnSaveFunc
            // 
            this.sbtnSaveFunc.Location = new System.Drawing.Point(15, 14);
            this.sbtnSaveFunc.Name = "sbtnSaveFunc";
            this.sbtnSaveFunc.Size = new System.Drawing.Size(99, 27);
            this.sbtnSaveFunc.TabIndex = 3;
            this.sbtnSaveFunc.Text = "保存功能数据";
            this.sbtnSaveFunc.Click += new System.EventHandler(this.sbtnSaveFunc_Click);
            // 
            // tlFunc
            // 
            this.tlFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlFunc.Appearance.Caption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlFunc.Appearance.Caption.ForeColor = System.Drawing.Color.Red;
            this.tlFunc.Appearance.Caption.Options.UseFont = true;
            this.tlFunc.Appearance.Caption.Options.UseForeColor = true;
            this.tlFunc.Appearance.Caption.Options.UseTextOptions = true;
            this.tlFunc.Appearance.Caption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tlFunc.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.col1});
            this.tlFunc.KeyFieldName = "Id";
            this.tlFunc.Location = new System.Drawing.Point(0, 51);
            this.tlFunc.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tlFunc.LookAndFeel.UseWindowsXPTheme = true;
            this.tlFunc.Name = "tlFunc";
            this.tlFunc.OptionsBehavior.Editable = false;
            this.tlFunc.OptionsView.ShowCaption = true;
            this.tlFunc.OptionsView.ShowCheckBoxes = true;
            this.tlFunc.OptionsView.ShowColumns = false;
            this.tlFunc.OptionsView.ShowIndicator = false;
            this.tlFunc.ParentFieldName = "ParentId";
            this.tlFunc.Size = new System.Drawing.Size(753, 391);
            this.tlFunc.TabIndex = 1;
            this.tlFunc.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.tlFunc_BeforeCheckNode);
            this.tlFunc.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tlFunc_AfterCheckNode);
            // 
            // col1
            // 
            this.col1.Caption = "功能名称";
            this.col1.FieldName = "FuncName";
            this.col1.Name = "col1";
            this.col1.Visible = true;
            this.col1.VisibleIndex = 0;
            this.col1.Width = 38;
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 488);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "RoleForm";
            this.Text = "角色管理";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcOU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSortCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTreeList.TreeList tlFunc;
        private DevExpress.XtraEditors.SimpleButton sbtnSave;
        private DevExpress.XtraEditors.TextEdit txtSortCode;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraGrid.GridControl gcOU;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOU;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col1;
        private DevExpress.XtraEditors.SimpleButton sbtnReLoadFunc;
        private DevExpress.XtraEditors.SimpleButton sbtnSaveFunc;
        private DevExpress.XtraEditors.SimpleButton sbtnUserRemove;
        private DevExpress.XtraEditors.SimpleButton sbtnUserAdd;
        private DevExpress.XtraEditors.SimpleButton sbtnOURemove;
        private DevExpress.XtraEditors.SimpleButton sbtnOUAdd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.GridControl gcRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRole;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}