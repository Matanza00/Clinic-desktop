using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SNS
{
    public partial class deletepatient : Form
    {
        public deletepatient()
        {
            InitializeComponent();
        }
        static MongoClient client = new MongoClient("mongodb+srv://shapenshine:Xsook2fb@cluster0.5x9i1.mongodb.net/<dbname>?retryWrites=true&w=majority");
        static IMongoDatabase db = client.GetDatabase("ShapeNShine");
        static IMongoCollection<PatientModel> collection = db.GetCollection<PatientModel>("Patients");
        public void ReadAllDocuments()
        {
            List<PatientModel> list = collection.AsQueryable().ToList<PatientModel>();
            dataGridView1.DataSource = list;
            // textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
        private void deletepatient_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            collection.DeleteOne(n => n.Name == textBox1.Text);
            ReadAllDocuments();
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
                    var regDef = Builders<PatientModel>.Filter.Gte(n => n.Name, textBox1.Text);
                    var cursor = collection.Find(regDef).ToList();
                    dataGridView1.DataSource = cursor;
                }
                if (comboBox1.SelectedItem.ToString() == "Number")
                {
                    var regDef = Builders<PatientModel>.Filter.Eq(n => n.PhNo, textBox1.Text);
                    var cursor = collection.Find(regDef).ToList();
                    dataGridView1.DataSource = cursor;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
