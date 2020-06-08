using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace RightingSys.DAL
{
    public class OrderMealService
    {

        #region 获取报餐信息

        /// <summary>
        ///获取指定日期的报餐表
        /// </summary>
        /// <param name="mealday">日期</param>
        /// <returns></returns>
        public  IList<Models.ys_OrderMeal> GetListByday(DateTime mealday)
        {
            //string sql = string.Format(@"select a.FullName,a.Id UserId,b.DepartmentName,c.*
            //    from ACL_User as a left join ACL_Department as b on a.DepartmentId=b.Id
            //   left join (select *from ys_OrderMeal where Mealday='{0}') as c on a.Id=c.UserId", mealday.Date);

            string sql = string.Format(@"select a.*,b.FullName,c.DepartmentName from ys_OrderMeal  as a inner join ACL_User as b on a.UserId=b.Id
                                 left join ACL_Department as c on b.DepartmentId=c.Id
								 where a.IsRemoved=0 and a.Mealday='{0}'", mealday.Date);
            DataTable dt = Models.SqlHelper.ExecuteDataTable(sql);

            IList<Models.ys_OrderMeal> list = Models.SqlHelper. DataTableToList<Models.ys_OrderMeal>(dt);

            return list;
        }

        /// <summary>
        ///获取指定日期的报餐表
        /// </summary>
        /// <param name="mealday">日期</param>
        /// <returns></returns>
        public IList<Models.ys_OrderMeal> GetListByday(DateTime startDay,DateTime endDay)
        {
            string sql = string.Format(@"select a.*,b.FullName,c.DepartmentName from ys_OrderMeal  as a inner join ACL_User as b on a.UserId=b.Id
                                 left join ACL_Department as c on b.DepartmentId=c.Id
								 where a.IsRemoved=0 and a.Mealday>='{0}'and a.Mealday<='{1}'",startDay.Date,endDay.Date);
            DataTable dt = Models.SqlHelper.ExecuteDataTable(sql);

            IList<Models.ys_OrderMeal> list = Models.SqlHelper.DataTableToList<Models.ys_OrderMeal>(dt);

            return list;
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="userId"></param>
        ///// <param name="mealday"></param>
        ///// <param name="ColumnName"></param>
        ///// <param name="Value"></param>
        //public static void ChangeOrderMeal(Guid id, Guid userId, DateTime mealday, string ColumnName, int Value)
        //{
        //    string sql = string.Format(@"if((select  COUNT(Id) from ys_OrderMeal where Id='{2}')>0)
        //                      update ys_OrderMeal set {0} = {1} where Id = '{2}'
        //                    else
        //                      insert into ys_OrderMeal(id, UserId, Mealday, {0})
        //                      values('{2}', '{3}', '{4}',{1} )", ColumnName, Value, id, userId, mealday);
        //    Service.SQLADO.ExecuteNoQuery(sql);

        //}

        //public static bool AddTackOrderMeal(Guid Id, string columnName, Guid userId, DateTime mealday)
        //{
        //    string sql = string.Format(@" insert into ys_OrderMeal(id, UserId, Mealday, Is{3},{3}time)
        //                            values('{0}', '{1}', '{2}',1,getdate())", Id, userId, mealday, columnName);
        //    return Service.SQLADO.ExecuteNoQuery(sql) > 0 ? true : false;
        //}

        //public static bool TackOrderMeal(Guid Id, string ColumnName)
        //{
        //    string sql = string.Format(@"update ys_OrderMeal set Is{0}=1,{0}time=getdate() where Id='{1}'", ColumnName, Id);
        //    return Service.SQLADO.ExecuteNoQuery(sql) > 0 ? true : false;
        //}


        #endregion
    }
}
