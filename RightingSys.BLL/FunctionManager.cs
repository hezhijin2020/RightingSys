using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.BLL
{
    public class FunctionManager
    {
        RightingSys.DAL.FunctionSerivce Sev = new RightingSys.DAL.FunctionSerivce();
        public bool AddNew(Models.ACL_Function model)
        {
           return Sev.AddNew(model);
        }
        public bool Modify(Models.ACL_Function model)
        {
            return Sev.Modify(model);
        }

        public bool Delete(Guid Id)
        {
            return Sev.Delete(Id);
        }

        public bool ExistsRoleById(Guid Id)
        {
            return Sev.ExistsRoleById(Id);
        }

        public Models.ACL_Function GetOneFuncionById(Guid Id)
        {
           return GetAllList().FirstOrDefault(s => s.Id == Id);
        }

        public IList<Models.ACL_Function> GetAllList()
        {
            return Sev.GetAllList();
        }

        public System.Data.DataTable GetTbFunctionTree()
        {
            return Sev.GetTbFunctionTree();
        }

        public  System.Data.DataTable GetFuncHandleList()
        {
            return Sev.GetFuncHandleList();
        }

        public string GetFuncHandleText(int pEnum)
        {
            string FuncHandleText = "";
            if ((pEnum & 1) == 1)
            {
                FuncHandleText = FuncHandleText + "," + "新增";
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
            return FuncHandleText == "" ? "" : FuncHandleText.Remove(0, 1);
        }
    }
}
