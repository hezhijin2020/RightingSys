using RightingSys.WinForm.AppPublic.AutoService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    public partial class SystemVersionForm : BaseForm
    {
        private Guid _SystemId;
        private Models.ACL_System model = new Models.ACL_System();
        RightingSys.BLL.SystemManager systemMg = new RightingSys.BLL.SystemManager();
        public SystemVersionForm(Guid systemId)
        {
            InitializeComponent();
            _SystemId = systemId;
            model = systemMg.GetOneById(_SystemId);
        }

        private void gvData_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }


        XMLFile xmlHp = new XMLFile();
        List<FileUnit> list = new List<FileUnit>();
        private static string strFilePath = Application.StartupPath;
        private static string strFullName = strFilePath + "\\UpdateList.xml";
        //系统出初始化加载
      
        /// <summary>
        /// 显示配置信息
        /// </summary>
        public void ShowConfigFile()
        {
            list = xmlHp.GetFileList(strFilePath);
            XmlDocument Xml_config = new XmlDocument();
            Xml_config.Load(strFullName);
            txtFilePath.Text = strFilePath;
            txtUrl.Text = Xml_config.SelectSingleNode("AutoUpdate/Updater/Url").InnerText;
            txtVersion.Text = Xml_config.SelectSingleNode("AutoUpdate/Application/Version").InnerText;
            gcData.DataSource = list;
            //Version ver = new Version(txtVersion.Text);

            //if (ver.Build >= 99)
            //{
            //    if (ver.Minor >= 99)
            //    {
            //        txtVersion.Text = (new Version(ver.Major + 1, 1, 1)).ToString();
            //    }
            //    else
            //    {
            //        txtVersion.Text = (new Version(ver.Major, ver.Minor + 1, 1)).ToString();
            //    }
            //}
            //else
            //{
            //    txtVersion.Text = (new Version(ver.Major, ver.Minor, ver.Build + 1)).ToString();
            //}
        }

        //更新配置文件
        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime LastTime = DateTime.Now;
            xmlHp.UpdateHeader(txtVersion.Text, txtUrl.Text,LastTime, strFilePath);
            list = (List<FileUnit>)gcData.DataSource;
            xmlHp.UpdateFiles(list, strFilePath);
            model.URL = txtUrl.Text;
            model.Version = txtVersion.Text;
            model.LastTime = LastTime;
            WriteVersionToDB(model);
        }

      

        private void txtFilePath_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog s = new FolderBrowserDialog();
            if (DialogResult.OK == s.ShowDialog())
            {
                strFilePath = txtFilePath.Text = s.SelectedPath;
                strFullName = strFilePath + "\\UpdateList.xml";
                if (!File.Exists(strFullName))
                {
                    xmlHp.CreateFile(strFilePath,model.Id.ToString(),model.URL,model.SortCode);
                    xmlHp.UpdateFiles(list, strFilePath);
                }
                ShowConfigFile();
            }
        }

        private void SystemVersionForm_Load(object sender, EventArgs e)
        {
            txtUrl.Text = model.URL;
            txtVersion.Text = model.Version;
            txtSystemName.Text = model.SystemName;
        }


        #region

        public void WriteVersionToDB(Models.ACL_System model)
        {
            systemMg.ModifyVersion(model);
        }
        #endregion 
    }
}
