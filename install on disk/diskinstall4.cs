using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 仿windows10电脑.system;

namespace 仿windows10电脑.install_on_disk
{
    public partial class diskinstall4 : Form
    {
        public diskinstall4()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
            timer1.Start();
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
            systeninfo.install = 3;
            this.Close();
            zm zm = zm.GetInstance();
            zm.Show();
        }
    }
}
