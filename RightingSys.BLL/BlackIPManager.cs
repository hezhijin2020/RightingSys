using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.BLL
{
    public class BlackIPManager
    {

        DAL.BlackIPService Sev = new DAL.BlackIPService();
        /// <summary>
        /// 新增防火墙规则
        /// </summary>
        /// <param name="model">实体</param>
        /// <param name="userlist">用户列表</param>
        /// <returns></returns>
        public bool AddNew(Models.ACL_BlackIP model)
        {
            return Sev.AddNew(model);
        }


        /// <summary>
        /// 修改防火墙规则
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool Modify(Models.ACL_BlackIP model)
        {
            return Sev.Modify(model);
        }

        /// <summary>
        /// 删除防火墙规则
        /// </summary>
        /// <param name="BlackIP_ID">规则Id</param>
        /// <returns></returns>
        public bool Delete(Guid BlackIPId)
        {
            return Sev.Delete(BlackIPId);
        }


        /// <summary>
        /// 新增用户信息到规则
        /// </summary>
        /// <param name="list">用户列表</param>
        /// <returns></returns>
        public bool AddUserForBlackIP(List<Models.ACL_BlackIP_User> list)
        {
            return Sev.AddUserForBlackIP(list);
        }

        /// <summary>
        /// 移除用户信息
        /// </summary>
        /// <param name="Id">明细Id</param>
        /// <returns></returns>
        public bool RemoveUserForBlackIP(Guid Id)
        {
            return Sev.RemoveUserForBlackIP(Id);
        }

        /// <summary>
        /// 获取所有的规则信息
        /// </summary>
        /// <returns></returns>
        public List<Models.ACL_BlackIP> GetAllList()
        {
            return Sev.GetAllList().ToList() ;
        }


        /// <summary>
        /// 获取规则用户明细信息
        /// </summary>
        /// <param name="BlackIPId">规则Id</param>
        /// <returns></returns>
        public List<Models.ACL_User> GetUserByBlackIP(Guid BlackIPId)
        {
            return Sev.GetUserByBlackIP(BlackIPId);
        }
    }
}
