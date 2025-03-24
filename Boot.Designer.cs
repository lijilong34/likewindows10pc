
namespace 仿windows10电脑
{
    partial class Boot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boot));
            this.label1 = new System.Windows.Forms.Label();
            this.pbboot = new System.Windows.Forms.PictureBox();
            this.imgeList = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbboot)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(521, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Powered by lijilong";
            // 
            // pbboot
            // 
            this.pbboot.BackColor = System.Drawing.Color.Transparent;
            this.pbboot.Location = new System.Drawing.Point(637, 470);
            this.pbboot.Name = "pbboot";
            this.pbboot.Size = new System.Drawing.Size(60, 60);
            this.pbboot.TabIndex = 1;
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
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pbboot);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Boot";
            this.Text = "Boot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbboot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbboot;
        private System.Windows.Forms.ImageList imgeList;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
    }
}