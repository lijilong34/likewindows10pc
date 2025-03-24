
namespace 仿windows10电脑
{
    partial class windowsinstall8
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
            this.btnkz = new System.Windows.Forms.Button();
            this.btnloading = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnyy = new System.Windows.Forms.Button();
            this.btnqx = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.dgvDisk = new System.Windows.Forms.DataGridView();
            this.分区id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总大小 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.可用空间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUddx = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUddx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "你想将Windows安装在哪里?";
            // 
            // btnkz
            // 
            this.btnkz.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnkz.Image = global::仿windows10电脑.Properties.Resources._006;
            this.btnkz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkz.Location = new System.Drawing.Point(194, 351);
            this.btnkz.Name = "btnkz";
            this.btnkz.Size = new System.Drawing.Size(82, 23);
            this.btnkz.TabIndex = 11;
            this.btnkz.Text = "扩展(&X)";
            this.btnkz.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkz.UseVisualStyleBackColor = true;
            this.btnkz.Click += new System.EventHandler(this.btnkz_Click);
            // 
            // btnloading
            // 
            this.btnloading.BackColor = System.Drawing.Color.Transparent;
            this.btnloading.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnloading.ForeColor = System.Drawing.Color.Blue;
            this.btnloading.Image = global::仿windows10电脑.Properties.Resources._005;
            this.btnloading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnloading.Location = new System.Drawing.Point(36, 349);
            this.btnloading.Name = "btnloading";
            this.btnloading.Size = new System.Drawing.Size(124, 23);
            this.btnloading.TabIndex = 10;
            this.btnloading.Text = "加载驱动程序(&L)";
            this.btnloading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnloading.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnadd.ForeColor = System.Drawing.Color.Blue;
            this.btnadd.Image = global::仿windows10电脑.Properties.Resources._004;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(405, 300);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(76, 23);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "新建(&E)";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.BackColor = System.Drawing.Color.Transparent;
            this.btnFormat.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFormat.Image = global::仿windows10电脑.Properties.Resources._003;
            this.btnFormat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFormat.Location = new System.Drawing.Point(281, 300);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(85, 23);
            this.btnFormat.TabIndex = 8;
            this.btnFormat.Text = "格式化(&F)";
            this.btnFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormat.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Image = global::仿windows10电脑.Properties.Resources._002;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(149, 300);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(84, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "删除(&D)";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdate.Image = global::仿windows10电脑.Properties.Resources._001;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(36, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "刷新(&R)";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(310, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "大小：(&S)";
            this.label2.Visible = false;
            // 
            // btnyy
            // 
            this.btnyy.Location = new System.Drawing.Point(470, 351);
            this.btnyy.Name = "btnyy";
            this.btnyy.Size = new System.Drawing.Size(75, 23);
            this.btnyy.TabIndex = 14;
            this.btnyy.Text = "应用(&P)";
            this.btnyy.UseVisualStyleBackColor = true;
            this.btnyy.Visible = false;
            this.btnyy.Click += new System.EventHandler(this.btnyy_Click);
            // 
            // btnqx
            // 
            this.btnqx.Location = new System.Drawing.Point(559, 351);
            this.btnqx.Name = "btnqx";
            this.btnqx.Size = new System.Drawing.Size(75, 23);
            this.btnqx.TabIndex = 15;
            this.btnqx.Text = "取消(&C)";
            this.btnqx.UseVisualStyleBackColor = true;
            this.btnqx.Visible = false;
            this.btnqx.Click += new System.EventHandler(this.btnqx_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(559, 402);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "下一步(&N)";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // dgvDisk
            // 
            this.dgvDisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.分区id,
            this.名称,
            this.总大小,
            this.可用空间,
            this.类型});
            this.dgvDisk.Location = new System.Drawing.Point(36, 54);
            this.dgvDisk.Name = "dgvDisk";
            this.dgvDisk.ReadOnly = true;
            this.dgvDisk.RowTemplate.Height = 23;
            this.dgvDisk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisk.Size = new System.Drawing.Size(585, 218);
            this.dgvDisk.TabIndex = 17;
            // 
            // 分区id
            // 
            this.分区id.DataPropertyName = "Did";
            this.分区id.HeaderText = "硬盘Id";
            this.分区id.Name = "分区id";
            this.分区id.ReadOnly = true;
            this.分区id.Visible = false;
            // 
            // 名称
            // 
            this.名称.DataPropertyName = "Diskname";
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            this.名称.Width = 200;
            // 
            // 总大小
            // 
            this.总大小.DataPropertyName = "Sum";
            this.总大小.HeaderText = "总大小";
            this.总大小.Name = "总大小";
            this.总大小.ReadOnly = true;
            // 
            // 可用空间
            // 
            this.可用空间.DataPropertyName = "Nullkj";
            this.可用空间.HeaderText = "可用空间";
            this.可用空间.Name = "可用空间";
            this.可用空间.ReadOnly = true;
            // 
            // 类型
            // 
            this.类型.DataPropertyName = "Type1";
            this.类型.HeaderText = "类型";
            this.类型.Name = "类型";
            this.类型.ReadOnly = true;
            this.类型.Width = 150;
            // 
            // dUddx
            // 
            this.dUddx.Location = new System.Drawing.Point(375, 351);
            this.dUddx.Name = "dUddx";
            this.dUddx.Size = new System.Drawing.Size(89, 21);
            this.dUddx.TabIndex = 18;
            this.dUddx.Visible = false;
            // 
            // windowsinstall8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.dUddx);
            this.Controls.Add(this.dgvDisk);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnqx);
            this.Controls.Add(this.btnyy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnkz);
            this.Controls.Add(this.btnloading);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Name = "windowsinstall8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "windows安装程序";
            this.Load += new System.EventHandler(this.windowsinstall8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUddx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnloading;
        private System.Windows.Forms.Button btnkz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnyy;
        private System.Windows.Forms.Button btnqx;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridView dgvDisk;
        private System.Windows.Forms.NumericUpDown dUddx;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分区id;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总大小;
        private System.Windows.Forms.DataGridViewTextBoxColumn 可用空间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
    }
}