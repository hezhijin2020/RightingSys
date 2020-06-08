using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RightingSys.BLL
{
    public class OperationLogManager
    {

        DAL.OperationLogService LogService = new DAL.OperationLogService();
        /// <summary>
        /// 获取操作日志信息
        /// </summary>
        /// <returns></returns>
        public List<Models.ACL_OperationLog> GetAllList()
        {
            return LogService.GetAllList().Where(a => a.IsRemoved == false).ToList();
        }

    }
}
