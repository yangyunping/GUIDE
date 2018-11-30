using MODEL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    public class Server
    {
        private string ConnectionString = PublicClass.Decrypt(ConfigurationManager.ConnectionStrings["GUIDEConnectionString"].ConnectionString, ConfigurationManager.AppSettings["sEncryptionKey"]);
        protected const int ExecuteTimeout = 60;
        /// <summary>
        /// 测试连接是否成功
        /// </summary>
        /// <returns>成功返回true，否则false</returns>
        public  bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 执行不返回结果的sql语句
        /// </summary>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        public  int ExecuteNonQuery(string sqlText)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlcommand = connection.CreateCommand();
                sqlcommand.CommandText = sqlText;
                sqlcommand.CommandTimeout = ExecuteTimeout;
                return sqlcommand.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 执行返回一行的sql语句
        /// </summary>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        public object ExecuteScalar(string sqlText)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand sqlcommand = connection.CreateCommand();
                sqlcommand.CommandText = sqlText;
                sqlcommand.CommandTimeout = ExecuteTimeout;
                return sqlcommand.ExecuteScalar();
            }
        }

        /// <summary>
        /// 执行返回结果的sql语句
        /// </summary>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        public  DataSet ExecuteQuery(string sqlText)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    SqlCommand sqlcommand = connection.CreateCommand();
                    sqlcommand.CommandText = sqlText;
                    sqlcommand.CommandTimeout = ExecuteTimeout;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds, @"result");
                    return ds;
                }
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 执行返回结果的sql语句
        /// </summary>
        /// <param name="cmdText">储存过程名称</param>
        /// <param name="cmdParams">参数</param>
        /// <returns></returns>
        public DataSet ExecuteLayQuery(string cmdText,string tag, string key)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand sqlcommand = connection.CreateCommand();
                    sqlcommand.CommandText = cmdText;
                    sqlcommand.CommandType = CommandType.StoredProcedure;
                    sqlcommand.Parameters.Add(new SqlParameter("@Tag", tag));
                    sqlcommand.Parameters.Add(new SqlParameter("@ShowContent", key));
                    sqlcommand.CommandTimeout = ExecuteTimeout;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds, @"result");
                    return ds;
                } 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}
