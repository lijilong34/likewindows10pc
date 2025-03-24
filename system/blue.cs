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
    /// <summary>
    /// 蓝屏页
    /// </summary>
    public partial class blue : Form
    {
        public blue()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num1 = int.Parse(labreboot.Text.ToString());
            num1 = num1 + 1;
            labreboot.Text = num1.ToString();
            if (num1 == 100)
            {
                timer1.Stop();
                this.Hide();
                Boot boot = new Boot();
                boot.Show();
            }
        }

        private void blue_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }
    }
}
