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
    public partial class windowsinstall6 : Form
    {
        public windowsinstall6()
        {
            InitializeComponent();
        }

        private void cheOK_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cheOK.Checked == false)
            {
                this.btnNext.Enabled = false;
            }else if (this.cheOK.Checked == true)
            {
                this.btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            windowsinstall7 install7 = new windowsinstall7();
            this.Hide();
            install7.Show();
        }
    }
}
