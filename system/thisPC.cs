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
    public partial class thisPC : Form
    {
        ToolStripMenuItem thisPC1 = new ToolStripMenuItem("此电脑");
        public zm zm;
        public thisPC()
        {
            InitializeComponent();
        }

        private void tsmiLarge_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void tsmisamll_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void tsmixxxx_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }
        private void LoadDiskInfoToListView()
        {
            listView1.Columns.Clear();
            // 添加列
            listView1.Columns.Add("分区ID", 80);
            listView1.Columns.Add("名称", 120);
            listView1.Columns.Add("总大小(GB)", 100);
            listView1.Columns.Add("可用空间(GB)", 120);
            listView1.Columns.Add("类型", 100);

            // 获取所有分区信息
            var partitions = Diskinfo.GetPartitions();
            foreach (var partition in partitions)
            {
                ListViewItem item = new ListViewItem(partition.Did.ToString());
                item.ImageIndex= 0;
                item.SubItems.Add(partition.Diskname);
                item.SubItems.Add(partition.Sum.ToString("0.00"));
                item.SubItems.Add(partition.Nullkj.ToString("0.00"));
                item.SubItems.Add(partition.Type1);
                listView1.Items.Add(item);
            }

            // 调整列宽以适应内容
            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2; // 自动调整列宽
            }
        }

        private void thisPC_Load(object sender, EventArgs e)
        {
            LoadDiskInfoToListView();
        }
    }
}