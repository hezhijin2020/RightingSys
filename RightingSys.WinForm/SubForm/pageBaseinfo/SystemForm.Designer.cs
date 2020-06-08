
namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    partial class SystemForm
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
            this.MenuSystem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuSystemVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.mygcData = new RightingSys.WinForm.Utility.CustomControls.CustomGridControl();
            this.mygvData = new RightingSys.WinForm.Utility.CustomControls.CustomGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MenuSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mygcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mygvData)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuSystem
            // 
            this.MenuSystem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuSystemVersion});
            this.MenuSystem.Name = "MenuSystem";
            this.MenuSystem.Size = new System.Drawing.Size(125, 26);
            // 
            // toolMenuSystemVersion
            // 
            this.toolMenuSystemVersion.Name = "toolMenuSystemVersion";
            this.toolMenuSystemVersion.Size = new System.Drawing.Size(124, 22);
            this.toolMenuSystemVersion.Text = "版本控制";
            this.toolMenuSystemVersion.Click += new System.EventHandler(this.toolMenuSystemVersion_Click);
            // 
            // mygcData
            // 
            this.mygcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mygcData.ContextMenuStrip = this.MenuSystem;
            this.mygcData.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.mygcData.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.mygcData.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.mygcData.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.mygcData.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.mygcData.EmbeddedNavigator.TextStringFormat = "记录 {0} / {1}";
            this.mygcData.Location = new System.Drawing.Point(12, 12);
            this.mygcData.MainView = this.mygvData;
            this.mygcData.Name = "mygcData";
            this.mygcData.Size = new System.Drawing.Size(794, 138);
            this.mygcData.TabIndex = 1;
            this.mygcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.mygvData});
            // 
            // mygvData
            // 
            this.mygvData.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.mygvData.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mygvData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            this.mygvData.EmptyForegroundText = null;
            this.mygvData.GridControl = this.mygcData;
            this.mygvData.IndicatorWidth = 28;
            this.mygvData.LocatedColumn = null;
            this.mygvData.Name = "mygvData";
            this.mygvData.OptionsBehavior.Editable = false;
            this.mygvData.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            this.mygvData.OptionsDetail.EnableMasterViewMode = false;
            this.mygvData.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic;
            this.mygvData.OptionsNavigation.EnterMoveNextColumn = true;
            this.mygvData.OptionsPrint.AutoWidth = false;
            this.mygvData.OptionsSelection.CheckBoxSelectorColumnWidth = 40;
            this.mygvData.OptionsSelection.MultiSelect = true;
            this.mygvData.OptionsView.ColumnAutoWidth = false;
            this.mygvData.OptionsView.EnableAppearanceEvenRow = true;
            this.mygvData.OptionsView.EnableAppearanceOddRow = true;
            this.mygvData.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.mygvData.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Id";
            this.gridColumn1.FieldName = "Id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "系统名称";
            this.gridColumn8.FieldName = "SystemName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 122;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "简码";
            this.gridColumn9.FieldName = "SimpleCode";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "版本";
            this.gridColumn10.FieldName = "Version";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "更新时间";
            this.gridColumn11.FieldName = "UpdateTime";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "FTP地址";
            this.gridColumn12.FieldName = "URL";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 5;
            this.gridColumn12.Width = 233;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "描述";
            this.gridColumn13.FieldName = "SystemDescription";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 6;
            this.gridColumn13.Width = 175;
            // 
            // SystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 162);
            this.Controls.Add(this.mygcData);
            this.Name = "SystemForm";
            this.Text = "系统定义";
            this.MenuSystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mygcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mygvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip MenuSystem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuSystemVersion;
        private RightingSys.WinForm.Utility.CustomControls.CustomGridControl mygcData;
        private RightingSys.WinForm.Utility.CustomControls.CustomGridView mygvData;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}