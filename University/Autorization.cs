using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    internal class Autorization
    {
        string login;
        string password;

        public Autorization(string ilogin,string ipassword)
        {
            login = ilogin;
            password = ipassword;
        }

        public string Login
        {
            get { return login; }
        }
        public string Parol
        {
            get { return password; }
        }
    }
}
