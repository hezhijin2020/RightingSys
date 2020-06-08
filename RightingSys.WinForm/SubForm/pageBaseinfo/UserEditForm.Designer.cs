namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    partial class UserEditForm
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
            this.sbtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.stbnSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHandNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoginName = new DevExpress.XtraEditors.TextEdit();
            this.tlDepartment = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHandNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbtnAdd
            // 
            this.sbtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnAdd.Location = new System.Drawing.Point(268, 147);
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.Size = new System.Drawing.Size(77, 27);
            this.sbtnAdd.TabIndex = 1;
            this.sbtnAdd.Text = "添加";
           // this.sbtnAdd.Click += new System.EventHandler(this.sbtnAdd_Click);
            // 
            // stbnSave
            // 
            this.stbnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stbnSave.Location = new System.Drawing.Point(363, 147);
            this.stbnSave.Name = "stbnSave";
            this.stbnSave.Size = new System.Drawing.Size(77, 27);
            this.stbnSave.TabIndex = 2;
            this.stbnSave.Text = "保存";
            this.stbnSave.Click += new System.EventHandler(this.stbnSave_Click);
            // 
            // sbtnCancel
            // 
            this.sbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnCancel.Location = new System.Drawing.Point(457, 147);
            this.sbtnCancel.Name = "sbtnCancel";
            this.sbtnCancel.Size = new System.Drawing.Size(77, 27);
            this.sbtnCancel.TabIndex = 3;
            this.sbtnCancel.Text = "取消";
            this.sbtnCancel.Click += new System.EventHandler(this.sbtnCancel_Click);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "用户基本信息";
            this.tabNavigationPage1.Controls.Add(this.panelControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(513, 81);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl15);
            this.panelControl1.Controls.Add(this.labelControl16);
            this.panelControl1.Controls.Add(this.txtFullName);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.txtHandNo);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtLoginName);
            this.panelControl1.Controls.Add(this.tlDepartment);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(513, 81);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(12, 47);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(65, 14);
            this.labelControl15.TabIndex = 19;
            this.labelControl15.Text = "所属机构(*)";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(262, 15);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(65, 14);
            this.labelControl16.TabIndex = 17;
            this.labelControl16.Text = "真实姓名(*)";
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.Location = new System.Drawing.Point(335, 12);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(165, 20);
            this.txtFullName.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(279, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "用户编码";
            // 
            // txtHandNo
            // 
            this.txtHandNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHandNo.Location = new System.Drawing.Point(335, 44);
            this.txtHandNo.Name = "txtHandNo";
            this.txtHandNo.Size = new System.Drawing.Size(165, 20);
            this.txtHandNo.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "用户名(*)";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(85, 12);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(168, 20);
            this.txtLoginName.TabIndex = 0;
            // 
            // tlDepartment
            // 
            this.tlDepartment.Location = new System.Drawing.Point(85, 44);
            this.tlDepartment.Name = "tlDepartment";
            this.tlDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tlDepartment.Properties.DisplayMember = "DepartmentName";
            this.tlDepartment.Properties.NullText = "";
            this.tlDepartment.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            this.tlDepartment.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.tlDepartment.Properties.ValueMember = "Id";
            this.tlDepartment.Size = new System.Drawing.Size(168, 20);
            this.tlDepartment.TabIndex = 18;
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn2,
            this.treeListColumn3});
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
            this.treeListColumn2.Caption = "机构名";
            this.treeListColumn2.FieldName = "DepartmentName";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "编码";
            this.treeListColumn3.FieldName = "SimpleCode";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 1;
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Location = new System.Drawing.Point(14, 14);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(531, 127);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(531, 127);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 188);
            this.Controls.Add(this.sbtnCancel);
            this.Controls.Add(this.stbnSave);
            this.Controls.Add(this.sbtnAdd);
            this.Controls.Add(this.tabPane1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 400);
            this.MinimizeBox = false;
            this.Name = "UserEditForm";
            this.Text = "用户信息";
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHandNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton sbtnAdd;
        private DevExpress.XtraEditors.SimpleButton stbnSave;
        private DevExpress.XtraEditors.SimpleButton sbtnCancel;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHandNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtLoginName;
        private DevExpress.XtraEditors.TreeListLookUpEdit tlDepartment;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
    }
}