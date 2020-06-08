namespace RightingSys.WinForm.Utility.ToolForm
{
    partial class RoleByDepartment_SelectList
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
            this.sbtnOK = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tl_OU = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tl_OU)).BeginInit();
            this.SuspendLayout();
            // 
            // sbtnOK
            // 
            this.sbtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnOK.Location = new System.Drawing.Point(175, 374);
            this.sbtnOK.Name = "sbtnOK";
            this.sbtnOK.Size = new System.Drawing.Size(52, 23);
            this.sbtnOK.TabIndex = 0;
            this.sbtnOK.Text = "完成";
            this.sbtnOK.Click += new System.EventHandler(this.sbtnOK_Click);
            // 
            // sbtnCancel
            // 
            this.sbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnCancel.Location = new System.Drawing.Point(233, 374);
            this.sbtnCancel.Name = "sbtnCancel";
            this.sbtnCancel.Size = new System.Drawing.Size(52, 23);
            this.sbtnCancel.TabIndex = 1;
            this.sbtnCancel.Text = "取消";
            this.sbtnCancel.Click += new System.EventHandler(this.sbtnCancel_Click);
            // 
            // tl_OU
            // 
            this.tl_OU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tl_OU.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.tl_OU.KeyFieldName = "Id";
            this.tl_OU.Location = new System.Drawing.Point(12, 12);
            this.tl_OU.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tl_OU.LookAndFeel.UseWindowsXPTheme = true;
            this.tl_OU.Name = "tl_OU";
            this.tl_OU.OptionsView.ShowCheckBoxes = true;
            this.tl_OU.ParentFieldName = "ParentId";
            this.tl_OU.Size = new System.Drawing.Size(275, 353);
            this.tl_OU.TabIndex = 2;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "机构列表";
            this.treeListColumn1.FieldName = "DepartmentName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // RoleByDepartment_SelectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 406);
            this.Controls.Add(this.tl_OU);
            this.Controls.Add(this.sbtnCancel);
            this.Controls.Add(this.sbtnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RoleByDepartment_SelectList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用色包含的机构";
            ((System.ComponentModel.ISupportInitialize)(this.tl_OU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtnOK;
        private DevExpress.XtraEditors.SimpleButton sbtnCancel;
        private DevExpress.XtraTreeList.TreeList tl_OU;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
    }
}