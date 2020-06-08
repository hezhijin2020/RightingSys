namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    partial class FunctionForm
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
            this.tlFunc = new DevExpress.XtraTreeList.TreeList();
            this.col_Name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSortCode = new DevExpress.XtraEditors.TextEdit();
            this.sbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtFuncHandle = new DevExpress.XtraEditors.ButtonEdit();
            this.tlPID = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSortCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncHandle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tlFunc);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(688, 342);
            this.splitContainerControl1.SplitterPosition = 216;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tlFunc
            // 
            this.tlFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlFunc.Caption = "系统功能列表";
            this.tlFunc.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.col_Name});
            this.tlFunc.KeyFieldName = "Id";
            this.tlFunc.Location = new System.Drawing.Point(0, 14);
            this.tlFunc.Name = "tlFunc";
            this.tlFunc.OptionsBehavior.Editable = false;
            this.tlFunc.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.CellSelect;
            this.tlFunc.OptionsView.BestFitMode = DevExpress.XtraTreeList.TreeListBestFitMode.Full;
            this.tlFunc.OptionsView.BestFitNodes = DevExpress.XtraTreeList.TreeListBestFitNodes.All;
            this.tlFunc.OptionsView.EnableAppearanceEvenRow = true;
            this.tlFunc.OptionsView.EnableAppearanceOddRow = true;
            this.tlFunc.OptionsView.ShowCaption = true;
            this.tlFunc.OptionsView.ShowColumns = false;
            this.tlFunc.OptionsView.ShowIndicator = false;
            this.tlFunc.ParentFieldName = "ParentId";
            this.tlFunc.Size = new System.Drawing.Size(215, 324);
            this.tlFunc.TabIndex = 7;
            this.tlFunc.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlFunc_FocusedNodeChanged);
            // 
            // col_Name
            // 
            this.col_Name.Caption = "treeListColumn1";
            this.col_Name.FieldName = "FuncName";
            this.col_Name.Name = "col_Name";
            this.col_Name.Visible = true;
            this.col_Name.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Location = new System.Drawing.Point(5, 294);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(454, 44);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "包含的角色";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txtSortCode);
            this.groupControl1.Controls.Add(this.sbtnSave);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.txtFuncHandle);
            this.groupControl1.Controls.Add(this.tlPID);
            this.groupControl1.Location = new System.Drawing.Point(5, 14);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(454, 274);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "功能详细信息";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(43, 137);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "排序编号";
            // 
            // txtSortCode
            // 
            this.txtSortCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSortCode.Location = new System.Drawing.Point(99, 135);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(333, 20);
            this.txtSortCode.TabIndex = 11;
            // 
            // sbtnSave
            // 
            this.sbtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnSave.Location = new System.Drawing.Point(345, 205);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new System.Drawing.Size(87, 27);
            this.sbtnSave.TabIndex = 10;
            this.sbtnSave.Text = "保存";
            this.sbtnSave.Click += new System.EventHandler(this.sbtnSave_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(43, 174);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 14);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "功能明细";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 14);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "上级功能(*)";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "功能名称(*)";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "功能ID";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(99, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(333, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(99, 33);
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(333, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtFuncHandle
            // 
            this.txtFuncHandle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFuncHandle.Location = new System.Drawing.Point(99, 172);
            this.txtFuncHandle.Name = "txtFuncHandle";
            this.txtFuncHandle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtFuncHandle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtFuncHandle.Size = new System.Drawing.Size(333, 20);
            this.txtFuncHandle.TabIndex = 9;
            this.txtFuncHandle.Click += new System.EventHandler(this.txtFuncHandle_Click);
            // 
            // tlPID
            // 
            this.tlPID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlPID.Location = new System.Drawing.Point(99, 67);
            this.tlPID.Name = "tlPID";
            this.tlPID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tlPID.Properties.DisplayMember = "FuncName";
            this.tlPID.Properties.NullText = "无";
            this.tlPID.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            this.tlPID.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.tlPID.Properties.ValueMember = "Id";
            this.tlPID.Size = new System.Drawing.Size(333, 20);
            this.tlPID.TabIndex = 1;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeListLookUpEdit1TreeList.KeyFieldName = "Id";
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.ParentFieldName = "ParentId";
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "功能名称";
            this.treeListColumn1.FieldName = "FuncName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "排序码";
            this.treeListColumn2.FieldName = "SortCode";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            // 
            // FunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 342);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FunctionForm";
            this.Text = "功能管理";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSortCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncHandle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlPID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton sbtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.ButtonEdit txtFuncHandle;
        private DevExpress.XtraTreeList.TreeList tlFunc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn col_Name;
        private DevExpress.XtraEditors.TreeListLookUpEdit tlPID;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSortCode;
    }
}