﻿namespace caculator1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(273, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 32F);
            this.label3.Location = new System.Drawing.Point(232, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "小型计算器";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(141, 148);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 25);
            this.number1.TabIndex = 4;
            this.number1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(425, 148);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 25);
            this.number2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(587, 151);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(67, 15);
            this.result.TabIndex = 7;
            this.result.Text = "计算结果";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(273, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Click this";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button button1;
    }
}

