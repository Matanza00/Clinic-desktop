using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SNS
{
    public partial class frmLogin : UserControl
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "perfecto123")
            {
                var newform999 = new Form1();
                newform999.Show();
            }
        }
    }
}
