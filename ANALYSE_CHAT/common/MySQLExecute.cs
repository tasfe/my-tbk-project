using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace ANALYSE_CHAT
{
    public class MySQLExecute
    {
        #region 执行SQL 文本命令返回 int
        /// <summary>
        /// 执行SQL 文本命令返回 int
        /// </summary>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回int</returns>
        public static int ExecuteNonQuery(string commandText, string sqlConnection)
        {
            string connectionString = sqlConnection;
            return MyHelper.ExecuteNonQuery(connectionString, CommandType.Text, commandText);
        }

        /// <summary>
        /// 执行SQL 文本命令返回 int
        /// </summary>
        /// <param name="commandText">Sql语句</param>
        /// <param name="commandParameters">参数</param>
        /// <returns>0失败 ， 1 成功</returns>
        public static int ExecuteNonQuery(string commandText, MySqlParameter[] commandParameters, string sqlConnection)
        {
            string connectionString = sqlConnection;
            return MyHelper.ExecuteNonQuery(connectionString, CommandType.Text, commandText, commandParameters);
        }

        #endregion

        #region 执行SQL 文本命令返回 DataSet
        /// <summary>
        /// 执行SQL 文本命令返回 DataSet
        /// </summary>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteDataset(string commandText, string sqlConnection)
        {
            string connectionString = sqlConnection;
            return MyHelper.ExecuteDataset(connectionString, CommandType.Text, commandText);
        }
        #endregion

        #region 执行SQL 文本命令返回 DataTable
        /// <summary>
        /// 执行SQL 文本命令返回 DataTable
        /// </summary>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回DataTable</returns>
        public static DataTable ExecuteDataTable(string commandText, string sqlConnection)
        {
            string connectionString = sqlConnection;
            DataSet ds = MyHelper.ExecuteDataset(connectionString, CommandType.Text, commandText);
            return ds.Tables[0];
        }
        #endregion

        #region 执行存储过程返回 int
        /// <summary>
        /// 执行存储过程返回 int
        /// </summary>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <param name="commandParameters">存储过程参数</param>
        /// <returns>返回int</returns>
        public static int ExecuteProcNonQuery(string commandProcedureName, ref MySqlParameter[] commandParameters, string sqlConnection)
        {
            string connectionString = sqlConnection;
            return MyHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, commandProcedureName, commandParameters);
        }

        /// <summary>
        /// 执行存储过程返回 int
        /// </summary>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <returns>返回int</returns>
        public static int ExecuteProcNonQuery(string commandProcedureName, string sqlConnection)
        {
            string connectionString = sqlConnection;
            return MyHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, commandProcedureName, null);
        }

        #endregion

        #region 执行存储过程返回 DataSet
        /// <summary>
        /// 执行存储过程返回 DataSet
        /// </summary>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <param name="commandParameters">存储过程参数</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteProcDataset(string commandProcedureName, ref MySqlParameter[] commandParameters, string sqlConnection)
        {
            string connectionString = sqlConnection;
            return MyHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, commandProcedureName, commandParameters);
        }
        #endregion

        #region 执行存储过程返回 DataTable
        /// <summary>
        /// 执行存储过程返回 DataTable
        /// </summary>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <param name="commandParameters">存储过程参数</param>
        /// <returns>返回DataSet</returns>
        public static DataTable ExecuteProcDataTable(string commandProcedureName, ref MySqlParameter[] commandParameters, string sqlConnection)
        {
            string connectionString = sqlConnection;
            DataSet ds = MyHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, commandProcedureName, commandParameters);
            return ds.Tables[0];
        }

        /// <summary>
        /// 执行存储过程返回 DataTable
        /// </summary>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <returns>返回DataSet</returns>
        public static DataTable ExecuteProcDataTable(string commandProcedureName, string sqlConnection)
        {
            string connectionString = sqlConnection;
            DataSet ds = MyHelper.ExecuteDataset(connectionString, CommandType.StoredProcedure, commandProcedureName, null);
            return ds.Tables[0];
        }



        #endregion

        #region 执行SQL 文本命令返回(带事务) int
        /// <summary>
        /// 执行SQL 文本命令返回(带事务) int
        /// </summary>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回int</returns>
        public static int ExecuteNonQuery(MySqlTransaction transaction, string commandText)
        {
            return MyHelper.ExecuteNonQuery(transaction, CommandType.Text, commandText);
        }
        #endregion

        #region 执行SQL 文本命令返回(带事务) DataSet
        /// <summary>
        /// 执行SQL 文本命令返回(带事务) DataSet
        /// </summary>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteDataset(MySqlTransaction transaction, string commandText)
        {
            return MyHelper.ExecuteDataset(transaction, CommandType.Text, commandText);
        }
        #endregion

        #region 执行SQL 文本命令返回(带事务) DataTable
        /// <summary>
        /// 执行SQL 文本命令返回(带事务) DataTable
        /// </summary>
        /// <param name="commandText">Sql语句</param>
        /// <returns>返回DataTable</returns>
        public static DataTable ExecuteDataTable(MySqlTransaction transaction, string commandText)
        {
            DataSet ds = MyHelper.ExecuteDataset(transaction, CommandType.Text, commandText);
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
        public static int ExecuteProcNonQuery(MySqlTransaction transaction, string commandProcedureName, ref MySqlParameter[] commandParameters)
        {
            return MyHelper.ExecuteNonQuery(transaction, CommandType.StoredProcedure, commandProcedureName, commandParameters);
        }
        #endregion

        #region 执行存储过程返回(带事务) DataSet
        /// <summary>
        /// 执行存储过程返回(带事务) DataSet
        /// </summary>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <param name="commandParameters">存储过程参数</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteProcDataset(MySqlTransaction transaction, string commandProcedureName, ref MySqlParameter[] commandParameters)
        {
            return MyHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, commandProcedureName, commandParameters);
        }
        #endregion

        #region 执行存储过程返回(带事务) DataTable
        /// <summary>
        /// 执行存储过程返回(带事务) DataTable
        /// </summary>
        /// <param name="commandProcedureName">Sql语句</param>
        /// <param name="commandParameters">存储过程参数</param>
        /// <returns>返回DataSet</returns>
        public static DataTable ExecuteProcDataTable(MySqlTransaction transaction, string commandProcedureName, ref MySqlParameter[] commandParameters)
        {
            DataSet ds = MyHelper.ExecuteDataset(transaction, CommandType.StoredProcedure, commandProcedureName, commandParameters);
            return ds.Tables[0];
        }
        #endregion
    }
}
