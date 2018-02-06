using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

using System.Data;
//using System.Data.OleDb;


namespace 小区物业管理系统
{
    class Class1
    {
        //定义全局静态变量connstring,用于连接数据库
        public static string connstring = "data source=.;initial catalog=netxqwy;user id=sa;password=";
       

        public int hsgexucute(string sql)  //自定义函数:执行sql语句
        {


            //连接数据库
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connstring;
            SqlCommand myCommand = new SqlCommand(sql, conn);

            SqlCommand cmd = new SqlCommand(sql, conn);


            try
            {
                //打开数据库连接
                conn.Open();
                //执行语句
                myCommand.ExecuteNonQuery();
                //如果正确执行,则返回值1
                return 1;
            }
            catch
            {
                //如果出现异常,返回值0
                return 0;

            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }

        public DataSet hsggetdata(string sql)  //自定义函数,用于查询数据库操作
        {

            //同上,连接数据库
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connstring;
            SqlCommand myCommand = new SqlCommand(sql, conn);

            SqlCommand cmd = new SqlCommand(sql, conn);

            try
            {
                //执行查询操作,将值以数据集形式返回
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch
            {
               //如果异常,返回null
                return null;

            }
            finally
            {
                //关闭连接
                conn.Close();
            }
        }
      
    }
    
}
