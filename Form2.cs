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
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void labelMain_Click(object sender, EventArgs e)
        {

        }

        public void getWeight(int weight)
        {
            wtb.Text = weight.ToString();
        }
        public void getHeight(int height)
        {
            wtb.Text = height.ToString();
        }
        public void getDay(int day)
        {
            wtb.Text = day.ToString();
        }
        public void getMonth(int month)
        {
            wtb.Text = month.ToString();
        }
        public void getYear(int year)
        {
            wtb.Text = year.ToString();
        }
        public void getGender(string gender)
        {
            wtb.Text = gender;
        }
        public void getFirst(string first)
        {
            wtb.Text = first;
        }
        public void getLast(string last)
        {
            wtb.Text = last;
        }
    }
}
