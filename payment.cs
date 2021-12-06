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
    
    public partial class payment : UserControl
    {
        public payment()
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
        private void search_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
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
            textBox1.Text = "";
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            ReadAllDocuments();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrintReciept P1 = new PrintReciept();
            P1.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            P1.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            P1.textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           // P1.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            P1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ReadAllDocuments();
        }



        //private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        //{
        //    e.Graphics.DrawImage(bitmap, 0, 0);
        //}

        //Bitmap bitmap;
        private void button3_Click(object sender, EventArgs e)
        {
            var newFrm13 = new PrintReciept();
            newFrm13.Show();
            //    Panel panel = new Panel();
            //    this.Controls.Add(panel);

            //    Graphics graphics = panel.CreateGraphics();
            //    Size size = this.ClientSize;
            //    bitmap = new Bitmap(size.Width, size.Height, graphics);
            //    graphics = Graphics.FromImage(bitmap);

            //    Point point = PointToScreen(panel.Location);
            //    graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            //    printPreviewDialog1.Document = printDocument1;
            //    printPreviewDialog1.ShowDialog();

        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            PrintReciept P1 = new PrintReciept();
            P1.textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            P1.textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            P1.textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           // P1.textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            P1.Show();
        }
    }
}
