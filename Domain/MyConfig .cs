using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MyConfig : Users
    {
        public DbContext db { get; private set; }

        public MyConfig()
        {

           
            db = new Users();

            db.Database.Connection.ConnectionString = DefaultConnection.ConnectionString;
        }

        #region  数据库连接字符串

        public static string DefaultConnectionString = "";

        public static IDbConnection DefaultConnection
        {
            get
            {
                //IDbConnection defaultConn = new System.Data.SqlClient.SqlConnection();
                IDbConnection defaultConn = new MySql.Data.MySqlClient.MySqlConnection();
                defaultConn.ConnectionString= DefaultConnectionString = ConfigurationManager.ConnectionStrings["AuthMySqlCon"].ConnectionString;
                return defaultConn;
            }
        }

        public static string DataBaseConnectionString(string EntityName)
        {
            IDbConnection con = DefaultConnection;
            return EFConnectionStringModel(EntityName, DefaultConnectionString);
        }

        static string EFConnectionStringModel(string EntityName, string DBsoure)
        {
            return string.Concat("metadata=res://*/",
              EntityName, ".csdl|res://*/",
              EntityName, ".ssdl|res://*/",
              EntityName, ".msl;provider=System.Data.SqlClient;provider connection string='",
              DBsoure, "'");
        }
        #endregion


        #region SQL拦截器
        ///// <summary>
        ///// 配置EF执行SQL拦截器
        ///// </summary>
        //public static void EFTracingConfig(ILog log4net)
        //{
        //    //注册拦截器
        //    EFTracingProviderConfiguration.RegisterProvider();
        //    //SQL日志
        //    log4net.ILog log = null;
        //    bool isdebug = (ConfigurationManager.AppSettings["isdebug"] == "true");
        //    if (isdebug)
        //    {
        //        log = log4net;
        //    }
        //    EFTracingProviderConfiguration.LogToLog4net = log;
        //}
        #endregion
    }
}
