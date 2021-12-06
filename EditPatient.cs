using MongoDB.Bson;
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
    public partial class EditPatient : Form
    {
        static MongoClient client = new MongoClient("mongodb+srv://shapenshine:Xsook2fb@cluster0.5x9i1.mongodb.net/<dbname>?retryWrites=true&w=majority");
        static IMongoDatabase db = client.GetDatabase("ShapeNShine");
        static IMongoCollection<AppointModel> collection2 = db.GetCollection<AppointModel>("Appointments");
        static IMongoCollection<PatientModel> collection = db.GetCollection<PatientModel>("Patients");
        static IMongoCollection<BillModel> collection3 = db.GetCollection<BillModel>("Bill");
        public void ReadAllDocuments()
        {
            List<PatientModel> list = collection.AsQueryable().ToList<PatientModel>();
            List<AppointModel> list2 = collection2.AsQueryable().ToList<AppointModel>();
            List<BillModel> list3 = collection3.AsQueryable().ToList<BillModel>();
            dataGridView1.DataSource = list;
            dataGridView2.DataSource = list2;
            dataGridView3.DataSource = list3;
            // textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
        public EditPatient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please fill first");

            }
            else
            {       
                //serach by name
                    var regDef = Builders<PatientModel>.Filter.Eq(n => n.Name, textBox1.Text);
                    var cursor = collection.Find(regDef).ToList();
                    dataGridView1.DataSource = cursor;
                    var regDef1 = Builders<AppointModel>.Filter.Gte(n => n.Name, textBox1.Text);
                    var cursor1 = collection2.Find(regDef1).ToList();
                    dataGridView2.DataSource = cursor1;
                    var regDef2 = Builders<BillModel>.Filter.Gte(n => n.Name, textBox1.Text);
                    var cursor2 = collection3.Find(regDef2).ToList();
                    dataGridView3.DataSource = cursor2;
                    
                //search by phone
                    var regDef3 = Builders<PatientModel>.Filter.Eq(n => n.PhNo, textBox2.Text);
                    var cursor3 = collection.Find(regDef3).ToList();
                    dataGridView1.DataSource = cursor3;
                    var regDef4 = Builders<AppointModel>.Filter.Gte(n => n.Name, textBox2.Text);
                    var cursor4 = collection2.Find(regDef4).ToList();
                    dataGridView2.DataSource = cursor4;
                    var regDef5 = Builders<BillModel>.Filter.Gte(n => n.Name, textBox2.Text);
                    var cursor5 = collection3.Find(regDef5).ToList();
                    dataGridView3.DataSource = cursor5;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<PatientModel>.Update.Set("Name", textBox1.Text).Set("PhNo", textBox2.Text).Set("CApp", dateTimePicker2.Value.ToUniversalTime()).Set("Bill", textBox4.Text).Set("Treatment", textBox5.Text);
            var updateApp = Builders<AppointModel>.Update.Set("Name", textBox1.Text).Set("CApp", dateTimePicker2.Value.ToUniversalTime());
            var updateBill = Builders<BillModel>.Update.Set("Name", textBox1.Text).Set("Bill", textBox4.Text).Set("Treatment",textBox5.Text);
            collection.UpdateOne(n => n.Pid == Guid.Parse(textBox6.Text) ,updateDef);
            collection2.UpdateOne(a => a.Pid== Guid.Parse(textBox3.Text), updateApp);
            collection3.UpdateOne(b => b.Pid == Guid.Parse(textBox7.Text), updateBill);
            ReadAllDocuments();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox3.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox7.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
