using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace Demo1.Patients
{
    public partial class AddPat : Form
    {
        static MongoClient client = new MongoClient("mongodb+srv://Matanza:levis250@cluster0.1qo3w.mongodb.net/Project1?retryWrites=true&w=majority");
        static IMongoDatabase db = client.GetDatabase("Demo1");
        static IMongoCollection<PatientModel> collection = db.GetCollection<PatientModel>("Patients");

        public void ReadAllDocuments()
        {
            //List<PatientModel> list = collection.AsQueryable().ToList<PatientModel>();
            //  dataGridView1.DataSource = list;
            //  textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
        public AddPat()
        {
            InitializeComponent();
        }
        private Form activeForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fORMSS.Appointment(), sender);
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

                }
            }

        }

        public void Alert(string msg)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PatientModel n = new PatientModel(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToUniversalTime(),textBox3.Text);
            collection.InsertOne(n);
            ReadAllDocuments();
            this.Alert("Successfully Saved");
        }
    }
}
