using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class SalaryUpdate : Form
    {
        private Boolean b = false;
        private Label lb2 = null;
        private Label lb3 = null;
        private Label lb4 = null;
        private Label lb5 = null;
        private Label lb6 = null;

        private TextBox textBox2 = null;
        private TextBox textBox3 = null;
        private TextBox textBox4 = null;
        private TextBox textBox5 = null;
        private TextBox textBox6 = null;

        private Teacher mTeacher=new Teacher();


        private static SalaryUpdate salaryUpdate = null;

        private SalaryUpdate()
        {
            InitializeComponent();
        }
        public static SalaryUpdate _getInstance()
        {
            if (salaryUpdate == null || salaryUpdate.IsDisposed)
            {
                salaryUpdate = new SalaryUpdate();
            }
            return salaryUpdate;
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
            

            //基本工资
            lb2 = new Label();
            lb2.Text = "基本工资:";
            lb2.Top = label1.Top + 40;
            lb2.Left = label1.Left;
            lb2.Width = 59;
            this.Controls.Add(lb2);
            textBox2 = new TextBox();
            textBox2.Top = lb2.Top;
            textBox2.Left = textBox1.Left;
            textBox2.Width = 100;
            textBox2.Height = 21;
            textBox2.Text = mTeacher.BaseSalary.ToString();
            this.Controls.Add(textBox2);


            //津贴
            lb3 = new Label();
            lb3.Text = "津贴:";
            lb3.Top = lb2.Top + 40;
            lb3.Left = lb2.Left;
            lb3.Width = 59;
            this.Controls.Add(lb3);
            textBox3 = new TextBox();
            textBox3.Top = lb3.Top;
            textBox3.Left = textBox1.Left;
            textBox3.Width = 100;
            textBox3.Height = 21;
            textBox3.Text = mTeacher.Allowance.ToString();
            this.Controls.Add(textBox3);

            //公积金
            lb4 = new Label();
            lb4.Text = "公积金:";
            lb4.Top = lb3.Top + 40;
            lb4.Left = lb3.Left;
            lb4.Width = 59;
            this.Controls.Add(lb4);
            textBox4 = new TextBox();
            textBox4.Top = lb4.Top;
            textBox4.Left = textBox1.Left;
            textBox4.Width = 100;
            textBox4.Height = 21;
            textBox4.Text = mTeacher.Fund.ToString();
            this.Controls.Add(textBox4);


            //生活费
            lb5 = new Label();
            lb5.Text = "生活费:";
            lb5.Top = lb4.Top + 40;
            lb5.Left = lb2.Left;
            lb5.Width = 59;
            this.Controls.Add(lb5);
            textBox5 = new TextBox();
            textBox5.Top = lb5.Top;
            textBox5.Left = textBox1.Left;
            textBox5.Width = 100;
            textBox5.Height = 21;
            textBox5.Text = mTeacher.Sanitary.ToString();
            this.Controls.Add(textBox5);


            //所得税
            lb6 = new Label();
            lb6.Text = "所得税:";
            lb6.Top = lb5.Top + 40;
            lb6.Left = lb2.Left;
            lb6.Width = 59;
            this.Controls.Add(lb6);
            textBox6 = new TextBox();
            textBox6.Top = lb6.Top;
            textBox6.Left = textBox1.Left;
            textBox6.Width = 100;
            textBox6.Height = 21;
            textBox6.Text = mTeacher.IncomeTax.ToString();
            this.Controls.Add(textBox6);

            b = true;
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
                if (Util.checkTeacherId(textBox1.Text.ToString().Trim()))
                    mTeacher.Id = textBox1.Text.ToString().Trim();//如果教工号改变则重新为mTeacher的id赋值;
                else
                {
                    textBox1.Select();
                    return;
                }

            }

            int f;//临时变量判断所有值是否全部检查通过;
                if ((f=Util.checkNum(textBox2.Text.ToString().Trim()))==0)
                    mTeacher.BaseSalary = float.Parse(textBox2.Text.ToString().Trim());
                else
                {
                    if(f==1)
                        MessageBox.Show("请输入正确数值!(基本工资)", "警告!");
                    else
                        MessageBox.Show("请输入数值!(基本工资)", "警告!");
                    textBox2.Select();
                    return;
                }
                    
                if ((f=Util.checkNum(textBox3.Text.ToString().Trim()))==0)
                    mTeacher.Allowance = float.Parse(textBox3.Text.ToString().Trim());
                else
                {
                    if (f == 1)
                        MessageBox.Show("请输入正确数值!(津贴)", "警告!");
                    else
                        MessageBox.Show("请输入数值!(津贴)", "警告!");
                    textBox3.Select();
                    return;
                }
                if ((f=Util.checkNum(textBox4.Text.ToString().Trim()))==0)
                    mTeacher.Fund = float.Parse(textBox4.Text.ToString().Trim());
                else
                {
                    if (f == 1)
                        MessageBox.Show("请输入正确数值!(公积金)", "警告!");
                    else
                        MessageBox.Show("请输入数值!(公积金)", "警告!");
                    textBox4.Select();
                    return;
                }
                if ((f=Util.checkNum(textBox5.Text.ToString().Trim()))==0)
                    mTeacher.Sanitary = float.Parse(textBox5.Text.ToString().Trim());
                else
                {
                    if (f == 1)
                        MessageBox.Show("请输入正确数值!(生活费)", "警告!");
                    else
                        MessageBox.Show("请输入数值!(生活费)", "警告!");
                    textBox5.Select();
                    return;
                }
                if ((f=Util.checkNum(textBox6.Text.ToString().Trim()))==0)
                    mTeacher.IncomeTax = float.Parse(textBox6.Text.ToString().Trim());
                else
                {
                    if (f == 1)
                        MessageBox.Show("请输入正确数值!(所得税)", "警告!");
                    else
                        MessageBox.Show("请输入数值!(所得税)", "警告!");
                    textBox6.Select();
                    return;
                }
                TeacherDB tdb = new TeacherDB();
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
            
        }

    }
}
