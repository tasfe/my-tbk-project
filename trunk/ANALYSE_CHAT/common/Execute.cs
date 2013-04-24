using System;
using System.Data;
using System.Xml;
using System.Data.SqlClient;

namespace ANALYSE_CHAT
{
    public class Execute
    {
        #region 执行SQL 文本命令返回 int
        /// <summary>
        /// 执行SQL 文本命令返回 int
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回int</returns>
        public static int ExecuteNonQuery(string connectionString,string commandText)
        {
            return SqlHelper.ExecuteNonQuery(connectionString, CommandType.Text, commandText);
        }

        /// <summary>
        /// 执行SQL 文本命令返回 int
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="commandText">Sql语句</param>
        /// <param name="commandParameters">参数</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string connectionString, string commandText, SqlParameter[] commandParameters)
        {
            return SqlHelper.ExecuteNonQuery(connectionString, CommandType.Text, commandText, commandParameters);
        }

        #endregion

        #region 执行SQL 文本命令返回 DataSet
        /// <summary>
        /// 执行SQL 文本命令返回 DataSet
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteDataset(string connectionString, string commandText)
        {
            return SqlHelper.ExecuteDataset(connectionString, CommandType.Text, commandText);
        }
        #endregion

        #region 执行SQL 文本命令返回 DataTable
        /// <summary>
        /// 执行SQL 文本命令返回 DataTable
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回DataTable</returns>
        public static DataTable ExecuteDataTable(string connectionString, string commandText)
        {
            DataSet ds = SqlHelper.ExecuteDataset(connectionString, CommandType.Text, commandText);
            return ds.Tables[0];
        }
        #endregion

        #region 执行存储过程返回 int
        /// <summary>
        /// 执行存储过程返回 int
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <param name="commandParameters">存储过程参数</param>
        /// <returns>返回int</returns>
        public static int ExecuteProcNonQuery(string connectionString, string commandProcedureName, ref SqlParameter[] commandParameters)
        {
            return SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, commandProcedureName, commandParameters);
        }

        /// <summary>
        /// 执行存储过程返回 int
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <returns>返回int</returns>
        public static int ExecuteProcNonQuery(string connectionString, string commandProcedureName)
        {
            return SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, commandProcedureName, null);
        }

        #endregion

        #region 执行存储过程返回 DataSet
        /// <summary>
        /// 执行存储过程返回 DataSet
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <param name="commandParameters">存储过程参数</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteProcDataset(string connectionString, string commandProcedureName, ref SqlParameter[] commandParameters)
        {
            return SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, commandProcedureName, commandParameters);
        }
        #endregion

        #region 执行存储过程返回 DataTable
        /// <summary>
        /// 执行存储过程返回 DataTable
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <param name="commandParameters">存储过程参数</param>
        /// <returns>返回DataSet</returns>
        public static DataTable ExecuteProcDataTable(string connectionString, string commandProcedureName, ref SqlParameter[] commandParameters)
        {
            DataSet ds = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, commandProcedureName, commandParameters);
            return ds.Tables[0];
        }

        /// <summary>
        /// 执行存储过程返回 DataTable
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <returns>返回DataSet</returns>
        public static DataTable ExecuteProcDataTable(string connectionString, string commandProcedureName)
        {
            DataSet ds = SqlHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, commandProcedureName, null);
            return ds.Tables[0];
        }

        #endregion

        #region 执行SQL 文本命令返回(带事务) int
        /// <summary>
        /// 执行SQL 文本命令返回(带事务) int
        /// </summary>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回int</returns>
        public static int ExecuteNonQuery(SqlTransaction transaction, string commandText)
        {
            return SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, commandText);
        }
        #endregion

        #region 执行SQL 文本命令返回(带事务) DataSet
        /// <summary>
        /// 执行SQL 文本命令返回(带事务) DataSet
        /// </summary>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteDataset(SqlTransaction transaction, string commandText)
        {
            return SqlHelper.ExecuteDataset(transaction, CommandType.Text, commandText);
        }
        #endregion

        #region 执行SQL 文本命令返回(带事务) DataTable
        /// <summary>
        /// 执行SQL 文本命令返回(带事务) DataTable
        /// </summary>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回DataTable</returns>
        public static DataTable ExecuteDataTable(SqlTransaction transaction, string commandText)
        {
            DataSet ds = SqlHelper.ExecuteDataset(transaction, CommandType.Text, commandText);
            return ds.Tables[0];
        }
        #endregion

        #region 执行存储过程返回(带事务) int
        /// <summary>
        /// 执行存储过程返回(带事务) int
        /// </summary>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <param name="commandParameters">存储过程参数</param>
        /// <returns>返回int</returns>
        public static int ExecuteProcNonQuery(SqlTransaction transaction, string commandProcedureName, ref SqlParameter[] commandParameters)
        {
            return SqlHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, commandProcedureName, commandParameters);
        }
        #endregion

        #region 执行存储过程返回(带事务) DataSet
        /// <summary>
        /// 执行存储过程返回(带事务) DataSet
        /// </summary>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <param name="commandParameters">存储过程参数</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteProcDataset(SqlTransaction transaction, string commandProcedureName, ref SqlParameter[] commandParameters)
        {
            return SqlHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, commandProcedureName, commandParameters);
        }
        #endregion

        #region 执行存储过程返回(带事务) DataTable
        /// <summary>
        /// 执行存储过程返回(带事务) DataTable
        /// </summary>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <param name="commandParameters">存储过程参数</param>
        /// <returns>返回DataSet</returns>
        public static DataTable ExecuteProcDataTable(SqlTransaction transaction, string commandProcedureName, ref SqlParameter[] commandParameters)
        {
            DataSet ds = SqlHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, commandProcedureName, commandParameters);
            return ds.Tables[0];
        }
        #endregion

    }
}
