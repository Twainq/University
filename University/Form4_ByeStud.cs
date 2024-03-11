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
    public partial class Form4_ByeStud : Form
    {
        public List<Student> students;
        public List<Prepod> prepod;
        public List<Group> group;
        public Form4_ByeStud(List<Student> students, List<Prepod> prepod, List<Group> group)
        {
            InitializeComponent();
            this.students = students;
            this.prepod = prepod;
            this.group = group;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flg = true;
            foreach (Student st in students)
            {
                if (st.fio == textBox1.Text)
                {
                    DialogResult result = MessageBox.Show( "Вы уверены?","Сообщение", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        students.Remove(st);
                        MessageBox.Show("Студент исключен!");
                        flg = false;
                        textBox1.Text = "";
                        break;
                    }
                    else
                    {
                        flg = false;
                        break;
                    }
                    
                }
            }
            if (flg)
                MessageBox.Show("Студент не найден!");
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form3_Admin f = new Form3_Admin(students,prepod,group);
            f.Show();
        }

        private void Form4_ByeStud_Load(object sender, EventArgs e)
        {

        }
    }
}
