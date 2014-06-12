using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace areyougay
{
    public partial class Form1 : Form
    {
        protected static bool isDisplayAbout = false;
        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(291, 80);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ansidev.uni.me");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isDisplayAbout == false)
            {
                int _height = this.ClientSize.Height;
                int j = 5000;
                int k = 45 * j;
                for (int i = 0; i < k; i++)
                {
                    if (i % j == 0)
                    {
                        _height += 1;
                        this.ClientSize = new Size(this.ClientSize.Width, _height);
                    }
                    else
                        continue;
                }
                isDisplayAbout = true;
            }
            else
                return;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int _height = this.ClientSize.Height - 45;
            this.ClientSize = new Size(this.ClientSize.Width, _height);
            isDisplayAbout = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây chỉ là một ứng dụng troll!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây chỉ là một ứng dụng troll!");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.Text = "Vâng, tôi bị gay";
            this.button1.Text = "Không, tôi không bị gay!";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.Text = "Vâng, tôi bị gay";
            this.button2.Text = "Không, tôi không bị gay!";
        }
    }
}
