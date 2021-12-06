using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Demo1
{
    public partial class PrintReciept : Form
    {
        public PrintReciept()
        {
            InitializeComponent();
        }
        private void PrintReciept_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void button1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
         }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox32.Text = (float.Parse(textBox30.Text) - float.Parse(textBox31.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = (float.Parse(textBox12.Text) + float.Parse(textBox16.Text) + float.Parse(textBox20.Text) + float.Parse(textBox24.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = (float.Parse(textBox12.Text) + float.Parse(textBox16.Text) + float.Parse(textBox20.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = (float.Parse(textBox12.Text) + float.Parse(textBox16.Text) + float.Parse(textBox20.Text) + float.Parse(textBox24.Text) + float.Parse(textBox28.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = (float.Parse(textBox12.Text) + float.Parse(textBox16.Text) + float.Parse(textBox20.Text) + float.Parse(textBox24.Text) + float.Parse(textBox28.Text) + float.Parse(textBox32.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            { 
            textBox12.Text = (float.Parse(textBox10.Text) - float.Parse(textBox11.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            { 
            textBox16.Text = (float.Parse(textBox14.Text) - float.Parse(textBox15.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox20.Text = (float.Parse(textBox18.Text) - float.Parse(textBox19.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox24.Text = (float.Parse(textBox22.Text) - float.Parse(textBox23.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox30.Text = (float.Parse(textBox26.Text) - float.Parse(textBox27.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox4.Text = DateTime.Now.ToString("dddd, dd MMM yyyy");
            textBox8.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = (float.Parse(textBox12.Text) + float.Parse(textBox16.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = (float.Parse(textBox12.Text)).ToString();
            }
            catch
            {

            }
        }
    }
}
