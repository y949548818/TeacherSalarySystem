using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    class Util
    {
        private static Queue<Control> query=null;// = new Queue<Control>();
        private Util()
        {
        }
        /**
         * 单例模式创建队列query
         */
        private static Queue<Control> queue_getInstance()
        {
            if(query==null)
                query=new Queue<Control>();

            return query;
        }
        /**
         *将所有窗体内的空间放入队列query
         */
        private static void DS(Control item)
        {
            for (int i = 0; i < item.Controls.Count; i++)
            {
                //递归调用
                if (item.Controls[i].HasChildren)//判断是否包含子控件
                {
                    DS(item.Controls[i]);
                }
                else
                {
                    query.Enqueue(item.Controls[i]);//将控件添加到队列query
                }
            }
        }

        /*
         * 销毁无用控件
         */
        public static void checkView(Control item)
        {
            queue_getInstance();
            query.Clear();
            DS(item);
            Control c = null;
            while (query.Count != 0)
            {
                c = query.Dequeue();
                if (!c.Name.Equals("label1") && !c.Name.Equals("textBox1") && !c.Name.Equals("button1") && !c.Name.Equals("button2") && !c.Name.Equals("button3"))//保留需要存在的控件
                    c.Dispose();
            }

        }

        /*
         * 判断是否是合法数值
         */
        public static int checkNum(String str)
        {
            int f = 0;
            try
            {
                float.Parse(str);//判断类型转换异常
                if (!float.Parse(str).ToString().Equals(str))//判断0开头数值
                {
                    f = 1;
                }
            }
            catch (Exception ee)
            {
                f = -1;
            }

            return f;
        }

        /*
         *教工号判断 
         * 
         */
        public static Boolean checkTeacherId(String str){
            if ("".Equals(str))
            {
                MessageBox.Show("教工号不能为空!", "警告!");
                return false;
            }
            else
            {
                Regex idReg = new Regex("[A-Z]{3}[0-9]{3}");
                if (!idReg.IsMatch(str))
                {
                    MessageBox.Show("格式应为：ABC123", "警告!");
                    return false;
                }

                Teacher mTeacher = new TeacherDB().selectTeacherById(str);
                if (mTeacher == null)
                {
                    MessageBox.Show("教工号不存在!", "注意!");
                    return false;

                }
            }

            return true;
        }
        /*
         * 
         *判断录入的教工号格式 
         */
        public static Boolean checkInputTeacherId(String str,Label lb,int a)
        {
            if (a == 1)
            {
                Regex idReg = new Regex("[A-Z]{3}[0-9]{3}");
                if (idReg.IsMatch(str))
                {
                    if ((new TeacherDB().selectTeacherById(str) == null))
                    {

                        lb.Text = "用户不存在!";
                        return false;
                    }
                    else
                        lb.Text = "通过!";
                }
                else
                {
                    lb.Text = "格式应为：ABC123";
                    return false;
                }
                return true;
            }
            else
            {
                Regex idReg = new Regex("[A-Z]{3}[0-9]{3}");
                if (idReg.IsMatch(str))
                {
                    if (!(new TeacherDB().selectTeacherById(str) == null))
                    {

                        lb.Text = "用户已存在!";
                        return false;
                    }
                    else
                        lb.Text = "通过!";
                }
                else
                {
                    lb.Text = "格式应为：ABC123";
                    return false;
                }
                return true;
            }
        }


        

        /*
         *判断工资格式 
         */

        public static Boolean checkSalary(TextBox tb, Label lb)
        {
            try
            {
                float.Parse(tb.Text);
                if (float.Parse(tb.Text).ToString().Equals(tb.Text))
                {
                    lb.Text = "通过!";
                }
                else
                {
                    lb.Text = "请输入正确的数值!";
                    return false;

                }
            }
            catch (Exception ee)
            {
                lb.Text = "请输入数值!";
                return false;
            }

            return true;
        }


        /*
         *空值判断 
         */
        public static Boolean isEmpty(String str)
        {
            if (str.Equals(""))
                return true;
            return false;
        }
        
    }
}
