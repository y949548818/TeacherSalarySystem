using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Add Mysql Library
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace WindowsFormsApplication1
{
    class TeacherDB
    {
        private MySqlConnection connection;
        private MySqlCommand cmd;
        public TeacherDB()
        {
            connection = DBConnection.getConnection();
        }
        
        /**
         * 
         * 通过teacherid查询teacher
         * 
         */
        public Teacher selectTeacherById(String teacherId)
        {
            String sql = "select * from teachers where teacher_id='" + teacherId + "'";
            //Console.WriteLine(sql);
            connection.Open();
            cmd = new MySqlCommand(sql, connection);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            if (dataReader.Read())
            {
                Teacher teacher = new Teacher();
                try
                {
                    teacher.Id = dataReader.GetString(0);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Id = "";
                }
                try
                {
                    teacher.Name = dataReader.GetString(1);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Name = "";
                }
                try
                {
                    teacher.Sex = dataReader.GetString(2);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Sex = "";
                }
                try
                {
                    teacher.Organization = dataReader.GetString(3);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Organization = "";
                }
                try
                {
                    teacher.Address = dataReader.GetString(4);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Address = "";
                }
                try
                {
                    teacher.Phone = dataReader.GetString(5);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Phone = "";
                }
                try
                {
                    teacher.BaseSalary = dataReader.GetFloat(6);
                }
                catch (SqlNullValueException e)
                {
                    teacher.BaseSalary = 0;
                }
                try
                {
                    teacher.Allowance = dataReader.GetFloat(7);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Allowance = 0;
                }
                try
                {
                    teacher.Fund = dataReader.GetFloat(8);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Fund = 0;
                }
                try
                {
                    teacher.Sanitary = dataReader.GetFloat(9);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Sanitary = 0;
                }
                try
                {
                    teacher.IncomeTax = dataReader.GetFloat(10);
                }
                catch (SqlNullValueException e)
                {
                    teacher.IncomeTax = 0;
                }

                //关闭连接
                dataReader.Close();
                closeConnection();


                return teacher;
            }

            //关闭连接
            dataReader.Close();
            closeConnection();
            return null;




        }


        /**
         * 
         * 查找全部teacher,返回List<Teacher>;
         * 
         */
        public List<Teacher> selectAll()
        {
            List<Teacher> all=new List<Teacher>();

            String sql = "select * from teachers";
            connection.Open();
            cmd = new MySqlCommand(sql, connection);
            MySqlDataReader dataReader= cmd.ExecuteReader();
            while (dataReader.Read())
            {
                
                Teacher teacher = new Teacher();
                try
                {
                    teacher.Id = dataReader.GetString(0);
                }
                catch(SqlNullValueException e)
                {
                    teacher.Id="";
                }
                try
                {
                    teacher.Name = dataReader.GetString(1);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Name = "";
                }
                try
                {
                    teacher.Sex = dataReader.GetString(2);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Sex = "";
                }
                try
                {
                    teacher.Organization = dataReader.GetString(3);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Organization = "";
                }
                try
                {
                    teacher.Address = dataReader.GetString(4);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Address = "";
                }
                try
                {
                    teacher.Phone = dataReader.GetString(5);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Phone = "";
                }
                try
                {
                    teacher.BaseSalary = dataReader.GetFloat(6);
                }
                catch (SqlNullValueException e)
                {
                    teacher.BaseSalary = 0;
                }
                try
                {
                    teacher.Allowance = dataReader.GetFloat(7);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Allowance = 0;
                }
                try
                {
                    teacher.Fund = dataReader.GetFloat(8);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Fund = 0;
                }
                try
                {
                    teacher.Sanitary = dataReader.GetFloat(9);
                }
                catch (SqlNullValueException e)
                {
                    teacher.Sanitary = 0;
                }
                try
                {
                    teacher.IncomeTax = dataReader.GetFloat(10);
                }
                catch (SqlNullValueException e)
                {
                    teacher.IncomeTax = 0;
                }
                

     
                
                
                

                all.Add(teacher);
            }

            //关闭连接
            dataReader.Close();
            closeConnection();

            return all;
        }




        /**
         * 
         * 插入teacher,失败返回0
         * 
         */
        public int insert(Teacher teacher)
        {
            String sql = "insert into teachers values('"
                            + teacher.Id + "','"
                            + teacher.Name + "','"
                            + teacher.Sex + "','"
                            + teacher.Organization + "','"
                            + teacher.Address + "','"
                            + teacher.Phone+ "',"
                            + teacher.BaseSalary + ","
                            + teacher.Allowance + ","
                            + teacher.Fund + ","
                            + teacher.Sanitary + ","
                            + teacher.IncomeTax + ")";

            //Console.WriteLine(sql);
            connection.Open();
            cmd = new MySqlCommand(sql, connection);
            int n = cmd.ExecuteNonQuery();


            //关闭连接
            closeConnection();

            return n;


        }


        /**
         * 
         * 根据teacher.id更新teacher,失败返回0
         * 
         */
        public int updata(Teacher teacher)
        {
            String sql = "update teachers set"
                            + " teacher_name='" + teacher.Name + "',"
                            + " teacher_sex='" + teacher.Sex + "',"
                            + " teacher_organization='" + teacher.Organization + "',"
                            + " teacher_address='" + teacher.Address + "',"
                            + " teacher_phone='" + teacher.Phone + "',"
                            + " salary_base=" + teacher.BaseSalary + ","
                            + " salary_allowance=" + teacher.Allowance + ","
                            + " salary_fund=" + teacher.Fund + ","
                            + " expenses_sanitary=" + teacher.Sanitary + ","
                            + " expenses_incomeTax=" + teacher.IncomeTax
                            + " where teacher_id='" + teacher.Id + "'";
            //Console.WriteLine(sql);
            connection.Open();
            cmd = new MySqlCommand(sql, connection);
            int n = cmd.ExecuteNonQuery();

            //关闭连接
            closeConnection();

            return n;
        }



        /**
         * 
         * 根据teacherId删除teacher,失败返回0
         * 
         */
        public int delete(String teacherId)
        {
            String sql = "delete from teachers where teacher_id='" + teacherId + "'";
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
