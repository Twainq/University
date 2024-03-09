using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student
    {
        public string fio;
        public int age;
        public int kurs;
        public string number;
        public string email;
        public string pass;
        public string login;
        public string group;
        public List<int> marks;

        public Student(string fio, int age, int kurs, string number, string email,string pass,string login, string group,List<int>mark)
        {
            this.fio = fio;
            this.age = age;
            this.kurs = kurs;
            this.number = number;
            this.email = email;
            this.pass = pass;
            this.group = group;
            this.login = login;
            marks = mark;
        }
    }
}
