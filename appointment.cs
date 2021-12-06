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
    public partial class appointment : UserControl
    {
        public appointment()
        {
            InitializeComponent();
        }
        static MongoClient client = new MongoClient("mongodb+srv://shapenshine:Xsook2fb@cluster0.5x9i1.mongodb.net/<dbname>?retryWrites=true&w=majority");
        static IMongoDatabase db = client.GetDatabase("ShapeNShine");
        static IMongoCollection<AppointModel> collection = db.GetCollection<AppointModel>("Appointments");
        public void ReadAllDocuments()
        {
            List<AppointModel> list = collection.AsQueryable().ToList<AppointModel>();
            dataGridView1.DataSource = list;
            // textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
        private void appointment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadAllDocuments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var regDef = Builders<AppointModel>.Filter.Gte(a => a.CApp, dateTimePicker1.Value.ToUniversalTime());
            var cursor = collection.Find(regDef).ToList();
            dataGridView1.DataSource = cursor;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
       
        }
    }
}
