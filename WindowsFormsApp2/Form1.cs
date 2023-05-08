using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Button 1 clicked!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Button 2 clicked!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Button 3 clicked!";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Radio Button 1 is selected!";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Radio Button 2 is selected!";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Radio Button 3 is selected!";
        }
    }
}
