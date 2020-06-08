using DevExpress.XtraTreeList.Nodes;
using RightingSys.WinForm.Utility.cls;
using RightingSys.WinForm.Utility.ToolForm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    public partial class UserForm : BaseForm
    {
        RightingSys.BLL.UserManager userMg = new RightingSys.BLL.UserManager();
        RightingSys.BLL.DepartmentManager deptMg = new RightingSys.BLL.DepartmentManager();
        RightingSys.BLL.FingerPrintManager fingerMg = new RightingSys.BLL.FingerPrintManager();
        List<Models.ACL_User> dtAll = null;
        public UserForm()
        {
            InitializeComponent();
            Initial();
        }
        private void Initial()
        {
            tlDepartment.DataSource = deptMg.GetAllList();
            //tl_Role.DataSource = bll.GetRoleInfo();
            Query();
        }

        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[] {
                FeatureButton.Add,
                FeatureButton.Query,
                FeatureButton.Modify,
                FeatureButton.Delete,
                FeatureButton.Import,
                FeatureButton.Export,
                FeatureButton.Preview,
                FeatureButton.Print });
        }
       
        public override void AddNew()
        {
            UserEditForm sub = new UserEditForm();
            sub.ShowDialog();
            Query();
        }

        public override void Query()
        {
            gcUser.DataSource = dtAll = userMg.GetAllList();
        }

        public override void Modify()
        {
            object obj_ID = gvUser.GetFocusedRowCellValue("Id");
            if (obj_ID != null)
            {
                UserEditForm sub = new UserEditForm((Guid)obj_ID);
                if (sub.ShowDialog() == DialogResult.OK)
                {
                    Query();
                }
            }
        }

        public override void Delete()
        {
            object obj_ID = gvUser.GetFocusedRowCellValue("Id");
            if (obj_ID != null)
            {
                if (MessageBox.Show("是否删除该用户？", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && userMg.Delete((Guid)obj_ID))
                {
                    Query();
                    MessageBox.Show("删除成功");
                }
            }
        }

        public override void Import()
        {
            clsPublic.GetOpenXlsFileName("");

            //string filePath = "文件完整的路径";
            //int sheetIndex = 1;//将要读取的Sheet页，从1开始
            //int startRow = 1;//开始读取的数据行，不包含表头，从1开始
            //string tableName = "对应数据库的名称，方便后续插入到数据库中";
            ////表格的列定义，想要输出多少列，就定义多少列
            //Dictionary<string, ExcelReader.DataTableColumnType> dtCols = new Dictionary<string, ExcelReader.DataTableColumnType>();
            //dtCols.Add("列名", ExcelReader.DataTableColumnType.Sys_DateTime);
            ////表格列 和 Excel表格列 的对应关系，必须和“表格的列定义”数量一致，且列名相同
            ////表格列 可以对应非 Excel表格列 的内容，目前仅支持 Guid 和 DataTime
            //Dictionary<string, ExcelReader.ExcelColumns> colsMap = new Dictionary<string, ExcelReader.ExcelColumns>();
            //colsMap.Add("列名", ExcelReader.ExcelColumns.Column_1);

            ////开始调用，获取表格
            //DataTable data = ExcelReader.GetExcelContent(filePath, sheetIndex, startRow, tableName, dtCols, colsMap);

        }

        public override void Export()
        {
            clsPublic.DevExprot(gcUser);
        }

        public override void Preview()
        {
            clsPublic.DevPreview(gcUser,"用户信息",true);
        }

        public override void Print()
        {
            base.Print();
        }

        #region 组织机构和角色树焦点改变事件,筛选用户信息
        private void tl_OU_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null&&dtAll!=null)
            {
                gcUser.DataSource = dtAll.FindAll(s=>s.DepartmentId==(Guid)e.Node.GetValue("Id"));
            }
        }

        private void tl_Role_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null && dtAll != null)
            {
                //dtAll.DefaultView.RowFilter = string.Format("RoleID='{0}'", e.Node.GetValue("ID"));
                //gcUser.DataSource = dtAll.DefaultView;
            }
        }

        private void GetNodChildrenID(TreeListNode node,ref string strListID)
        {
            strListID= strListID+",'" + node.GetValue("Id") + "'" ;

            foreach(TreeListNode n in node.Nodes)
            { 
                GetNodChildrenID(n, ref strListID);
            }
        }
        #endregion

        private void tabPaneView_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (e.Page.PageText == "tabpage_Dept")
            {
                tlDepartment.FocusedNode = null;
            }
            else
            {
                tlRole.FocusedNode = null;
            }
        }
        
        private void MenuFingerAdd_Click(object sender, EventArgs e)
        {
            Guid UserID =clsPublic.GetObjGUID(gvUser.GetFocusedRowCellValue("Id"));
            string FullName = clsPublic.GetObjectString(gvUser.GetFocusedRowCellValue("FullName"));
            string DepartmentName = clsPublic.GetObjectString(gvUser.GetFocusedRowCellValue("DepartmentName"));
            if (UserID != Guid.Empty)
            {
                UserFingerAdd cap = new UserFingerAdd(UserID,FullName,DepartmentName);
                cap.ShowDialog();
            }
        }

        private void MenuFingerClear_Click(object sender, EventArgs e)
        {
            Guid UserID = clsPublic.GetObjGUID(gvUser.GetFocusedRowCellValue("UserId"));
            if (UserID != Guid.Empty)
            {
                if (clsPublic.GetMessageBoxYesNoResult("是否清除该用户的指纹信息？",Text)&&fingerMg.Delete(UserID))
                {
                    clsPublic.ShowMessage("清除成功！", Text);
                }
                    
            }
        }

        private void MenuFingerVerification_Click(object sender, EventArgs e)
        {
            Guid UserID = clsPublic.GetObjGUID(gvUser.GetFocusedRowCellValue("Id"));
            if (UserID != Guid.Empty)
            {
                UserFingerMatching cap = new UserFingerMatching(UserID);
                cap.ShowDialog();
            }
        }

        private void MenuFingerMatching_Click(object sender, EventArgs e)
        {
           UserFingerMatching cap = new UserFingerMatching();
           cap.ShowDialog();
        }
    }
}
