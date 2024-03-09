using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Group
    {
        string name;
        int cnt { get; set; }

        public Group(string name)
        {
            this.name = name;
            this.cnt = 0;
        }
        public string Name { get { return name; }set { name = value; } }
        public int Cnt { get { return cnt; } set { cnt = value; } }
    }
}
