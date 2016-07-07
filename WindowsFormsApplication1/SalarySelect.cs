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
    public partial class SalarySelect : Form
    {
        private static SalarySelect salarySelect = null;

        private SalarySelect()
        {
            InitializeComponent();
        }


        public static SalarySelect _getInstance()
        {
            if (salarySelect == null || salarySelect.IsDisposed)
            {
                salarySelect = new SalarySelect();
            }
            return salarySelect;
        }
        public void resetData()
        {
            DataSet dstmp = new DataSet();
            //创建虚拟数据表  
            DataTable table = new DataTable("TAB_NM");
            //获取列集合,添加列  
            DataColumnCollection columns = table.Columns;
            columns.Add("教工号", typeof(String));
            columns.Add("姓名", typeof(String));
            columns.Add("基本工资", typeof(float));
            columns.Add("津贴", typeof(float));
            columns.Add("公积金", typeof(float));
            columns.Add("生活费", typeof(float));
            columns.Add("所得税", typeof(float));



            List<Teacher> list = new TeacherDB().selectAll();
            //Teacher mTeacher = new Teacher();
            foreach (Teacher mTeacher in list)
            {
                //添加一行记录
                DataRow row = table.NewRow();
                row["教工号"] = mTeacher.Id;
                row["姓名"] = mTeacher.Name;
                row["基本工资"] = mTeacher.BaseSalary;
                row["津贴"] = mTeacher.Allowance;
                row["公积金"] = mTeacher.Fund;
                row["生活费"] = mTeacher.Sanitary;
                row["所得税"] = mTeacher.IncomeTax;
                table.Rows.Add(row);

            }
            dstmp.Tables.Add(table); //把信息表放入DataSet中  

            dataGridView1.DataSource = dstmp.Tables["TAB_NM"];


        }
        private void SalarySelect_Load(object sender, EventArgs e)
        {
            resetData();
        }

    }
}
