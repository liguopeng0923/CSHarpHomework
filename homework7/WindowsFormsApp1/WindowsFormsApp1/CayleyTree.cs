﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
    private Graphics graphics;
        int recursionDepth1;
        double leng;
        double th1;
        double th2;
        double per1;
        double per2;
        Pen pen;
        
    private void button1_Click(object sender, EventArgs e)
    {
            if(!int.TryParse(recursionDepth.Text,out recursionDepth1))
            {
                MessageBox.Show("递归深度为整数");
                if (graphics != null)
                    graphics.Clear(BackColor);
                recursionDepth.Text = null;
            }
            if (!Double.TryParse(mainLeng.Text, out leng))
            {
                MessageBox.Show("主干长度为小数");
                if (graphics != null)
                    graphics.Clear(BackColor);
                mainLeng.Text = null;
            }
            if (!Double.TryParse(thRight.Text, out th1))
            {
                MessageBox.Show("右分支角度为小数");
                if (graphics != null)
                    graphics.Clear(BackColor);
                thRight.Text = null;
            }
            else
            {
                th1 = th1 * Math.PI / 180;
            }
            if (!Double.TryParse(thLeft.Text, out th2))
            {
                MessageBox.Show("左分支角度为小数");
                if (graphics != null)
                    graphics.Clear(BackColor);
                thLeft.Text = null;
            }
            else
            {
                th2 = th2 * Math.PI / 180;
            }
            if (!Double.TryParse(perRight.Text, out per1)||per1>1.0)
            {
                MessageBox.Show("右分支长度比为小于1的小数");
                if (graphics != null)
                    graphics.Clear(BackColor);
                perRight.Text = null;
            }
            if (!Double.TryParse(perLeft.Text, out per2)||per2>1.0)
            {
                MessageBox.Show("左分支长度比为小于1小数");
                if (graphics != null)
                    graphics.Clear(BackColor);
                perLeft.Text = null;
            }
            switch (Color.Text){
                case "红色":pen=Pens.Red; break;
                case "蓝色": pen = Pens.Blue; break;
                case "绿色": pen = Pens.Green; break;
                default:pen = Pens.Black;break;
            }
            if (graphics == null) graphics = panel1.CreateGraphics();
            else graphics.Clear(BackColor);
            drawCayleyTree(recursionDepth1, 200, 310, leng, -Math.PI / 2);

        }
    void drawCayleyTree(int n,double x0,double y0,double leng, double th)
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
