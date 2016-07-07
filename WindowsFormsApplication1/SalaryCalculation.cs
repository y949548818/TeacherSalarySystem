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
    public partial class SalaryCalculation : Form
    {
        private static SalaryCalculation salaryCalculation = null;
        private Teacher mTeacher;
        private SalaryCalculation()
        {
            InitializeComponent();
        }
        public static SalaryCalculation _getInstance()
        {
            if (salaryCalculation == null || salaryCalculation.IsDisposed)
            {
                salaryCalculation = new SalaryCalculation();
            }
            return salaryCalculation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Util.checkTeacherId(textBox1.Text.ToString().Trim()) == false)
                return;
            else
                mTeacher = new TeacherDB().selectTeacherById(textBox1.Text.ToString().Trim());

            textBox2.Text = (mTeacher.BaseSalary + mTeacher.Allowance).ToString();
            textBox3.Text = (mTeacher.Fund + mTeacher.Sanitary + mTeacher.IncomeTax).ToString();
            textBox4.Text = (Double.Parse(textBox2.Text.ToString().Trim()) - Double.Parse(textBox3.Text.ToString().Trim())).ToString();

        }
    }
}
