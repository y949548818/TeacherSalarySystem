using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Register : Form
    {
        //userDB操作类
        private UserDB userDB = new UserDB();

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ("".Equals(textBox1.Text))
            {
                MessageBox.Show("用户名不能为空!","警告!");
                textBox1.Select();
                return;
            }
            if ("".Equals(textBox2.Text))
            {
                MessageBox.Show("密码不能为空!", "警告!");
                textBox2.Select();
                return;
            }
            if ("".Equals(textBox3.Text))
            {
                MessageBox.Show("请确认密码!", "警告!");
                textBox3.Select();
                return;
            }
            if (!textBox2.Text.ToString().Equals(textBox3.Text.ToString()))
            {
                MessageBox.Show("两次密码输入不一致!", "警告!");
                textBox3.Select();
                return;
            }



            String username = textBox1.Text;
            String password = textBox2.Text;

            if (userDB.selectUserByUserName(username) != null)
            {
                MessageBox.Show("用户名已存在!", "消息!");
                textBox1.Select();
                return;
            }

            User user = new User();
            user.UserName = username;
            user.PassWord = password;

            if (userDB.insert(user) == 1)
            {
                MessageBox.Show("注册成功!", "消息!");
                Login.f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败!未知错误!", "消息!");
            }



        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.f.Show();
        }
    }
}
