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
    public partial class diskinstall3 : Form
    {
        private static diskinstall3 _instance;
        public diskinstall3()
        {
            InitializeComponent();
        }
        public bool nonull()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("请输入电脑名称再执行下一步", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtUser.Text == "")
            {
                MessageBox.Show("请输入用户名称再执行下一步", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPwd.Text == "" || txtpwda.Text == "")
            {
                MessageBox.Show("请输入密码再执行下一步", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPwd.Text != txtpwda.Text)
            {
                MessageBox.Show("两次密码不一样，请重新输入。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (nonull() == true)
            {
                systeninfo.Name = txtName.Text;
                systeninfo.User = txtUser.Text;
                systeninfo.pwd = txtpwda.Text;
                this.Hide();
                diskinstall4 diskinstall4 = new diskinstall4();
                diskinstall4.Show();
            }
        }
        public static diskinstall3 GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new diskinstall3();
            }
            return _instance;
        }
    }
}
