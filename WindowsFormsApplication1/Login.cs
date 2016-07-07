using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Add Mysql Library
using MySql.Data.MySqlClient;


namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public static Form f;
        //数据库操作类
        private UserDB userDB=new UserDB();

        private String username;
        private String password;
        private MySqlConnection connection;
        public Login()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "Page.ssk";

            f = this;
            init();
            


        }
        public void test()
        {
            TeacherDB teacherDB = new TeacherDB();


            
            //测试delete
            Console.WriteLine(teacherDB.delete("teacher"));
            


            
            //测试update
            /*Teacher t1 = new Teacher();
            t1.Id = "ABC111";
            t1.Name = "zxcxzczxc";
            Console.WriteLine(teacherDB.updata(t1));*/
            

            /*
            //测试insert
            Teacher t1 = new Teacher();
            t1.Id = "test1";
            teacherDB.insert(t1);
            */


            /*
            //测试selectTeacherByUserName
            Teacher t1 = new Teacher();
            t1 = teacherDB.selectTeacherById("teacher");
            MessageBox.Show(t1.ToString());
            */



            /*
            //测试selectAll
            List<Teacher> all = teacherDB.selectAll();
            foreach (Teacher t1 in all)
            {
                Console.WriteLine(t1.ToString());
            }
            */





        }

        public void init() 
        {
            connection = DBConnection.getConnection();
        }

        public void closeConnection()
        {
            if (connection != null)
            {
                connection.Close();
                connection.Dispose();
            }
            GC.Collect();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //test();
            //return;








            username = usernametxt.Text;
            password = pwdtxt.Text;

            User user = null;
            user = userDB.selectUserByUserName(username);
            //MessageBox.Show(user.ToString());


            if (user == null)
            {
                MessageBox.Show("用户名不存在！", "登陆出错");
                usernametxt.Select();
                return;
            }
            if(user.PassWord!=password)
            {
                MessageBox.Show("密码错误！", "登陆出错");
                pwdtxt.Select();
                return;
            }

            MainFrm main = new MainFrm();
            main.Show();
            this.Hide();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register mRegister = new Register();
            mRegister.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
