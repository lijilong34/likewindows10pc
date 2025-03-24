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
    public partial class windowsinstall2 : Form
    {
        public windowsinstall2()
        {
            InitializeComponent();
        }

        private void btninstall_Click(object sender, EventArgs e)
        {
            windowsinstall windowsinstall = new windowsinstall();
            windowsinstall.panel1.Enabled = false;
            this.Close();
            windowsinstall3 windowsinstall3 = new windowsinstall3();
            windowsinstall3.Show();
        }
    }
}
