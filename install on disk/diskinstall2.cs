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
    public partial class diskinstall2 : Form
    {
        public diskinstall2()
        {
            InitializeComponent();
            timeym1.Tick += timeym1_Tick;
            timeym1.Start();
            timerLo.Tick += timerLo_Tick;
            timerLo.Start();
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

        private void timeym1_Tick(object sender, EventArgs e)
        {
            timeym1.Stop();
              this.BackColor = Color.DodgerBlue;
            labtxt.Text = "海内存知己，天涯若比邻。";
            pbboot.Visible = true;
        }

        private void timerLo_Tick(object sender, EventArgs e)
        {
            timerLo.Stop();
            this.Hide();
            diskinstall3 diskinstall3 =diskinstall3.GetInstance();
            diskinstall3.Show();
        }
    }
}
