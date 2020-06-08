namespace RightingSys.WinForm.SubForm.pageSystem
{
    partial class FModifyUserPwd
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
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.sbtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewPwd1 = new DevExpress.XtraEditors.TextEdit();
            this.txtNewPwd2 = new DevExpress.XtraEditors.TextEdit();
            this.txtOldPwd = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPwd1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPwd2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPwd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.separatorControl1);
            this.panelControl1.Controls.Add(this.sbtnSave);
            this.panelControl1.Controls.Add(this.sbtnCancel);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtNewPwd1);
            this.panelControl1.Controls.Add(this.txtNewPwd2);
            this.panelControl1.Controls.Add(this.txtOldPwd);
            this.panelControl1.Location = new System.Drawing.Point(14, 14);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(302, 157);
            this.panelControl1.TabIndex = 0;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(2, 104);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Size = new System.Drawing.Size(297, 16);
            this.separatorControl1.TabIndex = 11;
            // 
            // sbtnSave
            // 
            this.sbtnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sbtnSave.Location = new System.Drawing.Point(71, 124);
            this.sbtnSave.Name = "sbtnSave";
            this.sbtnSave.Size = new System.Drawing.Size(70, 27);
            this.sbtnSave.TabIndex = 10;
            this.sbtnSave.Text = "保存";
            this.sbtnSave.Click += new System.EventHandler(this.sbtnSave_Click);
            // 
            // sbtnCancel
            // 
            this.sbtnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.sbtnCancel.Location = new System.Drawing.Point(160, 124);
            this.sbtnCancel.Name = "sbtnCancel";
            this.sbtnCancel.Size = new System.Drawing.Size(70, 27);
            this.sbtnCancel.TabIndex = 9;
            this.sbtnCancel.Text = " 取消";
            this.sbtnCancel.Click += new System.EventHandler(this.sbtnCancel_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 77);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "确认密码";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "新密码";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "原密码";
            // 
            // txtNewPwd1
            // 
            this.txtNewPwd1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPwd1.Location = new System.Drawing.Point(76, 75);
            this.txtNewPwd1.Name = "txtNewPwd1";
            this.txtNewPwd1.Properties.PasswordChar = '*';
            this.txtNewPwd1.Size = new System.Drawing.Size(208, 20);
            this.txtNewPwd1.TabIndex = 5;
            // 
            // txtNewPwd2
            // 
            this.txtNewPwd2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPwd2.Location = new System.Drawing.Point(76, 44);
            this.txtNewPwd2.Name = "txtNewPwd2";
            this.txtNewPwd2.Properties.PasswordChar = '*';
            this.txtNewPwd2.Size = new System.Drawing.Size(208, 20);
            this.txtNewPwd2.TabIndex = 4;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldPwd.Location = new System.Drawing.Point(76, 14);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.Properties.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(208, 20);
            this.txtOldPwd.TabIndex = 3;
            // 
            // FModifyUserPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 185);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FModifyUserPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " 修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPwd1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPwd2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPwd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton sbtnSave;
        private DevExpress.XtraEditors.SimpleButton sbtnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNewPwd1;
        private DevExpress.XtraEditors.TextEdit txtNewPwd2;
        private DevExpress.XtraEditors.TextEdit txtOldPwd;
    }
}