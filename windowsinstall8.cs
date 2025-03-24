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
    public partial class windowsinstall8 : Form
    {
        List<Diskinfo> diskinfo = new List<Diskinfo>();
        public double ynulldisk = 100;
        public int aj = 0;
        public int did = 0;
        public windowsinstall8()
        {
            InitializeComponent();
            diskinfo.Add(new Diskinfo { Did = 1, Diskname = "驱动器0未分配的空间", Sum = ynulldisk, Nullkj = ynulldisk, Type1 = "未分配" });
        }

        private void windowsinstall8_Load(object sender, EventArgs e)
        {
            selectDisk();
            CheckPartitionsAndEnableNextButton();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            aj = 1;
            label2.Visible = true;
            dUddx.Visible = true;
            btnyy.Visible = true;
            btnqx.Visible = true;
        }
        public void selectDisk()
        {
            dgvDisk.DataSource = diskinfo;
        }

        private void btnqx_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            dUddx.Visible = false;
            btnyy.Visible = false;
            btnqx.Visible = false;
        }

        private void btnyy_Click(object sender, EventArgs e)
        {
            double newPartitionSize = double.Parse(dUddx.Text);
            if (newPartitionSize <= diskinfo[0].Nullkj) // 确保未分配空间足够
            {
                if (aj == 1) // 新建分区
                {
                    did++; // 更新当前磁盘ID
                    Diskinfo newPartition = new Diskinfo { Did = did, Diskname = $"分区{did}", Sum = newPartitionSize, Nullkj = newPartitionSize, Type1 = "新建分区" };
                    diskinfo.Add(newPartition);
                    Diskinfo.AddPartition(newPartition); // 添加到静态数组
                    diskinfo[0].Nullkj -= newPartitionSize; // 减少未分配空间
                }
                else if (aj == 2) // 扩展分区
                {
                    if (dgvDisk.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dgvDisk.SelectedRows[0];
                        int didToExtend = Convert.ToInt32(selectedRow.Cells["Did"].Value);
                        foreach (var partition in diskinfo)
                        {
                            if (partition.Did == didToExtend && partition.Type1 != "未分配")
                            {
                                partition.Sum += newPartitionSize; // 扩展分区大小
                                diskinfo[0].Nullkj -= newPartitionSize; // 减少未分配空间
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("请选择一个要扩展的分区！");
                        return;
                    }
                }
                // 更新DataGridView显示
                dgvDisk.DataSource = null;
                dgvDisk.DataSource = diskinfo;
                // 重置界面元素
                aj = 0;
                label2.Visible = false;
                dUddx.Visible = false;
                btnyy.Visible = false;
                btnqx.Visible = false;
                // 检查分区并启用下一步按钮
                CheckPartitionsAndEnableNextButton();
            }
            else
            {
                MessageBox.Show("输入的分区大小超过了未分配空间！");
            }
        }

        private void btnkz_Click(object sender, EventArgs e)
        {
            aj = 2; // 设置为扩展操作
            label2.Visible = true;
            dUddx.Visible = true;
            btnyy.Visible = true;
            btnqx.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvDisk.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDisk.SelectedRows[0];
                int didToDelete = Convert.ToInt32(selectedRow.Cells["Did"].Value);
                foreach (var partition in diskinfo)
                {
                    if (partition.Did == didToDelete)
                    {
                        diskinfo[0].Nullkj += partition.Sum; // 将空间加回未分配
                        diskinfo.Remove(partition); // 删除分区
                        Diskinfo.GetPartitions().Remove(partition); // 从静态数组中删除
                        break;
                    }
                }
                dgvDisk.DataSource = null;
                dgvDisk.DataSource = diskinfo;
                MessageBox.Show("分区删除成功！");
                // 检查分区并启用下一步按钮
                CheckPartitionsAndEnableNextButton();
            }
            else
            {
                MessageBox.Show("请先选择要删除的分区！");
            }
        }
        private void CheckPartitionsAndEnableNextButton()
        {
            // 检查是否有分区
            bool hasPartitions = Diskinfo.HasPartitions();
            // 根据检查结果启用或禁用下一步按钮
            btnNext.Enabled = hasPartitions;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            windowsinstall9 install9 = new windowsinstall9();
            this.Close();
            install9.Show();
        }
    }
    }

