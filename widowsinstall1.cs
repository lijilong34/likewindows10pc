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
    public partial class widowsinstall1 : Form
    {
        public widowsinstall1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
            windowsinstall2 windowsinstall2 = new windowsinstall2();
            windowsinstall2.Show();
        }
    }
}
