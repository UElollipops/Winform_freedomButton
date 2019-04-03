using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool haha = false;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("啦啦啦");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            haha = true;
            Application.Exit();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    button3.Width = 100;
        //    button3.Height = 100;

        //Random random = new Random();
        //int x = random.Next(0, this.Width - 100);
        //int y = random.Next(0, this.Height - 100);
        //button3.Location = new Point(x, y);
        //}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("是否关闭窗口", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            if (haha)
            {
                MessageBox.Show("             太好了");

                e.Cancel = false;
            }
            else
            {
                MessageBox.Show("             回答错误");
                e.Cancel = true;
            }

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(10, this.Width - 150);
            int y = random.Next(10, this.Height - 100);
            button3.Location = new Point(x, y);
            textBox1.Text = button3.Location.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
