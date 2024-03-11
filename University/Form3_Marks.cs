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
    public partial class Form3_Marks : Form
    {
        List<Student> students { get; set; }
        List<Group> groups { get; set; }
        public Form3_Marks(List<Student> students, List<Group> groups)
        {
            InitializeComponent();
            this.students = students;
            this.groups = groups;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form2 f = new Form2(students,groups);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FindStudent())
            {
                label3.Visible = true;
                label3.Text = "ОЦЕНКА ВЫСТАВЛЕНА!";
            }
            else
            {
                label3.Visible = true;
                label3.Text = "ТАКОГО СТУДЕНТА НЕ СУЩЕСТВУЕТ!";
            }
        }
        public bool FindStudent()
        {
            foreach (Student student in students)
            {
                  if (student.fio == textBox1.Text)
                  {
                    try
                    {
                        student.marks.Add(Convert.ToInt32(textBox2.Text));
                        return true;
                    } catch
                    {
                        MessageBox.Show("Введите корректные данные в поле 'Отметка'!");
                    }
               
                  }
                
            }
            return false;
        }
    }
}
