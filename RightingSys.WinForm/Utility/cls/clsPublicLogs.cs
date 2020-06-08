using RightingSys.WinForm.AppPublic;
using System;
using System.Data.SqlClient;

namespace RightingSys.WinForm.Utility.cls
{
    public class clsPublicLogs
    {
        private static readonly log4net.ILog appLog = log4net.LogManager.GetLogger("appLogs");
        private static readonly log4net.ILog LogOpration = log4net.LogManager.GetLogger("LogOpration");
        private static readonly log4net.ILog LogEvent = log4net.LogManager.GetLogger("LogEvent");
        private static readonly log4net.ILog LogSQL = log4net.LogManager.GetLogger("LogSQL");


        #region  程序的日志信息
        //一般日志信息
        public static void LogInfo(string msg)
        {
            if (appLog.IsInfoEnabled)
            {
                appLog.Info(msg);
            }
        }
        public static void LogInfo(string msg,Exception ex)
        {
            if (appLog.IsInfoEnabled)
            {
                appLog.Info(msg,ex);
            }
        }

        //调试日志信息
        public static void LogDebug(string msg)
        {
            if (appLog.IsDebugEnabled)
            {
                appLog.Debug(msg);
            }
        }
        public static void LogDebug(string msg, Exception ex = null)
        {
            appLog.Debug(msg, ex);
        }

        //错误日志信息
        public static void LogError(string msg)
        {
            if (appLog.IsErrorEnabled)
            {
                appLog.Error(msg);
            }
        }
        public static void LogError(string msg, Exception ex = null)
        {
            appLog.Error(msg, ex);
        }


        // 致命日志信息
        public static void LogFatal(string msg)
        {
            if (appLog.IsFatalEnabled)
            {
                appLog.Fatal(msg);
            }
        }
        public static void LogFatal(string msg, Exception ex = null)
        {
            appLog.Fatal(msg, ex);
        }

        //警告日志信息
        public static void LogWarn(string msg)
        {
            if (appLog.IsWarnEnabled)
            {
                appLog.Warn(msg);
            }
        }
        public static void LogWarn(string msg, Exception ex = null)
        {
            appLog.Warn(msg, ex);
        }

        #endregion

        #region  LogOpration
        public static void LogOpInfo(string OpName,DateTime OpDate)
        {
            string msg = string.Format(" --[操作名称]：{0} --[操作时间]：{1} --[用户]：{2} --[网卡MAC]：{3} --[网络IP]：{4} ",
                OpName,
                OpDate.ToString("yyyy-MM-dd HH:mm:ss"), 
                Models.SqlHelper.Session._LoginName, 
                Models.SqlHelper.Session._MACAddress,
                Models.SqlHelper.Session._IPAddress);

            if (LogOpration.IsInfoEnabled)
            {
                LogOpration.Info(msg);
            }
        }
        #endregion

        #region LogEvent

        public static void EventInfo(string msg)
        {
            if (LogEvent.IsInfoEnabled)
            {
                LogEvent.Info(msg);
            }
        }
        public static void EventDebug(string msg)
        {
            if (LogEvent.IsDebugEnabled)
            {
                LogEvent.Debug(msg);
            }
        }
        public static void EventError(string msg)
        {
            if (LogEvent.IsErrorEnabled)
            {
                LogEvent.Error(msg);
            }
        }
        public static void EventFatal(string msg)
        {

            if (LogEvent.IsFatalEnabled)
            {
                LogEvent.Fatal(msg);
            }
        }
        public static void EventWarn(string msg)
        {

            if (LogEvent.IsWarnEnabled)
            {
                LogEvent.Warn(msg);
            }
        }

        #endregion

        #region LogSQL

        public static void SQLInfo(string msg)
        {
            if (LogSQL.IsInfoEnabled)
            {
                LogSQL.Info(msg);
            }
        }
        public static void SQLDebug(string msg)
        {
            if (LogSQL.IsDebugEnabled)
            {
                LogSQL.Debug(msg);
            }
        }
        public static void SQLError(string msg)
        {
            if (LogSQL.IsErrorEnabled)
            {
                LogSQL.Error(msg);
            }
        }
        public static void SQLFatal(string msg)
        {

            if (LogSQL.IsFatalEnabled)
            {
                LogSQL.Fatal(msg);
            }
        }
        public static void SQLWarn(string msg)
        {

            if (LogSQL.IsWarnEnabled)
            {
                LogSQL.Warn(msg);
            }
        }
        #endregion
        
        #region SQL数据库操作日志
        
