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

        private void lnkHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://ansidev.uni.me");
        }

        private void lnkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isDisplayAbout == false)
            {
                this.ClientSize = new Size(this.ClientSize.Width, 125);
                isDisplayAbout = true;

                this.lblAbout = new System.Windows.Forms.Label();
                this.lblAuthor = new System.Windows.Forms.Label();
                this.lnkHome = new System.Windows.Forms.LinkLabel();
                this.lnkHide = new System.Windows.Forms.LinkLabel();
                this.SuspendLayout();
                // 
                // lblAbout
                // 
                this.lblAbout.AutoSize = true;
                this.lblAbout.Location = new System.Drawing.Point(12, 85);
                this.lblAbout.Name = "lblAbout";
                this.lblAbout.Size = new System.Drawing.Size(144, 13);
                this.lblAbout.TabIndex = 5;
                this.lblAbout.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblAbout.ForeColor = Color.White;
                this.lblAbout.Text = "Đây chỉ là một ứng dụng troll.";
                // 
                // lblAuthor
                // 
                this.lblAuthor.AutoSize = true;
                this.lblAuthor.Location = new System.Drawing.Point(199, 85);
                this.lblAuthor.Name = "lblAuthor";
                this.lblAuthor.Size = new System.Drawing.Size(78, 13);
                this.lblAuthor.TabIndex = 6;
                this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lblAuthor.ForeColor = Color.White;
                this.lblAuthor.Text = "Coder: ansidev";
                // 
                // lnkHome
                // 
                this.lnkHome.AutoSize = true;
                this.lnkHome.Location = new System.Drawing.Point(218, 103);
                this.lnkHome.Name = "lnkHome";
                this.lnkHome.Size = new System.Drawing.Size(59, 13);
                this.lnkHome.TabIndex = 3;
                this.lnkHome.TabStop = true;
                this.lnkHome.Text = "Homepage";
                this.lnkHome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lnkHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHome_LinkClicked);
                // 
                // lnkHide
                // 
                this.lnkHide.AutoSize = true;
                this.lnkHide.Location = new System.Drawing.Point(12, 103);
                this.lnkHide.Name = "lnkHide";
                this.lnkHide.Size = new System.Drawing.Size(29, 13);
                this.lnkHide.TabIndex = 7;
                this.lnkHide.TabStop = true;
                this.lnkHide.Text = "Hide";
                this.lnkHide.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.lnkHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHide_LinkClicked);

                this.Controls.Add(this.lblAbout);
                this.Controls.Add(this.lblAuthor);
                this.Controls.Add(this.lnkHome);
                this.Controls.Add(this.lnkHide);
            }
            else
                return;
        }

        private void lnkHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (isDisplayAbout == true)
            {
                if (this.Controls.Contains(lblAbout))
                {
                    this.Controls.Remove(lblAbout);
                }

                if (this.Controls.Contains(lblAuthor))
                {
                    this.Controls.Remove(lblAuthor);
                }

                if (this.Controls.Contains(lnkHome))
                {
                    this.Controls.Remove(lnkHome);
                }

                if (this.Controls.Contains(lnkHide))
                {
                    this.Controls.Remove(lnkHide);
                }
                this.ClientSize = new Size(this.ClientSize.Width, 80);
                isDisplayAbout = false;
            }
            else
                return;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây chỉ là một ứng dụng troll!");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây chỉ là một ứng dụng troll!");
        }

        private void btnYes_MouseHover(object sender, EventArgs e)
        {
            this.btnYes.Text = "Có!";
            this.btnNo.Text = "Không!";
        }

        private void btnNo_MouseHover(object sender, EventArgs e)
        {
            this.btnNo.Text = "Có!";
            this.btnYes.Text = "Không!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.FlatAppearance.BorderSize = 1;
            this.btnExit.ForeColor = System.Drawing.Color.Azure;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.Color.White;
        }

    }
}
