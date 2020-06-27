namespace RightingSys.WinForm.SubForm.pageJob
{
    partial class JobQueryForm
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
            this.gcData = new RightingSys.WinForm.Utility.CustomControls.CustomGridControl();
            this.gvData = new RightingSys.WinForm.Utility.CustomControls.CustomGridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.tlJobCategory = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.cbBranch = new RightingSys.WinForm.Utility.CustomControls.CustomGridLookUpEdit();
            this.customGridLookUpEdit1View = new RightingSys.WinForm.Utility.CustomControls.CustomGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dEnd = new DevExpress.XtraEditors.DateEdit();
            this.dStart = new DevExpress.XtraEditors.DateEdit();
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
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlJobCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcData
            // 
            this.gcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gcData.EmbeddedNavigator.TextStringFormat = "记录 {0} / {1}";
            this.gcData.Location = new System.Drawing.Point(12, 58);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(742, 163);
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
            this.gridColumn17,
            this.gridColumn18});
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
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.tlJobCategory);
            this.panelControl1.Controls.Add(this.cbBranch);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dEnd);
            this.panelControl1.Controls.Add(this.dStart);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(742, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(223, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 14);
            this.label7.TabIndex = 82;
            this.label7.Text = "类别";
            // 
            // tlJobCategory
            // 
            this.tlJobCategory.Location = new System.Drawing.Point(253, 10);
            this.tlJobCategory.Name = "tlJobCategory";
            this.tlJobCategory.Properties.AllowMouseWheel = false;
            this.tlJobCategory.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.tlJobCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tlJobCategory.Properties.DisplayMember = "JobCategoryName";
            this.tlJobCategory.Properties.ImmediatePopup = true;
            this.tlJobCategory.Properties.NullText = "";
            this.tlJobCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.tlJobCategory.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.tlJobCategory.Properties.ValueMember = "Id";
            this.tlJobCategory.Size = new System.Drawing.Size(169, 20);
            this.tlJobCategory.TabIndex = 83;
            this.tlJobCategory.Tag = false;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(171, -167);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "类别";
            this.treeListColumn1.FieldName = "JobCategoryName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // cbBranch
            // 
            this.cbBranch.Location = new System.Drawing.Point(55, 10);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Properties.AllowMouseWheel = false;
            this.cbBranch.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBranch.Properties.DisplayMember = "BranchDesc";
            this.cbBranch.Properties.ImmediatePopup = true;
            this.cbBranch.Properties.NullText = "";
            this.cbBranch.Properties.PopupView = this.customGridLookUpEdit1View;
            this.cbBranch.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            this.cbBranch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbBranch.Properties.ValueMember = "BranchId";
            this.cbBranch.Size = new System.Drawing.Size(154, 20);
            this.cbBranch.TabIndex = 81;
            this.cbBranch.Tag = false;
            // 
            // customGridLookUpEdit1View
            // 
            this.customGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.customGridLookUpEdit1View.EmptyForegroundText = null;
            this.customGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.customGridLookUpEdit1View.LocatedColumn = null;
            this.customGridLookUpEdit1View.Name = "customGridLookUpEdit1View";
            this.customGridLookUpEdit1View.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic;
            this.customGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.customGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "店铺名称";
            this.gridColumn1.FieldName = "BranchDesc";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "客户编号";
            this.gridColumn2.FieldName = "ClientId";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "客户名称";
            this.gridColumn3.FieldName = "ClientDesc";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "更新时间";
            this.gridColumn4.FieldName = "Wno";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "店铺编号";
            this.gridColumn5.FieldName = "BranchId";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(431, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "日期";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "店铺";
            // 
            // dEnd
            // 
            this.dEnd.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dEnd.Location = new System.Drawing.Point(565, 10);
            this.dEnd.Name = "dEnd";
            this.dEnd.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEnd.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dEnd.Size = new System.Drawing.Size(100, 20);
            this.dEnd.TabIndex = 2;
            // 
            // dStart
            // 
            this.dStart.EditValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dStart.Location = new System.Drawing.Point(459, 10);
            this.dStart.Name = "dStart";
            this.dStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dStart.Properties.MinValue = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dStart.Size = new System.Drawing.Size(100, 20);
            this.dStart.TabIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "店铺编号";
            this.gridColumn6.FieldName = "BranchId";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "BranchId", "{0}")});
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "店铺名称";
            this.gridColumn7.FieldName = "BranchName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "职员";
            this.gridColumn8.FieldName = "StaffName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "联系方式";
            this.gridColumn9.FieldName = "Contact";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "描述信息";
            this.gridColumn10.FieldName = "Description";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "登记人员";
            this.gridColumn11.FieldName = "CreatorName";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "登记时间";
            this.gridColumn12.FieldName = "CreateTime";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 6;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "类别";
            this.gridColumn13.FieldName = "CategoryName";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 7;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "解决方案";
            this.gridColumn14.FieldName = "Solution";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 8;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "处理人员";
            this.gridColumn15.FieldName = "OperatorName";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 9;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "完成时间";
            this.gridColumn16.FieldName = "FinishTime";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 10;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "总用时";
            this.gridColumn17.FieldName = "TotalMins";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 11;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "状态";
            this.gridColumn18.FieldName = "IsFinish";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 12;
            // 
            // JobQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 233);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.gcData);
            this.Name = "JobQueryForm";
            this.Text = "工作记录查询";
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlJobCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Utility.CustomControls.CustomGridControl gcData;
        private Utility.CustomControls.CustomGridView gvData;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dEnd;
        private DevExpress.XtraEditors.DateEdit dStart;
        private Utility.CustomControls.CustomGridLookUpEdit cbBranch;
        private Utility.CustomControls.CustomGridView customGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.TreeListLookUpEdit tlJobCategory;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
    }
}