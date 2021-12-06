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
    public partial class BillHistory : Form
    {
        static MongoClient client = new MongoClient("mongodb+srv://shapenshine:Xsook2fb@cluster0.5x9i1.mongodb.net/<dbname>?retryWrites=true&w=majority");
        static IMongoDatabase db = client.GetDatabase("ShapeNShine");
        static IMongoCollection<BillModel> collection3 = db.GetCollection<BillModel>("Bill");
        public void ReadAllDocuments()
        {
            List<BillModel> list = collection3.AsQueryable().ToList<BillModel>();
            dataGridView1.DataSource = list;
            //  textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
        }
        public BillHistory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            ReadAllDocuments();
            for (int i = 0; i<dataGridView1.Rows.Count;i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            label2.Text = sum.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BillHistory_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
