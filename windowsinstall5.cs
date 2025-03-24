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
    public partial class windowsinstall5 : Form
    {
        public windowsinstall5()
        {
            InitializeComponent();
        }


        private void lvList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // 获取选中的行
                ListViewItem selectedItem = e.Item;

                // 将选中的行的内容显示在Label控件中
                labsysteminfo.Text = selectedItem.SubItems[0].Text;
                systeninfo.ver = labsysteminfo.Text;
            }
        }

        private void windowsinstall5_Load(object sender, EventArgs e)
        {
            labsysteminfo.Text = "";
            lvList.Items[0].Selected = true;
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            windowsinstall6 install6 = new windowsinstall6();
            this.Hide();
            install6.Show();
        }
       }

}
