using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 仿windows10电脑.install_on_disk;
using 仿windows10电脑.system;

namespace 仿windows10电脑
{

    public partial class Boot : Form
    {
        
        public Boot()
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
            this.Hide();
            switch (systeninfo.install)
            {
                case 0:
                    windowsinstall windowsinstall = new windowsinstall();
                    windowsinstall.Show();
                    break;
                case 1:
                    diskinstall1 diskinstall = new diskinstall1();
                    diskinstall.Show();
                    break;
                case 2:
                    diskinstall2 diskinstall2 = new diskinstall2();
                    diskinstall2.Show();
                    break;
                case 3:
                    @lock @lock = new @lock();
                    @lock.Show();
                    break;
            }

        }
       
            }

        }
    

