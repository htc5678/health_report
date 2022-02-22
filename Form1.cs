using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using health_report;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void bmi_b_Click(object sender, EventArgs e)
        {
            if (fname_tb.Text == "" || lname_tb.Text == "" || m_tb.Text == "" || d_tb.Text == "" || y_tb.Text == "" || g_tb.Text == "" || h_tb.Text == "" || w_tb.Text == "")
            {
                MessageBox.Show("Don't leave any textbox is empty");
            }
            else
            {
                        user user1 = new user();
                Int32.TryParse(d_tb.Text, out int d);
                Int32.TryParse(m_tb.Text, out int m);
                Int32.TryParse(y_tb.Text, out int y);
                Int32.TryParse(w_tb.Text, out int w);
                Int32.TryParse(h_tb.Text, out int h);

                user1.fname = fname_tb.Text;
                user1.lname = lname_tb.Text;
                user1.day = d;
                user1.month = m;
                user1.year = y;
                user1.gender = g_tb.Text;
                user1.weight = w;
                user1.height = h;
                user1.bmi = Math.Round(calcBmi(h, w));
                Form Form2 = new Form2(user1);
                Form2.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private double calcBmi(int h, int w)
        {
            return ((w / Math.Pow(h, 2)) * 703);
        }

        private void bmichart_b_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            Form3.Show();
        }
    }
}
