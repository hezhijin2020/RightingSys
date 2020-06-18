using System;
using System.Collections.Generic;
using System.Linq;

namespace RightingSys.BLL
{
    public class SystemManager
    {
        RightingSys.DAL.SystemService Sev = new DAL.SystemService();

        /// <summary>
        /// 新增系统授权
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(Models.ACL_System model)
        {
            return Sev.AddNew(model);
        }

        /// <summary>
        /// 修改系统信息
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool Modify(Models.ACL_System model)
        {
            return Sev.Modify(model);
        }

        /// <summary>
        /// 修改系统版本
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool ModifyVersion(Models.ACL_System model)
        {
            return Sev.ModifyVersion(model);
        }

        /// <summary>
        /// 删除系统信息（伪删除），系统下的所有功能也伪删除
        /// </summary>
        /// <param name="Id">系统ID</param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            return Sev.Delete(Id);
        }

        /// <summary>
        /// 获取所有系统
        /// </summary>
        /// <returns></returns>
        public List<Models.ACL_System> GetAllSystems()
        {
            return Sev.GetAllSystems().Where(s => s.IsRemoved == false).ToList();
        }
        
        /// <summary>
        /// 获取指定系统ID实体
        /// </summary>
        /// <returns></returns>
        public Models.ACL_System GetOneById(Guid Id)
        {
            return Sev.GetAllSystems().Where(s => s.IsRemoved == false).FirstOrDefault(a=>a.Id==Id);
        }

        /// <summary>
        /// 检查系统名称是否存在
        /// </summary>
        /// <param name="systemName">名称</param>
        /// <returns></returns>
        public bool ExistsByName(string systemName)
        {
            return Sev.ExistsByName(systemName);
        }

        /// <summary>
        /// 检查程序是否更新
        /// </summary>
        /// <param name="systemId">系统ID</param>
        /// <param name="version">当前版本信息</param>
        /// <param name="lasttime">当前更新时间</param>
        /// <returns>是否成新</returns>
        public bool IsNeedUpdate(Guid systemId,string version)
        {
            Models.ACL_System model = GetOneById(systemId);
            bool Result = false;
            if (model == null)
                   Result=false;
            if (model.Version.CompareTo(version)> 0)
                   Result = true;
            return Result;
        }
    }
}
