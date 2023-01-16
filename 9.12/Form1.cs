using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9._12
{
    public partial class Form1 : Form
    {
        string remindTime;
        string remindText;
        string currentG;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentG = DateTime.Now.ToString("HH:mm:ss");
            label1.Text = currentG;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            remindTime = maskedTextBox1.Text;
            remindText = textBox1.Text;
            remindTimer.Start();
        }

        private void remindTimer_Tick(object sender, EventArgs e)
        {
            if(currentG == remindTime)
            {
                remindTimer.Stop();
                MessageBox.Show(remindText);
                maskedTextBox1.Text = "";
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remindTimer.Stop();
            maskedTextBox1.Text = "";
            textBox1.Text = "";
        }
    }
}
