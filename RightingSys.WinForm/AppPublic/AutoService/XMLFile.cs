using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Xml;

namespace RightingSys.WinForm.AppPublic.AutoService
{
    public class XMLFile
    {
        private string FileName = "UpdateList.xml";
        private string FilePath="";
        
        public List<FileUnit> GetFileList(string sFilePath)
        {
            FilePath = sFilePath;
            List<FileUnit> list = new List<FileUnit>();
            GetFileInf(sFilePath, ref list);
            return list;
        }

        public void GetFileInf(string sFilePath, ref List<FileUnit> list)
        {
            FileUnit unit = null;
            DirectoryInfo dir = new DirectoryInfo(sFilePath);
            if (!dir.Exists)
            { return ; }
            FileInfo[] infos= dir.GetFiles();
            DirectoryInfo[] subdir= dir.GetDirectories();
            foreach (FileInfo i in infos)
            {
                unit = new FileUnit();
                FileVersionInfo ver = FileVersionInfo.GetVersionInfo(i.FullName);
                if (i.Name == "web.config") break;
                unit.FileName = i.FullName.Replace(FilePath, "");
                unit.FileSize = i.Length;
                unit.FileVersion=ver.FileVersion;
                unit.LastTime = i.LastWriteTime.ToString("yyyy-MM-dd:HH:mm:ss");
                unit.IsFlag = true;
                list.Add(unit);
            }
            foreach (DirectoryInfo d in subdir)
            {
                GetFileInf(d.FullName, ref list);
            }
 
        }
        public void UpdateFiles(List<FileUnit> list, string sFilePath)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(sFilePath+"\\"+ FileName);

            XmlNode node = xml.SelectSingleNode("AutoUpdate/Files");
            node.RemoveAll();
            string sFileName = "";
            string sLastTime = "";
            string sver = "";
            string Ssize = "";
            foreach (FileUnit unit in list)
            {
                if (unit.IsFlag)
                {
                    sFileName = unit.FileName;
                    sLastTime = unit.LastTime;
                    sver = unit.FileVersion;
                    Ssize = unit.FileSize.ToString();

                    XmlElement e = xml.CreateElement("File");
                    e.SetAttribute("FileSize", Ssize);
                    e.SetAttribute("LastTime", sLastTime);
                    e.SetAttribute("Ver", sver);
                    e.SetAttribute("Name", sFileName);
                    node.AppendChild(e);
                }
            }
            xml.Save(sFilePath + "\\" + FileName);
        }
        public void UpdateHeader(string proVer,string UpdateUrl,DateTime LastTime,string sFilePath)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(sFilePath + "\\" + FileName);
            xml.SelectSingleNode("AutoUpdate/Updater/Url").InnerText=UpdateUrl;
            xml.SelectSingleNode("AutoUpdate/Updater/LastUpdateTime").InnerText = LastTime.ToString("yyyy-MM-dd HH:mm:ss");
            xml.SelectSingleNode("AutoUpdate/Application/Version").InnerText = proVer;
            xml.Save(sFilePath + "\\" + FileName);
        }
        public void CreateFile(string sFilePath,string SystemId,string Url,string AppName)
        {
            XmlDocument XmlConfigFile = new XmlDocument();

            #region 增加声明段落
            XmlDeclaration xmldecl = XmlConfigFile.CreateXmlDeclaration("1.0", "gb2312", null);
            XmlConfigFile.AppendChild(xmldecl);
            #endregion

            #region  加入根元素
            XmlElement root = XmlConfigFile.CreateElement("AutoUpdate");
            XmlConfigFile.AppendChild(root);
            #endregion

            #region 更新描述、更新时间、更新地址、添加节点、和程序版本信息

            XmlElement Description = XmlConfigFile.CreateElement("Description");
            Description.InnerText = "更新列表文件";
            root.AppendChild(Description);

            XmlElement Updater = XmlConfigFile.CreateElement("Updater");

            XmlElement UpdateUrl = XmlConfigFile.CreateElement("Url");
            UpdateUrl.InnerText = Url;
            Updater.AppendChild(UpdateUrl);

            XmlElement LastUpdateTime = XmlConfigFile.CreateElement("LastUpdateTime");
            LastUpdateTime.InnerText = "2020-01-01";
            Updater.AppendChild(LastUpdateTime);

            XmlElement Application = XmlConfigFile.CreateElement("Application");
            Application.SetAttribute("ApplicationId", SystemId);

            XmlElement xAppName = XmlConfigFile.CreateElement("EntryPoint");
            xAppName.InnerText =AppName ;
            Application.AppendChild(xAppName);

            XmlElement Location = XmlConfigFile.CreateElement("Location");
            Location.InnerText = ".";
            Application.AppendChild(Location);

            XmlElement Version = XmlConfigFile.CreateElement("Version");
            Version.InnerText = "1.0.0";
            Application.AppendChild(Version);
            root.AppendChild(Application);
            root.AppendChild(Updater);

            #endregion

            #region  文件信息写入

            XmlElement Files = XmlConfigFile.CreateElement("Files");
            root.AppendChild(Files);

            XmlConfigFile.Save(sFilePath + "\\" + FileName);

            #endregion

        }
    }
}
