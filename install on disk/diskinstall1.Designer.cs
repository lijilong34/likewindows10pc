
namespace 仿windows10电脑.install_on_disk
{
    partial class diskinstall1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diskinstall1));
            this.labzt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbboot = new System.Windows.Forms.PictureBox();
            this.imgeList = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labinstall = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timerfw = new System.Windows.Forms.Timer(this.components);
            this.timerjx = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbboot)).BeginInit();
            this.SuspendLayout();
            // 
            // labzt
            // 
            this.labzt.AutoSize = true;
            this.labzt.BackColor = System.Drawing.Color.Transparent;
            this.labzt.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labzt.ForeColor = System.Drawing.Color.White;
            this.labzt.Location = new System.Drawing.Point(608, 610);
            this.labzt.Name = "labzt";
            this.labzt.Size = new System.Drawing.Size(82, 24);
            this.labzt.TabIndex = 0;
            this.labzt.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(520, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Powered by lijilong";
            // 
            // pbboot
            // 
            this.pbboot.BackColor = System.Drawing.Color.Transparent;
            this.pbboot.Location = new System.Drawing.Point(660, 463);
            this.pbboot.Name = "pbboot";
            this.pbboot.Size = new System.Drawing.Size(60, 76);
            this.pbboot.TabIndex = 2;
            this.pbboot.TabStop = false;
            // 
            // imgeList
            // 
            this.imgeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgeList.ImageStream")));
            this.imgeList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgeList.Images.SetKeyName(0, "001.jpg");
            this.imgeList.Images.SetKeyName(1, "002.jpg");
            this.imgeList.Images.SetKeyName(2, "003.jpg");
            this.imgeList.Images.SetKeyName(3, "004.jpg");
            this.imgeList.Images.SetKeyName(4, "005.jpg");
            this.imgeList.Images.SetKeyName(5, "006.jpg");
            this.imgeList.Images.SetKeyName(6, "007.jpg");
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(731, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "(";
            this.label1.Visible = false;
            // 
            // labinstall
            // 
            this.labinstall.AutoSize = true;
            this.labinstall.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labinstall.ForeColor = System.Drawing.Color.White;
            this.labinstall.Location = new System.Drawing.Point(753, 610);
            this.labinstall.Name = "labinstall";
            this.labinstall.Size = new System.Drawing.Size(19, 20);
            this.labinstall.TabIndex = 4;
            this.labinstall.Text = "0";
            this.labinstall.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(788, 610);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "%)";
            this.label4.Visible = false;
            // 
            // timerfw
            // 
            this.timerfw.Tick += new System.EventHandler(this.timerfw_Tick);
            // 
            // timerjx
            // 
            this.timerjx.Interval = 3000;
            this.timerjx.Tick += new System.EventHandler(this.timerjx_Tick);
            // 
            // diskinstall1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labinstall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbboot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labzt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "diskinstall1";
            this.Text = "diskinstall1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.diskinstall1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbboot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labzt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbboot;
        private System.Windows.Forms.ImageList imgeList;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labinstall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerfw;
        private System.Windows.Forms.Timer timerjx;
    }
}