
namespace 仿windows10电脑
{
    partial class windowsinstall7
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtzdy = new System.Windows.Forms.TextBox();
            this.labbz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "你想执行哪种类型的安装?";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(42, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(723, 87);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "升级:安装 Windows并保留文件、设置和应用程序(U)\n如果使用此选项，则会将文件、设置和应用程序移到Windows。只有当计算机上运行的是支持的\nWindo" +
    "ws 版本时，才能使用此选项。";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // txtzdy
            // 
            this.txtzdy.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtzdy.ForeColor = System.Drawing.Color.Blue;
            this.txtzdy.Location = new System.Drawing.Point(42, 195);
            this.txtzdy.Multiline = true;
            this.txtzdy.Name = "txtzdy";
            this.txtzdy.ReadOnly = true;
            this.txtzdy.Size = new System.Drawing.Size(723, 99);
            this.txtzdy.TabIndex = 5;
            this.txtzdy.Text = "自定义:仅安装 Windows(高级)(C)\n如果使用此选项，则不会将文件、设置和应用程序移到Windows。如果要对分区和驱动器进行更\n改，请使用安装盘启动计算" +
    "机。我们建议你先备份文件，然后再继续操作。";
            this.txtzdy.Click += new System.EventHandler(this.txtzdy_Click);
            // 
            // labbz
            // 
            this.labbz.AutoSize = true;
            this.labbz.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labbz.ForeColor = System.Drawing.Color.Blue;
            this.labbz.Location = new System.Drawing.Point(55, 317);
            this.labbz.Name = "labbz";
            this.labbz.Size = new System.Drawing.Size(112, 16);
            this.labbz.TabIndex = 6;
            this.labbz.Text = "帮助我决定(&H)";
            this.labbz.Click += new System.EventHandler(this.labbz_Click);
            // 
            // windowsinstall7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labbz);
            this.Controls.Add(this.txtzdy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "windowsinstall7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "windows安装程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtzdy;
        private System.Windows.Forms.Label labbz;
    }
}