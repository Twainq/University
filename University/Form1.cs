using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class Form1 : Form
    {
        Administration a1;
        
        public Form1()
        {
            InitializeComponent();
            a1 = new Administration();
            a1.name = "Anton";
            a1.age = 52;
            a1.login = "admin";
            a1.pass = "admin";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool flg = false;
            for (int i = 0; i < a1.students.Count; i++)
            {
                if (textBox1.Text == a1.students[i].login && textBox2.Text == a1.students[i].pass)
                {
                    Form3_Student f = new Form3_Student(a1.students[i]);
                    f.Show();
                    Hide();
                    flg = true;
                }
            }
            for (int i = 0; i < a1.prepods.Count; i++)
            {
                if (textBox1.Text == a1.prepods[i].login && textBox2.Text == a1.prepods[i].pass)
                {
                    Form2 f = new Form2(a1.students, a1.prepods[i],a1.groups);
                    f.Show();
                    Hide();
                    flg = true;
                }
            }
            if (textBox1.Text == a1.login && textBox2.Text == a1.pass)
            {
                Form3_Admin f = new Form3_Admin(a1.students,a1.prepods,a1.groups);
                f.Show();
                Hide();
            }
            if (!flg)
                label4.BackColor = Color.Red; label4.Text = "НЕВЕРНЫЙ ЛОГИН ИЛИ ПАРОЛЬ";
        }
    }

}
