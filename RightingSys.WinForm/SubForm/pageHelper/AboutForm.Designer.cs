namespace RightingSys.WinForm.SubForm.pageHelper
{
    partial class AboutForm
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
            this.labSystemName = new DevExpress.XtraEditors.LabelControl();
            this.labSystemVersion = new DevExpress.XtraEditors.LabelControl();
            this.labListTime = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labSystemName
            // 
            this.labSystemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labSystemName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSystemName.Appearance.Options.UseFont = true;
            this.labSystemName.Appearance.Options.UseTextOptions = true;
            this.labSystemName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labSystemName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labSystemName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labSystemName.Location = new System.Drawing.Point(23, 32);
            this.labSystemName.Name = "labSystemName";
            this.labSystemName.Size = new System.Drawing.Size(225, 25);
            this.labSystemName.TabIndex = 0;
            this.labSystemName.Text = "labelControl1";
            // 
            // labSystemVersion
            // 
            this.labSystemVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labSystemVersion.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSystemVersion.Appearance.Options.UseFont = true;
            this.labSystemVersion.Appearance.Options.UseTextOptions = true;
            this.labSystemVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labSystemVersion.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labSystemVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labSystemVersion.Location = new System.Drawing.Point(23, 63);
            this.labSystemVersion.Name = "labSystemVersion";
            this.labSystemVersion.Size = new System.Drawing.Size(225, 25);
            this.labSystemVersion.TabIndex = 1;
            this.labSystemVersion.Text = "labelControl2";
            // 
            // labListTime
            // 
            this.labListTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labListTime.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labListTime.Appearance.Options.UseFont = true;
            this.labListTime.Appearance.Options.UseTextOptions = true;
            this.labListTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labListTime.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labListTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labListTime.Location = new System.Drawing.Point(23, 98);
            this.labListTime.Name = "labListTime";
            this.labListTime.Size = new System.Drawing.Size(225, 25);
            this.labListTime.TabIndex = 2;
            this.labListTime.Text = "labelControl3";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.labListTime);
            this.panelControl1.Controls.Add(this.labSystemName);
            this.panelControl1.Controls.Add(this.labSystemVersion);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(273, 155);
            this.panelControl1.TabIndex = 3;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 179);
            this.Controls.Add(this.panelControl1);
            this.Name = "AboutForm";
            this.Text = "关于我们";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labSystemName;
        private DevExpress.XtraEditors.LabelControl labSystemVersion;
        private DevExpress.XtraEditors.LabelControl labListTime;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}