using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace RightingSys.BLL
{
    public  class FingerPrintManager
    {
        DAL.FingerPrintService Sev = new DAL.FingerPrintService();

        public bool AddNew(Models.ACL_FingerPrint model)
        {
           return Sev.AddNew(model);
        }

        public bool Modify(Models.ACL_FingerPrint model)
        {
            return Sev.Modify(model);
        }

        public bool Delete(Guid UserId)
        {
            return Sev.Delete(UserId);
        }

        public bool ExistsById(Guid Id)
        {
            return Sev.ExistsById(Id);
        }
        public List<Models.ACL_FingerPrint> GetAllList()
        {
            return Sev.GetAllList().ToList();
        }

        public  Models.ACL_FingerPrint GetOneById(Guid Id)
        {
            return Sev.GetOneById(Id);
        }
    }
}
