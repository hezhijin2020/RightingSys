﻿using RightingSys.WinForm.Utility.cls;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    public partial class FBlackIP : BaseForm
    {
        BLL.BlackIPManager blackIPManager = new BLL.BlackIPManager();
        List<Models.ACL_BlackIP> lsSource = new List<Models.ACL_BlackIP>();
        public FBlackIP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 功能初始化
        /// </summary>
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[] { FeatureButton.Add,FeatureButton.Modify,FeatureButton.Delete, FeatureButton.Query });
        }

        /// <summary>
        /// 新增规则
        /// </summary>
        public override void AddNew()
        {
            FBlackIP_User sub = new FBlackIP_User();
            if (sub.ShowDialog() == DialogResult.OK)
            {
                Query();
            }
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        public override void Modify()
        {
            object id = gvBlackIP.GetFocusedRowCellValue("Id");
            if (id != null)
            {
                var BlackIPId = clsPublic.GetObjGUID(id);
                Models.ACL_BlackIP md = lsSource.FirstOrDefault(a => a.Id == BlackIPId);

                FBlackIP_User sub = new FBlackIP_User(md);
                if (sub.ShowDialog() == DialogResult.OK)
                {
                    Query();
                }
            }
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        public override void Delete()
        {
            object id = gvBlackIP.GetFocusedRowCellValue("Id");
            if (id != null)
            {
                if (blackIPManager.Delete(clsPublic.GetObjGUID(id)))
                {
                    if (clsPublic.GetMessageBoxYesNoResult("是否删除该记录？", Text))
                    {
                        clsPublic.ShowMessage("删除成功", Text);
                    }
                }
            }
        }

        /// <summary>
        /// 查询规则
        /// </summary>
        public override void Query()
        {
            gcBlackIP.DataSource = lsSource= blackIPManager.GetAllList();
        }

        /// <summary>
        /// 自定义显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvBlackIP_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "AuthorizeType")
            {
                e.DisplayText =e.Value.ToString() =="1" ?"白名单" : "黑名单";
            }
            if (e.Column.FieldName == "IsEnabled")
            {
                e.DisplayText = e.Value.ToString() == "1" ? "已启用" : "未启用";
            }
        }
    }
}