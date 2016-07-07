using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Add Mysql Library
using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class UserDB
    {

        private MySqlConnection connection;
        private MySqlCommand cmd;
        public UserDB()
        {
            connection = DBConnection.getConnection();
        }

        /**
         * 
         * 根据username查询管理员
         * 
         */
        public User selectUserByUserName(String userName)
        {
            String sql = "select * from admin where username='" + userName + "'";
            //Console.WriteLine(sql);
            connection.Open();
            cmd = new MySqlCommand(sql, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                User user = new User();
                user.UserName = dataReader["username"].ToString();
                user.PassWord = dataReader["password"].ToString();
                Console.WriteLine(user.ToString());

                //关闭连接
                dataReader.Close();
                closeConnection();


                return user;
            }

            //关闭连接
            dataReader.Close();
            closeConnection();
            return null;




        }

        /**
         * 
         * 插入管理员用户
         * 
         */
        public int insert(User user)
        {
            String sql = "insert into admin values('" + user.UserName + "','" + user.PassWord + "')";
            connection.Open();
            cmd = new MySqlCommand(sql, connection);
            int n = cmd.ExecuteNonQuery();

            //关闭连接
            closeConnection();

            return n;
        }






        /**
         * 
         * 关闭数据库连接
         * 
         **/
        public void closeConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
            GC.Collect();
        }



    }
}
