namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    partial class FBlackIP_User
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.txtEndIP = new DevExpress.XtraEditors.TextEdit();
            this.txtStartIP = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboxType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.sbtnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gcUser = new DevExpress.XtraGrid.GridControl();
            this.gvUser = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.IsEnabled = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartIP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsEnabled.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.txtRemark);
            this.panelControl1.Controls.Add(this.txtEndIP);
            this.panelControl1.Controls.Add(this.txtStartIP);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cboxType);
            this.panelControl1.Location = new System.Drawing.Point(14, 14);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(488, 215);
            this.panelControl1.TabIndex = 0;
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemark.Location = new System.Drawing.Point(63, 164);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(405, 31);
            this.txtRemark.TabIndex = 10;
            // 
            // txtEndIP
            // 
            this.txtEndIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndIP.Location = new System.Drawing.Point(63, 127);
            this.txtEndIP.Name = "txtEndIP";
            this.txtEndIP.Properties.Mask.EditMask = "((25[0-5]|2[0-4]\\d|((1\\d{2})|([1-9]?\\d)))\\.){3}(25[0-5]|2[0-4]\\d|((1\\d{2})|([1-9]" +
    "?\\d)))";
            this.txtEndIP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEndIP.Size = new System.Drawing.Size(405, 20);
            this.txtEndIP.TabIndex = 8;
            // 
            // txtStartIP
            // 
            this.txtStartIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStartIP.Location = new System.Drawing.Point(63, 90);
            this.txtStartIP.Name = "txtStartIP";
            this.txtStartIP.Properties.Mask.EditMask = "((25[0-5]|2[0-4]\\d|((1\\d{2})|([1-9]?\\d)))\\.){3}(25[0-5]|2[0-4]\\d|((1\\d{2})|([1-9]" +
    "?\\d)))";
            this.txtStartIP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtStartIP.Size = new System.Drawing.Size(405, 20);
            this.txtStartIP.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(63, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(405, 20);
            this.txtName.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(28, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "备注";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "结束IP";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "开始IP";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "类型";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "名称";
            // 
            // cboxType
            // 
            this.cboxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxType.EditValue = "黑名单";
            this.cboxType.Location = new System.Drawing.Point(63, 52);
            this.cboxType.Name = "cboxType";
            this.cboxType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboxType.Properties.DropDownRows = 3;
            this.cboxType.Properties.Items.AddRange(new object[] {
            "黑名单",
            "白名单"});
            this.cboxType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboxType.Size = new System.Drawing.Size(405, 20);
            this.cboxType.TabIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.sbtnRemove);
            this.panelControl2.Controls.Add(this.sbtnAdd);
            this.panelControl2.Controls.Add(this.gcUser);
            this.panelControl2.Location = new System.Drawing.Point(508, 14);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(224, 215);
            this.panelControl2.TabIndex = 1;
            // 
            // sbtnRemove
            // 
            this.sbtnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbtnRemove.Location = new System.Drawing.Point(80, 172);
            this.sbtnRemove.Name = "sbtnRemove";
            this.sbtnRemove.Size = new System.Drawing.Size(63, 27);
            this.sbtnRemove.TabIndex = 5;
            this.sbtnRemove.Text = "移除";
            this.sbtnRemove.Click += new System.EventHandler(this.sbtnRemove_Click);
            // 
            // sbtnAdd
            // 
            this.sbtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbtnAdd.Location = new System.Drawing.Point(11, 172);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new System.Drawing.Size(63, 27);
            this.sbtnAdd.TabIndex = 4;
            this.sbtnAdd.Text = "添加";
            this.sbtnAdd.Click += new System.EventHandler(this.sbtnAdd_Click);
            // 
            // gcUser
            // 
            this.gcUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcUser.Location = new System.Drawing.Point(6, 6);
            this.gcUser.MainView = this.gvUser;
            this.gcUser.Name = "gcUser";
            this.gcUser.Size = new System.Drawing.Size(212, 154);
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
            this.gvUser.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "User_ID";
            this.gridColumn1.FieldName = "User_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "BlackIP_ID";
            this.gridColumn2.FieldName = "BlackIP_ID";
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
            // sbtnSave
            // 
            this.sbtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnSave.Location = new System.Drawing.Point(550, 267);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new System.Drawing.Size(82, 27);
            this.sbtnSave.TabIndex = 2;
            this.sbtnSave.Text = "保存";
            this.sbtnSave.Click += new System.EventHandler(this.sbtnSave_Click);
            // 
            // sbtnClose
            // 
            this.sbtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnClose.Location = new System.Drawing.Point(645, 267);
            this.sbtnClose.Name = "sbtnClose";
            this.sbtnClose.Size = new System.Drawing.Size(82, 27);
            this.sbtnClose.TabIndex = 3;
            this.sbtnClose.Text = "关闭";
            this.sbtnClose.Click += new System.EventHandler(this.sbtnClose_Click);
            // 
            // IsEnabled
            // 
            this.IsEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IsEnabled.Location = new System.Drawing.Point(14, 235);
            this.IsEnabled.Name = "IsEnabled";
            this.IsEnabled.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsEnabled.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.IsEnabled.Properties.Appearance.Options.UseFont = true;
            this.IsEnabled.Properties.Appearance.Options.UseForeColor = true;
            this.IsEnabled.Properties.Caption = "是否启用";
            this.IsEnabled.Size = new System.Drawing.Size(87, 23);
            this.IsEnabled.TabIndex = 5;
            // 
            // FBlackIP_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 308);
            this.Controls.Add(this.IsEnabled);
            this.Controls.Add(this.sbtnClose);
            this.Controls.Add(this.sbtnSave);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FBlackIP_User";
            this.Text = "黑白名单列表";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartIP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboxType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsEnabled.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraEditors.TextEdit txtEndIP;
        private DevExpress.XtraEditors.TextEdit txtStartIP;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcUser;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUser;
        private DevExpress.XtraEditors.SimpleButton sbtnSave;
        private DevExpress.XtraEditors.SimpleButton sbtnClose;
        private DevExpress.XtraEditors.CheckEdit IsEnabled;
        private DevExpress.XtraEditors.ComboBoxEdit cboxType;
        private DevExpress.XtraEditors.SimpleButton sbtnRemove;
        private DevExpress.XtraEditors.SimpleButton sbtnAdd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}