using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Prepod
    {
        public string fio;
        public int age;
        public int kab;
        public string lesson;
        public int zp;
        public string pass;
        public string login;

        public Prepod(string fio, int age, int kab, string lesson,int zp,string pass,string login)
        {
            this.fio = fio;
            this.age = age;
            this.kab = kab;
            this.lesson = lesson;
            this.zp = zp;
            this.pass = pass;
            this.login = login;
        }
    }
}
