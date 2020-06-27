using DevExpress.XtraGrid.Views.BandedGrid;
using RightingSys.WinForm.Utility.cls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageJob
{
    public partial class WeekPlanForm : BaseForm
    {
        BLL.WorkPlanManager manager = new BLL.WorkPlanManager();
        BLL.DepartmentManager deptManager = new BLL.DepartmentManager();


        public WeekPlanForm()
        {
            InitializeComponent();

            tlDepartment.Properties.DataSource = deptManager.GetAllList();

            this.dEnd.DateTime = clsPublic.GetWeekLastDaySun(DateTime.Now);
            this.dStart.DateTime = clsPublic.GetWeekLastDaySun(DateTime.Now).AddDays(-13);

            gvData.ViewCaption = string.Format("   当前是第 {0} 周，上一周第 {1} 周，日期范围是： {2} 到 {3}  共14天", 
                clsPublic.GetWeekOfYear(DateTime.Now.Date),
                clsPublic.GetWeekOfYear(DateTime.Now) - 1, 
                dStart.DateTime.Date.ToString("yyyy-MM-dd"), 
                dEnd.DateTime.Date.ToString("yyyy-MM-dd"));

            tlDepartment.EditValue = Models.SqlHelper.Session._DepartmentId;

        }

        /// <summary>
        /// 功能初始化
        /// </summary>
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[] { FeatureButton.Query, FeatureButton.Export, FeatureButton.Next, FeatureButton.Previous });
        }

        /// <summary>
        /// 查询功能
        /// </summary>
        public override void Query()
        {
            IsEidtTable();
            ChengBandDesc();

            string sqlText = @"select a.Id StaffId ,a.FullName StaffName,c.DepartmentName,";
            List<string> list = clsPublic.GetDateArrangeList(dStart.DateTime, dEnd.DateTime);

            for (int i = 0; i < list.Count; i++)
            {
                string sql1 = string.Format(@"max(case workday when '{0}' then WorkPlan end) 'P{1}',
                                              max(case workday when '{0}' then CheckPlan end) 'C{1}',
                                              max(case workday when '{0}' then FocusWork end) 'F{1}',
                                              ", list[i], i + 1);
                sqlText = sqlText + sql1;
            }
          
            //部门筛选条件
            var DepartmentId = clsPublic.GetObjGUID(tlDepartment.EditValue);
            string FilterWhere = DepartmentId==Guid.Empty?"": string.Format( " Where a.DepartmentId='{0}' ", DepartmentId);

            string sql2 = string.Format(@" '行程' ItemP,'检视' ItemC ,'重点'ItemF
                            from  ACL_User as a left join (select* from ys_WorkPlan where WorkDay>='{0}' and WorkDay<='{1}') as b on a.Id = b.StaffId
                                                inner join ACL_Department as c on a.DepartmentId = c.Id  {2}
                           Group By  a.Id,a.FullName,c.DepartmentName", dStart.DateTime.Date.ToString("yyyy-MM-dd"), dEnd.DateTime.ToString("yyyy-MM-dd"), FilterWhere);
            

            sqlText = sqlText + sql2;

            gcData.DataSource = manager.GetDtWorkPlan(sqlText);
         
        }

        /// <summary>
        /// 导出
        /// </summary>
        public override void Export()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Title = "导出Excel";
            fileDialog.Filter = "Excel文件(*.xls)|*.xls";
            DialogResult dialogResult = fileDialog.ShowDialog(this);
            if (dialogResult == DialogResult.OK)
            {
                DevExpress.XtraPrinting.XlsExportOptions options = new DevExpress.XtraPrinting.XlsExportOptions();
                gcData.ExportToXls(fileDialog.FileName);
                DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示");
            }
        }

        /// <summary>
        /// 打印
        /// </summary>
        public override void Print()
        {
            gcData.ShowPrintPreview();
            gcData.ShowRibbonPrintPreview();
        }

        /// <summary>
        /// 下一周
        /// </summary>
        public override void Next()
        {
            this.dStart.EditValue = this.dStart.DateTime.AddDays(7);
            this.dEnd.EditValue = this.dEnd.DateTime.AddDays(7);
            Query();
        }


        /// <summary>
        /// 上一周
        /// </summary>
        public override void Previous()
        {
            this.dStart.EditValue = this.dStart.DateTime.AddDays(-7);
            this.dEnd.EditValue = this.dEnd.DateTime.AddDays(-7);
            Query();
        }

        /// <summary>
        /// 根据日期是否禁用编辑
        /// </summary>
        private void IsEidtTable()
        {
            int CurrentWeek = clsPublic.GetWeekOfYear(DateTime.Now.Date);//本周
            int week= clsPublic.GetWeekOfYear(dEnd.DateTime.AddDays(-6));//下周

            if (CurrentWeek <=week)
            {
                this.C1.OptionsColumn.AllowEdit = true;
                this.F1.OptionsColumn.AllowEdit = true;
                this.P1.OptionsColumn.AllowEdit = true;

                this.C2.OptionsColumn.AllowEdit = true;
                this.F2.OptionsColumn.AllowEdit = true;
                this.P2.OptionsColumn.AllowEdit = true;

                this.C3.OptionsColumn.AllowEdit = true;
                this.F3.OptionsColumn.AllowEdit = true;
                this.P3.OptionsColumn.AllowEdit = true;

                this.C4.OptionsColumn.AllowEdit = true;
                this.F4.OptionsColumn.AllowEdit = true;
                this.P4.OptionsColumn.AllowEdit = true;

                this.C5.OptionsColumn.AllowEdit = true;
                this.F5.OptionsColumn.AllowEdit = true;
                this.P5.OptionsColumn.AllowEdit = true;

                this.C6.OptionsColumn.AllowEdit = true;
                this.F6.OptionsColumn.AllowEdit = true;
                this.P6.OptionsColumn.AllowEdit = true;

                this.C7.OptionsColumn.AllowEdit = true;
                this.F7.OptionsColumn.AllowEdit = true;
                this.P7.OptionsColumn.AllowEdit = true;

                this.C8.OptionsColumn.AllowEdit = true;
                this.F8.OptionsColumn.AllowEdit = true;
                this.P8.OptionsColumn.AllowEdit = true;

                this.C9.OptionsColumn.AllowEdit = true;
                this.F9.OptionsColumn.AllowEdit = true;
                this.P9.OptionsColumn.AllowEdit = true;

                this.C10.OptionsColumn.AllowEdit = true;
                this.F10.OptionsColumn.AllowEdit = true;
                this.P10.OptionsColumn.AllowEdit = true;

                this.C11.OptionsColumn.AllowEdit = true;
                this.F11.OptionsColumn.AllowEdit = true;
                this.P11.OptionsColumn.AllowEdit = true;

                this.C12.OptionsColumn.AllowEdit = true;
                this.F12.OptionsColumn.AllowEdit = true;
                this.P12.OptionsColumn.AllowEdit = true;

                this.C13.OptionsColumn.AllowEdit = true;
                this.F13.OptionsColumn.AllowEdit = true;
                this.P13.OptionsColumn.AllowEdit = true;

                this.C14.OptionsColumn.AllowEdit = true;
                this.F14.OptionsColumn.AllowEdit = true;
                this.P14.OptionsColumn.AllowEdit = true;

            }
            else if (CurrentWeek == week + 1)
            {
                this.C1.OptionsColumn.AllowEdit = false;
                this.F1.OptionsColumn.AllowEdit = false;
                this.P1.OptionsColumn.AllowEdit = false;

                this.C2.OptionsColumn.AllowEdit = false;
                this.F2.OptionsColumn.AllowEdit = false;
                this.P2.OptionsColumn.AllowEdit = false;

                this.C3.OptionsColumn.AllowEdit = false;
                this.F3.OptionsColumn.AllowEdit = false;
                this.P3.OptionsColumn.AllowEdit = false;

                this.C4.OptionsColumn.AllowEdit = false;
                this.F4.OptionsColumn.AllowEdit = false;
                this.P4.OptionsColumn.AllowEdit = false;

                this.C5.OptionsColumn.AllowEdit = false;
                this.F5.OptionsColumn.AllowEdit = false;
                this.P5.OptionsColumn.AllowEdit = false;

                this.C6.OptionsColumn.AllowEdit = false;
                this.F6.OptionsColumn.AllowEdit = false;
                this.P6.OptionsColumn.AllowEdit = false;

                this.C7.OptionsColumn.AllowEdit = false;
                this.F7.OptionsColumn.AllowEdit = false;
                this.P7.OptionsColumn.AllowEdit = false;

                this.C8.OptionsColumn.AllowEdit = true;
                this.F8.OptionsColumn.AllowEdit = true;
                this.P8.OptionsColumn.AllowEdit = true;

                this.C9.OptionsColumn.AllowEdit = true;
                this.F9.OptionsColumn.AllowEdit = true;
                this.P9.OptionsColumn.AllowEdit = true;

                this.C10.OptionsColumn.AllowEdit = true;
                this.F10.OptionsColumn.AllowEdit = true;
                this.P10.OptionsColumn.AllowEdit = true;

                this.C11.OptionsColumn.AllowEdit = true;
                this.F11.OptionsColumn.AllowEdit = true;
                this.P11.OptionsColumn.AllowEdit = true;

                this.C12.OptionsColumn.AllowEdit = true;
                this.F12.OptionsColumn.AllowEdit = true;
                this.P12.OptionsColumn.AllowEdit = true;

                this.C13.OptionsColumn.AllowEdit = true;
                this.F13.OptionsColumn.AllowEdit = true;
                this.P13.OptionsColumn.AllowEdit = true;

                this.C14.OptionsColumn.AllowEdit = true;
                this.F14.OptionsColumn.AllowEdit = true;
                this.P14.OptionsColumn.AllowEdit = true;
            }
            else if(CurrentWeek>week+1){
                this.C1.OptionsColumn.AllowEdit = false;
                this.F1.OptionsColumn.AllowEdit = false;
                this.P1.OptionsColumn.AllowEdit = false;

                this.C2.OptionsColumn.AllowEdit = false;
                this.F2.OptionsColumn.AllowEdit = false;
                this.P2.OptionsColumn.AllowEdit = false;

                this.C3.OptionsColumn.AllowEdit = false;
                this.F3.OptionsColumn.AllowEdit = false;
                this.P3.OptionsColumn.AllowEdit = false;

                this.C4.OptionsColumn.AllowEdit = false;
                this.F4.OptionsColumn.AllowEdit = false;
                this.P4.OptionsColumn.AllowEdit = false;

                this.C5.OptionsColumn.AllowEdit = false;
                this.F5.OptionsColumn.AllowEdit = false;
                this.P5.OptionsColumn.AllowEdit = false;

                this.C6.OptionsColumn.AllowEdit = false;
                this.F6.OptionsColumn.AllowEdit = false;
                this.P6.OptionsColumn.AllowEdit = false;

                this.C7.OptionsColumn.AllowEdit = false;
                this.F7.OptionsColumn.AllowEdit = false;
                this.P7.OptionsColumn.AllowEdit = false;

                this.C8.OptionsColumn.AllowEdit = false;
                this.F8.OptionsColumn.AllowEdit = false;
                this.P8.OptionsColumn.AllowEdit = false;

                this.C9.OptionsColumn.AllowEdit = false;
                this.F9.OptionsColumn.AllowEdit = false;
                this.P9.OptionsColumn.AllowEdit = false;

                this.C10.OptionsColumn.AllowEdit = false;
                this.F10.OptionsColumn.AllowEdit = false;
                this.P10.OptionsColumn.AllowEdit = false;

                this.C11.OptionsColumn.AllowEdit = false;
                this.F11.OptionsColumn.AllowEdit = false;
                this.P11.OptionsColumn.AllowEdit = false;

                this.C12.OptionsColumn.AllowEdit = false;
                this.F12.OptionsColumn.AllowEdit = false;
                this.P12.OptionsColumn.AllowEdit = false;

                this.C13.OptionsColumn.AllowEdit = false;
                this.F13.OptionsColumn.AllowEdit = false;
                this.P13.OptionsColumn.AllowEdit = false;

                this.C14.OptionsColumn.AllowEdit = false;
                this.F14.OptionsColumn.AllowEdit = false;
                this.P14.OptionsColumn.AllowEdit = false;
            }
        
        }

        /// <summary>
        /// 更新列名
        /// </summary>
        private void ChengBandDesc()
        {
            List<string> list =clsPublic.GetDateArrangeList(dStart.DateTime, dEnd.DateTime);
            gbWeek.Caption = string.Format("第{0}周", clsPublic.GetWeekOfYear(dEnd.DateTime.AddDays(-6)));
            gbUpWeek.Caption = string.Format("第{0}周", clsPublic.GetWeekOfYear(dStart.DateTime));
            
            for (int i = 0; i < list.Count; i++)
            {
               
                switch (i + 1)
                {
                    case 1:
                        this.gbItem1.Caption = list[i];
                        break;
                    case 2:
                        this.gbItem2.Caption = list[i];
                        break;
                    case 3:
                        this.gbItem3.Caption = list[i];
                        break;
                    case 4:
                        this.gbItem4.Caption = list[i];
                        break;
                    case 5:
                        this.gbItem5.Caption = list[i];
                        break;
                    case 6:
                        this.gbItem6.Caption = list[i];
                        break;
                    case 7:
                        this.gbItem7.Caption = list[i];
                        break;
                    case 8:
                        this.gbItem8.Caption = list[i];
                        break;
                    case 9:
                        this.gbItem9.Caption = list[i];
                        break;
                    case 10:
                        this.gbItem10.Caption = list[i];
                        break;
                    case 11:
                        this.gbItem11.Caption = list[i];
                        break;
                    case 12:
                        this.gbItem12.Caption = list[i];
                        break;
                    case 13:
                        this.gbItem13.Caption = list[i];
                        break;
                    case 14:
                        this.gbItem14.Caption = list[i];
                        break;
                    default:
                        break;

                }
            }
        }
    
        /// <summary>
        /// 计划信息更新保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvBand_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Value != null)
            {
                Models.ys_WorkPlan md = new Models.ys_WorkPlan();
                md.StaffId = clsPublic.GetObjGUID(gvData.GetFocusedRowCellValue("StaffId"));
                md.StaffName = clsPublic.GetObjectString(gvData.GetFocusedRowCellValue("StaffName"));
                md.WorkDay=clsPublic.ToDateTime(((BandedGridColumn)e.Column).OwnerBand.Caption);
                md.OperatorId = Models.SqlHelper.Session._UserId;
                md.OperatorName = Models.SqlHelper.Session._FullName;
               
                var FileValue = e.Value.ToString();
                string FileName = e.Column.FieldName;

                switch (FileName.Substring(0, 1))
                {
                    case "F":
                        FileName = "FocusWork";md.FocusWork = FileValue;
                        break;
                    case "C":
                        FileName = "CheckPlan"; md.CheckPlan = FileValue;
                        break;
                    case "P":
                        FileName = "WorkPlan"; md.WorkPlan = FileValue;
                        break;
                }

                if (!manager.Save(md,FileName))
                {
                    clsPublic.ShowMessage(MessageBoxIcon.Error, "保存出错", Text);
                }
            }
        }

       /// <summary>
       /// 显示行号
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void gvBand_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 检查是否是本部门人行程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvData_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Value != null)
            {
                if (e.Column.OptionsColumn.AllowEdit == false)
                {
                    return;
                }
                var DeptId = clsPublic.GetObjGUID(gvData.GetFocusedRowCellValue("DepartmentId"));
                if (DeptId != Models.SqlHelper.Session._DepartmentId)
                {
                    e.Column.OptionsColumn.AllowEdit = false;
                    clsPublic.ShowMessage("系统不允许更改非本部人员行程计划！");
                }
                else
                {
                    e.Column.OptionsColumn.AllowEdit = true;
                }
            }
        }
    }
}
