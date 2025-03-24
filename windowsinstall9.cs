using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仿windows10电脑
{
    public partial class windowsinstall9 : Form
    {
        public windowsinstall9()
        {
            InitializeComponent();
        }

        private void windowsinstall9_Load(object sender, EventArgs e)
        {
            timecpoy.Start();
           
        }
        private void timecpoy_Tick(object sender, EventArgs e)
        {
            int cpoy = int.Parse(labcpoy3.Text);
            cpoy = cpoy + 1;
            labcpoy3.Text = cpoy.ToString();
            if (cpoy==100)
            {
                timecpoy.Stop();
                piccpoy.Visible = true;
                labinstall2.Visible = true;
                labinstall3.Visible = true;
                labinstall4.Visible = true;
                labcpoy3.Visible = false;
                labcpoy2.Visible = false;
                labcpoy4.Visible = false;
                timeinstall.Start();
            }
        }

        private void timeinstall_Tick(object sender, EventArgs e)
        {
            int install = int.Parse(labinstall3.Text);
            install = install + 1;
            labinstall3.Text = install.ToString();
            if (install == 100)
            {
                timeinstall.Stop();
                picinstall.Visible = true;
               labgl2.Visible = true;
                labgl3.Visible = true;
                labgl4.Visible = true;
                labinstall2.Visible = false;
                labinstall3.Visible = false;
                labinstall4.Visible = false;
                timegl.Start();
            }
        }

        private void timegl_Tick(object sender, EventArgs e)
        {
            int gl = int.Parse(labgl3.Text);
            gl = gl + 1;
            labgl3.Text = gl.ToString();
            if (gl == 100)
            {
                timegl.Stop();
                picgl.Visible = true;
                labgx2.Visible = true;
                labgx3.Visible = true;
                labgx4.Visible = true;
                labgl2.Visible = false;
                labgl3.Visible = false;
                labgl3.Visible = false;
                labgl4.Visible = false;
                timegx.Start();
            }
        }

        private void timegx_Tick(object sender, EventArgs e)
        {
            int gx = int.Parse(labgx3.Text);
            gx = gx + 1;
            labgx3.Text = gx.ToString();
            if (gx == 100)
            {
                timegx.Stop();
                picgx.Visible = true;
                labgx2.Visible = false;
                labgx3.Visible = false;
                labgx4.Visible = false;
                systeninfo.install = 1;
                timewc.Start();
            }
        }

        private void timewc_Tick(object sender, EventArgs e)
        {
            int wc = int.Parse(labwc3.Text);
            wc = wc + 1;
            labwc3.Text = wc.ToString();
            if (wc == 100)
            {
                timewc.Stop();
                windowsinstall windowsinstall = new windowsinstall();
                windowsinstall.Close();
                this.Close();
                Boot boot = new Boot();
                boot.Show();
            }
        }
    }
}
