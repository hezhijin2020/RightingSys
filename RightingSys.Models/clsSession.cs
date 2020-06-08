using System;
using System.Collections.Generic;

namespace RightingSys.Models
{
    /// <summary>
    /// 用户会话信息
    /// </summary>
    public class clsSession
    {
        /// <summary>
        /// Ini配置文件路径
        /// </summary>
        public string _IniConigPath { get;  set; }

        /// <summary>
        /// AppConfig.xml文件路径
        /// </summary>
        public  string _AppConfigPath { get;  set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public  Guid _UserId { get;  set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public  string _LoginName { get;  set; }
         /// <summary>
        /// 用户密码
         /// </summary>
        public  string _LoginPwd { get;  set; }

        /// <summary>
        /// 是否记住密码
        /// </summary>
        public  bool _IsRemPwd { get;  set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public  string _FullName { get;  set; }

        /// <summary>
        /// 问题ID
        /// </summary>
        public  Guid _DepartmentId { get;  set; }

        /// <summary>
        /// 部门
        /// </summary>
        public  string _DepartmentName { get;  set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        public List<Guid> _RoleIds { get;  set; } = null;

        /// <summary>
        /// 角色列表
        /// </summary>
        public List<Guid> _RoleNames { get;  set; } = null;

        /// <summary>
        /// 系统ID
        /// </summary>
        public  Guid _SystemId { get;  set; }=Guid.Parse("f770f9f8-96f0-46a6-a8ec-b2b43657126c");

        /// <summary>
        /// 系统名称
        /// </summary>
        public  string _SystemName { get;  set; }= "企业信息化管理系统";

        /// <summary>
        /// 登录电脑IP
        /// </summary>
        public  string _IPAddress { get;  set; }

        /// <summary>
        /// 登录电脑的Mac地址
        /// </summary>
        public  string _MACAddress { get;  set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public clsSession()
        {
        }

       /// <summary>
       /// 构造函数
       /// </summary>
        public clsSession(string IniConigPath, 
            Guid UserId,
            string LoginName, 
            string LoginPwd, 
            bool IsRemPwd, 
            string FullName,
            Guid DepartmentId,
            string DepartmentName,
            string IPAddress, 
            string MACAddress,
            Guid SystemId,
            string SystemName,
            List < Guid > RoleIds,
            List<Guid> RoleNames)
        {
            _IniConigPath = IniConigPath;
            _UserId = UserId;
            _LoginName = LoginName;
            _LoginPwd = LoginPwd;
            _IsRemPwd = IsRemPwd;
            _FullName = FullName;
            _DepartmentId = DepartmentId;
            _DepartmentName = DepartmentName;
            _RoleIds = RoleIds;
            _RoleNames = RoleNames;
            _SystemId = SystemId;
            _SystemName = SystemName;
            _IPAddress = IPAddress;
            _MACAddress = MACAddress;
        }
        /// <summary>
        /// 构造函数
        /// </summary>

        public clsSession(
            string IniConigPath,
            Guid UserId,
            string LoginName,
            string LoginPwd,
            bool IsRemPwd,
            string FullName,
            Guid DepartmentId,
            string DepartmentName,
            string IPAddress,
            string MACAddress,
            Guid SystemId,
            string SystemName)
        {
            _IniConigPath = IniConigPath;
            _UserId = UserId;
            _LoginName = LoginName;
            _LoginPwd = LoginPwd;
            _IsRemPwd = IsRemPwd;
            _FullName = FullName;
            _DepartmentId = DepartmentId;
            _DepartmentName = DepartmentName;
            _SystemId = SystemId;
            _SystemName = SystemName;
            _IPAddress = IPAddress;
            _MACAddress = MACAddress;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public clsSession(
            string IniConigPath,
            Guid UserId,
            string LoginName,
            string LoginPwd,
            bool IsRemPwd,
            string FullName,
            Guid DepartmentId,
            string DepartmentName,
            string IPAddress,
            string MACAddress)
        {
            _IniConigPath = IniConigPath;
            _UserId = UserId;
            _LoginName = LoginName;
            _LoginPwd = LoginPwd;
            _IsRemPwd = IsRemPwd;
            _FullName = FullName;
            _DepartmentId = DepartmentId;
            _DepartmentName = DepartmentName;
            _IPAddress = IPAddress;
            _MACAddress = MACAddress;
        }

        /// <summary>
        /// 初始化方法
        /// </summary>
        public void SessionIntial()
        {
            _UserId = Guid.Empty;
            _LoginPwd = "";
            _IsRemPwd = false;
            _LoginName = "";
            _FullName = "";
            _DepartmentId = Guid.Empty;
            _DepartmentName = "";
            _RoleIds = null;
            _RoleNames = null;
        }
    }
}
