using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Form3_Student : Form
    {
        Student st;
        public Form3_Student(Student student)
        {
            InitializeComponent();
            st = student;
        }

        public Form3_Student()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text += "ОЦЕНКИ : \n";
            foreach(int mark in st.marks)
            {
                label2.Text += mark;
            }
            
        }

    }
}
