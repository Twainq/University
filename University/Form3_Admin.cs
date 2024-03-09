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
    public partial class Form3_Admin : Form
    {
        List<Student> students;
        List<Prepod> prepods;
        List<Group> group;
        public Form3_Admin()
        {
            InitializeComponent();
        }
        public Form3_Admin(List<Student>students,List<Prepod> prepods, List<Group> group)
        {
            InitializeComponent();
            this.students = students;
            this.prepods = prepods;
            this.group = group;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student
                (textBox1.Text,Convert.ToInt32(textBox2.Text),1,
                textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text,new List<int> { });
            
                students.Add(student);
                MessageBox.Show("СТУДЕНТ ДОБАВЛЕН!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ВВЕДИТЕ ВСЕ КОРРЕКТНЫЕ ПОЛЯ ДЛЯ ДОБАВЛЕНИЯ!");
            }
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Prepod prepod = new Prepod
                (textBox8.Text, Convert.ToInt32(textBox9.Text),
                Convert.ToInt32(textBox10.Text), textBox11.Text,
                Convert.ToInt32(textBox12.Text),textBox13.Text,textBox14.Text);

                prepods.Add(prepod);
                MessageBox.Show("ПРЕПОДАВАТЕЛЬ ДОБАВЛЕН!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ВВЕДИТЕ ВСЕ КОРРЕКТНЫЕ ПОЛЯ ДЛЯ ДОБАВЛЕНИЯ!");
            }
            textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text = textBox13.Text = textBox14.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4_ByeStud f = new Form4_ByeStud(students);
            f.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4_ByePrep f = new Form4_ByePrep(prepods);
            f.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4_AllUnics f = new Form4_AllUnics(students,prepods,group);
            f.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
