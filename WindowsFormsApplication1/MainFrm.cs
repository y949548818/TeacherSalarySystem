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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void 录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UserIFM mUserIFM = UserIFM._getInstance();
            mUserIFM.MdiParent = this;
            //mUserIFM.StartPosition = FormStartPosition.CenterScreen;//在父窗体内居中显示
            mUserIFM.Show();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherUpdate mTeacherUpdate = TeacherUpdate._getInstance();
            mTeacherUpdate.MdiParent = this;
            //mTeacherUpdate.StartPosition = FormStartPosition.CenterScreen;//在父窗体内居中显示
            mTeacherUpdate.Show();
        }

        private void 浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherSelect mTeacherSelect = TeacherSelect._getInstance();
            mTeacherSelect.MdiParent = this;
            //mTeacherSelect.StartPosition = FormStartPosition.CenterScreen;//在父窗体内居中显示
            mTeacherSelect.Show();
        }

        private void 薪资管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryIFM mSalaryIFM = SalaryIFM._getInstance();
            mSalaryIFM.MdiParent = this;
            //mSalaryIFM.StartPosition = FormStartPosition.CenterScreen;//在父窗体内居中显示
            mSalaryIFM.Show();
        }

        private void 教师数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryUpdate mSalaryUpdate = SalaryUpdate._getInstance();
            mSalaryUpdate.MdiParent = this;
            //mSalaryUpdate.StartPosition = FormStartPosition.CenterScreen;//在父窗体内居中显示
            mSalaryUpdate.Show();
        }

        private void 综合信息输出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalarySelect mSalarySelect = SalarySelect._getInstance();
            mSalarySelect.MdiParent = this;
            //mSalarySelect.StartPosition = FormStartPosition.CenterScreen;//在父窗体内居中显示
            mSalarySelect.Show();
        }

        private void 薪资计算ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryCalculation mSalaryCalculation = SalaryCalculation._getInstance();
            mSalaryCalculation.MdiParent = this;
            //mSalaryCalculation.StartPosition = FormStartPosition.CenterScreen;//在父窗体内居中显示
            mSalaryCalculation.Show();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.f.Close();
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login.f.Close();
        }

    }
}
