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
    public partial class windowsinstall7 : Form
    {
        public windowsinstall7()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你的设备不支持该安装方式！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtzdy_Click(object sender, EventArgs e)
        {
            windowsinstall8 install8 = new windowsinstall8();
            this.Hide();
            install8.Show();
        }

       

        private void labbz_Click(object sender, EventArgs e)
        {
            windowsinstall8 install8 = new windowsinstall8();
            this.Hide();
            install8.Show();
        }
    }
}
