namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainLeng = new System.Windows.Forms.TextBox();
            this.perRight = new System.Windows.Forms.TextBox();
            this.thRight = new System.Windows.Forms.TextBox();
            this.perLeft = new System.Windows.Forms.TextBox();
            this.thLeft = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recursionDepth = new System.Windows.Forms.TextBox();
            this.Color = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Location = new System.Drawing.Point(8, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 340);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mainLeng);
            this.groupBox1.Controls.Add(this.perRight);
            this.groupBox1.Controls.Add(this.thRight);
            this.groupBox1.Controls.Add(this.perLeft);
            this.groupBox1.Controls.Add(this.thLeft);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.recursionDepth);
            this.groupBox1.Controls.Add(this.Color);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(538, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "颜色";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "主干长度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "右分支长度比";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "右分支角度";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "左分支角度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "左分支长度比";
            // 
            // mainLeng
            // 
            this.mainLeng.Location = new System.Drawing.Point(80, 57);
            this.mainLeng.Name = "mainLeng";
            this.mainLeng.Size = new System.Drawing.Size(56, 25);
            this.mainLeng.TabIndex = 21;
            this.mainLeng.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // perRight
            // 
            this.perRight.Location = new System.Drawing.Point(265, 22);
            this.perRight.Name = "perRight";
            this.perRight.Size = new System.Drawing.Size(56, 25);
            this.perRight.TabIndex = 20;
            this.perRight.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // thRight
            // 
            this.thRight.Location = new System.Drawing.Point(265, 57);
            this.thRight.Name = "thRight";
            this.thRight.Size = new System.Drawing.Size(56, 25);
            this.thRight.TabIndex = 19;
            this.thRight.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // perLeft
            // 
            this.perLeft.Location = new System.Drawing.Point(430, 25);
            this.perLeft.Name = "perLeft";
            this.perLeft.Size = new System.Drawing.Size(56, 25);
            this.perLeft.TabIndex = 18;
            this.perLeft.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // thLeft
            // 
            this.thLeft.Location = new System.Drawing.Point(430, 56);
            this.thLeft.Name = "thLeft";
            this.thLeft.Size = new System.Drawing.Size(56, 25);
            this.thLeft.TabIndex = 17;
            this.thLeft.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "递归深度";
            // 
            // recursionDepth
            // 
            this.recursionDepth.Location = new System.Drawing.Point(80, 22);
            this.recursionDepth.Name = "recursionDepth";
            this.recursionDepth.Size = new System.Drawing.Size(56, 25);
            this.recursionDepth.TabIndex = 8;
            this.recursionDepth.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Color
            // 
            this.Color.FormattingEnabled = true;
            this.Color.ItemHeight = 15;
            this.Color.Items.AddRange(new object[] {
            "红色",
            "蓝色",
            "绿色"});
            this.Color.Location = new System.Drawing.Point(581, 25);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(114, 49);
            this.Color.TabIndex = 7;
            this.Color.UseWaitCursor = true;
            this.Color.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "绘制";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 441);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 444);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recursionDepth;
        private System.Windows.Forms.TextBox mainLeng;
        private System.Windows.Forms.TextBox perRight;
        private System.Windows.Forms.TextBox thRight;
        private System.Windows.Forms.TextBox perLeft;
        private System.Windows.Forms.TextBox thLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

