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
            this.tlDepartment = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcData = new RightingSys.WinForm.Utility.CustomControls.CustomGridControl();
            this.gvData = new RightingSys.WinForm.Utility.CustomControls.CustomGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbtnFinish = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(10, 8);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tlDepartment);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcData);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(600, 135);
            this.splitContainerControl1.SplitterPosition = 227;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
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
            this.tlDepartment.Size = new System.Drawing.Size(227, 135);
            this.tlDepartment.TabIndex = 1;
            this.tlDepartment.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlDepartment_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "部门名称";
            this.treeListColumn1.FieldName = "DepartmentName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
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
            this.gcData.Size = new System.Drawing.Size(368, 135);
            this.gcData.TabIndex = 0;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData});
            // 
            // gvData
            // 
            this.gvData.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
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
            this.gvData.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvData.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gvData.OptionsSelection.UseIndicatorForSelection = false;
            this.gvData.OptionsView.ColumnAutoWidth = false;
            this.gvData.OptionsView.EnableAppearanceEvenRow = true;
            this.gvData.OptionsView.EnableAppearanceOddRow = true;
            this.gvData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvData.OptionsView.ShowFooter = true;
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "部门";
            this.gridColumn1.FieldName = "DepartmentName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "用户";
            this.gridColumn2.FieldName = "LoginName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "LoginName", "{0}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "姓名";
            this.gridColumn3.FieldName = "FullName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "编号";
            this.gridColumn4.FieldName = "SimpleCode";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Id";
            this.gridColumn5.FieldName = "Id";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // sbtnFinish
            // 
            this.sbtnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnFinish.Location = new System.Drawing.Point(483, 149);
            this.sbtnFinish.Name = "sbtnFinish";
            this.sbtnFinish.Size = new System.Drawing.Size(64, 23);
            this.sbtnFinish.TabIndex = 3;
            this.sbtnFinish.Text = "完成选择";
            this.sbtnFinish.Click += new System.EventHandler(this.sbtnFinish_Click);
            // 
            // sbtnClose
            // 
            this.sbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnClose.Location = new System.Drawing.Point(553, 149);
            this.sbtnClose.Name = "sbtnClose";
            this.sbtnClose.Size = new System.Drawing.Size(54, 23);
            this.sbtnClose.TabIndex = 5;
            this.sbtnClose.Text = "关闭";
            this.sbtnClose.Click += new System.EventHandler(this.sbtnClose_Click);
            // 
            // F_UserForBlackIP_Selectlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 182);
            this.Controls.Add(this.sbtnClose);
            this.Controls.Add(this.sbtnFinish);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "F_UserForBlackIP_Selectlist";
            this.Text = "人员选择";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton sbtnFinish;
        private DevExpress.XtraEditors.SimpleButton sbtnClose;
        private DevExpress.XtraTreeList.TreeList tlDepartment;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private CustomControls.CustomGridControl gcData;
        private CustomControls.CustomGridView gvData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}