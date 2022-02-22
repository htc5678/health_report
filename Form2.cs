using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment2;

namespace health_report
{
    public partial class Form2 : Form
    {
        public Form2(user user1)
        {
            InitializeComponent();
            wtb.Text = user1.weight.ToString();
            htb.Text = user1.height.ToString();
            gtb.Text = user1.gender.ToString();
            ftb.Text = user1.fname;
            ltb.Text = user1.lname;
            mtb.Text = user1.month.ToString();
            dtb.Text = user1.day.ToString();
            ytb.Text = user1.year.ToString();
            bmi_l.Text = user1.bmi.ToString();

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void labelMain_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bmi_l_Click(object sender, EventArgs e)
        {

        }
    }
}
