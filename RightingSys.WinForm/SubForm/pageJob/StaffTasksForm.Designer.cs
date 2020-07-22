using DevExpress.XtraEditors;

namespace RightingSys.WinForm.SubForm.pageJob
{
    partial class StaffTasksForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule1 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffTasksForm));
            this.ColProgress = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ColTaskName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.ColIsCompleted = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCompletedComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.svgImageCollection = new DevExpress.Utils.SvgImageCollection(this.components);
            this.ColPriority = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemPriorityComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ColIsDescription = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemDescriptionComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ColStaffName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ColStartDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ColDueDate = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemProgressBarProgress = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCompletedComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPriorityComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDescriptionComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBarProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColProgress
            // 
            this.ColProgress.AppearanceCell.Options.UseTextOptions = true;
            this.ColProgress.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColProgress.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ColProgress.Caption = "进度";
            this.ColProgress.FieldName = "Progress";
            this.ColProgress.Format.FormatString = "{0}%";
            this.ColProgress.Format.FormatType = DevExpress.Utils.FormatType.Custom;
            this.ColProgress.MaxWidth = 100;
            this.ColProgress.MinWidth = 80;
            this.ColProgress.Name = "ColProgress";
            this.ColProgress.Visible = true;
            this.ColProgress.VisibleIndex = 5;
            this.ColProgress.Width = 80;
            // 
            // ColTaskName
            // 
            this.ColTaskName.Caption = "任务";
            this.ColTaskName.FieldName = "TaskName";
            this.ColTaskName.Name = "ColTaskName";
            this.ColTaskName.OptionsColumn.ShowInCustomizationForm = false;
            this.ColTaskName.Visible = true;
            this.ColTaskName.VisibleIndex = 3;
            this.ColTaskName.Width = 136;
            // 
            // treeList1
            // 
            this.treeList1.AutoFillFieldName = "TaskName";
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ColIsCompleted,
            this.ColPriority,
            this.ColIsDescription,
            this.ColTaskName,
            this.ColStaffName,
            this.ColProgress,
            this.ColStartDate,
            this.ColDueDate});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.CustomizationFormBounds = new System.Drawing.Rectangle(864, 337, 210, 186);
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.FixedLineWidth = 1;
            treeListFormatRule1.Column = this.ColProgress;
            treeListFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            formatConditionRuleDataBar1.MaximumType = DevExpress.XtraEditors.FormatConditionValueType.Percent;
            formatConditionRuleDataBar1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            formatConditionRuleDataBar1.MinimumType = DevExpress.XtraEditors.FormatConditionValueType.Percent;
            formatConditionRuleDataBar1.PredefinedName = null;
            treeListFormatRule1.Rule = formatConditionRuleDataBar1;
            this.treeList1.FormatRules.Add(treeListFormatRule1);
            this.treeList1.HierarchyFieldName = "TaskName";
            this.treeList1.IndicatorWidth = 40;
            this.treeList1.KeyFieldName = "Id";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.DoubleClick;
            this.treeList1.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList1.OptionsMenu.EnableColumnMenu = false;
            this.treeList1.OptionsMenu.EnableFooterMenu = false;
            this.treeList1.OptionsMenu.ShowConditionalFormattingItem = true;
            this.treeList1.OptionsSelection.SelectNodesOnRightClick = true;
            this.treeList1.OptionsSelection.UseIndicatorForSelection = true;
            this.treeList1.OptionsView.AutoWidth = false;
            this.treeList1.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList1.OptionsView.EnableAppearanceOddRow = true;
            this.treeList1.OptionsView.ShowHierarchyIndentationLines = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.ParentFieldName = "ParentId";
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCompletedComboBox,
            this.repositoryItemPriorityComboBox,
            this.repositoryItemDescriptionComboBox,
            this.repositoryItemProgressBarProgress,
            this.repositoryItemProgressBar1});
            this.treeList1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor;
            this.treeList1.Size = new System.Drawing.Size(739, 76);
            this.treeList1.TabIndex = 0;
            this.treeList1.CustomDrawNodeIndicator += new DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventHandler(this.treeList1_CustomDrawNodeIndicator);
            // 
            // ColIsCompleted
            // 
            this.ColIsCompleted.ColumnEdit = this.repositoryItemCompletedComboBox;
            this.ColIsCompleted.FieldName = "IsCompleted";
            this.ColIsCompleted.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.ColIsCompleted.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.ColIsCompleted.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ColIsCompleted.ImageOptions.SvgImage")));
            this.ColIsCompleted.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ColIsCompleted.MaxWidth = 30;
            this.ColIsCompleted.MinWidth = 30;
            this.ColIsCompleted.Name = "ColIsCompleted";
            this.ColIsCompleted.OptionsColumn.AllowEdit = false;
            this.ColIsCompleted.OptionsColumn.AllowMove = false;
            this.ColIsCompleted.OptionsColumn.AllowSize = false;
            this.ColIsCompleted.OptionsColumn.AllowSort = false;
            this.ColIsCompleted.OptionsColumn.FixedWidth = true;
            this.ColIsCompleted.OptionsFilter.AllowAutoFilter = false;
            this.ColIsCompleted.OptionsFilter.AllowFilter = false;
            this.ColIsCompleted.Visible = true;
            this.ColIsCompleted.VisibleIndex = 0;
            this.ColIsCompleted.Width = 30;
            // 
            // repositoryItemCompletedComboBox
            // 
            this.repositoryItemCompletedComboBox.AutoHeight = false;
            this.repositoryItemCompletedComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCompletedComboBox.Name = "repositoryItemCompletedComboBox";
            this.repositoryItemCompletedComboBox.SmallImages = this.svgImageCollection;
            // 
            // svgImageCollection
            // 
            this.svgImageCollection.Add("apply", "image://devav/actions/apply.svg");
            this.svgImageCollection.Add("show", "image://devav/actions/show.svg");
            // 
            // ColPriority
            // 
            this.ColPriority.ColumnEdit = this.repositoryItemPriorityComboBox;
            this.ColPriority.FieldName = "Priority";
            this.ColPriority.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.ColPriority.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.ColPriority.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ColPriority.ImageOptions.SvgImage")));
            this.ColPriority.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ColPriority.MaxWidth = 30;
            this.ColPriority.MinWidth = 30;
            this.ColPriority.Name = "ColPriority";
            this.ColPriority.OptionsColumn.AllowEdit = false;
            this.ColPriority.OptionsColumn.AllowMove = false;
            this.ColPriority.OptionsColumn.AllowSize = false;
            this.ColPriority.OptionsColumn.AllowSort = false;
            this.ColPriority.OptionsColumn.FixedWidth = true;
            this.ColPriority.OptionsFilter.AllowAutoFilter = false;
            this.ColPriority.OptionsFilter.AllowFilter = false;
            this.ColPriority.Visible = true;
            this.ColPriority.VisibleIndex = 1;
            this.ColPriority.Width = 30;
            // 
            // repositoryItemPriorityComboBox
            // 
            this.repositoryItemPriorityComboBox.AutoHeight = false;
            this.repositoryItemPriorityComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPriorityComboBox.Name = "repositoryItemPriorityComboBox";
            this.repositoryItemPriorityComboBox.SmallImages = this.imageCollection;
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            // 
            // ColIsDescription
            // 
            this.ColIsDescription.ColumnEdit = this.repositoryItemDescriptionComboBox;
            this.ColIsDescription.FieldName = "IsDescription";
            this.ColIsDescription.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.ColIsDescription.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.ColIsDescription.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ColIsDescription.ImageOptions.SvgImage")));
            this.ColIsDescription.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.ColIsDescription.MaxWidth = 30;
            this.ColIsDescription.MinWidth = 30;
            this.ColIsDescription.Name = "ColIsDescription";
            this.ColIsDescription.OptionsColumn.AllowEdit = false;
            this.ColIsDescription.OptionsColumn.AllowMove = false;
            this.ColIsDescription.OptionsColumn.AllowSize = false;
            this.ColIsDescription.OptionsColumn.AllowSort = false;
            this.ColIsDescription.OptionsColumn.FixedWidth = true;
            this.ColIsDescription.OptionsFilter.AllowAutoFilter = false;
            this.ColIsDescription.OptionsFilter.AllowFilter = false;
            this.ColIsDescription.ToolTip = "Description";
            this.ColIsDescription.Visible = true;
            this.ColIsDescription.VisibleIndex = 2;
            this.ColIsDescription.Width = 30;
            // 
            // repositoryItemDescriptionComboBox
            // 
            this.repositoryItemDescriptionComboBox.AutoHeight = false;
            this.repositoryItemDescriptionComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDescriptionComboBox.Name = "repositoryItemDescriptionComboBox";
            this.repositoryItemDescriptionComboBox.SmallImages = this.svgImageCollection;
            // 
            // ColStaffName
            // 
            this.ColStaffName.Caption = "职员";
            this.ColStaffName.FieldName = "StaffName";
            this.ColStaffName.Name = "ColStaffName";
            this.ColStaffName.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.ColStaffName.Visible = true;
            this.ColStaffName.VisibleIndex = 4;
            this.ColStaffName.Width = 103;
            // 
            // ColStartDate
            // 
            this.ColStartDate.Caption = "开始日期";
            this.ColStartDate.FieldName = "StartDate";
            this.ColStartDate.Name = "ColStartDate";
            this.ColStartDate.Visible = true;
            this.ColStartDate.VisibleIndex = 6;
            this.ColStartDate.Width = 145;
            // 
            // ColDueDate
            // 
            this.ColDueDate.Caption = "结束日期";
            this.ColDueDate.FieldName = "DueDate";
            this.ColDueDate.Name = "ColDueDate";
            this.ColDueDate.Visible = true;
            this.ColDueDate.VisibleIndex = 7;
            this.ColDueDate.Width = 149;
            // 
            // repositoryItemProgressBarProgress
            // 
            this.repositoryItemProgressBarProgress.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemProgressBarProgress.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemProgressBarProgress.DisplayFormat.FormatString = "{0}%";
            this.repositoryItemProgressBarProgress.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemProgressBarProgress.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemProgressBarProgress.Name = "repositoryItemProgressBarProgress";
            this.repositoryItemProgressBarProgress.ShowTitle = true;
            this.repositoryItemProgressBarProgress.TextOrientation = DevExpress.Utils.Drawing.TextOrientation.Horizontal;
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // StaffTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 76);
            this.Controls.Add(this.treeList1);
            this.Name = "StaffTasksForm";
            this.Text = "工作任务进度";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCompletedComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPriorityComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDescriptionComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBarProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColTaskName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColStaffName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColStartDate;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColDueDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemCompletedComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemPriorityComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemDescriptionComboBox;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColIsCompleted;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColPriority;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColIsDescription;
        private DevExpress.Utils.ImageCollection imageCollection;
        private DevExpress.Utils.SvgImageCollection svgImageCollection;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBarProgress;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
    }
}