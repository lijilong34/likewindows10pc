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
    public partial class zm : Form
    {
        
        private static zm _instance;
        systemdown systemdown = new systemdown();
        public zm()
        {
            InitializeComponent();
        }

        private void tmsidown_Click(object sender, EventArgs e)
        {
            systemdown.zt = 1;
            systemdown.labzt.Text = "正在关机";
            this.Hide();
            systemdown.Show();
        }
        public static zm GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
            {
                _instance = new zm();
            }
            return _instance;
        }

        private void tsmireturn_Click(object sender, EventArgs e)
        {
            systemdown.zt = 2;
            systemdown.labzt.Text = "正在重新启动";
            this.Hide();
            systemdown.Show();
        }

        private void tsmilock_Click(object sender, EventArgs e)
        {
            this.Hide();
            @lock @lock = new @lock();
            @lock.Show();
        }

        private void panthisPC_Click(object sender, EventArgs e)
        {
            panthisPC.BackColor = Color.Turquoise;
        }

        private void zm_Load(object sender, EventArgs e)
        {
            picPC.Click += panthisPC_Click;
            labthisPC.Click += panthisPC_Click;
            picPC.DoubleClick += panthisPC_DoubleClick;
            labthisPC.DoubleClick += panthisPC_DoubleClick;
            pictureBoxlijilong.Click += panellijilong_Click;
            lijilongnoaq.Click += panellijilong_Click;
            pictureBoxlijilong.DoubleClick += panellijilong_DoubleClick;
            lijilongnoaq.DoubleClick += panellijilong_DoubleClick;
            picsz.Click += pansz_Click;
            labsz.Click += pansz_Click;
            picsz.DoubleClick +=pansz_DoubleClick;
            labsz.DoubleClick += pansz_DoubleClick;
        }
        thisPC thisPC3 = new thisPC();
        public void panthisPC_DoubleClick(object sender, EventArgs e)
        {
            thisPC thisPC = new thisPC();
            thisPC.Show();
        }

        private void panellijilong_DoubleClick(object sender, EventArgs e)
        {
            lijilongnoaq lijilongno = new lijilongnoaq();
            lijilongno.Show();
        }

        private void panellijilong_Click(object sender, EventArgs e)
        {
            panellijilong.BackColor = Color.Turquoise;
        }

        private void pansz_Click(object sender, EventArgs e)
        {
            pansz.BackColor = Color.Turquoise;
        }

        private void pansz_DoubleClick(object sender, EventArgs e)
        {
            sz sz = new sz();
            sz.Show();
        }
    }
}
