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
    public partial class SalaryIFM : Form
    {
        private Boolean flag;
        private static SalaryIFM salaryIFM = null;
        private SalaryIFM()
        {
            InitializeComponent();
        }
        public static SalaryIFM _getInstance()
        {
            if (salaryIFM == null || salaryIFM.IsDisposed)
            {
                salaryIFM = new SalaryIFM();
            }
            return salaryIFM;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;//初始化flag
            //判断教工号格式
            if(!Util.checkInputTeacherId(textBox1.Text.ToString().Trim(),label7,1))
                flag=false;

            //判断基本工资
            if (!Util.checkSalary(textBox2, label8))
                flag = false;
           

            //判断津贴
            if (!Util.checkSalary(textBox3, label9))
                flag = false;

            //判断公积金
            if (!Util.checkSalary(textBox4, label10))
                flag = false;

            //判断生活费
            if (!Util.checkSalary(textBox5, label11))
                flag = false;

            //判断所得税
            if (!Util.checkSalary(textBox6, label12))
                flag = false;
            


            if (flag == true)
            {
                Teacher mTeacher = new TeacherDB().selectTeacherById(textBox1.Text.ToString().Trim());
                mTeacher.BaseSalary = float.Parse(textBox2.Text.ToString().Trim());
                mTeacher.Allowance = float.Parse(textBox3.Text.ToString().Trim());
                mTeacher.Fund = float.Parse(textBox4.Text.ToString().Trim());
                mTeacher.Sanitary = float.Parse(textBox5.Text.ToString().Trim());
                mTeacher.IncomeTax = float.Parse(textBox6.Text.ToString().Trim());
                TeacherDB tdb = new TeacherDB();
                if (tdb.updata(mTeacher) == 0)
                {
                    MessageBox.Show("插入失败!", "警告!");
                    return;
                }
                else
                {
                    TeacherSelect._getInstance().resetData();
                    SalarySelect._getInstance().resetData();
                    MessageBox.Show("插入成功!", "消息!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    label7.Text = "";
                    label8.Text = "";
                    label9.Text = "";
                    label10.Text = "";
                    label11.Text = "";
                    label12.Text = "";
                }
            }
        }
    }
}
