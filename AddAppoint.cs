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
    public partial class AddAppoint : Form
    {
        public AddAppoint()
        {
            InitializeComponent();
        }
        static MongoClient client = new MongoClient("mongodb+srv://Matanza:levis250@cluster0.1qo3w.mongodb.net/Project1?retryWrites=true&w=majority");
        static IMongoDatabase db = client.GetDatabase("Demo1");
        static IMongoCollection<PatientModel> collection = db.GetCollection<PatientModel>("Patients");
        static IMongoCollection<AppointModel> collection2 = db.GetCollection<AppointModel>("Appointments");
       
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var updateApp = Builders<AppointModel>.Update.Set("Name", textBox1.Text).Set("CApp", dateTimePicker2.Value.ToUniversalTime()).Set("Doctor", comboBox1.Text);
            //collection2.UpdateOne(a => a.Pid == Guid.Parse(textBox4.Text), updateApp);
            //Close();
            AppointModel c = new AppointModel(textBox1.Text,dateTimePicker2.Value.ToUniversalTime(), comboBox1.Text);
            //collection.InsertOne(c);
            //ReadAllDocuments();
            this.Alert("Successfully Booked");
        }
        public void Alert(string msg)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
