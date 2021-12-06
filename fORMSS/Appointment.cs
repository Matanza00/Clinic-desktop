using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Demo1.Patients;
using MongoDB.Driver;

namespace Demo1.fORMSS
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
            LoadTheme();
        }
        static MongoClient client = new MongoClient("mongodb+srv://Matanza:levis250@cluster0.1qo3w.mongodb.net/Project1?retryWrites=true&w=majority");
        static IMongoDatabase db = client.GetDatabase("Demo1");
        static IMongoCollection<PatientModel> collection = db.GetCollection<PatientModel>("Patients");
        static IMongoCollection<AppointModel> collection2 = db.GetCollection<AppointModel>("Appointments");

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please fill first");

            }
            else
            {
                if (comboBox1.SelectedItem.ToString() == "Name")
                {
                    var regDef = Builders<PatientModel>.Filter.Eq(n => n.Name, textBox1.Text);
                    var regDef2 = Builders<AppointModel>.Filter.Eq(a => a.Name, textBox1.Text);
                    var cursor = collection.Find(regDef).ToList();
                    var cursor2 = collection2.Find(regDef2).ToList();
                    dataGridView1.DataSource = cursor;
                }
                if (comboBox1.SelectedItem.ToString() == "Number")
                {
                    var regDef = Builders<PatientModel>.Filter.Eq(n => n.PhNo, textBox1.Text);
                    var cursor = collection.Find(regDef).ToList();
                    dataGridView1.DataSource = cursor;
                }
            }
            textBox1.Text = "";
        }
        public void ReadAllDocuments()
        {
            List<AppointModel> list = collection2.AsQueryable().ToList<AppointModel>();
            dataGridView1.DataSource = list;
             //textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
        private void Appointment_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Patients.AddAppoint P2 = new Patients.AddAppoint();
            P2.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            P2.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            P2.dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            // P1.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            P2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var regDef = Builders<AppointModel>.Filter.Empty;
            //var cursor = collection.Find(regDef).SortBy(n => n.Name).ToList();
            //dataGridView1.DataSource = cursor;
            ReadAllDocuments();
        }
    }
}
