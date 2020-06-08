using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.BLL
{
    public  class OrderMealManager
    {
        RightingSys.DAL.OrderMealService sev = new DAL.OrderMealService();
        /// <summary>
        ///获取指定日期的报餐表
        /// </summary>
        /// <param name="mealday">日期</param>
        /// <returns></returns>
        public  IList<Models.ys_OrderMeal> GetListByday(DateTime mealday)
        {
            return sev.GetListByday(mealday);
        }

        /// <summary>
        ///获取指定日期的报餐表
        /// </summary>
        /// <param name="mealday">日期</param>
        /// <returns></returns>
        public IList<Models.ys_OrderMeal> GetListByday(DateTime startDay, DateTime endDay)
        {
            return sev.GetListByday(startDay,endDay);
        }
    }
}
