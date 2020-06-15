using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.Utils.Serializing;
using DevExpress.Utils;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Base.Handler;

namespace RightingSys.WinForm.Utility.CustomControls
{
    public class CustomGridView : GridView
    {
        /// <summary>
        /// DevExpress选择列的默认fieldname
        /// </summary>
        public const string DEVEXPRESS_SELECTION_NAME = "DX$CheckboxSelectorColumn";

        /// <summary>
        /// 当光标在末行最后一个指定字段时继续回车的跳转方式
        /// </summary>
        public enum EnumForwardType
        {
            [Description("跳转到首行首列")]
            Circle = 0,
            [Description("停止跳转，直接返回")]
            Stop = 1,
            [Description("新增一行，光标定位到新行指定列")]
            NewRow = 2,
        }

        /// <summary>
        /// 视图的默认名称
        /// </summary>
        protected override string ViewName { get { return "CustomGridView"; } }

        /// <summary>
        /// 新增行代理
        /// </summary>
        public delegate void AddNewLineDelegate();

        /// <summary>
        /// 新增行自定义事件
        /// </summary>
        public AddNewLineDelegate AddNewLineEventHandler;

        #region 自定义属性
    
        //
        // 摘要:                                                        
        //     当 GridView 没有数据时是否显示提示，提示的值由 EmptyForegroundText 属性设置
        [DefaultValue(false),]
        [DXCategory("自定义属性")]
        [Description("当 GridView 没有数据时是否显示提示，提示的值由 EmptyForegroundText 属性设置")]
        [XtraSerializableProperty]
        public virtual bool EnableShowEmptyForeground { get; set; }
        //
        // 摘要:
        //     当 GridView 没有数据时的默认提示. 
        [DefaultValue(typeof(string), "")]
        [DXCategory("自定义属性")]
        [Description("当 GridView 没有数据时显示的值，默认显示\"没有查询到你所想要的数据!\"")]
        [XtraSerializableProperty]
        public virtual string EmptyForegroundText { get; set; }
        //
        // 摘要:
        //     GridView 回车时按指定字段跳转到相应的单元格.   
        //     调用方法如：new List<string>() { "SKUCODE", "PRICE", "DESCRIPTION" };   
        [DefaultValue(typeof(List<string>), "")]
        [DXCategory("自定义属性")]
        [Description("指定可以跳转的列（FieldName)，回车时按值先后顺序跳转")]
        [XtraSerializableProperty]
        [TypeConverter(typeof(CollectionConverter))]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(false)]
        public virtual List<string> ForwardColumnList { get; set; }
        //
        // 摘要:
        //     当光标在末行最后一个指定字段时继续回车的跳转方式.  
        [DefaultValue(typeof(EnumForwardType), "Circle")]
        [DXCategory("自定义属性")]
        [Description("当光标在末行最后一个指定字段时继续回车的跳转方式")]
        [XtraSerializableProperty]
        public virtual EnumForwardType ForwardType { get; set; } = EnumForwardType.Circle;
        //
        // 摘要:
        //     当末行最后一列回车新增行时，指定光标在新行定位的列（FieldName).
        [DefaultValue(typeof(string), "")]
        [DXCategory("自定义属性")]
        [Description("当末行最后一列回车新增行时，指定光标在新行定位的列（FieldName)，默认为新增行首个可编辑列")]
        [XtraSerializableProperty]
        public virtual string LocatedColumn { get; set; }

        #endregion

        #region 自定义方法
      
