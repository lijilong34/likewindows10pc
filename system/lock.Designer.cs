
namespace 仿windows10电脑.system
{
    partial class @lock
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
            this.labetime = new System.Windows.Forms.Label();
            this.labtData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labetime
            // 
            this.labetime.AutoSize = true;
            this.labetime.BackColor = System.Drawing.Color.Transparent;
            this.labetime.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labetime.ForeColor = System.Drawing.Color.Black;
            this.labetime.Location = new System.Drawing.Point(119, 492);
            this.labetime.Name = "labetime";
            this.labetime.Size = new System.Drawing.Size(220, 64);
            this.labetime.TabIndex = 0;
            this.labetime.Text = "label1";
            // 
            // labtData
            // 
            this.labtData.AutoSize = true;
            this.labtData.BackColor = System.Drawing.Color.Transparent;
            this.labtData.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labtData.ForeColor = System.Drawing.Color.Black;
            this.labtData.Location = new System.Drawing.Point(117, 638);
            this.labtData.Name = "labtData";
            this.labtData.Size = new System.Drawing.Size(103, 29);
            this.labtData.TabIndex = 1;
            this.labtData.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // @lock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::仿windows10电脑.Properties.Resources.OIP_C__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.labtData);
            this.Controls.Add(this.labetime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "@lock";
            this.Text = "@lock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.lock_Load);
            this.Click += new System.EventHandler(this.lock_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labetime;
        private System.Windows.Forms.Label labtData;
        private System.Windows.Forms.Timer timer1;
    }
}