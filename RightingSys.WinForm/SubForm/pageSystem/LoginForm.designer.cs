namespace RightingSys.WinForm.SubForm.pageSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CheckRemPwd = new DevExpress.XtraEditors.CheckEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoginPwd = new DevExpress.XtraEditors.TextEdit();
            this.txtLoginName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckRemPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.Location = new System.Drawing.Point(65, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(68, 27);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(214, 139);
            this.btnCancel.LookAndFeel.SkinName = "Springtime";
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(68, 27);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // CheckRemPwd
            // 
            this.CheckRemPwd.Location = new System.Drawing.Point(184, 106);
            this.CheckRemPwd.Name = "CheckRemPwd";
            this.CheckRemPwd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckRemPwd.Properties.Appearance.Options.UseFont = true;
            this.CheckRemPwd.Properties.Caption = "记住密码";
            this.CheckRemPwd.Size = new System.Drawing.Size(87, 19);
            this.CheckRemPwd.TabIndex = 11;
            // 
            // textEdit3
            // 
            this.textEdit3.EditValue = "湖南办事处";
            this.textEdit3.Location = new System.Drawing.Point(186, 20);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.AllowFocused = false;
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(144, 20);
            this.textEdit3.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(137, 22);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "机   构";
            // 
            // txtLoginPwd
            // 
            this.txtLoginPwd.EditValue = "ys147258";
            this.txtLoginPwd.Location = new System.Drawing.Point(186, 82);
            this.txtLoginPwd.Name = "txtLoginPwd";
            this.txtLoginPwd.Properties.PasswordChar = '*';
            this.txtLoginPwd.Size = new System.Drawing.Size(144, 20);
            this.txtLoginPwd.TabIndex = 9;
            // 
            // txtLoginName
            // 
            this.txtLoginName.EditValue = "george";
            this.txtLoginName.Location = new System.Drawing.Point(186, 51);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(144, 20);
            this.txtLoginName.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(137, 84);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "密   码";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(137, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "用   户";
            // 
            // separatorControl3
            // 
            this.separatorControl3.AutoSizeMode = true;
            this.separatorControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorControl3.Location = new System.Drawing.Point(0, 0);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Padding = new System.Windows.Forms.Padding(3);
            this.separatorControl3.Size = new System.Drawing.Size(342, 8);
            this.separatorControl3.TabIndex = 15;
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorControl1.Location = new System.Drawing.Point(0, 169);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(3);
            this.separatorControl1.Size = new System.Drawing.Size(342, 8);
            this.separatorControl1.TabIndex = 16;
            // 
            // separatorControl2
            // 
            this.separatorControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.separatorControl2.AutoSizeMode = true;
            this.separatorControl2.Location = new System.Drawing.Point(0, 128);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Padding = new System.Windows.Forms.Padding(3);
            this.separatorControl2.Size = new System.Drawing.Size(344, 8);
            this.separatorControl2.TabIndex = 17;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 177);
            this.ControlBox = false;
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckRemPwd);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtLoginPwd);
            this.Controls.Add(this.txtLoginName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 216);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(352, 201);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.FLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckRemPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.CheckEdit CheckRemPwd;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtLoginPwd;
        private DevExpress.XtraEditors.TextEdit txtLoginName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
    }
}