
using RightingSys.WinForm.Utility.cls;
using System;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    public partial class SystemForm :BaseForm
    {

        RightingSys.BLL.SystemManager sysMg = new RightingSys.BLL.SystemManager();
        public SystemForm()
        {
            InitializeComponent();
        }

        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[] { FeatureButton .Add,FeatureButton.Query,FeatureButton.Modify,FeatureButton.Delete});
        }

        /// <summary>
        /// 新增系统
        /// </summary>
        public override void AddNew()
        {
            SystemEditForm sub = new SystemEditForm();
            sub.Text = "新增-" + sub.Text;
            sub.ShowDialog();
            Query(); 
        }

        /// <summary>
        /// 修改系统
        /// </summary>
        public override void Modify()
        {
            if (mygvData.FocusedRowHandle >= 0)
            {
                Guid Id = Guid.Parse(mygvData.GetFocusedRowCellValue("Id").ToString());
                SystemEditForm sub = new SystemEditForm(Id);
                sub.Text = "修改-" + sub.Text;
                if (sub.ShowDialog() == DialogResult.OK)
                {
                    Query();
                }
            }
        }

        /// <summary>
        /// 删除系统
        /// </summary>
        public override void Delete()
        {
            if(mygvData.FocusedRowHandle >=0)
            {
               Guid Id= Guid.Parse( mygvData.GetFocusedRowCellValue("Id").ToString());
                if (clsPublic.GetMessageBoxYesNoResult("是否删除该记录？", "询问"))
                {
                    if (sysMg.Delete(Id))
                    {
                        Query();
                        clsPublic.ShowMessage("删除成功！", Text);
                    }
                    else
                    {
                        clsPublic.ShowMessage("系统出错！", Text);
                    }
                }
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        public override void Query()
        {
            mygcData.DataSource = sysMg.GetAllSystems();
        }


        /// <summary>
        ///右键菜单
        /// </summary>
        private void toolMenuSystemVersion_Click(object sender, EventArgs e)
        {
            if(mygvData.FocusedRowHandle>=0)
            {
                Guid _systemId = (Guid)mygvData.GetFocusedRowCellValue("Id");
                SystemVersionForm sub = new SystemVersionForm(_systemId);
                sub.ShowDialog();
            }
        }
    }
}
