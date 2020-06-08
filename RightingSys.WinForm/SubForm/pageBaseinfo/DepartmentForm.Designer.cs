namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    partial class DepartmentForm
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
            this.tlDepartment = new DevExpress.XtraTreeList.TreeList();
            this.col_Name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcRole = new DevExpress.XtraGrid.GridControl();
            this.gvRole = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcUser = new DevExpress.XtraGrid.GridControl();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtHandNo = new DevExpress.XtraEditors.TextEdit();
            this.tlPID = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.tlParent = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.sbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSortCode = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtCreatTime = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHandNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSortCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatTime.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tlDepartment);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(771, 376);
            this.splitContainerControl1.SplitterPosition = 224;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tlDepartment
            // 
            this.tlDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlDepartment.Caption = "组织机构列表";
            this.tlDepartment.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.col_Name});
            this.tlDepartment.KeyFieldName = "Id";
            this.tlDepartment.Location = new System.Drawing.Point(6, 16);
            this.tlDepartment.Name = "tlDepartment";
            this.tlDepartment.OptionsBehavior.Editable = false;
            this.tlDepartment.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.CellSelect;
            this.tlDepartment.OptionsView.BestFitMode = DevExpress.XtraTreeList.TreeListBestFitMode.Full;
            this.tlDepartment.OptionsView.BestFitNodes = DevExpress.XtraTreeList.TreeListBestFitNodes.All;
            this.tlDepartment.OptionsView.EnableAppearanceEvenRow = true;
            this.tlDepartment.OptionsView.EnableAppearanceOddRow = true;
            this.tlDepartment.OptionsView.ShowCaption = true;
            this.tlDepartment.OptionsView.ShowColumns = false;
            this.tlDepartment.OptionsView.ShowIndicator = false;
            this.tlDepartment.ParentFieldName = "ParentId";
            this.tlDepartment.Size = new System.Drawing.Size(213, 351);
            this.tlDepartment.TabIndex = 6;
            this.tlDepartment.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlOU_FocusedNodeChanged);
            // 
            // col_Name
            // 
            this.col_Name.Caption = "treeListColumn1";
            this.col_Name.FieldName = "DepartmentName";
            this.col_Name.Name = "col_Name";
            this.col_Name.Visible = true;
            this.col_Name.VisibleIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.gcRole);
            this.groupControl3.Location = new System.Drawing.Point(310, 200);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(229, 167);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "包含角色";
            // 
            // gcRole
            // 
            this.gcRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcRole.Location = new System.Drawing.Point(6, 28);
            this.gcRole.MainView = this.gvRole;
            this.gcRole.Name = "gcRole";
            this.gcRole.Size = new System.Drawing.Size(217, 133);
            this.gcRole.TabIndex = 9;
            this.gcRole.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRole});
            // 
            // gvRole
            // 
            this.gvRole.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvRole.GridControl = this.gcRole;
            this.gvRole.Name = "gvRole";
            this.gvRole.OptionsBehavior.Editable = false;
            this.gvRole.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "OU_ID";
            this.gridColumn4.FieldName = "OU_ID";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "角色ID";
            this.gridColumn5.FieldName = "Role_ID";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "角色";
            this.gridColumn6.FieldName = "RoleDesc";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gcUser);
            this.groupControl2.Location = new System.Drawing.Point(310, 16);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(229, 178);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "包含用户";
            // 
            // gcUser
            // 
            this.gcUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUser.Location = new System.Drawing.Point(6, 28);
            this.gcUser.MainView = this.gvUser;
            this.gcUser.Name = "gcUser";
            this.gcUser.Size = new System.Drawing.Size(214, 145);
            this.gcUser.TabIndex = 8;
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
            this.gvUser.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "OUID";
            this.gridColumn1.FieldName = "OU_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "用户ID";
            this.gridColumn2.FieldName = "User_ID";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "用户";
            this.gridColumn3.FieldName = "UserDesc";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtHandNo);
            this.groupControl1.Controls.Add(this.tlPID);
            this.groupControl1.Controls.Add(this.sbtnSave);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtSortCode);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.txtCreatTime);
            this.groupControl1.Location = new System.Drawing.Point(8, 16);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(296, 351);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "机构详细信息";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(39, 212);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 14);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "创建时间";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(39, 143);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "机构编码";
            // 
            // txtHandNo
            // 
            this.txtHandNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHandNo.Location = new System.Drawing.Point(92, 139);
            this.txtHandNo.Name = "txtHandNo";
            this.txtHandNo.Size = new System.Drawing.Size(184, 20);
            this.txtHandNo.TabIndex = 13;
            // 
            // tlPID
            // 
            this.tlPID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlPID.EditValue = "无";
            this.tlPID.Location = new System.Drawing.Point(92, 104);
            this.tlPID.Name = "tlPID";
            this.tlPID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tlPID.Properties.DisplayMember = "DepartmentName";
            this.tlPID.Properties.NullText = "无";
            this.tlPID.Properties.TreeList = this.tlParent;
            this.tlPID.Properties.ValueMember = "Id";
            this.tlPID.Size = new System.Drawing.Size(184, 20);
            this.tlPID.TabIndex = 12;
            // 
            // tlParent
            // 
            this.tlParent.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn3,
            this.treeListColumn2});
            this.tlParent.KeyFieldName = "Id";
            this.tlParent.Location = new System.Drawing.Point(0, 0);
            this.tlParent.Name = "tlParent";
            this.tlParent.OptionsView.ShowIndentAsRowStyle = true;
            this.tlParent.ParentFieldName = "ParentId";
            this.tlParent.RootValue = "";
            this.tlParent.Size = new System.Drawing.Size(400, 200);
            this.tlParent.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "机构名称";
            this.treeListColumn1.FieldName = "DepartmentName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "机构编码";
            this.treeListColumn3.FieldName = "SimpleCode";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 1;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "排序码";
            this.treeListColumn2.FieldName = "SortCode";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 2;
            // 
            // sbtnSave
            // 
            this.sbtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnSave.Location = new System.Drawing.Point(178, 314);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new System.Drawing.Size(98, 27);
            this.sbtnSave.TabIndex = 11;
            this.sbtnSave.Text = "保存";
            this.sbtnSave.Click += new System.EventHandler(this.sbtnSave_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(34, 72);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 14);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "机构名(*)";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 108);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "上级机构(*)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 178);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "排序码";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "机构ID";
            // 
            // txtSortCode
            // 
            this.txtSortCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSortCode.Location = new System.Drawing.Point(92, 174);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(184, 20);
            this.txtSortCode.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(92, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(92, 34);
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(184, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtCreatTime
            // 
            this.txtCreatTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreatTime.Location = new System.Drawing.Point(92, 209);
            this.txtCreatTime.Name = "txtCreatTime";
            this.txtCreatTime.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtCreatTime.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtCreatTime.Properties.ReadOnly = true;
            this.txtCreatTime.Size = new System.Drawing.Size(184, 20);
            this.txtCreatTime.TabIndex = 18;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 376);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "DepartmentForm";
            this.Text = "组织机构管理";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHandNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSortCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreatTime.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcRole;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRole;
        private DevExpress.XtraGrid.GridControl gcUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sbtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSortCode;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TreeListLookUpEdit tlPID;
        private DevExpress.XtraTreeList.TreeList tlParent;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtHandNo;
        private DevExpress.XtraTreeList.TreeList tlDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtCreatTime;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_Name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
    }
}