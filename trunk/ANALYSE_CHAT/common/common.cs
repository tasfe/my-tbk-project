using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ANALYSE_CHAT
{
    public static class common
    {
        //解密码
        private static string strCRGKey = "chenCao!";

        public static string strCenterConnSql = CRG.Components.Security.DESCrypto.Decrypt(strCRGKey, System.Configuration.ConfigurationSettings.AppSettings["conn"]);

        //Analyse连接字符串   
        private static string strAnalyseConn = "";
        //REPORT连接字符串   
        private static string strReportConn = "";
        //MYSQL数据库连接字符串   
        private static DataTable dtCrmConn = new DataTable();
        //API的URL
        private static string strApiUrl = "";

        public static string StrAnalyseConn
        {
            get
            {
                if (string.IsNullOrEmpty(strAnalyseConn))
                {
                    string strAnalyseSql = "SELECT APP_NAME,APP_SERVER_IP,APP_DB_NAME,APP_DB_USER,APP_DB_PASS,PORT FROM T_BI_APP WHERE BI_TYPE='ANALYSE' AND APPR_STUS = 'Y' AND USE_YN = 'Y' ";
                  
                    DataTable dtAnalyse = Execute.ExecuteDataTable(strCenterConnSql, strAnalyseSql);

                    if (dtAnalyse.Rows.Count == 0)
                    {
                        return "";
                    }
                    //strAnalyseConn = "server=" + dtAnalyse.Rows[0]["APP_SERVER_IP"].ToString() + ";user id=" + dtAnalyse.Rows[0]["APP_DB_USER"].ToString() + ";password=" + DBUtility.SETCSS.Lywin(dtAnalyse.Rows[0]["APP_DB_PASS"].ToString()) + ";database=" + dtAnalyse.Rows[0]["APP_DB_NAME"].ToString() + ";CharSet=utf8;port=30005;";

                    strAnalyseConn = "server=" + dtAnalyse.Rows[0]["APP_SERVER_IP"].ToString() + ";user id=" + dtAnalyse.Rows[0]["APP_DB_USER"].ToString() + ";password=" + DBUtility.SETCSS.Lywin(dtAnalyse.Rows[0]["APP_DB_PASS"].ToString()) + ";database=" + dtAnalyse.Rows[0]["APP_DB_NAME"].ToString() + ";CharSet=utf8;port=" +  int.Parse(dtAnalyse.Rows[0]["PORT"].ToString());
                }
                return strAnalyseConn;
            }
        }
        public static string StrReportConn
        {
            get
            {
                if (string.IsNullOrEmpty(strReportConn))
                {
                    string strReportSql = "SELECT APP_NAME,APP_SERVER_IP,APP_DB_NAME,APP_DB_USER,APP_DB_PASS,PORT FROM T_BI_APP WHERE BI_TYPE='REPORT' AND APPR_STUS = 'Y' AND USE_YN = 'Y' ";

                    DataTable dtReport = Execute.ExecuteDataTable(strCenterConnSql, strReportSql);

                    if (dtReport.Rows.Count == 0)
                    {
                        return "";
                    }
                    //strReportConn = "server=" + dtReport.Rows[0]["APP_SERVER_IP"].ToString() + ";user id=" + dtReport.Rows[0]["APP_DB_USER"].ToString() + ";password=" + DBUtility.SETCSS.Lywin(dtReport.Rows[0]["APP_DB_PASS"].ToString()) + ";database=" + dtReport.Rows[0]["APP_DB_NAME"].ToString() + ";CharSet=utf8;port=30005;";
                    strReportConn = "server=" + dtReport.Rows[0]["APP_SERVER_IP"].ToString() + ";user id=" + dtReport.Rows[0]["APP_DB_USER"].ToString() + ";password=" + DBUtility.SETCSS.Lywin(dtReport.Rows[0]["APP_DB_PASS"].ToString()) + ";database=" + dtReport.Rows[0]["APP_DB_NAME"].ToString() + ";CharSet=utf8;port=" + int.Parse(dtReport.Rows[0]["PORT"].ToString());
                }
                return strReportConn;
            }
        }
        public static DataTable DtCrmConn
        {
            get
            {
                if (dtCrmConn.Rows.Count == 0)
                {
                    string strCrmSql = "SELECT DISTINCT APP_SERVER_IP,APP_DB_NAME,APP_DB_USER,APP_DB_PASS,PORT FROM "
                        + "(SELECT APP_SERVER_IP,APP_DB_NAME,APP_DB_USER,APP_DB_PASS,PORT FROM T_BI_APP WHERE BI_TYPE='CRM' AND APPR_STUS = 'Y' AND USE_YN = 'Y' "
                        + "union all select DISTINCT CRM_DB_IP,CRM_DB_NAME,CRM_DB_USER,CRM_DB_PASS,CRM_DB_PORT from T_CRM_GROUP WHERE USE_YN='Y') A ";

                    dtCrmConn = Execute.ExecuteDataTable(strCenterConnSql, strCrmSql);
                }
                return dtCrmConn;
            }
        }
        public static string StrApiUrl
        {
            get
            {
                //if (string.IsNullOrEmpty(strApiUrl))
                //{
                //    string strApiSql = "SELECT TOP 1 [FACT_SERVER_IP],[SERVER_URL] FROM [T_SERVER_IP] WHERE [BI_YN]='Y' AND [USE_YN]='Y' order by newid()";
                //    //获取API的URL
                //    DataTable dtApi = Execute.ExecuteDataTable(strCenterConnSql, strApiSql);

                //    if (dtApi.Rows.Count == 0)
                //    {
                //        return "";
                //    }
                //    strApiUrl = dtApi.Rows[0]["SERVER_URL"].ToString();
                //}
                return strApiUrl;
            }
        }
        //MYSQL特殊符号处理
        public static string StrReplaceMySql(string str)
        {
            str = str.Replace("'", "''");
            str = str.Replace("\\", "\\\\");
            return str;
        }
        //SQLServer特殊符号处理
        public static string StrReplaceSQLServer(string str)
        {
            str = str.Replace("'", "''"); 
            return str;
        }
    }
}
