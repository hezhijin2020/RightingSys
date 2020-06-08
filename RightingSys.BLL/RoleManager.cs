using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.BLL
{
    public class RoleManager
    {
        RightingSys.DAL.RoleService Sev = new DAL.RoleService();

        #region 角色操作
        public bool AddNew(Models.ACL_Role model)
        {
           return Sev.AddNew(model);
        }
        public bool Modify(Models.ACL_Role model)
        {
            return Sev.Modify(model);
        }
        public bool Delete(Guid Id)
        {
            return Sev.Delete(Id);
        }
        public bool ExistsRoleByName(string RoleName)
        {
            return Sev.ExistsRoleByName(RoleName);
        }
        public bool ExistsUserOrDepartmentById(Guid Id)
        {
            if (Sev.ExistsDepartmentById(Id) || Sev.ExistsUserById(Id))
            {
                return true;
            }
            else
            { return false; }
        }
    
        public List<Models.ACL_Role> GetAllList()
        {
            return Sev.GetAllList().ToList();
        }

        public Models.ACL_Role GetOneById(Guid Id)
        {
            return Sev.GetOneById(Id);
        }
        #endregion

        #region 权限方法
        public string GetFuncHandleText(int pEnum)
        {
            string FuncHandleText = "";
            if ((pEnum & 1) == 1)
            {
                FuncHandleText = "新增";
            }
            if ((pEnum & 2) == 2)
            {
                FuncHandleText = FuncHandleText + "," + "查询";
            }
            if ((pEnum & 4) == 4)
            {
                FuncHandleText = FuncHandleText + "," + "修改";
            }
            if ((pEnum & 8) == 8)
            {
                FuncHandleText = FuncHandleText + "," + "删除";
            }
            if ((pEnum & 16) == 16)
            {
                FuncHandleText = FuncHandleText + "," + "保存";
            }
            if ((pEnum & 32) == 32)
            {
                FuncHandleText = FuncHandleText + "," + "取消";
            }
            if ((pEnum & 64) == 64)
            {
                FuncHandleText = FuncHandleText + "," + "审核";
            }
            if ((pEnum & 128) == 128)
            {
                FuncHandleText = FuncHandleText + "," + "反审";
            }
            if ((pEnum & 256) == 256)
            {
                FuncHandleText = FuncHandleText + "," + "导入";
            }
            if ((pEnum & 512) == 512)
            {
                FuncHandleText = FuncHandleText + "," + "导出";
            }
            if ((pEnum & 1024) == 1024)
            {
                FuncHandleText = FuncHandleText + "," + "预览";
            }
            if ((pEnum & 2048) == 2048)
            {
                FuncHandleText = FuncHandleText + "," + "打印";
            }
            if ((pEnum & 4096) == 4096)
            {
                FuncHandleText = FuncHandleText + "," + "首笔";
            }
            if ((pEnum & 8192) == 8192)
            {
                FuncHandleText = FuncHandleText + "," + "上笔";
            }
            if ((pEnum & 16384) == 16384)
            {
                FuncHandleText = FuncHandleText + "," + "下笔";
            }
            if ((pEnum & 32768) == 32768)
            {
                FuncHandleText = FuncHandleText + "," + "末笔";
            }
            return FuncHandleText;
        }

        public string GetFuncHandle(int pEnum)
        {
            string FuncHandle = "0";
            if ((pEnum & 1) == 1)
            {
                FuncHandle = "1";
            }
            if ((pEnum & 2) == 2)
            {
                FuncHandle = FuncHandle + "," + "2";
            }
            if ((pEnum & 4) == 4)
            {
                FuncHandle = FuncHandle + "," + "4";
            }
            if ((pEnum & 8) == 8)
            {
                FuncHandle = FuncHandle + "," + "8";
            }
            if ((pEnum & 16) == 16)
            {
                FuncHandle = FuncHandle + "," + "16";
            }
            if ((pEnum & 32) == 32)
            {
                FuncHandle = FuncHandle + "," + "32";
            }
            if ((pEnum & 64) == 64)
            {
                FuncHandle = FuncHandle + "," + "64";
            }
            if ((pEnum & 128) == 128)
            {
                FuncHandle = FuncHandle + "," + "128";
            }
            if ((pEnum & 256) == 256)
            {
                FuncHandle = FuncHandle + "," + "256";
            }
            if ((pEnum & 512) == 512)
            {
                FuncHandle = FuncHandle + "," + "512";
            }
            if ((pEnum & 1024) == 1024)
            {
                FuncHandle = FuncHandle + "," + "1024";
            }
            if ((pEnum & 2048) == 2048)
            {
                FuncHandle = FuncHandle + "," + "2048";
            }
            if ((pEnum & 4096) == 4096)
            {
                FuncHandle = FuncHandle + "," + "4096";
            }
            if ((pEnum & 8192) == 8192)
            {
                FuncHandle = FuncHandle + "," + "8192";
            }
            if ((pEnum & 16384) == 16384)
            {
                FuncHandle = FuncHandle + "," + "16384";
            }
            if ((pEnum & 32768) == 32768)
            {
                FuncHandle = FuncHandle + "," + "32768";
            }
            return FuncHandle;
        }


        //public System.Data.DataTable FilldtRoleTree()
        //{
        //    return dal.FilldtRoleTree();
        //}

        public System.Data.DataTable GetTbAllFunctionByRoleId(Guid RoleId)
        {
            System.Data.DataTable dtFunc = Sev.GetTbAllFunctionByRoleId(RoleId);
            return FillFuncHandle(dtFunc);
        }


        private System.Data.DataTable FillFuncHandle(System.Data.DataTable dtFunc)
        {
            System.Data.DataTable dt = dtFunc.Copy();
            foreach (System.Data.DataRow s in dtFunc.Rows)
            {
                int pEnum = int.Parse(s["FuncHandle"].ToString());
                int Opcode = 0;
                int spEnum = int.TryParse(s["OpCode"].ToString(), out Opcode) == true ? Opcode : 0;
                string handleNos = GetFuncHandle(pEnum);
                string shandleNos = GetFuncHandle(spEnum);
                System.Data.DataTable dtHandle = Sev.GetTbFuncHandlesByHandleNos(handleNos);
                System.Data.DataTable sdtHandle = Sev.GetTbFuncHandlesByHandleNos(shandleNos);
                foreach (System.Data.DataRow r in dtHandle.Rows)
                {
                    System.Data.DataRow Row = dt.NewRow();
                    Row["Id"] = Guid.NewGuid();
                    Row["ParentId"] = s["Id"];
                    Row["FuncName"] = s["FuncName"] + "-" + r["Name"];
                    Row["FuncHandle"] = r["HandleNo"];
                    Row["SortCode"] = r["HandleNo"];
                    Row["TypeId"] = 2;
                    if (sdtHandle.Select("HandleNo=" + r["HandleNo"]).ToList().Count > 0)
                    {
                        Row["Enabled"] = 1;
                    }
                    else
                    {
                        Row["Enabled"] = 0;
                    }
                    dt.Rows.Add(Row);
                }
            }
            return dt;
        }


        public bool SaveRighting(System.Data.DataTable dt, string RoleId)
        {
            System.Data.DataRow[] array = dt.Select("TypeId=1");
            System.Data.DataTable dts = new System.Data.DataTable();
            dts.Columns.AddRange(
                new System.Data.DataColumn[] {
                    new System.Data.DataColumn("RoleId"),
                    new System.Data.DataColumn("FuncId"),
                    new System.Data.DataColumn("OpCode")
                });
            foreach (System.Data.DataRow r in array)
            {
                object OpCode = 0;
                if (int.Parse(r["FuncHandle"].ToString()) > 0)
                {
                    OpCode = dt.Compute("sum(FuncHandle)", "ParentId='" + r["Id"] + "'");
                    OpCode = OpCode.ToString() == "" ? 0 : OpCode;
                }
                dts.Rows.Add(RoleId, r["Id"], OpCode);

            }

            return Sev.SaveRighting(dts, RoleId);
        }
        #endregion

        

        #region 用户关联角色       
        public bool AddNewUserByRoleId(Guid RoleId, List<Guid> UserList)
        {
            return Sev.AddNewUserByRoleId(RoleId, UserList);
        }

        public bool DeleteUserByRoleId(Guid RoleId,Guid UserId)
        {
            return Sev.DeleteUserByRoleId(RoleId, UserId);
        }

        public System.Data.DataTable GetTbAllUsersByRoleId(Guid RoleId)
        {
            return Sev.GetTbAllUsersByRoleId(RoleId);
        }

        public System.Data.DataTable GetTbUsersByRoleId(Guid RoleId)
        {
            return Sev.GetTbUsersByRoleId(RoleId);
        }

        #endregion

        #region 机构关联角色
        public bool AddNewDepartmentByRoleId(Guid RoleId, List<string> departments)
        {
            return Sev.AddNewDepartmentByRoleId(RoleId, departments);
        }
        public bool DeleteDepartmentByRoleId(Guid RoleId, Guid departmentId)
        {
            return Sev.DeleteDepartmentByRoleId(RoleId, departmentId);
        }
        public System.Data.DataTable GetTbAllDepartmentsByRoleId(Guid RoleId)
        {
            return Sev.GetTbAllDepartmentsByRoleId(RoleId);
        }
        public System.Data.DataTable GetTbDepartmentsByRoleId(Guid RoleId)
        {
            return Sev.GetTbDepartmentsByRoleId(RoleId);
        }

        #endregion

        #region  获取所有功能
        public List<Models.ACL_Function> GetAllFunction()
        {
            return Sev.GetAllFunction().ToList();
        }
        #endregion
    }
}
