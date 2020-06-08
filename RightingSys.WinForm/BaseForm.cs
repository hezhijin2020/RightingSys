using RightingSys.WinForm.Utility.cls;
using System;
using System.Linq;

namespace RightingSys.WinForm
{
    public partial class BaseForm : DevExpress.XtraEditors.XtraForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        #region 声明变量、功能ID（FuncId）、可用的功能权限（activeBtns）、
        public string FuncId = Guid.Empty.ToString();
        public Guid sFuncId = Guid.Empty;
        public FeatureButton[] activeBtns;

        public IMainForm Mainform { get; set; }


        #endregion

        #region  窗体方法初始化方法

        public virtual void InitFeatureButton()
        {

        }

        protected void SetFeatureButton(params FeatureButton[] buttons)
        {
            if (this.Mainform == null)
            {
                return;
            }
           // if ("" != sFuncId && "00000000-0000-0000-0000-000000000000" != sFuncId)
           if(sFuncId!=null&&sFuncId!=Guid.Empty)
            {
                buttons = this.GetValidFeatureButton(buttons);
            }
            this.activeBtns = buttons;
            this.Mainform.SetFeatureButton(buttons);
        }

        private FeatureButton[] GetValidFeatureButton(FeatureButton[] btns)
        {
            System.Collections.Generic.List<FeatureButton> list = new System.Collections.Generic.List<FeatureButton>();
            if (btns != null && 0 <= btns.Length && this.Mainform != null)
            {
                for (int i = 0; i < btns.Length; i++)
                {
                    FeatureButton featureButton = btns[i];
                    if (featureButton == FeatureButton.Cancel || featureButton == FeatureButton.Save)
                    {
                        list.Add(featureButton);
                    }
                    else if (featureButton == FeatureButton.Add)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Add))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.Approve)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Approve))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.Delete)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Delete))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.Export)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Export))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.Import)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Import))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.Modify)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Modify))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.Preview)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Preview))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.Print)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Print))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.Query)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Query))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.UnApprove)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.UnApprove))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.First)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Query))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.Previous)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Query))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.Next)
                    {
                        if (this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Query))
                        {
                            list.Add(featureButton);
                        }
                    }
                    else if (featureButton == FeatureButton.Last && this.Mainform.UserHasRightNew(sFuncId, FeatureButton.Query))
                    {
                        list.Add(featureButton);
                    }
                }
            }
            return list.ToArray();
        }

        protected void SetFeatureButton(bool NoAuth, params FeatureButton[] buttons)
        {
            if (!NoAuth)
            {
                this.SetFeatureButton(buttons);
                return;
            }
            if (this.Mainform == null)
            {
                return;
            }
            this.activeBtns = buttons;
            this.Mainform.SetFeatureButton(buttons);
        }

        #endregion

        #region 编辑工具栏虚拟方法
        public virtual void AddNew()
        {
        }

        public virtual void Delete()
        {
        }

        public virtual void Query()
        {
        }

        public virtual void Modify()
        {
        }

        public virtual void Cancel()
        {
        }

        public virtual void Save()
        {
        }

        public virtual void Approve()
        {
        }

        public virtual void UnApprove()
        {
        }

        public virtual void Import()
        {
        }

        public virtual void Export()
        {
        }

        public virtual void Preview()
        {
        }

        public virtual void Print()
        {
        }

        public virtual void First()
        {
        }

        public virtual void Previous()
        {
        }

        public virtual void Next()
        {
        }

        public virtual void Last()
        {
        }
        #endregion

        #region MessageBox消息提示方法

        #endregion
    }
}