         /// <summary>
         /// 初始化，设置默认值
         /// </summary>
         public void Initialize() {
           // 设置为多选
           this.OptionsSelection.MultiSelect = true;
           // 自带勾选列的宽度
           this.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
           // 选中序号列是否勾选
           this.OptionsSelection.UseIndicatorForSelection = false;
           // 隐藏提示
           this.OptionsView.ShowGroupPanel = false;
           // 是否自适应列宽度
           this.OptionsView.ColumnAutoWidth = false;
           // 是否启用偶数行外观                                               
           this.OptionsView.EnableAppearanceEvenRow = true;
           // 是否启用奇数行外观
           this.OptionsView.EnableAppearanceOddRow = true;
           // 是否显示过滤面板
           this.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
           // 是否显示子报表
           this.OptionsDetail.EnableMasterViewMode = false;
           // 筛选模式
           this.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic;
           // 编辑模式
           this.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
           // 打印效果
           this.OptionsPrint.AutoWidth = false;
           // 字段标题居中
           this.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
           //选中行颜色
           //this.SetAppearanceColor();
           // 是否回车后光标移到下一个单元格
           this.OptionsNavigation.EnterMoveNextColumn = true;
           // 是否允许移动列
           this.OptionsCustomization.AllowColumnMoving = false;
           // 默认选中第一行                              
           this.FocusedRowHandle = 0;
           // 设置行号宽度
           this.IndicatorWidth = 28;

            //单元格水平和垂直居中
            this.Appearance.Row.TextOptions.HAlignment = HorzAlignment.Center;
            this.Appearance.Row.TextOptions.VAlignment = VertAlignment.Center;

           // 可编辑列设定
          // SetEditableColumns();
         }
     
         /// <summary>
         /// 设置单元格是否可编辑
         /// </summary>
         /// <param name="editableColumnsList">当GridView可编辑时，指定可以编辑的列(FieldName).</param>
         public void SetEditableColumns(List<string> editableColumnsList) {
           if (this.OptionsBehavior.Editable && editableColumnsList != null && editableColumnsList.Count > 0) {
             foreach (GridColumn col in this.Columns) {
               if (editableColumnsList.Exists(x => x == col.FieldName)) {
                 // 设置标题字体色
                 col.AppearanceHeader.ForeColor = Color.Blue;
                 col.OptionsColumn.AllowEdit = true;
               } else {
                 // 设置标题字体色
                 col.AppearanceHeader.ForeColor = Color.Black;
                 col.OptionsColumn.AllowEdit = false;
               }
             }
           }
         }
     
         /// <summary>
         /// 判断是否为表格最后一列可编辑列
         /// </summary>
         /// <param name="view"></param>
         /// <param name="focusedColumn"></param>
         /// <returns></returns>
         private bool IsLastEditableColumn(GridColumn focusedColumn) {
           var index = this.VisibleColumns.IndexOf(focusedColumn);
     
           for (int i = this.VisibleColumns.Count - 1; i >= 0; i--) {
             GridColumn column = this.VisibleColumns[i];
             // 忽略不可编辑Column 
             if (!column.OptionsColumn.AllowEdit) continue;
             // 当前列如果是最后一列可编辑列，则返回True，否则返回False
             return index == i;
           }
           // 如果都不可编辑，则返回False
           return false;
         }
     
         /// <summary>
         /// 添加新行
         /// </summary>
         private void AddNewLine() {
           var list = this.GridControl.DataSource;
           // 获取当前实例的 Type
           var t = this.DataSource.GetType();
           // 动态创建实例
           var obj = Activator.CreateInstance(t.GetGenericArguments()[0]);
           // 调用公用方法 Add
           var method = t.GetMethod("Add");
           // 将构建好的实例添加到数据源中
           method.Invoke(list, new object[] { obj });
           // 刷新数据源
           this.RefreshData();
         }
     
         /// <summary>  
         /// 获取GridView过滤或排序后的数据集  
         /// </summary>  
         /// <typeparam name="T">泛型对象</typeparam>  
         /// <returns></returns>  
         public IEnumerable<T> GetFilteredDataSource<T>() where T : class {
           var list = new List<T>();
           for (int i = 0; i < this.RowCount; i++) {
             if (this.IsGroupRow(i)) continue;
     
             var entity = this.GetRow(i) as T;
             if (entity == null) continue;
     
             list.Add(entity);
           }
           return list;
         }

        /// <summary>
        /// 获取GridView的选中行数据集
        /// </summary>
        /// <returns></returns>
        public List<object> GetSelectRowToObject()
        {
            List<object> list = new List<object>();
            var rowIds = this.GetSelectedRows();
            foreach (var id in rowIds)
            {
                object row = this.GetRow(id);
                if (row == null) continue;
                list.Add(row);
            }
            return list;
        }

