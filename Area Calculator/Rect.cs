﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Calculator
{
    public partial class Rect : Form
    {
        
        
        
        public Rect()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                Square square2 = new Square();
                square2.Show();
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Tri tri2 = new Tri();
                tri2.Show();
                this.Close ();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Circular circular2 = new Circular();
                circular2.Show();
                this.Close () ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string long1 = textBox1.Text.Trim();
            string width1 = textBox2.Text.Trim();
            decimal m = Convert.ToDecimal(long1);
            decimal n = Convert.ToDecimal(width1);
            decimal MeasureArea = m * n;
            String str = MeasureArea.ToString("0.000");
            string Measure = str + " ";
            textBox3.Text = Measure;
        }
    }
}
