using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SNS
{
    public partial class patient : UserControl
    {
        public patient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new adpatient();
            newForm.Show();
        }

        private void patient_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm2 = new deletepatient();
            newForm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm3 = new EditPatient();
            newForm3.Show();
        }
    }
}
