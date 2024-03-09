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
    public partial class Form2 : Form
    {
         List<Student> students { get; set; }
         List<Group> groups { get; set; } 
         Prepod prepod;
        public Form2(List <Student> student1,Prepod prepod1,List<Group> groups1)
        {
            InitializeComponent();
            students = student1;
            prepod = prepod1;
            groups = groups1;
        }
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<Student> student1, List<Group> group1)
        {
            InitializeComponent();
            students = student1;
            groups = group1;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form3_Marks f = new Form3_Marks(students,groups);
            f.Show();
            Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Student student in students)
            {
                label1.Text += $"{i++} студент: \n";
                label1.Text += "ФИО : " + student.fio + "\n";
                label1.Text += "КУРС : " + student.kurs + "\n";
                label1.Text += "ОЦЕНКИ : ";
                foreach (int mark in student.marks)
                {
                    label1.Text += mark;
                }
                label1.Text += "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Student st in students)
            {
                if (st.group == "P11")
                    groups[0].Cnt++;
                    
                else if (st.group == "P12")
                    groups[1].Cnt++;
            }
            foreach (Group gr in groups)
            {
                label2.Text += $"{i++} группа: \n";
                label2.Text += "НАЗВАНИЕ : " + gr.Name + "\n";
                label2.Text += "КОЛИЧЕСТВО УЧАЩИХСЯ : " + gr.Cnt + "\n";
                label2.Text += "\n";
            }
        }
    }
}
