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
    public partial class EditPat : Form
    {
        public EditPat()
        {
            InitializeComponent();
        }
        static MongoClient client = new MongoClient("mongodb+srv://Matanza:levis250@cluster0.1qo3w.mongodb.net/Project1?retryWrites=true&w=majority");
        static IMongoDatabase db = client.GetDatabase("Demo1");
        static IMongoCollection<PatientModel> collection = db.GetCollection<PatientModel>("Patients");
        static IMongoCollection<AppointModel> collection2 = db.GetCollection<AppointModel>("Appointments");

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void ReadAllDocuments()
        {
            List<PatientModel> list = collection.AsQueryable().ToList<PatientModel>();
            //List<AppointModel> list2 = collection2.AsQueryable().ToList<AppointModel>();
            //List<BillModel> list3 = collection3.AsQueryable().ToList<BillModel>();
            dataGridView1.DataSource = list;
            //dataGridView2.DataSource = list2;
            //dataGridView3.DataSource = list3;
            // textBox1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            var regDef = Builders<PatientModel>.Filter.Empty;
            var cursor = collection.Find(regDef).SortBy(n => n.Name).ToList();
            dataGridView1.DataSource = cursor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Alert("Successfully Updated");
            //var update = Builders<PatientModel>.Update.Set("Name", textBox1.Text).Set("PhNo", textBox2.Text).Set("DOB", dateTimePicker1.Value).Set("Predicament", textBox3.Text);
            //collection.UpdateOne(n => n.Pid == Guid.Parse(textBox4.Text), update);
            ReadAllDocuments();
        }
        public void Alert(string msg)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Show();
        }
    }
}

