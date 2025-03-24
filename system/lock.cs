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
    public partial class @lock : Form
    {
        private static @lock _instance;
        public @lock()
        {
            InitializeComponent();
        }

        private void lock_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void lock_Click(object sender, EventArgs e)
        {
            this.Hide();
            wec wec = new wec();
            wec.Show();
        }
        public static @lock GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new @lock();
            }
            return _instance;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labtData.Text = DateTime.Now.ToLongDateString().ToString();//获取日期
            labetime.Text = DateTime.Now.ToShortTimeString().ToString();//获取时间
        }
    }
}
