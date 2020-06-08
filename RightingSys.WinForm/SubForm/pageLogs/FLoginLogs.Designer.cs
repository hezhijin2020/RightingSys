using RightingSys.WinForm.Utility.CustomControls;

namespace RightingSys.WinForm.SubForm.pageLogs
{
    partial class FLoginLogs
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lkupSystem = new RightingSys.WinForm.Utility.CustomControls.CustomGridLookUpEdit();
            this.customGridLookUpEdit1View = new RightingSys.WinForm.Utility.CustomControls.CustomGridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkupUser = new RightingSys.WinForm.Utility.CustomControls.CustomGridLookUpEdit();
            this.gvDataUser = new RightingSys.WinForm.Utility.CustomControls.CustomGridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dStartday = new DevExpress.XtraEditors.DateEdit();
            this.dEndday = new DevExpress.XtraEditors.DateEdit();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkupSystem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStartday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStartday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEndday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEndday.Properties)).BeginInit();
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
            this.gcData.Location = new System.Drawing.Point(12, 79);
            this.gcData.MainView = this.gvData;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(621, 155);
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
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
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
            this.gvData.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "名称";
            this.gridColumn2.FieldName = "LogName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 63;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "用户名";
            this.gridColumn3.FieldName = "LoginName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "姓名";
            this.gridColumn4.FieldName = "FullName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "部门";
            this.gridColumn5.FieldName = "DepartmentName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "登录IP";
            this.gridColumn6.FieldName = "LoginIP";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 89;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "登录Mac";
            this.gridColumn7.FieldName = "LoginMac";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            this.gridColumn7.Width = 142;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "系统";
            this.gridColumn8.FieldName = "SystemName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            this.gridColumn8.Width = 131;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "时间";
            this.gridColumn9.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn9.FieldName = "CreateTime";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            this.gridColumn9.Width = 148;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.lkupSystem);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lkupUser);
            this.groupControl1.Controls.Add(this.dStartday);
            this.groupControl1.Controls.Add(this.dEndday);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(621, 61);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "筛选条件";
            // 
            // lkupSystem
            // 
            this.lkupSystem.Location = new System.Drawing.Point(48, 31);
            this.lkupSystem.Name = "lkupSystem";
            this.lkupSystem.Properties.AllowMouseWheel = false;
            this.lkupSystem.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lkupSystem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupSystem.Properties.DisplayMember = "SystemName";
            this.lkupSystem.Properties.ImmediatePopup = true;
            this.lkupSystem.Properties.NullText = "";
            this.lkupSystem.Properties.PopupView = this.customGridLookUpEdit1View;
            this.lkupSystem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkupSystem.Properties.ValueMember = "Id";
            this.lkupSystem.Size = new System.Drawing.Size(155, 20);
            this.lkupSystem.TabIndex = 0;
            this.lkupSystem.Tag = false;
            //this.lkupSystem.EditValueChanged += new System.EventHandler(this.lkupSystem_EditValueChanged);
            // 
            // customGridLookUpEdit1View
            // 
            this.customGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn15,
            this.gridColumn16});
            this.customGridLookUpEdit1View.EmptyForegroundText = null;
            this.customGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.customGridLookUpEdit1View.LocatedColumn = null;
            this.customGridLookUpEdit1View.Name = "customGridLookUpEdit1View";
            this.customGridLookUpEdit1View.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic;
            this.customGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.customGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(209, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "用户";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(323, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "时间";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "系统";
            // 
            // lkupUser
            // 
            this.lkupUser.Location = new System.Drawing.Point(239, 31);
            this.lkupUser.Name = "lkupUser";
            this.lkupUser.Properties.AllowMouseWheel = false;
            this.lkupUser.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lkupUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupUser.Properties.DisplayMember = "LoginName";
            this.lkupUser.Properties.ImmediatePopup = true;
            this.lkupUser.Properties.NullText = "";
            this.lkupUser.Properties.PopupView = this.gvDataUser;
            this.lkupUser.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkupUser.Properties.ValueMember = "Id";
            this.lkupUser.Size = new System.Drawing.Size(78, 20);
            this.lkupUser.TabIndex = 1;
            this.lkupUser.Tag = false;
            // 
            // gvDataUser
            // 
            this.gvDataUser.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn17,
            this.gridColumn13,
            this.gridColumn14});
            this.gvDataUser.EmptyForegroundText = null;
            this.gvDataUser.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvDataUser.LocatedColumn = null;
            this.gvDataUser.Name = "gvDataUser";
            this.gvDataUser.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic;
            this.gvDataUser.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvDataUser.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "编号";
            this.gridColumn10.FieldName = "SimpleCode";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "姓名";
            this.gridColumn13.FieldName = "FullName";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "部门";
            this.gridColumn14.FieldName = "DepartmentName";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            // 
            // dStartday
            // 
            this.dStartday.EditValue = null;
            this.dStartday.Location = new System.Drawing.Point(353, 31);
            this.dStartday.Name = "dStartday";
            this.dStartday.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dStartday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dStartday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dStartday.Size = new System.Drawing.Size(100, 20);
            this.dStartday.TabIndex = 2;
            // 
            // dEndday
            // 
            this.dEndday.EditValue = null;
            this.dEndday.Location = new System.Drawing.Point(459, 31);
            this.dEndday.Name = "dEndday";
            this.dEndday.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dEndday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEndday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEndday.Size = new System.Drawing.Size(100, 20);
            this.dEndday.TabIndex = 3;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "名称";
            this.gridColumn11.FieldName = "SystemName";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "简称";
            this.gridColumn12.FieldName = "SimpleCode";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "描述";
            this.gridColumn15.FieldName = "SystemDescription";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 2;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "gridColumn16";
            this.gridColumn16.FieldName = "Id";
            this.gridColumn16.Name = "gridColumn16";
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "用户";
            this.gridColumn17.FieldName = "LoginName";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 1;
            // 
            // FLoginLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 246);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcData);
            this.Name = "FLoginLogs";
            this.Text = "登录日志";
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkupSystem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDataUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStartday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStartday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEndday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEndday.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGridControl gcData;
        private CustomGridView gvData;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private CustomGridLookUpEdit lkupUser;
        private CustomGridView gvDataUser;
        private DevExpress.XtraEditors.DateEdit dStartday;
        private DevExpress.XtraEditors.DateEdit dEndday;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private CustomGridLookUpEdit lkupSystem;
        private CustomGridView customGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
    }
}