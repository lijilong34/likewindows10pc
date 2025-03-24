
namespace 仿windows10电脑.system
{
    partial class systemdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(systemdown));
            this.imgeList = new System.Windows.Forms.ImageList(this.components);
            this.pbboot = new System.Windows.Forms.PictureBox();
            this.labzt = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbboot)).BeginInit();
            this.SuspendLayout();
            // 
            // imgeList
            // 
            this.imgeList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgeList.ImageStream")));
            this.imgeList.TransparentColor = System.Drawing.Color.DodgerBlue;
            this.imgeList.Images.SetKeyName(0, "001.jpg");
            this.imgeList.Images.SetKeyName(1, "002.jpg");
            this.imgeList.Images.SetKeyName(2, "003.jpg");
            this.imgeList.Images.SetKeyName(3, "004.jpg");
            this.imgeList.Images.SetKeyName(4, "005.jpg");
            this.imgeList.Images.SetKeyName(5, "006.jpg");
            this.imgeList.Images.SetKeyName(6, "007.jpg");
            // 
            // pbboot
            // 
            this.pbboot.BackColor = System.Drawing.Color.Black;
            this.pbboot.Location = new System.Drawing.Point(672, 258);
            this.pbboot.Name = "pbboot";
            this.pbboot.Size = new System.Drawing.Size(83, 83);
            this.pbboot.TabIndex = 4;
            this.pbboot.TabStop = false;
            // 
            // labzt
            // 
            this.labzt.AutoSize = true;
            this.labzt.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labzt.ForeColor = System.Drawing.Color.White;
            this.labzt.Location = new System.Drawing.Point(654, 382);
            this.labzt.Name = "labzt";
            this.labzt.Size = new System.Drawing.Size(111, 33);
            this.labzt.TabIndex = 5;
            this.labzt.Text = "label1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // systemdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1334, 690);
            this.Controls.Add(this.labzt);
            this.Controls.Add(this.pbboot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "systemdown";
            this.Text = "systemdown";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbboot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbboot;
        private System.Windows.Forms.ImageList imgeList;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labzt;
    }
}