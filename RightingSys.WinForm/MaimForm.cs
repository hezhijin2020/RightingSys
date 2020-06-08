using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using RightingSys.WinForm.Utility.cls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RightingSys.WinForm
{
    public partial class MainForm :DevExpress.XtraBars.Ribbon.RibbonForm,IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FrmMain_MdiChildActivate(object sender, System.EventArgs e)
        {
            this.currentForm = (base.ActiveMdiChild as BaseForm);
            if (this.currentForm == null)
            {
                this.SetEditPageVisible(false);
                return;
            }
            DisableButtons();
            this.currentForm.InitFeatureButton();
            this.SetEditPageVisible(true);
            this.MainRibbon.SelectedPage = this.pageEditor;
        }

        public int GetMenuHeight()
        {
            return this.MainRibbon.Height;
        }
        public Form[] GetMDIChildren()
        {
            return base.MdiChildren;
        }

        #region  声明变量

        private RightingSys.BLL.RightingSysManager _appRight = new RightingSys.BLL.RightingSysManager();
        private int AlertHoldTime = 3;
        private bool TriggerPageChanged = false;
        private DevExpress.XtraBars.Ribbon.RibbonPage FunctionPage=null;
        private bool CurrentUserIsAdmin = false;
        private static DataTable dtUserFunction = null;
        private static List<Models.ACL_Role_Function> ListUserFuntions =null;
        private RightingSys.WinForm.SubForm.pageSystem.LoginForm LoginForm=null;
        private BaseForm currentForm;

        private bool _MenuInited=false;

        private bool _LoginedIn = false;
        public bool LoginedIn { get => _LoginedIn; set => _LoginedIn = value; }
        public bool MenuInited { get => _MenuInited; set => _MenuInited = value; }


        #endregion

        #region  信息提示
        public void MdiShow(BaseForm frm, object FuncId)
        {
            this.MdiShow(frm, FuncId, false);
        }

        public void MdiShow(BaseForm frm, object FuncId, bool ReStart = false)
        {
            try
            {
                System.Windows.Forms.Form[] mdiChildren = base.MdiChildren;
                for (int i = 0; i < mdiChildren.Length; i++)
                {
                    System.Windows.Forms.Form form = mdiChildren[i];
                    if (!ReStart)
                    {
                        if (form.GetType().Equals(frm.GetType()))
                        {
                            form.Activate();
                            form.Show();
                            frm.Dispose();
                            return;
                        }
                    }
                    else if (form.GetType().Equals(frm.GetType()))
                    {
                        form.Close();
                        form.Dispose();
                    }
                }
                string objectString =  clsPublic.GetObjectString(FuncId);
                if (!string.IsNullOrEmpty(objectString))
                {
                    frm.sFuncId =Guid.Parse(objectString);
                }
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                frm.MdiParent = this;
                frm.KeyPreview = true;
                frm.Mainform = this;
                frm.InitFeatureButton();
                frm.Show();
            }
            catch (System.Exception ex)
            {
                //DBhelper.clsPublic.ShowException(ex, this.Text);
                //DBhelper.OpSysLog.WriteErrorLog(Text, ex.Message, DBhelper.Global.LoginName);
            }
        }

        public void MdiShow2(BaseForm frm)
        {
            try
            {
                System.Windows.Forms.Form[] mdiChildren = base.MdiChildren;
                for (int i = 0; i < mdiChildren.Length; i++)
                {
                    System.Windows.Forms.Form form = mdiChildren[i];
                    if (form.GetType().Equals(frm.GetType()))
                    {
                        form.Activate();
                        form.Show();
                        frm.Dispose();
                        return;
                    }
                }
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                frm.MdiParent = this;
                frm.KeyPreview = true;
                frm.Mainform = this;
                frm.InitFeatureButton();
                frm.Show();
            }
            catch (System.Exception ex)
            {
                //DBhelper.clsPublic.ShowException(ex, this.Text);
                // DBhelper.OpSysLog.WriteErrorLog(Text, ex.Message, DBhelper.Global.LoginName);
            }
        }
        #endregion

        #region 用户中权限获取、启用、授权提示方法

        public void SetEditPageVisible(bool Visible)
        {
            this.pageEditor.Visible = Visible;
        }
        public void RestorePage()
        {
            try
            {
                this.TriggerPageChanged = false;
                if (this.FunctionPage != null)
                {
                    this.MainRibbon.SelectedPage = this.FunctionPage;
                }
            }
            finally
            {
                this.TriggerPageChanged = true;
            }
        }
        public void SetFeatureButton(params FeatureButton[] btns)
        {
            if (btns != null)
            {
                this.DisableButtons();
                for (int i = 0; i < btns.Length; i++)
                {
                    FeatureButton code = btns[i];
                    this.SetButtonEnableByCode(code, true);
                }
            }
        }
        public void DisableButtons()
        {
            base.Invoke(new EventHandler(delegate
            {
                this.barAddNew.Enabled = (this.barQuery.Enabled = (this.barModify.Enabled = (this.barDelete.Enabled = (this.barCancel.Enabled = (this.barSave.Enabled = (this.barApprove.Enabled = (this.barUnApprove.Enabled = (this.barImport.Enabled = (this.barExport.Enabled = (this.barPreview.Enabled = (this.barPrint.Enabled = (this.barFirst.Enabled = (this.barPrevious.Enabled = (this.barNext.Enabled = (this.barLast.Enabled = false)))))))))))))));
            }));
        }

        public bool OperFuncVeifyNew(Guid FuncId)
        {
            if (this.CurrentUserIsAdmin)
            {
                return true;
            }
            if (MainForm.ListUserFuntions == null)
            {
                MainForm.ListUserFuntions = this.InitUserFunctionNew(clsSession._SystemId, clsSession._UserId, clsSession._DepartmentId);
            }
            return MainForm.ListUserFuntions.FirstOrDefault(s=>s.FunctionId==FuncId)!= null;
        }

        //public bool OperFuncVeify(string pfunctionKey)
        //{
        //    if (this.CurrentUserIsAdmin)
        //    {
        //        return true;
        //    }
        //    if (MainForm.dtUserFunction == null)
        //    {
        //        MainForm.dtUserFunction = this.InitUserFunction(clsSession._SystemId, clsSession._UserId, clsSession._DepartmentId);
        //    }
        //    return MainForm.dtUserFunction.Rows.Find(new System.Guid(pfunctionKey)) != null;
        //}
        //public bool UserHasRight(string guidFuncId)
        //{
        //    return this.UserHasRight(guidFuncId, FeatureButton.None);
        //}
        public bool UserHasRightNew(Guid FuncId)
        {
            return this.UserHasRightNew(FuncId, FeatureButton.None);
        }
        public bool UserHasRightNew(Guid guidFuncId, FeatureButton opCode)
        {
            if (this.CurrentUserIsAdmin)
            {
                return true;
            }
            List<int> Opcodes= this.GetUserOpCodeNew(guidFuncId);

            foreach(int m in Opcodes) {
                if (m <= 0)
                {
                    break;
                }
                int ia = (m & (int)opCode);
                bool flag = (m & (int)opCode) == (int)opCode;
                if (!flag && (opCode.Equals(FeatureButton.First) || opCode.Equals(FeatureButton.Last) || opCode.Equals(FeatureButton.Previous) || opCode.Equals(FeatureButton.Next)))
                {
                    int num = 2;
                    flag = ((m & num) == num);
                }
                if (flag)
                {
                    return flag;
                }
            }
            return false;
            
        }
        //public bool UserHasRight(string guidFuncId, FeatureButton opCode)
        //{
        //    if (this.CurrentUserIsAdmin)
        //    {
        //        return true;
        //    }
        //    MainForm.dtUserFunction.Rows.Find(System.Guid.Parse(guidFuncId));
        //    int userOpCode = this.GetUserOpCode(guidFuncId);
        //    if (userOpCode < 0)
        //    {
        //        return false;
        //    }
        //    int ia = (userOpCode & (int)opCode);
        //    bool flag = (userOpCode & (int)opCode) == (int)opCode;
        //    if (!flag && (opCode.Equals(FeatureButton.First) || opCode.Equals(FeatureButton.Last) || opCode.Equals(FeatureButton.Previous) || opCode.Equals(FeatureButton.Next)))
        //    {
        //        int num = 2;
        //        flag = ((userOpCode & num) == num);
        //    }
        //    return flag;
        //}

        public void ShowNoRight(string guidFuncId)
        {

            MessageBox.Show("没权访问", Text);
            //string funcName = PosRighting.GetFuncName(guidFuncId);
           // clsPublic.ShowMessage(MSG_TYPE.ALERT, string.Format(YSPOS.MainForm_NoRight_OneParameter, funcName), this.Text);
        }
        public void ShowNoRight(string guidFuncId, FeatureButton opCode)
        {
            if (opCode == FeatureButton.None)
            {
                this.ShowNoRight(guidFuncId);
                return;
            }
        }

        public List<int> GetUserOpCodeNew(Guid FuncId)
        {
            List<int> Opcodes = new List<int>();
            if (MainForm.ListUserFuntions == null)
            {
                this.InitUserFunctionNew(clsSession._SystemId, clsSession._UserId, clsSession._DepartmentId);
            }
            Opcodes = MainForm.ListUserFuntions.FindAll(s => s.FunctionId == FuncId).Select(s => s.OpCode).ToList(); ;
            
            return Opcodes;
        }

        //public int GetUserOpCode(string guidFuncId)
        //{
        //    if (MainForm.dtUserFunction == null)
        //    {
        //        this.InitUserFunction(clsSession._SystemId, clsSession._UserId,clsSession._DepartmentId);
        //    }
        //    DataRow dataRow = MainForm.dtUserFunction.Rows.Find(System.Guid.Parse(guidFuncId));
        //    if (dataRow == null)
        //    {
        //        return -1;
        //    }
        //    return System.Convert.ToInt32(dataRow["OpCode"]);

        //}
        public void SetButtonEnableByCode(FeatureButton code, bool enabled)
        {
            if (code <= FeatureButton.Import)
            {
                if (code <= FeatureButton.Cancel)
                {
                    switch (code)
                    {
                        case FeatureButton.Add:
                            this.barAddNew.Enabled = enabled;
                            return;
                        case FeatureButton.Query:
                            this.barQuery.Enabled = enabled;
                            return;
                        case (FeatureButton)3:
                            break;
                        case FeatureButton.Modify:
                            this.barModify.Enabled = enabled;
                            return;
                        default:
                            if (code == FeatureButton.Delete)
                            {
                                this.barDelete.Enabled = enabled;
                                return;
                            }
                            if (code != FeatureButton.Cancel)
                            {
                                return;
                            }
                            this.barCancel.Enabled = enabled;
                            return;
                    }
                }
                else if (code <= FeatureButton.Approve)
                {
                    if (code == FeatureButton.Save)
                    {
                        this.barSave.Enabled = enabled;
                        return;
                    }
                    if (code != FeatureButton.Approve)
                    {
                        return;
                    }
                    this.barApprove.Enabled = enabled;
                    return;
                }
                else
                {
                    if (code == FeatureButton.UnApprove)
                    {
                        this.barUnApprove.Enabled = enabled;
                        return;
                    }
                    if (code != FeatureButton.Import)
                    {
                        return;
                    }
                    this.barImport.Enabled = enabled;
                    return;
                }
            }
            else if (code <= FeatureButton.Print)
            {
                if (code == FeatureButton.Export)
                {
                    this.barExport.Enabled = enabled;
                    return;
                }
                if (code == FeatureButton.Preview)
                {
                    this.barPreview.Enabled = enabled;
                    return;
                }
                if (code != FeatureButton.Print)
                {
                    return;
                }
                this.barPrint.Enabled = enabled;
                return;
            }
            else if (code <= FeatureButton.Previous)
            {
                if (code == FeatureButton.First)
                {
                    this.barFirst.Enabled = enabled;
                    return;
                }
                if (code != FeatureButton.Previous)
                {
                    return;
                }
                this.barPrevious.Enabled = enabled;
                return;
            }
            else
            {
                if (code == FeatureButton.Next)
                {
                    this.barNext.Enabled = enabled;
                    return;
                }
                if (code != FeatureButton.Last)
                {
                    return;
                }
                this.barLast.Enabled = enabled;
            }



        }
        #endregion

        #region 系统右下角状态栏提示控件 （NotifyIcon）相关方法

        /* 关闭子窗体时数据是否保存
         * public void SetDontAlertWhenExit(bool Val)
        {
            this.DontAlertWhenExit = Val;
            if (this.DontAlertWhenExit)
            {
                System.Windows.Forms.Form[] mdiChildren = base.MdiChildren;
                for (int i = 0; i < mdiChildren.Length; i++)
                {
                    System.Windows.Forms.Form form = mdiChildren[i];
                }
            }
        }
        public bool GetDontAlertWhenExit()
        {
            return this.DontAlertWhenExit;
        }
        */

        private void ntyAlert_BalloonTipClicked(object sender, System.EventArgs e)
        {
            // clsPublic.ExecuteNoException(new dele_SimpleDo(this.doOpenAlert));
        }
        private void ntyAlert_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //clsPublic.ExecuteNoException(new dele_SimpleDo(this.doOpenAlert));
        }
        public void ShowAlertInfo(string Title, string Text, System.Windows.Forms.ToolTipIcon IconType)
        {
            this.ntyAlert.ShowBalloonTip(this.AlertHoldTime * 1000, Title, Text, IconType);
        }
        public void ShowAlertInfo(string Title, string Text)
        {
            this.ntyAlert.ShowBalloonTip(this.AlertHoldTime * 1000, Title, Text, System.Windows.Forms.ToolTipIcon.Info);
        }
        #endregion
        
        #region 编辑工具栏方法
        public void PerformAddNew()
        {
            this.btnAddNew_ItemClick(null, null);
        }

        public void PerformDelete()
        {
            this.btnDelete_ItemClick(null, null);
        }

        public void PerformQuery()
        {
            this.btnQuery_ItemClick(null, null);
        }

        public void PerformModify()
        {
            this.btnModify_ItemClick(null, null);
        }

        public void PerformCancel()
        {
            this.btnCancel_ItemClick(null, null);
        }

        public void PerformSave()
        {
            this.btnSave_ItemClick(null, null);
        }

        public void PerformApprove()
        {
            this.btnApprove_ItemClick(null, null);
        }

        public void PerformUnApprove()
        {
            this.btnUnApprove_ItemClick(null, null);
        }

        public void PerformImport()
        {
            this.btnImport_ItemClick(null, null);
        }

        public void PerformExport()
        {
            this.btnExport_ItemClick(null, null);
        }

        public void PerformPreview()
        {
            this.btnPreview_ItemClick(null, null);
        }

        public void PerformPrint()
        {
            this.btnPrint_ItemClick(null, null);
        }

        public void PerformFirst()
        {
            this.btnFirst_ItemClick(null, null);
        }

        public void PerformPrevious()
        {
            this.btnPre_ItemClick(null, null);
        }

        public void PerformNext()
        {
            this.btnNext_ItemClick(null, null);
        }

        public void PerformLast()
        {
            this.btnLast_ItemClick(null, null);
        }

        private void btnAddNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barAddNew.Enabled)
            {
                this.currentForm.AddNew();
            }
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barDelete.Enabled)
            {
                this.currentForm.Delete();
            }
        }

        private void btnQuery_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barQuery.Enabled)
            {
                this.currentForm.Query();
            }
        }

        private void btnModify_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barModify.Enabled)
            {
                this.currentForm.Modify();
            }
        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barCancel.Enabled)
            {
                this.currentForm.Cancel();
            }
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barSave.Enabled)
            {
                this.currentForm.Save();
            }
        }

        private void btnApprove_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barApprove.Enabled)
            {
                this.currentForm.Approve();
            }
        }

        private void btnUnApprove_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barUnApprove.Enabled)
            {
                this.currentForm.UnApprove();
            }
        }

        private void btnImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barImport.Enabled)
            {
                this.currentForm.Import();
            }
        }

        private void btnExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barExport.Enabled)
            {
                this.currentForm.Export();
            }
        }

        private void btnPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barPreview.Enabled)
            {
                this.currentForm.Preview();
            }
        }

        private void btnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barPrint.Enabled)
            {
                this.currentForm.Print();
            }
        }

        private void btnFirst_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barFirst.Enabled)
            {
                this.currentForm.First();
            }
        }

        private void btnPre_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barPrevious.Enabled)
            {
                this.currentForm.Previous();
            }
        }

        private void btnNext_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barNext.Enabled)
            {
                this.currentForm.Next();
            }
        }

        private void btnLast_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.currentForm != null && this.barLast.Enabled)
            {
                this.currentForm.Last();
            }
        }
        #endregion
       
        #region 登录方法

        private void doLogin()
        {
            this.Invoke((EventHandler)delegate
            {
                LoginForm = new SubForm.pageSystem.LoginForm(_appRight);
                if (this.LoginForm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    this.pageEditor.Visible = false;
                    this.pageSystem.Visible = true;
                    this.MainRibbon.SelectedPage = this.pageSystem;
                    this.LoginedIn = false;
                    this.btnUserLogout.Caption = "用户登录";
                    return;
                }
                else
                {
                    this.CloseAllWin();
                    this.btnUserLogout.Caption = "用户注销";
                    this.LoginedIn = true;
                }
                this.Init();
                
            });
        }
        private void CloseAllWin()
        {
            foreach (BaseForm sub in base.MdiChildren)
            {
                sub.Dispose();
            }
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this._LoginedIn)
            {
                clsPublicLogs.AddNewLoginLog(false);
            }
            Application.ExitThread();
            Application.Exit();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            InitialUserSkin();
            CloseAllWin();
            Menu_Null();
            if (this.LoginForm != null)
            {
                this.LoginForm = null;
            }
            try
            {
               Thread ThLogin = new Thread(doLogin);
               ThLogin.Start();
            }
            catch (System.Exception ex)
            {
               // DBhelper.OpSysLog.WriteErrorLog(this.Text, ex.Message);
                  clsPublic.ShowException(ex, this.Text);
            }
            finally
            {
                if (this.LoginForm != null)
                {
                    this.LoginForm.Dispose();
                    this.LoginForm = null;
                }
            }
            this.TriggerPageChanged = true;
            this.MainRibbon.SelectedPage = this.pageSystem;
            this.SetEditPageVisible(false);
        }
        public void Init()
        {
            MainForm.ListUserFuntions = null;
            this.InitUserFuncNew();
            this.Menu_Init();
        }
        public List<Models.ACL_Role_Function> InitUserFunctionNew(Guid pSystemId, Guid pUserId, Guid pDepartmentId)
        {
            MainForm.ListUserFuntions = _appRight.GetUserFunctionList(pSystemId, pUserId, pDepartmentId);
            return MainForm.ListUserFuntions;
        }
        public DataTable InitUserFunction(Guid pSystemId, Guid pUserId,Guid pDepartmentId)
        {
            MainForm.dtUserFunction = _appRight.GetUserFunction(pSystemId,pUserId,pDepartmentId);
            //MainForm.dtUserFunction.PrimaryKey = new DataColumn[]
            //{
            //    MainForm.dtUserFunction.Columns["FunctionId"]
            //};
            return MainForm.dtUserFunction;
        }
        private void InitUserFunc()
        {
            this.InitUserFunction(clsSession._SystemId,clsSession._UserId,clsSession._DepartmentId);
            
        }

        public void InitUserFuncNew()
        {
            this.InitUserFunctionNew(clsSession._SystemId, clsSession._UserId, clsSession._DepartmentId);
        }
        private void Menu_Init()
        {
            base.Invoke(new EventHandler(delegate
            {
                if (clsSession._UserId != null && clsSession._UserId != Guid.Empty)
                {
                    this.StatusLoginName.Caption = "用户：" + clsSession._LoginName;
                    this.statusLogintime.Caption = DateTime.Now.ToString("yyyy年MM月dd HH:mm:ss dddd");
                    this.statusIP.Caption = "  登录IP：" + clsSession._IPAddress;
                    this.statusMac.Caption = "  登录MAC：" + clsSession._MACAddress;
                    this.statusFullName.Caption = "  真实姓名：" + clsSession._FullName;
                    try
                    {
                        this.Menu_Visible();
                        this.MenuInited = true;
                    }
                    catch (System.Exception ex)
                    {
                       clsPublic.ShowException(ex, this.Text);
                    }
                }
            }));
        }
        private void Menu_Null()
        {
            base.Invoke(new EventHandler(delegate
            {
                this.StatusLoginName.Caption = "用户：未验证";
                this.statusLogintime.Caption = DateTime.Now.ToString("yyyy年MM月dd HH:mm:ss dddd");
                this.statusIP.Caption = "  登录IP：" + clsSession._IPAddress;
                this.statusMac.Caption = "  登录MAC：" + clsSession._MACAddress;
                this.statusFullName.Caption = "  真实姓名：未验证";
                foreach (RibbonPage ribbonPage in this.MainRibbon.Pages)
                {
                    ribbonPage.Visible = false;
                }

                this.pageSystem.Visible = true;
                this.btnUserLogout.Visibility = BarItemVisibility.Always;
                this.btnAppExit.Visibility = BarItemVisibility.Always;
                this.btnModifyPwd.Visibility = BarItemVisibility.Never;

                this.pageHelper.Visible = true;
                this.btnAbout.Visibility = BarItemVisibility.Always;
                this.btnCalc.Visibility = BarItemVisibility.Always;
                this.btnNotepad.Visibility = BarItemVisibility.Always;
                this.btnstikynot.Visibility = BarItemVisibility.Always;
                this.pageEditor.Visible = false;

                if (this.LoginForm != null)
                {
                    this.LoginForm.SetFocus();
                }
            }));
        }
        private void Menu_Visible()
        {
            try
            {
                for (int i = 0; i < this.MainRibbon.Items.Count; i++)
                {
                    if ((this.MainRibbon.Items[i].Tag != null) && (this.MainRibbon.Items[i].Tag.ToString() != "NO") && (this.MainRibbon.Items[i] is BarButtonItem || this.MainRibbon.Items[i] is BarSubItem))
                    {
                        object tag = this.MainRibbon.Items[i].Tag;
                        object cass = this.MainRibbon.Items[i].Caption;
                        if (tag == null || tag.ToString().Trim() == "")
                        {
                            this.MainRibbon.Items[i].Visibility = BarItemVisibility.Always;
                        }
                        else
                        {
                            this.MainRibbon.Items[i].Visibility = (this.OperFuncVeifyNew(Guid.Parse(this.MainRibbon.Items[i].Tag.ToString().Trim()))?BarItemVisibility.Always:BarItemVisibility.Never);
                            //this.MainRibbon.Items[i].Visibility = (this.OperFuncVeify(this.MainRibbon.Items[i].Tag.ToString().Trim()) ? BarItemVisibility.Always : BarItemVisibility.Never);
                        }
                    }
                }
                foreach (RibbonPage ribbonPage in this.MainRibbon.Pages)
                {
                    object tag2 = ribbonPage.Tag;
                    if (tag2 == null || tag2.ToString().Trim() == "")
                    {
                        ribbonPage.Visible = false;
                    }
                    else
                    {
                       // ribbonPage.Visible = this.OperFuncVeify(ribbonPage.Tag.ToString().Trim());
                        ribbonPage.Visible = this.OperFuncVeifyNew(Guid.Parse(ribbonPage.Tag.ToString().Trim()));
                    }
                    if (ribbonPage.Visible)
                    {
                        int count = ribbonPage.Groups.Count;
                        for (int j = 0; j < count; j++)
                        {
                            this.DealPageGroupVisible(ribbonPage.Groups[j]);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
               // DBhelper.OpSysLog.WriteErrorLog(this.Text, ex.Message);
               // DBhelper.clsPublic.ShowException(ex, this.Text);
            }
            finally
            {
                this.pageEditor.Visible = false;
                this.pageSystem.Visible = true;
                this.pageHelper.Visible = true;
                this.MainRibbon.SelectedPage = this.pageSystem;
                //if (this.btnFunction.Visibility == BarItemVisibility.Always && (!Session.CurrentUserIsAdmin() || !YsposAppSetting.Instance.FuncMainMode))
                //{
                   // this.btnFunction.Visibility = BarItemVisibility.Never;
                //}
                //this.PageFund.Visible = false;
            }
        }
        private void DealPageGroupVisible(RibbonPageGroup rpg)
        {
            if (rpg == null)
            {
                return;
            }
            int count = rpg.ItemLinks.Count;
            for (int i = 0; i < count; i++)
            {
                BarItem item = rpg.ItemLinks[i].Item;
                if (item != null && item.Visibility == BarItemVisibility.Always)
                {
                    rpg.Visible = true;
                    return;
                }
            }
            rpg.Visible = false;
        }

        #endregion

        #region  菜单栏方法
        private void btnAppExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!clsPublic.GetMessageBoxYesNoResult("是否退出登录？", this.Text))
            {
                return;
            }
            Application.ExitThread();
            Application.Exit();
        }
        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!this._LoginedIn)
            {
                this.FrmMain_Load(null, null);
                return;
            }
            if (!clsPublic.GetMessageBoxYesNoResult("是否注销系统？", this.Text))
            {
                return;
            }
           // appLogs.Add_LoginLog("用户注销");
            this.CloseAllWin();
            clsSession.SessionIntial();
            this.Menu_Null();
            this.FrmMain_Load(null, null);
            this._LoginedIn = false;
        }
        private void btnOuSetup_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiShow(new RightingSys.WinForm.SubForm.pageBaseinfo.DepartmentForm(), btnOuSetup.Tag);
        }
        private void btnRoleSetup_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiShow(new RightingSys.WinForm.SubForm.pageBaseinfo.RoleForm(), btnRoleSetup.Tag);
        }
        private void btnFiledRightingSetup_ItemClick(object sender, ItemClickEventArgs e)
        {
            //MdiShow(new RightingSys.WinForm.SubForm.pageBaseinfo.FRole(), btnRoleSetup.Tag);
        }
        private void btnBlackIPorUser_ItemClick(object sender, ItemClickEventArgs e)
        {
           //MdiShow(new RightingSys.WinForm.SubForm.FingerPrint.MealForm(), btnBlackIP.Tag);
        }
        private void btnLoginLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiShow(new RightingSys.WinForm.SubForm.pageLogs.FLoginLogs(), btnLoginLog .Tag);
        }
        private void btnOpLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiShow(new RightingSys.WinForm.SubForm.pageLogs.FOprationLogs(), btnOpLog.Tag);
        }
        private void btnUserSetup_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiShow(new RightingSys.WinForm.SubForm.pageBaseinfo.UserForm(), btnUserSetup.Tag);
        }
        private void btnFuncSetup_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiShow(new RightingSys.WinForm.SubForm.pageBaseinfo.FunctionForm(), btnFuncSetup.Tag);
        }
        private void btnSystemSetup_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiShow(new RightingSys.WinForm.SubForm.pageBaseinfo.SystemForm(), btnSystemSetup.Tag);
        }
        private void btnCalc_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            System.Diagnostics.Process.Start("calc.exe");
        }
        private void btnNotepad_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
        private void btnstikynot_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }
        private void btnModifyPwd_ItemClick(object sender, ItemClickEventArgs e)
        {
            SubForm.pageSystem.FModifyUserPwd sub = new SubForm.pageSystem.FModifyUserPwd(_appRight);
            sub.ShowDialog();
        }
        #endregion

        #region 系统窗体主题
        private void InitialUserSkin()
        {
            string defaultSkinName = "Springtime";
            SkinHelper.InitSkinGallery(skinRibbon);
            defaultSkinName = clsPublic.ReadDefaultSkinName() == "" ? defaultSkinName : clsPublic.ReadDefaultSkinName();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(defaultSkinName);//skinName为皮肤名 
            skinRibbon.Caption = "主题：" + defaultSkinName;
        }
        private void skinRibbon_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            string name = string.Empty;
            string caption = string.Empty;
            if (skinRibbon.Gallery == null) return;
            caption = skinRibbon.Gallery.GetCheckedItems()[0].Caption;//主题的描述
            clsPublic.WriteDefaultSkinName(caption);
            skinRibbon.Caption = "主题：" + caption + name;
        }


        #endregion

        private void btnMenuSetup_ItemClick(object sender, ItemClickEventArgs e)
        {
            //MdiShow(new RightingSys.WinForm.SubForm.FingerPrint.OrderMealAnalysisForm(), btnMenuManager.Tag);
        }
    }
}
