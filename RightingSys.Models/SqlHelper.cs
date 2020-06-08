using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace RightingSys.Models
{
    public static class SqlHelper
    {
        #region 实体列表与DataTable互换
        /// <summary>
        /// DataTable转换成实体列表
        /// </summary>
        /// <typeparam name="T">实体 T </typeparam>
        /// <param name="table">datatable</param>
        /// <returns></returns>
        public static IList<T> DataTableToList<T>(DataTable table)
            where T : class
        {
            //if (!IsHaveRows(table))
            if (table == null || table.Rows.Count == 0)
                return new List<T>();

            IList<T> list = new List<T>();
            T model = default(T);
            foreach (DataRow dr in table.Rows)
            {
                model = Activator.CreateInstance<T>();

                foreach (DataColumn dc in dr.Table.Columns)
                {
                    object drValue = dr[dc.ColumnName];
                    PropertyInfo pi = model.GetType().GetProperty(dc.ColumnName);

                    if (pi != null && pi.CanWrite && (drValue != null && !Convert.IsDBNull(drValue)))
                    {
                        pi.SetValue(model, drValue, null);
                    }
                }
                list.Add(model);
            }
            return list;
        }

        /// <summary>
        /// 实体列表转换成DataTable
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="list"> 实体列表</param>
        /// <returns></returns>
        public static DataTable ListToDataTable<T>(IList<T> list)
            where T : class
        {
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            DataTable dt = new DataTable(typeof(T).Name);
            DataColumn column;
            DataRow row;

            PropertyInfo[] myPropertyInfo = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            int length = myPropertyInfo.Length;
            bool createColumn = true;

            foreach (T t in list)
            {
                if (t == null)
                {
                    continue;
                }

                row = dt.NewRow();
                for (int i = 0; i < length; i++)
                {
                    PropertyInfo pi = myPropertyInfo[i];
                    string name = pi.Name;
                    if (createColumn)
                    {
                        column = new DataColumn(name, pi.PropertyType);
                        dt.Columns.Add(column);
                    }

                    row[name] = pi.GetValue(t, null);
                }

                if (createColumn)
                {
                    createColumn = false;
                }

                dt.Rows.Add(row);
            }
            return dt;

        }
        #endregion

        #region 连接字符串
        /// <summary>
        /// 连接数据库的字符串
        /// </summary>
        private static string conStr = "Data Source=172.20.58.3;Initial Catalog=RightingSys;User Id=itprogram;Password=!tpr0gram;Connect Timeout=5;";
        
        #endregion

        #region 01.执行查询返回datatable +DataTable ExecuteDataTable(string sql, params SqlParameter[] param)
        /// <summary>
        /// 返回datatable
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">数组型参数，sql语句需要替换的参数</param>
        /// <returns>DataTable</returns>
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                //con.ConnectionString = conStr; 
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    //com.CommandText = sql;
                    //com.Connection = con;
                    //com.CommandType = CommandType.Text;
                    //com.CommandTimeout = Convert.ToInt32(ConfigurationSettings.AppSettings["CommandTimeout"]); 
                    com.Parameters.AddRange(param);
                    //创建适配器对象(卡车，它会自动开关连接通道)
                    SqlDataAdapter adapter = new SqlDataAdapter(com);
                    //adapter.SelectCommand = com;//也可以用这种方式联系command对象
                    adapter.Fill(dt);
                    com.Parameters.Clear();
                    return dt;
                }
            }
        }
        #endregion

        #region 02.返回非查询命令ExecuteNoQuery受影响的行数 +int ExecuteNoQuery(string sql, params SqlParameter[] param)
        /// <summary>
        /// 返回非查询命令ExecuteNoQuery受影响的行数
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">数组型参数，sql语句需要替换的参数</param>
        /// <returns>返回受影响的行数</returns>
        public static int ExecuteNoQuery(string sql, params SqlParameter[] param)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand com = new SqlCommand(sql, con))
                {                                      
                    com.Parameters.AddRange(param);
                    con.Open();
                    int count = com.ExecuteNonQuery();
                    com.Parameters.Clear();
                    return count;
                }
            }
        }
        #endregion

        #region 03.执行查询或者非查询， 返回结果集的第一行第一列 +object ExecuteScalar(string sql, params SqlParameter[] param)
        /// <summary>
        /// 执行查询或者非查询， 返回结果集的第一行第一列
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">数组型参数，sql语句需要替换的参数</param>
        /// <returns>返回查询结果集的第一行第一列</returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] param)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.AddRange(param);
                    con.Open();
                    object o = com.ExecuteScalar();
                    com.Parameters.Clear();
                    return o;

                }
            }
        }
        #endregion

        #region 04.返回 SqlDataReader + SqlDataReader ExecuteDataReader(string sql, params SqlParameter[] param)
        /// <summary>
        /// 返回datareader
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteDataReader(string sql, params SqlParameter[] param)
        {
            //因为 SqlDataReader 是基于连接的，所以不能在这里用using释放掉连接，不然返回的SqlDataReader就无法从数据库服务器一条一条的读取数据了
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand com = new SqlCommand(sql, con);
            if (param != null)
            {
                com.Parameters.AddRange(param);
            }
            con.Open();
            //因为当读取完数据后又需要释放连接（连接是宝贵的），所以在这里为ExecuteReader（）方法加了一个枚举型参数CommandBehavior.CloseConnection，让datareader关闭时，自动的关闭connection的连接。
            SqlDataReader reader = com.ExecuteReader(CommandBehavior.CloseConnection);
            com.Parameters.Clear();
            return reader;
        }
        #endregion

        #region 05.存储过程 返回数据
        /// <summary>
        /// 返回DataTable和pageCount
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pageCount"></param>
        /// <returns></returns>
        public static DataTable ExecuteProc(string sql, int pageSize, int pageIndex, out int pageCount)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                //string sql = "usp_GetPageData";
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = CommandType.StoredProcedure;//设置sql语句类型为存储过程

                    //设置存储过程的输入参数
                    com.Parameters.AddWithValue("@pageSize", pageSize);
                    com.Parameters.AddWithValue("@pageIndex", pageIndex);

                    //输出参数的设置
                    SqlParameter sp = com.Parameters.Add("@pageCount", SqlDbType.Int);
                    sp.Direction = ParameterDirection.Output;


                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adaper = new SqlDataAdapter(com))
                    {
                        adaper.Fill(dt);
                        com.Parameters.Clear();
                        pageCount = Convert.ToInt32(sp.Value);//获取输出参数的值
                        return dt;
                    }
                }
            }
        }
        #endregion

        #region 06.分页返回数据
        /// <summary>
        /// 分页返回数据
        /// </summary>
        /// <param name="sql">查询命令</param>
        /// <param name="orderByKey">按降序或者升序获取数据 如：id desc</param>
        /// <param name="pageIndex">要获取哪页的数据</param>
        /// <param name="pageSize">页的大小</param>
        /// <param name="totalRows">输出型参数：总数据行数目</param>
        /// <param name="PageCount">输出型参数：总页数</param>
        /// <param name="param">查询命令参数</param>
        /// <returns>数据行集合dtatable</returns>
        public static DataTable ExecuteSplitQueryData(string sql, string orderByKey, int pageIndex, int pageSize, out long totalRows, out long PageCount, params SqlParameter[] param)
        {

            string str = string.Format("select row_number()over(order by {0}) as rownumber,* from ({1}) as t", orderByKey, sql);
            return ExecuteSplitQuery(str, orderByKey, pageIndex, pageSize, out totalRows, out PageCount, param);

        }
        private static DataTable ExecuteSplitQuery(string sql, string orderByKey, int pageIndex, int pageSize, out long totalRows, out long PageCount, params SqlParameter[] param)
        {
            //获取总行数
            object count = ExecuteScalar(string.Format("select count(1) from ({0})t", sql), param);
            totalRows = Convert.ToInt32(count);

            //获取总页数
            long pagecount = totalRows / pageSize;
            long laterNum = totalRows % pageSize;
            if (laterNum > 0)
            {
                pagecount++;
            }
            PageCount = pagecount;

            //获取分页后的数据
            string str = string.Format("select * from ({0})t ", sql);
            str += string.Format("where t.rownumber between {0} and {1} order by {2}", pageIndex * pageSize - pageSize + 1, pageIndex * pageSize, orderByKey);
            return ExecuteDataTable(str, param);
        }
        #endregion

        #region 07.事务处理
        public static int ExecuteTransaction(IDictionary<string, SqlParameter[]> dics,bool IsAllowNoneRows=true)
        {
            int n = 0;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            SqlTransaction myTransaction = con.BeginTransaction();
            cmd.Transaction = myTransaction;
            try
            {
                foreach (var dic in dics)
                {
                    cmd.CommandText = dic.Key;
                    cmd.Parameters.Clear();
                    if (dic.Value != null)
                    {
                        cmd.Parameters.AddRange(dic.Value);
                    }
                    int rows = cmd.ExecuteNonQuery();
                    if (!IsAllowNoneRows)
                    {
                        if (rows > 0)
                        {
                            n += rows; //循环执行命令
                        }
                        else
                        {
                            throw new Exception("系统错误");
                        }
                    }
                    else
                    {
                        n += rows; //循环执行命令
                    }
                   
                }
                myTransaction.Commit(); //提交数据库事务
                return n;
            }
            catch (System.Exception ex)
            {
                myTransaction.Rollback();
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public static int ExecuteTransaction1(IDictionary<SqlParameter[], string> dics, bool IsAllowNoneRows = true)
        {
            int n = 0;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = conStr;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            SqlTransaction myTransaction = con.BeginTransaction();
            cmd.Transaction = myTransaction;
            try
            {
                foreach (var dic in dics)
                {
                    cmd.CommandText = dic.Value;
                    cmd.Parameters.Clear();
                    if (dic.Value != null)
                    {
                        cmd.Parameters.AddRange(dic.Key);
                    }
                    int rows = cmd.ExecuteNonQuery();
                    if (!IsAllowNoneRows)
                    {
                        if (rows > 0)
                        {
                            n += rows; //循环执行命令
                        }
                        else
                        {
                            throw new Exception("系统错误");
                        }
                    }
                    else
                    {
                        n += rows; //循环执行命令
                    }

                }
                myTransaction.Commit(); //提交数据库事务
                return n;
            }
            catch (System.Exception ex)
            {
                myTransaction.Rollback();
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        //public static int ExecuteTransaction(IDictionary<string, SqlParameter[]> dics)
        //{
        //    int n = 0;
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = conStr;
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    con.Open();
        //    SqlTransaction myTransaction = con.BeginTransaction();
        //    cmd.Transaction = myTransaction;
        //    try
        //    {
        //        foreach (var dic in dics)
        //        {
        //            cmd.CommandText = dic.Key;
        //            cmd.Parameters.Clear();
        //            if (dic.Value != null)
        //            {
        //                cmd.Parameters.AddRange(dic.Value);
        //            }
        //            n += cmd.ExecuteNonQuery(); //循环执行命令
        //        }
        //        myTransaction.Commit(); //提交数据库事务
        //        return n;
        //    }
        //    catch (System.Exception ex)
        //    {
        //        myTransaction.Rollback();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
        #endregion

        #region 08.数据更新ExecuteUpdate DataSet

        public static int ExecuteUpdate(DataSet ds, params SqlParameter[] param)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = conStr;
                con.Open();
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.Parameters.AddRange(param);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = com;
                    SqlCommandBuilder builder = new SqlCommandBuilder();
                    builder.DataAdapter = adapter;
                    return adapter.Update(ds);

                }
            }
        }
        #endregion
    }
}
