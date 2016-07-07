using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public partial class UserIFM : Form
    {
        private Boolean flag;
        private static UserIFM userIFM = null;
        private UserIFM()
        {
            InitializeComponent();
        }

        public static UserIFM _getInstance()
        {
            if (userIFM == null || userIFM.IsDisposed)
            {
                userIFM = new UserIFM();
            }
            return userIFM;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;//初始化flag
            //判断教工号格式
            if (!Util.checkInputTeacherId(textBox1.Text.ToString().Trim(), label7,2))
                flag = false;

            //判断手机号码格式
            Regex phoneReg = new Regex("1[3,5,7,8][0,2,3,6,5,7,8][0-9]{8}");
            if (phoneReg.IsMatch(textBox5.Text.Trim()))
            {
                label8.Text = "通过!";
            }
            else
            {
                label8.Text ="手机号输入有误!";
                flag = false;
            }

            //判断姓名是否为空
            if (Util.isEmpty(textBox2.Text))
            {
                label9.Text = "不能为空!";
                flag = false;
            }
            else
            {
                label9.Text = "通过!";
            }

            //判断单位名称是否为空
            if (Util.isEmpty(textBox3.Text))
            {
                label10.Text = "不能为空!";
                flag = false;
            }
            else
            {
                label10.Text = "通过!";
            }

            //判断家庭住址是否为空
            if (Util.isEmpty(textBox4.Text))
            {
                label11.Text = "不能为空!";
                flag = false;
            }
            else
            {
                label11.Text = "通过!";
            }
            if (flag == true)
            {
                Teacher mTeacher = new Teacher();
                mTeacher.Id = textBox1.Text.ToString().Trim();
                mTeacher.Name = textBox2.Text.ToString().Trim();
                if (radioButton1.Checked)
                    mTeacher.Sex = "男";
                else
                    mTeacher.Sex = "女";
                mTeacher.Organization = textBox3.Text.ToString().Trim();
                mTeacher.Address = textBox4.Text.ToString().Trim();
                mTeacher.Phone = textBox5.Text.ToString().Trim();
                TeacherDB mTeacherDB = new TeacherDB();
                mTeacherDB.insert(mTeacher);

                MessageBox.Show("录入成功!");
                TeacherSelect._getInstance().resetData();
                SalarySelect._getInstance().resetData();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                radioButton1.Checked = true;
                label7.Text = "";
                label8.Text = "";
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";

            }

        }
        


    }
}
