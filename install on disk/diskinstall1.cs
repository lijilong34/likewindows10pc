using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仿windows10电脑.install_on_disk
{
    public partial class diskinstall1 : Form
    {
        public diskinstall1()
        {
            InitializeComponent();
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

        private void diskinstall1_Load(object sender, EventArgs e)
        {
            labzt.Text = "正在准备设备";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = int.Parse(labinstall.Text);
            num = num + 1;
            labinstall.Text = num.ToString();
            if (num == 100)
            {
                timer1.Stop();
                labinstall.Text = "0";
                labzt.Text = "启动服务";
                label1.Visible = true;
                labinstall.Visible = true;
                label4.Visible = true;
                timerfw.Start();
            }
        }

        private void timerfw_Tick(object sender, EventArgs e)
        {
            int num = int.Parse(labinstall.Text);
            num = num + 1;
            labinstall.Text = num.ToString();
            if (num == 100)
            {
                timer1.Stop();
                labinstall.Text = "0";
                labzt.Text = "准备就绪";
                label1.Visible = false;
                label4.Visible = false;
                labinstall.Visible = false;
                timerjx.Start();
            }
        }

        private void timerjx_Tick(object sender, EventArgs e)
        {
            int num = int.Parse(labinstall.Text);
            num = num + 1;
            labinstall.Text = num.ToString();
            if (num == 100)
            {
                timerjx.Stop();
                this.Close();
                systeninfo.install = 2;
                Boot boot = new Boot();
                boot.Show();
            }
        }
    }
}
