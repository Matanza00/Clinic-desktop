using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SNS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 11;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Fill first");
            }
            else
            {
                if (textBox1.Text == "admin" && textBox2.Text == "perfecto123")
                {

                    var newform999 = new Form1();
                    newform999.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Id or Password");
                }

        } 
       }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
