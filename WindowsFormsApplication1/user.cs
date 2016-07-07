using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class User
    {
        private String userName;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private String passWord;

        public String PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        public String ToString()
        {
            return "User:[userName=" + this.UserName + " passWord=" + this.PassWord  + "]";
        
        }


    }
}