        /// <summary>
        /// 系统登录和退出日志
        /// </summary>
        /// <param name="LoginOrExit">登录或退出</param>
        public static void AddNewLoginLog(bool IsLoginOrExit=true)
        {
            try
            {
                var LogName = IsLoginOrExit ? "登录" : "退出";
                string sqlText = @"INSERT INTO [RightingSys].[dbo].[ACL_LoginLog]
                                               ([Id]
                                               ,[LogName]
                                               ,[UserId]
                                               ,[LoginName]
                                               ,[FullName]
                                               ,[DepartmentName]
                                               ,[DepartmentId]
                                               ,[LoginIP]
                                               ,[LoginMac]
                                               ,[SystemId]
                                               ,[SystemName])
                                         VALUES
                                               (@Id
                                               ,@LogName
                                               ,@UserId
                                               ,@LoginName
                                               ,@FullName
                                               ,@DepartmentName
                                               ,@DepartmentId
                                               ,@LoginIP
                                               ,@LoginMac
                                               ,@SystemId
                                               ,@SystemName)";

                SqlParameter s1 = new SqlParameter("@Id",Guid.NewGuid());
                SqlParameter s2 = new SqlParameter("@LogName", LogName);
                SqlParameter s3 = new SqlParameter("@UserId", Models.SqlHelper.Session._UserId);
                SqlParameter s4 = new SqlParameter("@LoginName", Models.SqlHelper.Session._LoginName);
                SqlParameter s5 = new SqlParameter("@FullName", Models.SqlHelper.Session._FullName);
                SqlParameter s6 = new SqlParameter("@DepartmentName", Models.SqlHelper.Session._DepartmentName);
                SqlParameter s7 = new SqlParameter("@DepartmentId", Models.SqlHelper.Session._DepartmentId);
                SqlParameter s8 = new SqlParameter("@LoginIP", Models.SqlHelper.Session._IPAddress);
                SqlParameter s9 = new SqlParameter("@LoginMac", Models.SqlHelper.Session._MACAddress);
                SqlParameter s10 = new SqlParameter("@SystemId", Models.SqlHelper.Session._SystemId);
                SqlParameter s11 = new SqlParameter("@SystemName", Models.SqlHelper.Session._SystemName);
                Models.SqlHelper.ExecuteNoQuery(sqlText, new SqlParameter[] { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11 });
                LogOpInfo(LogName, DateTime.Now);
            }
            catch (Exception e)
            {
                clsPublic.ShowException(e, "提示");
                appLog.Error(e.Message);
            }
}
       
        /// <summary>
        /// 系统操作日志
        /// </summary>
        /// <param name="sLogDesc">操作名称</param>
        /// <param name="OpTime">时间</param>
        /// <param name="sTableName">表名</param>
        /// <param name="sOperationType">类型</param>
        /// <param name="sSqlText">sqlCommond</param>
        public static void AddNewOperatorLog(string LogName, string TableName, string OperatorType, string SqlCommand)
        {
            try
            {
                string sqlText = @"INSERT INTO [RightingSys].[dbo].[ACL_OperationLog]
                                ([Id]
                                ,[LogName]
                                ,[UserId]
                                ,[LoginName]
                                ,[FullName]
                                ,[DepartmentName]
                                ,[DepartmentId]
                                ,[LoginIP]
                                ,[LoginMac]
                                ,[SystemId]
                                ,[SystemName]
                                ,[OperationType]
                                ,[SqlCommand]
                                ,[OperationTable])
                          VALUES
                                (@Id
                                ,@LogName
                                ,@UserId
                                ,@LoginName
                                ,@FullName
                                ,@DepartmentName
                                ,@DepartmentId
                                ,@LoginIP
                                ,@LoginMac
                                ,@SystemId
                                ,@SystemName
                                ,@OperationType
                                ,@SqlCommand
                                ,@OperationTable)";

                Models.SqlHelper.ExecuteNoQuery(sqlText, new SqlParameter[] {
                 new SqlParameter("@Id",Guid.NewGuid())
                ,new SqlParameter("@LogName",LogName )
                ,new SqlParameter("@UserId", Models.SqlHelper.Session._UserId)
                ,new SqlParameter("@LoginName", Models.SqlHelper.Session._LoginName)
                ,new SqlParameter("@FullName", Models.SqlHelper.Session._FullName)
                ,new SqlParameter("@DepartmentName", Models.SqlHelper.Session._DepartmentName)
                ,new SqlParameter("@DepartmentId", Models.SqlHelper.Session._DepartmentId)
                ,new SqlParameter("@LoginIP",Models.SqlHelper.Session._IPAddress)
                ,new SqlParameter("@LoginMac", Models.SqlHelper.Session._MACAddress)
                ,new SqlParameter("@SystemId", Models.SqlHelper.Session._SystemId)
                ,new SqlParameter("@SystemName", Models.SqlHelper.Session._SystemName)
                ,new SqlParameter("@OperationType", OperatorType)
                ,new SqlParameter("@OperationTable", TableName)
                ,new SqlParameter("@SqlCommand", SqlCommand) });

                LogOpInfo(LogName, DateTime.Now);
            }
            catch (Exception e)
            {
                clsPublic.ShowException(e, "提示");
                appLog.Error(e.Message);
            }
        }

        #endregion
    }
}
