using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
namespace RightingSys.BLL
{
    public class RightingSysManager
    {

        DAL.RightingSysService ser = new DAL.RightingSysService();
        /// <summary>
        /// 根据用户ID获取用户权限列表
        /// </summary>
        /// <param name="guidUserId">用户ID</param>
        /// <returns>用户列表</returns>
        public  DataTable GetUserFunction(Guid sysetemId, Guid userId, Guid departmentId)
        {
            return ser.GetUserFunction(sysetemId, userId, departmentId);
        }

        /// <summary>
        /// 根据用户ID获取用户权限列表
        /// </summary>
        /// <param name="sysetemId">系统Id</param>
        /// <param name="userId">用户Id</param>
        /// <param name="departmentId">部门Id</param>
        /// <returns></returns>
        public List<Models.ACL_Role_Function> GetUserFunctionList(Guid sysetemId, Guid userId, Guid departmentId)
        {
            return ser.GetUserFunctionList(sysetemId, userId, departmentId).ToList();
        }

            /// <summary>
            /// 根据用户和密码获取用户信息
            /// </summary>
            /// <param name="LoginName">用户名</param>
            /// <param name="LoginPwd">密码</param>
            /// <returns>用户信息</returns>
            public  DataTable GetUserInfo(string LoginName, string LoginPwd)
        {
            return ser.GetUserInfo(LoginName,LoginPwd);
        }

        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="userID">用户ID</param>
        /// <param name="oldPwd">原密码</param>
        /// <param name="newPwd">新密码</param>
        public  bool ModifyUserPwd(Guid userId, String oldPwd, string newPwd)
        {
            return ser.ModifyUserPwd(userId, oldPwd, newPwd);
        }

    }
}