        /// <summary>
        /// 设置选种的行
        /// </summary>
        /// <param name="selectlist"></param>
        public void SetSelectRow(List<object> objlt)
        {
            for(int i=0; i<this.RowCount;i++)
            {
               object rowobj=  this.GetRow(i);
                if (objlt.Any(a => a.Equals(rowobj)))
                {
                    this.SelectRow(i);
                }
            }
        }




         /// <summary>
         /// 获取GridView的选中行数据集（数据源是 DataTable）
         /// </summary>
         /// <returns></returns>
         public DataTable GetSelectedDataRows() {
           var dt = (this.DataSource as DataView).Table.Clone();
           var rowIds = this.GetSelectedRows();
           foreach (var id in rowIds) {
             var row = (this.GetRow(id) as DataRowView).Row;
             if (row == null) continue;
     
             dt.Rows.Add(row.ItemArray);
           }
           return dt;
         }
        
        /// <summary>
        /// 在初始化后注册一些事件
        /// </summary>
        public override void EndInit()
        {
            base.EndInit();

            // 针对MyGridLookUpEdit的情况
            if (string.IsNullOrWhiteSpace(this.GridControl?.Name)) return;

            // 设置行号
            this.CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(MyGridView_CustomDrawRowIndicator);
            // 设置行号宽度
            this.RowCountChanged += new EventHandler(MyGridView_RowCountChanged);
            // 在查询得到0条记录时显示自定义的字符提示/显示
            this.CustomDrawEmptyForeground += new CustomDrawEventHandler(MyGridView_CustomDrawEmptyForeground);
            // 回车跳转单元格（配合 ForwardColumnList 使用）
             this.KeyDown += new KeyEventHandler(MyGridView_KeyDown);
        }

        /// <summary>
        /// 在查询得到0条记录时显示自定义的字符提示/显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyGridView_CustomDrawEmptyForeground(object sender, CustomDrawEventArgs e)
        {
            if (!this.EnableShowEmptyForeground) return;

            string showText = string.IsNullOrWhiteSpace(this.EmptyForegroundText) ? "没有查询到你所想要的数据!" : this.EmptyForegroundText;

            //方法一（此方法为GridView设置了数据源绑定时，可用）
            try
            {
                var bindingSource = this.DataSource as BindingSource;
                if (bindingSource.Count == 0)
                {
                    var str = showText;
                    var f = new Font("宋体", 10, FontStyle.Bold);
                    var r = new Rectangle(e.Bounds.Top + 5, e.Bounds.Left + 5, e.Bounds.Right - 5, e.Bounds.Height - 5);
                    e.Graphics.DrawString(str, f, Brushes.Black, r);
                }
            }
            catch
            {
                //方法二（此方法为GridView没有设置数据源绑定时使用，一般使用此种方法）  
                if (this.RowCount == 0)
                {
                    var str = showText;
                    var f = new Font("宋体", 10, FontStyle.Bold);
                    var r = new Rectangle(e.Bounds.Left + 5, e.Bounds.Top + 5, e.Bounds.Width - 5, e.Bounds.Height - 5);
                    e.Graphics.DrawString(str, f, Brushes.Black, r);
                }
            }
        }
        #endregion

        #region 重写属性

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override ColumnViewOptionsView CreateOptionsView() {
            return base.CreateOptionsView();
            //return new CustomGridOptionsView();
        }
    
        #endregion

        #region 单元格回车事件
    
        /// <summary>
        /// 默认情况下，回车或Tab按可编辑列跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDefaultKeyDown(object sender, KeyEventArgs e) {
          if (!((e.KeyCode == Keys.Enter && this.OptionsNavigation.EnterMoveNextColumn) || e.KeyCode == Keys.Tab)) return;
    
          GridColumn column = null;
          var index = this.VisibleColumns.IndexOf(this.FocusedColumn);
    
