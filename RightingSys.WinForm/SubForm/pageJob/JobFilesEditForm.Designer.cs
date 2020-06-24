namespace RightingSys.WinForm.SubForm.pageJob
{
    partial class JobFilesEditForm
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
            this.panelEdit = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lkpAuditor = new RightingSys.WinForm.Utility.CustomControls.CustomGridLookUpEdit();
            this.customGridLookUpEdit2View = new RightingSys.WinForm.Utility.CustomControls.CustomGridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkpStaff = new RightingSys.WinForm.Utility.CustomControls.CustomGridLookUpEdit();
            this.customGridLookUpEdit1View = new RightingSys.WinForm.Utility.CustomControls.CustomGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dAuditorday = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFileName = new DevExpress.XtraEditors.TextEdit();
            this.tlCategory = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.txtDescription = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnFileSelect = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pdfView = new DevExpress.XtraPdfViewer.PdfViewer();
            ((System.ComponentModel.ISupportInitialize)(this.panelEdit)).BeginInit();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpAuditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpStaff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAuditorday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAuditorday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileSelect.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEdit
            // 
            this.panelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelEdit.Controls.Add(this.btnCancel);
            this.panelEdit.Controls.Add(this.btnSave);
            this.panelEdit.Controls.Add(this.labelControl7);
            this.panelEdit.Controls.Add(this.lkpAuditor);
            this.panelEdit.Controls.Add(this.lkpStaff);
            this.panelEdit.Controls.Add(this.dAuditorday);
            this.panelEdit.Controls.Add(this.labelControl6);
            this.panelEdit.Controls.Add(this.labelControl4);
            this.panelEdit.Controls.Add(this.labelControl3);
            this.panelEdit.Controls.Add(this.labelControl2);
            this.panelEdit.Controls.Add(this.labelControl1);
            this.panelEdit.Controls.Add(this.txtFileName);
            this.panelEdit.Controls.Add(this.tlCategory);
            this.panelEdit.Controls.Add(this.txtDescription);
            this.panelEdit.Location = new System.Drawing.Point(12, 12);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(277, 351);
            this.panelEdit.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "取消";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(78, 319);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "确认";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(33, 182);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 14);
            this.labelControl7.TabIndex = 32;
            this.labelControl7.Text = "描述";
            // 
            // lkpAuditor
            // 
            this.lkpAuditor.Location = new System.Drawing.Point(63, 112);
            this.lkpAuditor.Name = "lkpAuditor";
            this.lkpAuditor.Properties.AllowMouseWheel = false;
            this.lkpAuditor.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lkpAuditor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpAuditor.Properties.DisplayMember = "FullName";
            this.lkpAuditor.Properties.ImmediatePopup = true;
            this.lkpAuditor.Properties.KeyMember = "Id";
            this.lkpAuditor.Properties.NullText = "";
            this.lkpAuditor.Properties.PopupView = this.customGridLookUpEdit2View;
            this.lkpAuditor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkpAuditor.Properties.ValueMember = "Id";
            this.lkpAuditor.Size = new System.Drawing.Size(193, 20);
            this.lkpAuditor.TabIndex = 31;
            this.lkpAuditor.Tag = false;
            // 
            // customGridLookUpEdit2View
            // 
            this.customGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.customGridLookUpEdit2View.EmptyForegroundText = null;
            this.customGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.customGridLookUpEdit2View.LocatedColumn = null;
            this.customGridLookUpEdit2View.Name = "customGridLookUpEdit2View";
            this.customGridLookUpEdit2View.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic;
            this.customGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.customGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "部门";
            this.gridColumn5.FieldName = "DepartmentName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "用户";
            this.gridColumn6.FieldName = "LoginName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "姓名";
            this.gridColumn7.FieldName = "FullName";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "简码";
            this.gridColumn8.FieldName = "SimpleCode";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // lkpStaff
            // 
            this.lkpStaff.Location = new System.Drawing.Point(63, 78);
            this.lkpStaff.Name = "lkpStaff";
            this.lkpStaff.Properties.AllowMouseWheel = false;
            this.lkpStaff.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lkpStaff.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkpStaff.Properties.DisplayMember = "FullName";
            this.lkpStaff.Properties.ImmediatePopup = true;
            this.lkpStaff.Properties.KeyMember = "Id";
            this.lkpStaff.Properties.NullText = "";
            this.lkpStaff.Properties.PopupView = this.customGridLookUpEdit1View;
            this.lkpStaff.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkpStaff.Properties.ValueMember = "Id";
            this.lkpStaff.Size = new System.Drawing.Size(193, 20);
            this.lkpStaff.TabIndex = 30;
            this.lkpStaff.Tag = false;
            // 
            // customGridLookUpEdit1View
            // 
            this.customGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
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
            this.gridColumn1.Caption = "部门";
            this.gridColumn1.FieldName = "DepartmentName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "用户";
            this.gridColumn2.FieldName = "LoginName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "姓名";
            this.gridColumn3.FieldName = "FullName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "编号";
            this.gridColumn4.FieldName = "SimpleCode";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // dAuditorday
            // 
            this.dAuditorday.EditValue = null;
            this.dAuditorday.Location = new System.Drawing.Point(63, 146);
            this.dAuditorday.Name = "dAuditorday";
            this.dAuditorday.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dAuditorday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dAuditorday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dAuditorday.Size = new System.Drawing.Size(193, 20);
            this.dAuditorday.TabIndex = 25;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(33, 148);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(24, 14);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "日期";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 114);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 14);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "签字人员";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 80);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "职员";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "类别";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "名称";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(63, 10);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(193, 20);
            this.txtFileName.TabIndex = 29;
            // 
            // tlCategory
            // 
            this.tlCategory.Location = new System.Drawing.Point(63, 44);
            this.tlCategory.Name = "tlCategory";
            this.tlCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tlCategory.Properties.DisplayMember = "JobFileCategoryName";
            this.tlCategory.Properties.NullText = "";
            this.tlCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.tlCategory.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.tlCategory.Properties.ValueMember = "Id";
            this.tlCategory.Size = new System.Drawing.Size(193, 20);
            this.tlCategory.TabIndex = 28;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2});
            this.treeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "名称";
            this.treeListColumn2.FieldName = "JobFileCategoryName";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(63, 180);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.DisplayFormat.FormatString = "d";
            this.txtDescription.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDescription.Properties.EditFormat.FormatString = "d";
            this.txtDescription.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDescription.Size = new System.Drawing.Size(193, 123);
            this.txtDescription.TabIndex = 33;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.btnFileSelect);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.pdfView);
            this.panelControl2.Location = new System.Drawing.Point(295, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(320, 351);
            this.panelControl2.TabIndex = 1;
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileSelect.Location = new System.Drawing.Point(39, 5);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnFileSelect.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.btnFileSelect.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnFileSelect_Properties_ButtonClick);
            this.btnFileSelect.Size = new System.Drawing.Size(276, 20);
            this.btnFileSelect.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "文档";
            // 
            // pdfView
            // 
            this.pdfView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfView.Location = new System.Drawing.Point(5, 47);
            this.pdfView.Name = "pdfView";
            this.pdfView.Size = new System.Drawing.Size(310, 299);
            this.pdfView.TabIndex = 0;
            this.pdfView.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToVisible;
            // 
            // JobFilesEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 375);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelEdit);
            this.Name = "JobFilesEditForm";
            this.Text = "档案信息";
            ((System.ComponentModel.ISupportInitialize)(this.panelEdit)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkpAuditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkpStaff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAuditorday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dAuditorday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFileSelect.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelEdit;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.ButtonEdit btnFileSelect;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraPdfViewer.PdfViewer pdfView;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private Utility.CustomControls.CustomGridLookUpEdit lkpAuditor;
        private Utility.CustomControls.CustomGridView customGridLookUpEdit2View;
        private Utility.CustomControls.CustomGridLookUpEdit lkpStaff;
        private Utility.CustomControls.CustomGridView customGridLookUpEdit1View;
        private DevExpress.XtraEditors.DateEdit dAuditorday;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFileName;
        private DevExpress.XtraEditors.TreeListLookUpEdit tlCategory;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.MemoEdit txtDescription;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}