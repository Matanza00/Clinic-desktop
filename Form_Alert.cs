using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1
{
    public partial class Form_Alert : Form
    {
        public Form_Alert()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void Form_Alert_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in panel1.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    BackColor = ThemeColor.PrimaryColor;
                    

                }
            }

        }

        public enum enmACtion
        {
            wait,
            start,
            close
        }

        private Form_Alert.enmACtion action;
        private int x;
        private int y;

        public void showAlert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 0; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            this.lblMsg.Text = msg;

            this.Show();
            this.action = enmACtion.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmACtion.wait:
                    timer1.Interval = 5000;
                    action = enmACtion.close;
                    break;
                case enmACtion.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {

                        this.Left--;
                    }
                    else;
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmACtion.wait;
                        }
                    }
                    break;
                case enmACtion.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmACtion.close;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
