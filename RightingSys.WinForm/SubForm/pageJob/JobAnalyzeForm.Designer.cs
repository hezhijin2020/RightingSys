namespace RightingSys.WinForm.SubForm.pageJob
{
    partial class JobAnalyzeForm
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
            this.pgcMain = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField10 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
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
            this.pivotGridField9 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pgcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pgcMain
            // 
            this.pgcMain.ActiveFilterString = "";
            this.pgcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgcMain.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField7,
            this.pivotGridField3,
            this.pivotGridField4,
            this.pivotGridField5,
            this.pivotGridField6,
            this.pivotGridField10,
            this.pivotGridField8,
            this.pivotGridField9});
            this.pgcMain.Location = new System.Drawing.Point(12, 59);
            this.pgcMain.Name = "pgcMain";
            this.pgcMain.Size = new System.Drawing.Size(526, 143);
            this.pgcMain.TabIndex = 2;
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.Caption = "店铺";
            this.pivotGridField1.FieldName = "BranchName";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.Width = 175;
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.Caption = "故障类型";
            this.pivotGridField2.FieldName = "CategoryName";
            this.pivotGridField2.Name = "pivotGridField2";
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.AreaIndex = 4;
            this.pivotGridField7.Caption = "日期";
            this.pivotGridField7.FieldName = "CreateTime";
            this.pivotGridField7.Name = "pivotGridField7";
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField3.AreaIndex = 0;
            this.pivotGridField3.Caption = "次数";
            this.pivotGridField3.FieldName = "QTY";
            this.pivotGridField3.Name = "pivotGridField3";
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField4.AreaIndex = 1;
            this.pivotGridField4.Caption = "时长(分钟)";
            this.pivotGridField4.FieldName = "TotalMins";
            this.pivotGridField4.Name = "pivotGridField4";
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.AreaIndex = 2;
            this.pivotGridField5.Caption = "处理人员";
            this.pivotGridField5.FieldName = "OpreatorName";
            this.pivotGridField5.Name = "pivotGridField5";
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.AreaIndex = 1;
            this.pivotGridField6.Caption = "登记人员";
            this.pivotGridField6.FieldName = "CreatorName";
            this.pivotGridField6.Name = "pivotGridField6";
            // 
            // pivotGridField10
            // 
            this.pivotGridField10.AreaIndex = 3;
            this.pivotGridField10.Caption = "职员";
            this.pivotGridField10.FieldName = "StaffName";
            this.pivotGridField10.Name = "pivotGridField10";
            // 
            // pivotGridField8
            // 
            this.pivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField8.AreaIndex = 1;
            this.pivotGridField8.Caption = "客户";
            this.pivotGridField8.FieldName = "ClientDesc";
            this.pivotGridField8.Name = "pivotGridField8";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.cbBranch);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dEnd);
            this.panelControl1.Controls.Add(this.dStart);
            this.panelControl1.Location = new System.Drawing.Point(12, 11);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(525, 40);
            this.panelControl1.TabIndex = 3;
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
            this.labelControl2.Location = new System.Drawing.Point(223, 13);
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
            this.dEnd.Location = new System.Drawing.Point(357, 10);
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
            this.dStart.Location = new System.Drawing.Point(251, 10);
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
            // pivotGridField9
            // 
            this.pivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField9.AreaIndex = 0;
            this.pivotGridField9.Caption = "部门";
            this.pivotGridField9.FieldName = "DepartmentName";
            this.pivotGridField9.Name = "pivotGridField9";
            // 
            // JobAnalyzeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 212);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pgcMain);
            this.Name = "JobAnalyzeForm";
            this.Text = "工作分析";
            ((System.ComponentModel.ISupportInitialize)(this.pgcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pgcMain;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField10;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Utility.CustomControls.CustomGridLookUpEdit cbBranch;
        private Utility.CustomControls.CustomGridView customGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dEnd;
        private DevExpress.XtraEditors.DateEdit dStart;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField9;
    }
}