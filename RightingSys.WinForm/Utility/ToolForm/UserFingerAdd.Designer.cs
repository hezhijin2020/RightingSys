namespace RightingSys.WinForm.Utility.ToolForm
{
    partial class UserFingerAdd
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.picFPImg = new DevExpress.XtraEditors.PictureEdit();
            this.cbmFingerRemark = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtLoginName = new DevExpress.XtraEditors.TextEdit();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.txtDeptName = new DevExpress.XtraEditors.TextEdit();
            this.textRes = new DevExpress.XtraEditors.MemoEdit();
            this.bnEnroll = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbmFingerRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeptName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用户名";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "姓名";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 72);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "部门";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 102);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 14);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "手指";
            // 
            // picFPImg
            // 
            this.picFPImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFPImg.Enabled = false;
            this.picFPImg.Location = new System.Drawing.Point(224, 9);
            this.picFPImg.Name = "picFPImg";
            this.picFPImg.Properties.AllowFocused = false;
            this.picFPImg.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picFPImg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picFPImg.Size = new System.Drawing.Size(124, 150);
            this.picFPImg.TabIndex = 4;
            // 
            // cbmFingerRemark
            // 
            this.cbmFingerRemark.EditValue = "左手拇指";
            this.cbmFingerRemark.Location = new System.Drawing.Point(54, 99);
            this.cbmFingerRemark.Name = "cbmFingerRemark";
            this.cbmFingerRemark.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbmFingerRemark.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbmFingerRemark.Properties.Items.AddRange(new object[] {
            "左手拇指",
            "左手食指",
            "左手中指",
            "左手无名指",
            "左手小指",
            "右手拇指",
            "右手食指",
            "右手中指",
            "右手无名指",
            "右手小指"});
            this.cbmFingerRemark.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbmFingerRemark.Size = new System.Drawing.Size(162, 20);
            this.cbmFingerRemark.TabIndex = 5;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Enabled = false;
            this.txtLoginName.Location = new System.Drawing.Point(54, 9);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Properties.AllowFocused = false;
            this.txtLoginName.Size = new System.Drawing.Size(162, 20);
            this.txtLoginName.TabIndex = 6;
            // 
            // txtFullName
            // 
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(54, 39);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.AllowFocused = false;
            this.txtFullName.Size = new System.Drawing.Size(162, 20);
            this.txtFullName.TabIndex = 7;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Enabled = false;
            this.txtDeptName.Location = new System.Drawing.Point(54, 69);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Properties.AllowFocused = false;
            this.txtDeptName.Size = new System.Drawing.Size(162, 20);
            this.txtDeptName.TabIndex = 8;
            // 
            // textRes
            // 
            this.textRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRes.Location = new System.Drawing.Point(13, 166);
            this.textRes.Name = "textRes";
            this.textRes.Properties.AllowFocused = false;
            this.textRes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRes.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.textRes.Properties.Appearance.Options.UseFont = true;
            this.textRes.Properties.Appearance.Options.UseForeColor = true;
            this.textRes.Properties.ReadOnly = true;
            this.textRes.Size = new System.Drawing.Size(337, 122);
            this.textRes.TabIndex = 9;
            // 
            // bnEnroll
            // 
            this.bnEnroll.Location = new System.Drawing.Point(54, 136);
            this.bnEnroll.Name = "bnEnroll";
            this.bnEnroll.Size = new System.Drawing.Size(75, 23);
            this.bnEnroll.TabIndex = 10;
            this.bnEnroll.Text = "开始登记";
            this.bnEnroll.Click += new System.EventHandler(this.bnEnroll_Click);
            // 
            // UserFingerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 296);
            this.Controls.Add(this.bnEnroll);
            this.Controls.Add(this.textRes);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.cbmFingerRemark);
            this.Controls.Add(this.picFPImg);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserFingerAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "员工指纹信息登记";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserFingerAdd_FormClosing);
            this.Load += new System.EventHandler(this.UserFingerAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbmFingerRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeptName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRes.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit picFPImg;
        private DevExpress.XtraEditors.ComboBoxEdit cbmFingerRemark;
        private DevExpress.XtraEditors.TextEdit txtLoginName;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.TextEdit txtDeptName;
        private DevExpress.XtraEditors.MemoEdit textRes;
        private DevExpress.XtraEditors.SimpleButton bnEnroll;
    }
}