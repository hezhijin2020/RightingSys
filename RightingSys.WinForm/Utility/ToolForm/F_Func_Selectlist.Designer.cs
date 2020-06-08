namespace RightingSys.WinForm.Utility.ToolForm
{
    partial class F_Func_Selectlist
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
            this.gcDate = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbtnOK = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDate
            // 
            this.gcDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcDate.Location = new System.Drawing.Point(10, 12);
            this.gcDate.MainView = this.gridView1;
            this.gcDate.Name = "gcDate";
            this.gcDate.Size = new System.Drawing.Size(264, 400);
            this.gcDate.TabIndex = 0;
            this.gcDate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col1,
            this.col2,
            this.col3,
            this.col4});
            this.gridView1.GridControl = this.gcDate;
            this.gridView1.IndicatorWidth = 10;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col1
            // 
            this.col1.Caption = "选择";
            this.col1.FieldName = "IsSelect";
            this.col1.Name = "col1";
            this.col1.OptionsColumn.AllowMove = false;
            this.col1.OptionsColumn.AllowShowHide = false;
            this.col1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col1.OptionsFilter.AllowAutoFilter = false;
            this.col1.OptionsFilter.AllowFilter = false;
            this.col1.Visible = true;
            this.col1.VisibleIndex = 0;
            this.col1.Width = 40;
            // 
            // col2
            // 
            this.col2.Caption = "名称";
            this.col2.FieldName = "Name";
            this.col2.Name = "col2";
            this.col2.OptionsColumn.AllowEdit = false;
            this.col2.OptionsColumn.AllowMove = false;
            this.col2.OptionsColumn.AllowShowHide = false;
            this.col2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col2.OptionsFilter.AllowAutoFilter = false;
            this.col2.OptionsFilter.AllowFilter = false;
            this.col2.Visible = true;
            this.col2.VisibleIndex = 1;
            this.col2.Width = 50;
            // 
            // col3
            // 
            this.col3.Caption = "功能";
            this.col3.FieldName = "HandleNo";
            this.col3.Name = "col3";
            this.col3.OptionsColumn.AllowEdit = false;
            this.col3.OptionsColumn.AllowMove = false;
            this.col3.OptionsColumn.AllowShowHide = false;
            this.col3.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col3.OptionsFilter.AllowAutoFilter = false;
            this.col3.OptionsFilter.AllowFilter = false;
            this.col3.Visible = true;
            this.col3.VisibleIndex = 2;
            this.col3.Width = 60;
            // 
            // col4
            // 
            this.col4.Caption = "代码";
            this.col4.FieldName = "Code";
            this.col4.Name = "col4";
            this.col4.OptionsColumn.AllowEdit = false;
            this.col4.OptionsColumn.AllowMove = false;
            this.col4.OptionsColumn.AllowShowHide = false;
            this.col4.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.col4.OptionsFilter.AllowAutoFilter = false;
            this.col4.OptionsFilter.AllowFilter = false;
            this.col4.Visible = true;
            this.col4.VisibleIndex = 3;
            // 
            // sbtnOK
            // 
            this.sbtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbtnOK.Location = new System.Drawing.Point(54, 426);
            this.sbtnOK.Name = "sbtnOK";
            this.sbtnOK.Size = new System.Drawing.Size(75, 23);
            this.sbtnOK.TabIndex = 1;
            this.sbtnOK.Text = "确定";
            this.sbtnOK.Click += new System.EventHandler(this.sbtnOK_Click);
            // 
            // sbtnCancel
            // 
            this.sbtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnCancel.Location = new System.Drawing.Point(151, 426);
            this.sbtnCancel.Name = "sbtnCancel";
            this.sbtnCancel.Size = new System.Drawing.Size(75, 23);
            this.sbtnCancel.TabIndex = 2;
            this.sbtnCancel.Text = "取消";
            this.sbtnCancel.Click += new System.EventHandler(this.sbtnCancel_Click);
            // 
            // F_Func_Selectlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.sbtnCancel);
            this.Controls.Add(this.sbtnOK);
            this.Controls.Add(this.gcDate);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "F_Func_Selectlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "功能明细";
            ((System.ComponentModel.ISupportInitialize)(this.gcDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col1;
        private DevExpress.XtraGrid.Columns.GridColumn col2;
        private DevExpress.XtraEditors.SimpleButton sbtnOK;
        private DevExpress.XtraEditors.SimpleButton sbtnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn col3;
        private DevExpress.XtraGrid.Columns.GridColumn col4;
    }
}