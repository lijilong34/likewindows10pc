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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           }

        private void button1_Click(object sender, EventArgs e)
        {
            Boot boot = new Boot();
            timer1.Start();
            this.Hide();
            boot.Show();
        }

        

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
