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
    public partial class windowsinstall3 : Form
    {
        private DateTime startTime;
        public windowsinstall3()
        {
            InitializeComponent();
        }

        private void windowsinstall3_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan totalTime = DateTime.Now - startTime;
            if (totalTime.TotalSeconds >60)
            {
                timer1.Stop();
                windowsinstall4 install4 =windowsinstall4.GetInstance();
                this.Close();
                install4.Show();
            }
        }
    }
}
