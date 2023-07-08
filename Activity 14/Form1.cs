using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string weather;

            if (listBox1.SelectedIndex != -1)
            {
                weather = listBox1.SelectedItem.ToString();
                label4.Text = "It is " + weather + " out today.";
            }

            if (radioButton1.Checked)
            {
                label5.Text = "You like the weather today.";
            }

            else if (radioButton2.Checked)
            {
                label5.Text = "You do not like the weather today.";
            }

            if (checkBox1.Checked)
            {
                label6.Text = "You should wear shorts today.";
            }

            if (checkBox2.Checked)
            {
                label6.Text = "You should wear a jacket today.";
            }

            if (checkBox3.Checked)
            {
                label6.Text = "You should wear a wind breaker today.";
            }

            if (checkBox4.Checked)
            {
                label6.Text = "You should use an umbrella today.";
            }
        }
    }
}
