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
    public partial class sz : Form
    {
        public sz()
        {
            InitializeComponent();
        }

        private void sz_Load(object sender, EventArgs e)
        {
            labsysteminfo.Text = systeninfo.ver;
            if (systeninfo.activestate == 0)
            {
                labzt.Text = "未激活";
            }
            else
            {
                labzt.Text = "已激活";
                label8.Visible = false;
                labzt.Visible = false;
            }
            txtName.Text = systeninfo.Name;
            txtUesr.Text = systeninfo.User;
        }
        public bool checkMag()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("计算机名不得为空","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (txtUesr.Text == "")
            {
                MessageBox.Show("用户名不得为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtold.Text == "")
            {
                MessageBox.Show("原密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!txtold.Text.Equals(systeninfo.pwd))
            {
                MessageBox.Show("原密码与旧密码不匹配!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtnewPwd.Text == "")
            {
                MessageBox.Show("新密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("重复密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!txtnewPwd.Text.Equals(txtPwd.Text))
            {
                MessageBox.Show("两次密码不匹配，请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkMag()==true)
            {
                if (txtjhm.Text == "")
                {
                    systeninfo.Name = txtName.Text;
                    systeninfo.User = txtUesr.Text;
                    systeninfo.pwd = txtPwd.Text;
                    MessageBox.Show("信息保存成功！");
                    this.Close();
                }
                else if(txtjhm.Text.Equals("W269N-WFGWX-YVC9B-4J6C9-T83GX"))
                {
                    systeninfo.Name = txtName.Text;
                    systeninfo.User = txtUesr.Text;
                    systeninfo.pwd = txtPwd.Text;
                    systeninfo.activestate = 1;
                    MessageBox.Show("系统激活成功");
                    MessageBox.Show("信息保存成功！");
                    this.Close();
                }
                else if(!txtjhm.Text.Equals("W269N-WFGWX-YVC9B-4J6C9-T83GX"))
                {
                    MessageBox.Show("激活码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
