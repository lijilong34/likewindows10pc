
namespace 仿windows10电脑.install_on_disk
{
    partial class diskinstall2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(diskinstall2));
            this.labtxt = new System.Windows.Forms.Label();
            this.imgeList = new System.Windows.Forms.ImageList(this.components);
            this.pbboot = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeym1 = new System.Windows.Forms.Timer(this.components);
            this.timerLo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbboot)).BeginInit();
            this.SuspendLayout();
            // 
            // labtxt
            // 
            this.labtxt.AutoSize = true;
            this.labtxt.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labtxt.ForeColor = System.Drawing.Color.White;
            this.labtxt.Location = new System.Drawing.Point(569, 419);
            this.labtxt.Name = "labtxt";
            this.labtxt.Size = new System.Drawing.Size(271, 33);
            this.labtxt.TabIndex = 0;
            this.labtxt.Text = "嗨，别来无恙啊。";
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
            this.pbboot.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbboot.Location = new System.Drawing.Point(653, 312);
            this.pbboot.Name = "pbboot";
            this.pbboot.Size = new System.Drawing.Size(83, 83);
            this.pbboot.TabIndex = 2;
            this.pbboot.TabStop = false;
            this.pbboot.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeym1
            // 
            this.timeym1.Interval = 5000;
            this.timeym1.Tick += new System.EventHandler(this.timeym1_Tick);
            // 
            // timerLo
            // 
            this.timerLo.Interval = 30000;
            this.timerLo.Tick += new System.EventHandler(this.timerLo_Tick);
            // 
            // diskinstall2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pbboot);
            this.Controls.Add(this.labtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "diskinstall2";
            this.Text = "diskinstall2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbboot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labtxt;
        private System.Windows.Forms.PictureBox pbboot;
        private System.Windows.Forms.ImageList imgeList;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timeym1;
        private System.Windows.Forms.Timer timerLo;
    }
}