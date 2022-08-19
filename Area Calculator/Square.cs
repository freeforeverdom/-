using System;
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
    public partial class Square : Form
    {
        
        
        
        public Square()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Rect rect3 = new Rect();
                rect3.Show();
                this.Close();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Tri tri3 = new Tri();
                tri3.Show();
                this.Close();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Circular circular3 = new Circular();
                circular3.Show();
                this.Close();
            }
        }

        private void Square_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string long1 = textBox1.Text.Trim();
            decimal m = Convert.ToDecimal(long1);
            decimal MeasureArea = m * m;
            String str = MeasureArea.ToString("0.000");
            string Measure = str + " ";
            textBox3.Text = Measure;
        }
    }
}
