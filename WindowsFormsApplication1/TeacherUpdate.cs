using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class TeacherUpdate : Form
    {
        private Boolean b = false;//用于判断用户是否查询到此用户
        private Label lb2 = null;
        private Label lb3 = null;
        private Label lb4 = null;
        private Label lb5 = null;
        private Label lb6 = null;
        private TextBox textBox2 = null;
        private TextBox textBox3 = null;
        private TextBox textBox4 = null;
        private TextBox textBox5 = null;
        private Panel pl=null;
        private RadioButton rb1 = null;
        private RadioButton rb2 = null;


        private Teacher mTeacher=new Teacher();

        private static TeacherUpdate teacherUpdate = null;
        private TeacherUpdate()
        {
            InitializeComponent();
        }
        //单例模式
        public static TeacherUpdate _getInstance()
        {
            if (teacherUpdate == null || teacherUpdate.IsDisposed)
            {
                teacherUpdate = new TeacherUpdate();
            }
            return teacherUpdate;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //判断教工号【是否符合条件，是否被修改】
            if (!mTeacher.Id.Equals(textBox1.Text.ToString().Trim()))
            {
                if (Util.checkTeacherId(textBox1.Text.ToString().Trim()))
                    mTeacher = new TeacherDB().selectTeacherById(textBox1.Text.ToString().Trim());//如果教工号改变则重新获取mTeacher
                else
                {
                    textBox1.Select();
                    return;
                }
            }
            
            //如果控件已经存在就删除重建;
            Util.checkView(this);


            //姓名
            lb2 = new Label();
            lb2.Name = "lb2";
            lb2.Text = "教师姓名:";
            lb2.Top = label1.Top + 40;
            lb2.Left = label1.Left;
            lb2.Width = 59;
            this.Controls.Add(lb2);
            textBox2 = new TextBox();
            textBox2.Top = lb2.Top;
            textBox2.Left = textBox1.Left;
            textBox2.Width = 100;
            textBox2.Height = 21;
            textBox2.Text = mTeacher.Name.ToString();
            this.Controls.Add(textBox2);

            //性别控件
            lb3 = new Label();
            lb3.Name = "lb3";
            lb3.Text = "性别:";
            lb3.Top = lb2.Top + 40;
            lb3.Left = lb2.Left;
            lb3.Width = 50;
            this.Controls.Add(lb3);
            pl = new Panel();
            pl.Top = lb3.Top;
            pl.Left = textBox2.Left;
            pl.Width=130;
            pl.Height = 28;
            rb1 = new RadioButton();
            rb1.Text = "男";
            rb1.Width = 35;
            rb1.Height = 16;
            rb1.Left = 15;
            rb2 = new RadioButton();
            rb2.Text = "女";
            rb2.Width = 35;
            rb2.Height = 16;
            rb2.Left = rb1.Left+50;
            if (mTeacher.Sex.Equals("男"))
                rb1.Checked = true;
            else
                rb2.Checked = true;
            pl.Controls.Add(rb2);
            pl.Controls.Add(rb1);
            this.Controls.Add(pl);


            //单位名称
            lb4 = new Label();
            lb4.Name = "lb4";
            lb4.Text="单位名称:";
            lb4.Top = lb3.Top + 40;
            lb4.Left = lb3.Left;
            lb4.Width = 59;
            this.Controls.Add(lb4);
            textBox3 = new TextBox();
            textBox3.Top = lb4.Top;
            textBox3.Left = textBox2.Left;
            textBox3.Width = 100;
            textBox3.Height = 21;
            textBox3.Text = mTeacher.Organization.ToString();
            this.Controls.Add(textBox3);


            //家庭地址
            lb5 = new Label();
            lb5.Name = "lb5";
            lb5.Text = "家庭地址:";
            lb5.Top = lb4.Top + 40;
            lb5.Left = lb3.Left;
            lb5.Width = 59;
            this.Controls.Add(lb5);
            textBox4 = new TextBox();
            textBox4.Top = lb5.Top;
            textBox4.Left = textBox2.Left;
            textBox4.Width = 135;
            textBox4.Height = 21;
            textBox4.Text = mTeacher.Address.ToString();
            this.Controls.Add(textBox4);



            //联系电话
            lb6 = new Label();
            lb6.Name = "lb6";
            lb6.Text = "联系电话:";
            lb6.Top = lb5.Top + 40;
            lb6.Left = lb3.Left;
            lb6.Width = 59;
            this.Controls.Add(lb6);
            textBox5 = new TextBox();
            textBox5.Top = lb6.Top;
            textBox5.Left = textBox2.Left;
            textBox5.Width = 135;
            textBox5.Height = 21;
            textBox5.Text = mTeacher.Phone.ToString();
            this.Controls.Add(textBox5);

            b = true;//查询完成
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                MessageBox.Show("请先查询!", "警告!");
                return;
            }
            //判断教工号【是否符合条件，是否被修改】
            if (!mTeacher.Id.Equals(textBox1.Text.ToString().Trim()))
            {
                if(Util.checkTeacherId(textBox1.Text.ToString().Trim()))
                    mTeacher.Id = textBox1.Text.ToString().Trim();//如果教工号改变则重新为mTeacher的id赋值;
                else
                {
                    textBox1.Select();
                    return;
                }
                
            }
            //开始为mTeacher赋值
                mTeacher.Name = textBox2.Text.ToString().Trim();
                if (rb1.Checked)
                    mTeacher.Sex = "男";
                else
                    mTeacher.Sex = "女";
                
                mTeacher.Organization = textBox3.Text.ToString().Trim();
                mTeacher.Address = textBox4.Text.ToString().Trim();
                mTeacher.Phone = textBox5.Text.ToString().Trim();
                TeacherDB tdb = new TeacherDB();
                tdb.updata(mTeacher);
                if (tdb.updata(mTeacher) == 0)
                {
                    MessageBox.Show("修改失败!", "警告!");
                    return;
                }
                else
                {
                    MessageBox.Show("修改成功!", "消息!");
                    TeacherSelect._getInstance().resetData();
                    SalarySelect._getInstance().resetData();
                }

                //如果控件已经存在就删除重建;
                textBox1.Text = "";
                Util.checkView(this);


                b = false;//查询未完成
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeacherDB tdb = new TeacherDB();
            if ("".Equals(textBox1.Text.ToString().Trim()))
            {
                MessageBox.Show("教工号不能为空!","警告!");
                return;
            }
            if (tdb.delete(textBox1.Text.ToString().Trim())==0)
            {
                MessageBox.Show("用户名不存在!","警告!");
                return;
            }
            TeacherSelect._getInstance().resetData();
            SalarySelect._getInstance().resetData();
            MessageBox.Show("删除成功!","消息!");
            textBox1.Text = "";
            //如果控件已经存在就删除重建;
            Util.checkView(this);
        }
    }
}
