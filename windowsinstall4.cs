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
    public partial class windowsinstall4 : Form
    {
        private static windowsinstall4 _instance;
        public windowsinstall4()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtjhm.Text.Equals("W269N-WFGWX-YVC9B-4J6C9-T83GX"))
            {
                MessageBox.Show("激活成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                windowsinstall5 install5 = new windowsinstall5();
                systeninfo.activestate = 1;
                install5.Show();
                this.Hide();
            }
            else if(txtjhm.Text=="")
            {
                MessageBox.Show("请输入产品密钥！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("产品密钥输入错误！","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void labtg_Click(object sender, EventArgs e)
        {
            windowsinstall5 install5 = new windowsinstall5();
            install5.Show();
            this.Hide();
        }
        public static windowsinstall4 GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new windowsinstall4();
            }
            return _instance;
        }
    }
}
