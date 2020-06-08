using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RightingSys.WinForm.Utility.cls
{
    public class clsSession
    {
        public static string _IniConigPath = Application.StartupPath + "\\AppConfig.ini";
        public static string _AppConfigPath = Application.StartupPath + "\\AppConfig.ini";
        public static Guid _UserId;
        public static string _LoginName;
        public static string _LoginPwd;
        public static bool _IsRemPwd;
        public static string _FullName;
        public static Guid _DepartmentId;
        public static string _DepartmentName;
        public static List<Guid> _RoleIds;
        public static List<Guid> _RoleNames;
        public static Guid _SystemId = Guid.Parse("f770f9f8-96f0-46a6-a8ec-b2b43657126c");
        public static string _SystemName = "企业信息化管理系统";
        public static string _IPAddress = clsPublic.getLocalIP();
        public static string _MACAddress = clsPublic.getLocalMac();

        public static void SessionIntial()
        {
            _UserId = Guid.Empty;
            _LoginName = "";
            _FullName = "";
            _DepartmentId = Guid.Empty;
            _DepartmentName = "";
            _RoleIds = null;
            _RoleNames = null;
        }
    }
}