          // 光标是否在最后一列可编辑列
          if (IsLastEditableColumn(this.FocusedColumn)) {
            #region 判断是否到达末行
    
            if (this.FocusedRowHandle >= this.RowCount - 1) {
              // 此处可选择跳转到首行或者直接返回或者新增行
              switch (this.ForwardType) {
                case EnumForwardType.Circle:  // 首行首列
                  this.MoveFirst();
                  for (int i = 0; i < this.VisibleColumns.Count; i++) {
                    column = this.VisibleColumns[i];
                    // 忽略不可编辑Column 
                    if (!column.OptionsColumn.AllowEdit) continue;
                    // 当前列可编辑，则光标定位到该列
                    this.FocusedColumn = column;
                    return;
                  }
                  break;
                case EnumForwardType.Stop:    // 停止跳转，直接返回
                  e.Handled = true;
                  break;
                case EnumForwardType.NewRow:  // 新增行，并跳转到新行首列
                  if (this.AddNewLineEventHandler == null)
                    AddNewLine();
                  else
                    AddNewLineEventHandler();
    
                  this.MoveNext();
                  // 没有指定定位字段
                  if (string.IsNullOrWhiteSpace(this.LocatedColumn)) {
                    for (int i = 0; i < this.VisibleColumns.Count; i++) {
                      column = this.VisibleColumns[i];
                      // 忽略不可编辑Column 
                      if (!column.OptionsColumn.AllowEdit) continue;
                      // 当前列可编辑，则光标定位到该列
                      this.FocusedColumn = column;
                      return;
                    }
                  } else {
                    this.FocusedColumn = this.Columns[this.LocatedColumn];
                  }
                  break;
              }
              return;
            }
    
            #endregion
    
            this.MoveNext();
            for (int i = 0; i < this.VisibleColumns.Count; i++) {
              column = this.VisibleColumns[i];
              // 忽略不可编辑Column 
              if (!column.OptionsColumn.AllowEdit) continue;
              // 如果是系统自带的编辑列，则直接跳过
              if (column.FieldName == DEVEXPRESS_SELECTION_NAME) continue;
    
              // 当前列可编辑，则光标定位到该列
              this.FocusedColumn = column;
              return;
            }
          } else {
            // 从当前定位列跳转到下一可编辑列
            for (int i = index + 1; i < this.VisibleColumns.Count; i++) {
              column = this.VisibleColumns[i];
              // 忽略不可编辑Column 
              if (!column.OptionsColumn.AllowEdit) continue;
              // 如果是系统自带的编辑列，则直接跳过
              if (column.FieldName == DEVEXPRESS_SELECTION_NAME) continue;
    
              // 当前列可编辑，则光标定位到该列
              this.FocusedColumn = column;
              return;
            }
    
            // 如果光标在不可编辑列
            for (int i = 0; i <= index; i++) {
              column = this.VisibleColumns[i];
              // 忽略不可编辑Column 
              if (!column.OptionsColumn.AllowEdit) continue;
              // 如果是系统自带的编辑列，则直接跳过
              if (column.FieldName == DEVEXPRESS_SELECTION_NAME) continue; 
              
              // 当前列可编辑，则光标定位到该列
              this.FocusedColumn = column;
              return;
            }
          }
        }
    
        /// <summary>
        /// 自定义跳转，按指定列字段跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCustomerKeyDown(object sender, KeyEventArgs e) {
          if (!((e.KeyCode == Keys.Enter && this.OptionsNavigation.EnterMoveNextColumn) || e.KeyCode == Keys.Tab)) return;
    
          var fieldName = this.FocusedColumn.FieldName;
    
          if (this.ForwardColumnList.Contains(fieldName)) {
            var index = this.ForwardColumnList.IndexOf(fieldName);
    
            // 光标不在当前行指定列集合的最后一列
            if (index != this.ForwardColumnList.Count - 1) {
              this.FocusedColumn = this.Columns[this.ForwardColumnList[index + 1]];
            } else  // 光标定位当前行指定列集合的最后一列
              {
              #region 判断是否到达末行
    
              if (this.FocusedRowHandle >= this.RowCount - 1) {
                // 此处可选择跳转到首行或者直接返回或者新增行
                switch (this.ForwardType) {
                  case EnumForwardType.Circle:  // 首行首列
                    this.MoveFirst();
                    this.FocusedColumn = this.Columns[this.ForwardColumnList[0]];
                    break;
                  case EnumForwardType.Stop:    // 停止跳转，直接返回
                    e.Handled = true;
                    break;
                  case EnumForwardType.NewRow:  // 新增行，并跳转到新行首列
                    if (this.AddNewLineEventHandler == null)
                      AddNewLine();
                    else
                      AddNewLineEventHandler();
    
                    fieldName = string.IsNullOrWhiteSpace(this.LocatedColumn) ? this.ForwardColumnList[0] : this.LocatedColumn;
    
                    this.MoveNext();
                    this.FocusedColumn = this.Columns[fieldName];
                    break;
                }
                return;
              }
    
              #endregion
    
              this.MoveNext();
              this.FocusedColumn = this.Columns[this.ForwardColumnList[0]];
            }
          } else {
            this.FocusedColumn = this.Columns[this.ForwardColumnList[0]];
          }
        }
    
        /// <summary>
        /// 回车跳转单元格 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyGridView_KeyDown(object sender, KeyEventArgs e) {
          if (!((e.KeyCode == Keys.Enter && this.OptionsNavigation.EnterMoveNextColumn) || e.KeyCode == Keys.Tab)) return;
    
          if (this.ValidateEditor() == false) {
            return;
          }
    
          // 未设置，则按默认规则跳转
          if (this.ForwardColumnList == null || this.ForwardColumnList.Count == 0) {
            OnDefaultKeyDown(sender, e);
          } else {
            OnCustomerKeyDown(sender, e);
          }
        }
    
        #endregion

        #region 设置行号


        /// <summary>
        /// 设置自动行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyGridView_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 行号宽度随行数的变化而变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyGridView_RowCountChanged(object sender, EventArgs e)
        {
            // 根据总行数设置行号宽度
            this.IndicatorWidth = 28 + (this.RowCount.ToString().Length - 1) * 10;
        }

        
        #endregion

        #region 构造函数 带参 不带参
        /// <summary>
        /// 构造函数
        /// </summary>
        public CustomGridView() : base() {
            this.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic;
        }

         /// <summary>
         /// 含参构造
         /// </summary>
         /// <param name="grid"></param>
         public CustomGridView(GridControl ownerGrid)
             : base(ownerGrid) {
           this.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Classic;
         }
        #endregion

        #region 多列模糊匹配
        /// <summary>
        /// SetGridControlAccessMethod，主要是了MyGridLookUpEdit用
        /// </summary>
        /// <param name="newControl"></param>
        protected internal virtual void SetGridControlAccessMetod(GridControl newControl)
        {
            SetGridControl(newControl);
        }

        /// <summary>
        ///  GridLookUpEdit的模糊匹配
        /// </summary>
        /// <param name="text">匹配字符串</param>
        /// <param name="displayMember">显示的字段</param>
        /// <returns></returns>
        protected override string OnCreateLookupDisplayFilter(string text, string displayMember)
        {
            List<CriteriaOperator> subStringOperators = new List<CriteriaOperator>();
            foreach (string sString in text.Split(' '))
            {
                string exp = LikeData.CreateContainsPattern(sString);
                List<CriteriaOperator> columnsOperators = new List<CriteriaOperator>();
                foreach (GridColumn col in Columns)
                {
                    if (col.Visible && col.ColumnType == typeof(string))
                        columnsOperators.Add(new BinaryOperator(col.FieldName, exp, BinaryOperatorType.Like));
                }
                subStringOperators.Add(new GroupOperator(GroupOperatorType.Or, columnsOperators));
            }
            return new GroupOperator(GroupOperatorType.And, subStringOperators).ToString();
        }
        

        /// <summary>
        /// 模糊匹配的字符串
        /// </summary>
        protected virtual internal string GetExtraFilterText { get { return ExtraFilterText; } }
        #endregion


    }

    [ToolboxItem(true)]
    public class CustomGridControl : GridControl
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CustomGridControl() : base() { CustomBeginInit(); }

        /// <summary>
        ///  向容器中注册所有的控件
        /// </summary>
        /// <param name="collection"></param>
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new CustomGridInfoRegistrator());//表格 自定义
            //collection.Add(new CustomBandedGridInfoRegistrator());//带表头
            //collection.Add(new CardInfoRegistrator());//卡片
            //collection.Add(new AdvBandedGridInfoRegistrator());//高级表头 
        }

        /// <summary>
        /// 创建初始化的GridView视图（请参照第3点）
        /// </summary>
        /// <returns></returns>
        protected override BaseView CreateDefaultView()
        {
            return CreateView("CustomGridView");
        }

        #region  自定义初始化方法
        /// <summary>
        /// 初始化内置的分页，如果要使用增、删、改功能，则把下面的代码注释即可
        /// </summary>
        private void InitNagiator()
        {
            this.EmbeddedNavigator.TextStringFormat = "记录 {0} / {1}";
            this.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
        }

        /// <summary>
        /// 自定义初始化方法
        /// </summary>
        private void CustomBeginInit()
        {
            this.InitNagiator();
        }
        #endregion
    }

    public class CustomGridPainter : GridPainter
    {
        public CustomGridPainter(GridView view) : base(view) { }

        public virtual new CustomGridView View { get { return (CustomGridView)base.View; } }

        protected override void DrawRowCell(GridViewDrawArgs e, GridCellInfo cell)
        {
            cell.ViewInfo.MatchedStringUseContains = true;
            cell.ViewInfo.MatchedString = View.GetExtraFilterText;
            cell.State = GridRowCellState.Dirty;
            e.ViewInfo.UpdateCellAppearance(cell);
            base.DrawRowCell(e, cell);
        }
    }

    public class CustomGridInfoRegistrator : GridInfoRegistrator
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CustomGridInfoRegistrator() : base() { }
        
        /// <summary>
        /// 创建自定义的绘画
        /// </summary>
        /// <param name="view"></param>
        /// <returns></returns>
        public override BaseViewPainter CreatePainter(BaseView view) { return new CustomGridPainter(view as DevExpress.XtraGrid.Views.Grid.GridView); }
        public override string ViewName { get { return "CustomGridView"; } }

        /// <summary>
        /// 创建GridView
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public override BaseView CreateView(GridControl grid)
        {
            CustomGridView view = new CustomGridView();
            view.SetGridControlAccessMetod(grid);
            view.Initialize();//初始化视图
            return view;
        }

        /// <summary>
        /// CreateViewInfo
        /// </summary>
        /// <param name="view"></param>
        /// <returns></returns>
        public override BaseViewInfo CreateViewInfo(BaseView view) {
          return new CustomGridViewInfo(view as CustomGridView);
        }
    
        /// <summary>
        /// 创建自定义的事件
        /// </summary>
        /// <param name="view"></param>
        /// <returns></returns>
        public override BaseViewHandler CreateHandler(BaseView view) {
          return new CustomGridHandler(view as CustomGridView);
        }
    }


    /// <summary>
    /// processes the mouse and keyboard.
    /// </summary>
    public class CustomGridHandler : DevExpress.XtraGrid.Views.Grid.Handler.GridHandler {
      /// <summary>
      /// Constructor
      /// </summary>
      /// <param name="gridView"></param>
      public CustomGridHandler(GridView gridView)
          : base(gridView) {
      }
  
      /// <summary>
      /// 重写事件 OnKeyDown
      /// </summary>
      /// <param name="e"></param>
      protected override void OnKeyDown(KeyEventArgs e) {
        try {
          base.OnKeyDown(e);
        } catch { }
  
        // Ctrl + C 复制单元格
        if (e.Control & e.KeyCode == Keys.C) {
          try {
            Clipboard.SetDataObject(this.View.GetFocusedRowCellDisplayText(this.View.FocusedColumn));
            e.Handled = true;
          } catch { }
        }
      }
    }
  
    

    /// <summary>
    /// 自定义视图信息
    /// </summary>
    public class CustomGridViewInfo : GridViewInfo
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gridView"></param>
        public CustomGridViewInfo(GridView gridView)
            : base(gridView) { }
    }

    public class CustomBandedGridInfoRegistrator : BandedGridInfoRegistrator
    {
        public CustomBandedGridInfoRegistrator() : base() { }
        public override BaseViewPainter CreatePainter(BaseView view) { return new CustomGridPainter(view as DevExpress.XtraGrid.Views.Grid.GridView); }
        public override string ViewName { get { return "CustomGridView"; } }
        public override BaseView CreateView(GridControl grid)
        {
            CustomGridView view = new CustomGridView();
            view.SetGridControlAccessMetod(grid);
            return view;
        }
    }
}
