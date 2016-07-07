using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Teacher
    {
        private String id="";
        
        public String Id
        {
            get { return id; }
            set { id = value; }
        }
        private String name = "";

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String sex = "";

        public String Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private String organization = "";

        public String Organization
        {
            get { return organization; }
            set { organization = value; }
        }
        private String address = "";

        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        private String phone = "";

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private float baseSalary = 0;

        public float BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }
        private float allowance = 0;

        public float Allowance
        {
            get { return allowance; }
            set { allowance = value; }
        }
        private float fund = 0;

        public float Fund
        {
            get { return fund; }
            set { fund = value; }
        }
        private float sanitary = 0;

        public float Sanitary
        {
            get { return sanitary; }
            set { sanitary = value; }
        }

        private float incomeTax = 0;

        public float IncomeTax
        {
            get { return incomeTax; }
            set { incomeTax = value; }
        }


        //重载父类ToString
        public String ToString()
        {
            return "Teacher:[id=" + this.Id + " name=" + this.Name + " sex=" + this.sex + " organization=" + this.Organization + " address=" + this.Address +
                " phone=" + this.Phone + " baseSalary=" + this.BaseSalary + " allowance=" + this.Allowance + " fund=" + this.Fund + " sanitary=" + this.Sanitary + " incomeTax=" + this.IncomeTax + "]";
        }

    }
}
