using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仿windows10电脑.system
{
    public partial class wec : Form
    {
        public wec()
        {
            InitializeComponent();
        }

        private void wec_Load(object sender, EventArgs e)
        {
            labeUser.Text = systeninfo.User;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (systeninfo.pwd.Equals(txtPwd.Text))
            {
                labeUser.Text = "欢迎";
                txtPwd.Visible = false;
                btnLogin.Visible = false;
                pbboot.Visible = true;
                labpwderror.Visible = false;
                timer1.Tick+= timer1_Tick;
                timer1.Start();
            }
            else
            {
                labpwderror.Visible = true;
            }
        }
        int index = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (index < this.imgeList.Images.Count - 1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            this.pbboot.Image = this.imgeList.Images[index];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            zm zm = new zm();
            zm.Show();
        }
    }
}
