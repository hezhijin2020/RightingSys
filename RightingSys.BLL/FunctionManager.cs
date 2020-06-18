using System;
using System.Collections.Generic;
using System.Linq;

namespace RightingSys.BLL
{
    public class FunctionManager
    {
        RightingSys.DAL.FunctionSerivce Sev = new RightingSys.DAL.FunctionSerivce();

        /// <summary>
        /// 功能新增方法
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(Models.ACL_Function model)
        {
           return Sev.AddNew(model);
        }

        /// <summary>
        /// 功能修改方法
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool Modify(Models.ACL_Function model)
        {
            return Sev.Modify(model);
        }

        /// <summary>
        /// 删除功能方法
        /// </summary>
        /// <param name="Id">功能Id</param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            return Sev.Delete(Id);
        }

        /// <summary>
        /// 检查角色是否有功能权限
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool ExistsRoleById(Guid Id)
        {
            return Sev.ExistsRoleById(Id);
        }

        /// <summary>
        /// 获取指定功能ID实体
        /// </summary>
        /// <returns></returns>
        public Models.ACL_Function GetOneFuncionById(Guid Id)
        {
           return GetAllList().FirstOrDefault(s => s.Id == Id);
        }

        /// <summary>
        /// 获取所有功能列表
        /// </summary>
        /// <returns></returns>
        public IList<Models.ACL_Function> GetAllList()
        {
            return Sev.GetAllList();
        }

        /// <summary>
        /// 获取权限树列表
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable GetTbFunctionTree()
        {
            return Sev.GetTbFunctionTree();
        }

        /// <summary>
        /// 获取功能菜单列表
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable GetFuncHandleList()
        {
            return Sev.GetFuncHandleList();
        }
      
        /// <summary>
        /// 获取功能菜单名称
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 获取所指定功能的所有引用角色列表
        /// </summary>
        /// <param name="Id">功能Id</param>
        /// <returns></returns>
        public IList<Models.ACL_Role> GetRoleListByFuncId(Guid FuncId)
        {
            return Sev.GetRoleListByFuncId(FuncId);
        }
    }
}
