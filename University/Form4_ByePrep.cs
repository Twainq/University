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
    public partial class Form4_ByePrep : Form
    {
        List<Prepod> prepods;
        public Form4_ByePrep(List<Prepod> prepods)
        {
            InitializeComponent();
            this.prepods = prepods;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flg = true;
            foreach (Prepod pr in prepods)
            {
                if (pr.fio == textBox1.Text)
                {
                    DialogResult result = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        prepods.Remove(pr);
                        MessageBox.Show("Преподаватель исключен!");
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
                MessageBox.Show("Преподаватель не найден!");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form3_Admin f = new Form3_Admin();
            f.Show();
        }
    }
}
