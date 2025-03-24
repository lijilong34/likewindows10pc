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
    public partial class systemdown : Form
    {
        public int zt;
        public string text5;
        public systemdown()
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
            switch (zt)
            {
                case 1:
                    this.Close();
                    Form1 form1 = new Form1();
                    form1.Show();
                    break;
                case 2:
                    this.Close();
                    Boot boot = new Boot();
                    boot.Show();
                    break;
            }
        }
    }
}
