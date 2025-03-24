
namespace 仿windows10电脑.system
{
    partial class zm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmireturn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmilock = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsidown = new System.Windows.Forms.ToolStripMenuItem();
            this.picPC = new System.Windows.Forms.PictureBox();
            this.labthisPC = new System.Windows.Forms.Label();
            this.panthisPC = new System.Windows.Forms.Panel();
            this.pictureBoxlijilong = new System.Windows.Forms.PictureBox();
            this.panellijilong = new System.Windows.Forms.Panel();
            this.lijilongnoaq = new System.Windows.Forms.Label();
            this.picsz = new System.Windows.Forms.PictureBox();
            this.pansz = new System.Windows.Forms.Panel();
            this.labsz = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPC)).BeginInit();
            this.panthisPC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlijilong)).BeginInit();
            this.panellijilong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picsz)).BeginInit();
            this.pansz.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 1062);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1946, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmireturn,
            this.tsmilock,
            this.tmsidown});
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.开始ToolStripMenuItem.Text = "开始";
            // 
            // tsmireturn
            // 
            this.tsmireturn.Name = "tsmireturn";
            this.tsmireturn.Size = new System.Drawing.Size(146, 34);
            this.tsmireturn.Text = "重启";
            this.tsmireturn.Click += new System.EventHandler(this.tsmireturn_Click);
            // 
            // tsmilock
            // 
            this.tsmilock.Name = "tsmilock";
            this.tsmilock.Size = new System.Drawing.Size(146, 34);
            this.tsmilock.Text = "锁屏";
            this.tsmilock.Click += new System.EventHandler(this.tsmilock_Click);
            // 
            // tmsidown
            // 
            this.tmsidown.Name = "tmsidown";
            this.tmsidown.Size = new System.Drawing.Size(146, 34);
            this.tmsidown.Text = "关机";
            this.tmsidown.Click += new System.EventHandler(this.tmsidown_Click);
            // 
            // picPC
            // 
            this.picPC.BackColor = System.Drawing.Color.Transparent;
            this.picPC.Image = global::仿windows10电脑.Properties.Resources.game_icons_pc;
            this.picPC.Location = new System.Drawing.Point(44, 36);
            this.picPC.Margin = new System.Windows.Forms.Padding(4);
            this.picPC.Name = "picPC";
            this.picPC.Size = new System.Drawing.Size(90, 90);
            this.picPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPC.TabIndex = 1;
            this.picPC.TabStop = false;
            // 
            // labthisPC
            // 
            this.labthisPC.AutoSize = true;
            this.labthisPC.ForeColor = System.Drawing.Color.White;
            this.labthisPC.Location = new System.Drawing.Point(32, 100);
            this.labthisPC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labthisPC.Name = "labthisPC";
            this.labthisPC.Size = new System.Drawing.Size(62, 18);
            this.labthisPC.TabIndex = 0;
            this.labthisPC.Text = "此电脑";
            // 
            // panthisPC
            // 
            this.panthisPC.BackColor = System.Drawing.Color.Transparent;
            this.panthisPC.Controls.Add(this.labthisPC);
            this.panthisPC.Location = new System.Drawing.Point(36, 36);
            this.panthisPC.Margin = new System.Windows.Forms.Padding(4);
            this.panthisPC.Name = "panthisPC";
            this.panthisPC.Size = new System.Drawing.Size(120, 120);
            this.panthisPC.TabIndex = 2;
            this.panthisPC.Click += new System.EventHandler(this.panthisPC_Click);
            this.panthisPC.DoubleClick += new System.EventHandler(this.panthisPC_DoubleClick);
            // 
            // pictureBoxlijilong
            // 
            this.pictureBoxlijilong.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxlijilong.Image = global::仿windows10电脑.Properties.Resources.material_symbols_shield;
            this.pictureBoxlijilong.Location = new System.Drawing.Point(44, 228);
            this.pictureBoxlijilong.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxlijilong.Name = "pictureBoxlijilong";
            this.pictureBoxlijilong.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxlijilong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxlijilong.TabIndex = 3;
            this.pictureBoxlijilong.TabStop = false;
            // 
            // panellijilong
            // 
            this.panellijilong.BackColor = System.Drawing.Color.Transparent;
            this.panellijilong.Controls.Add(this.lijilongnoaq);
            this.panellijilong.Location = new System.Drawing.Point(18, 228);
            this.panellijilong.Margin = new System.Windows.Forms.Padding(4);
            this.panellijilong.Name = "panellijilong";
            this.panellijilong.Size = new System.Drawing.Size(159, 120);
            this.panellijilong.TabIndex = 4;
            this.panellijilong.Click += new System.EventHandler(this.panellijilong_Click);
            this.panellijilong.DoubleClick += new System.EventHandler(this.panellijilong_DoubleClick);
            // 
            // lijilongnoaq
            // 
            this.lijilongnoaq.AutoSize = true;
            this.lijilongnoaq.ForeColor = System.Drawing.Color.White;
            this.lijilongnoaq.Location = new System.Drawing.Point(-3, 94);
            this.lijilongnoaq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lijilongnoaq.Name = "lijilongnoaq";
            this.lijilongnoaq.Size = new System.Drawing.Size(152, 18);
            this.lijilongnoaq.TabIndex = 0;
            this.lijilongnoaq.Text = "李吉隆不安全卫士";
            // 
            // picsz
            // 
            this.picsz.BackColor = System.Drawing.Color.Transparent;
            this.picsz.Image = global::仿windows10电脑.Properties.Resources.material_symbols_settings;
            this.picsz.Location = new System.Drawing.Point(44, 408);
            this.picsz.Margin = new System.Windows.Forms.Padding(4);
            this.picsz.Name = "picsz";
            this.picsz.Size = new System.Drawing.Size(90, 90);
            this.picsz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsz.TabIndex = 5;
            this.picsz.TabStop = false;
            // 
            // pansz
            // 
            this.pansz.BackColor = System.Drawing.Color.Transparent;
            this.pansz.Controls.Add(this.labsz);
            this.pansz.Location = new System.Drawing.Point(18, 408);
            this.pansz.Margin = new System.Windows.Forms.Padding(4);
            this.pansz.Name = "pansz";
            this.pansz.Size = new System.Drawing.Size(159, 120);
            this.pansz.TabIndex = 6;
            this.pansz.Click += new System.EventHandler(this.pansz_Click);
            this.pansz.DoubleClick += new System.EventHandler(this.pansz_DoubleClick);
            // 
            // labsz
            // 
            this.labsz.AutoSize = true;
            this.labsz.ForeColor = System.Drawing.Color.White;
            this.labsz.Location = new System.Drawing.Point(50, 94);
            this.labsz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labsz.Name = "labsz";
            this.labsz.Size = new System.Drawing.Size(44, 18);
            this.labsz.TabIndex = 0;
            this.labsz.Text = "设置";
            // 
            // zm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::仿windows10电脑.Properties.Resources.OIP_C__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1946, 1094);
            this.Controls.Add(this.picsz);
            this.Controls.Add(this.pansz);
            this.Controls.Add(this.pictureBoxlijilong);
            this.Controls.Add(this.picPC);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panthisPC);
            this.Controls.Add(this.panellijilong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "zm";
            this.Text = "zm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.zm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPC)).EndInit();
            this.panthisPC.ResumeLayout(false);
            this.panthisPC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlijilong)).EndInit();
            this.panellijilong.ResumeLayout(false);
            this.panellijilong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picsz)).EndInit();
            this.pansz.ResumeLayout(false);
            this.pansz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmireturn;
        private System.Windows.Forms.ToolStripMenuItem tsmilock;
        private System.Windows.Forms.ToolStripMenuItem tmsidown;
        private System.Windows.Forms.PictureBox picPC;
        private System.Windows.Forms.Label labthisPC;
        private System.Windows.Forms.Panel panthisPC;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBoxlijilong;
        private System.Windows.Forms.Panel panellijilong;
        private System.Windows.Forms.Label lijilongnoaq;
        private System.Windows.Forms.PictureBox picsz;
        private System.Windows.Forms.Panel pansz;
        private System.Windows.Forms.Label labsz;
    }
}