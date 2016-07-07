using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Add Mysql Library
using MySql.Data.MySqlClient;
using System.Data;


namespace WindowsFormsApplication1
{
    class DBConnection
    {

        private static String server = "5745515c2fd0b.sh.cdb.myqcloud.com";
        private static String port = "4942";
        private static String database = "teacherSalaryDB";
        private static String uid = "cdb_outerroot";
        private static String password = "qihong123456";
        private static String charset = "utf8";
        private static String connString = "";
        private static MySqlConnection connection;
        
        static DBConnection()
        {
            connString = "Data Source=" + server + ";"
                        + "port=" + port + ";"
                        + "Database=" + database + ";"
                        + "User Id=" + uid + ";"
                        + "password=" + password + ";"
                        + "CharSet=" + charset;
        }
        

        /**
         *获取数据库连接
         *
         **/
        public static MySqlConnection getConnection()
        {
            connection = new MySqlConnection(connString);

            return connection;
        }

  





    }
}
