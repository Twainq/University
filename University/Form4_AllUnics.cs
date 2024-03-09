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
    public partial class Form4_AllUnics : Form
    {
        List<Student> students;
        List<Prepod> prepods;
        List<Group> group;
        public Form4_AllUnics(List<Student> students, List<Prepod> prepods, List<Group> group)
        {
            InitializeComponent();
            this.students = students;
            this.prepods = prepods;
            this.group = group;
        }

        private void label1_Click(object sender, EventArgs e)
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
        private void label5_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Student st in students)
            {
                if (st.group == "P11")
                    group[0].Cnt++;

                else if (st.group == "P12")
                    group[1].Cnt++;
            }
            foreach (Group gr in group)
            {
                label5.Text += $"{i++} группа: \n";
                label5.Text += "НАЗВАНИЕ : " + gr.Name + "\n";
                label5.Text += "КОЛИЧЕСТВО УЧАЩИХСЯ : " + gr.Cnt + "\n";
                label5.Text += "\n";
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Prepod pr in prepods)
            {
                label3.Text += $"{i++} преподаватель: \n";
                label3.Text += "ФИО : " + pr.fio + "\n";
                label3.Text += "Возраст : " + pr.age + "\n";
                label3.Text += "Зарплата : " + pr.zp + "\n";
                label3.Text += "Номер кабинета : " + pr.kab + "\n";
                label3.Text += "Преподает : " + pr.lesson + "\n";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form3_Admin f = new Form3_Admin(students, prepods, group);
            f.Show();
        }

        
    }
}
