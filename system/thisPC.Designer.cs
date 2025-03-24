
namespace 仿windows10电脑.system
{
    partial class thisPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("下载");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("文档");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("图片");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("桌面");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("音乐");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("视频");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("此电脑");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thisPC));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisamll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmixxxx = new System.Windows.Forms.ToolStripMenuItem();
            this.ListLarge = new System.Windows.Forms.ImageList(this.components);
            this.Listsmall = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode15.Name = "节点0";
            treeNode15.Text = "下载";
            treeNode16.Name = "节点1";
            treeNode16.Text = "文档";
            treeNode17.Name = "节点2";
            treeNode17.Text = "图片";
            treeNode18.Name = "节点3";
            treeNode18.Text = "桌面";
            treeNode19.Name = "节点4";
            treeNode19.Text = "音乐";
            treeNode20.Name = "节点5";
            treeNode20.Text = "视频";
            treeNode21.Name = "节点6";
            treeNode21.Text = "此电脑";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21});
            this.treeView1.Size = new System.Drawing.Size(284, 650);
            this.treeView1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.ListLarge;
            this.listView1.Location = new System.Drawing.Point(333, 29);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(855, 634);
            this.listView1.SmallImageList = this.Listsmall;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLarge,
            this.tsmisamll,
            this.tsmixxxx});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 94);
            // 
            // tsmiLarge
            // 
            this.tsmiLarge.Name = "tsmiLarge";
            this.tsmiLarge.Size = new System.Drawing.Size(152, 30);
            this.tsmiLarge.Text = "大图标";
            this.tsmiLarge.Click += new System.EventHandler(this.tsmiLarge_Click);
            // 
            // tsmisamll
            // 
            this.tsmisamll.Name = "tsmisamll";
            this.tsmisamll.Size = new System.Drawing.Size(152, 30);
            this.tsmisamll.Text = "小图标";
            this.tsmisamll.Click += new System.EventHandler(this.tsmisamll_Click);
            // 
            // tsmixxxx
            // 
            this.tsmixxxx.Name = "tsmixxxx";
            this.tsmixxxx.Size = new System.Drawing.Size(152, 30);
            this.tsmixxxx.Text = "详细信息";
            this.tsmixxxx.Click += new System.EventHandler(this.tsmixxxx_Click);
            // 
            // ListLarge
            // 
            this.ListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ListLarge.ImageStream")));
            this.ListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ListLarge.Images.SetKeyName(0, "pajamas_disk.png");
            // 
            // Listsmall
            // 
            this.Listsmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Listsmall.ImageStream")));
            this.Listsmall.TransparentColor = System.Drawing.Color.Transparent;
            this.Listsmall.Images.SetKeyName(0, "pajamas_disk.png");
            // 
            // thisPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "thisPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "此电脑";
            this.Load += new System.EventHandler(this.thisPC_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLarge;
        private System.Windows.Forms.ToolStripMenuItem tsmisamll;
        private System.Windows.Forms.ToolStripMenuItem tsmixxxx;
        private System.Windows.Forms.ImageList ListLarge;
        private System.Windows.Forms.ImageList Listsmall;
    }
}