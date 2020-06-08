using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.BLL
{
    public class SystemManager
    {
        RightingSys.DAL.SystemService Sev = new DAL.SystemService();
        public bool AddNew(Models.ACL_System model)
        {
            return Sev.AddNew(model);
        }
        public bool Modify(Models.ACL_System model)
        {
            return Sev.Modify(model);
        }

        public bool ModifyVersion(Models.ACL_System model)
        {
            return Sev.ModifyVersion(model);
        }
        public bool Delete(Guid Id)
        {
            return Sev.Delete(Id);
        }
        public List<Models.ACL_System> GetAllSystems()
        {
            return Sev.GetAllSystems().Where(s => s.IsRemoved == false).ToList();
        }

        public Models.ACL_System GetOneById(Guid Id)
        {
            return Sev.GetAllSystems().Where(s => s.IsRemoved == false).FirstOrDefault(a=>a.Id==Id);
        }

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
