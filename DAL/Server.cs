using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Server
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["GUIDEConnectionString"].ConnectionString;
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
    }
}
