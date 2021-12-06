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

namespace Demo1.fORMSS
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            LoadTheme();
        }
        static MongoClient client = new MongoClient("mongodb+srv://Matanza:levis250@cluster0.1qo3w.mongodb.net/Project1?retryWrites=true&w=majority");
        static IMongoDatabase db = client.GetDatabase("Demo1");
        static IMongoCollection<PatientModel> collection = db.GetCollection<PatientModel>("Patients");
        static IMongoCollection<AppointModel> collection2 = db.GetCollection<AppointModel>("Appointments");

        private void Search_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        public void ReadAllDocuments()
        {
            List<PatientModel> list = collection.AsQueryable().ToList<PatientModel>();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    var cursor = collection.Find(regDef).SortBy(n => n.Name).ToList();
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

        private void button2_Click(object sender, EventArgs e)
        {
            var regDef = Builders<PatientModel>.Filter.Empty;
            var cursor = collection.Find(regDef).SortBy(n => n.Name).ToList();
            dataGridView1.DataSource = cursor;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
