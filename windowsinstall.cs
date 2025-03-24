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
    public partial class windowsinstall : Form
    {
       
        public windowsinstall()
        {
            InitializeComponent();
        }

        private void windowsinstall_Load(object sender, EventArgs e)
        {
            widowsinstall1 widowsinstall1 = new widowsinstall1();
            widowsinstall1.TopLevel = false;
            widowsinstall1.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(widowsinstall1);
            widowsinstall1.Show();
        }
      
    }
}
