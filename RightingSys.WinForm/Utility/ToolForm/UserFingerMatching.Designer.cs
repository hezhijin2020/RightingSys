namespace RightingSys.WinForm.Utility.ToolForm
{
    partial class UserFingerMatching
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
            this.lbeFingerCount = new DevExpress.XtraEditors.LabelControl();
            this.textRes = new DevExpress.XtraEditors.MemoEdit();
            this.picFPImg = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textRes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.lbeFingerCount);
            this.panelControl1.Controls.Add(this.textRes);
            this.panelControl1.Controls.Add(this.picFPImg);
            this.panelControl1.Location = new System.Drawing.Point(10, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(502, 222);
            this.panelControl1.TabIndex = 0;
            // 
            // lbeFingerCount
            // 
            this.lbeFingerCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbeFingerCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbeFingerCount.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbeFingerCount.Location = new System.Drawing.Point(5, 193);
            this.lbeFingerCount.Name = "lbeFingerCount";
            this.lbeFingerCount.Size = new System.Drawing.Size(492, 23);
            this.lbeFingerCount.TabIndex = 2;
            this.lbeFingerCount.Text = "指纹模板数量";
            // 
            // textRes
            // 
            this.textRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRes.Enabled = false;
            this.textRes.Location = new System.Drawing.Point(5, 5);
            this.textRes.Name = "textRes";
            this.textRes.Properties.ReadOnly = true;
            this.textRes.Size = new System.Drawing.Size(338, 182);
            this.textRes.TabIndex = 1;
            // 
            // picFPImg
            // 
            this.picFPImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFPImg.Location = new System.Drawing.Point(349, 5);
            this.picFPImg.Name = "picFPImg";
            this.picFPImg.Properties.AllowFocused = false;
            this.picFPImg.Properties.ReadOnly = true;
            this.picFPImg.Properties.ShowMenu = false;
            this.picFPImg.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picFPImg.Size = new System.Drawing.Size(148, 182);
            this.picFPImg.TabIndex = 0;
            // 
            // UserFingerMatching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 246);
            this.Controls.Add(this.panelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserFingerMatching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户指纹认证";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserFingerMatching_FormClosing);
            this.Load += new System.EventHandler(this.UserFingerMatching_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textRes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFPImg.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.MemoEdit textRes;
        private DevExpress.XtraEditors.PictureEdit picFPImg;
        private DevExpress.XtraEditors.LabelControl lbeFingerCount;
    }
}