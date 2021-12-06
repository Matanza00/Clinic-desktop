using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ePOSOne.btnProduct;
using MongoDB.Driver;

namespace Demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            splitsideleft.Panel1Collapsed = true;
        }
        static MongoClient client = new MongoClient("mongodb+srv://Matanza:levis250@cluster0.1qo3w.mongodb.net/Project1?retryWrites=true&w=majority");
        static IMongoDatabase db = client.GetDatabase("Demo1");
        static IMongoCollection<PatientModel> collection = db.GetCollection<PatientModel>("Patients");
        static IMongoCollection<AppointModel> collection2 = db.GetCollection<AppointModel>("Appointments");

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();

            if (splitsideleft.Panel1Collapsed != true)
            {
                splitsideleft.Panel1Collapsed = true;
                timer1.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splitsideleft.Panel1Collapsed = false;
            timer1.Stop();
        }
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private int index;
        private Form activeForm;

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex == index)
            {
               index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }



        private void ActivateButton(Object btnSender)
        {
            if (btnSender != null)
            {
            
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Sitka Heading", 16.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    panel2.BackColor = ThemeColor.ChangeColorBrightness(color, -0.2);
                    panelSide.BackColor = ThemeColor.ChangeColorBrightness(color, -0.4);
                    panelTitleBar.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSide.Controls)
            {
                if (previousBtn.GetType() == typeof(Button_WOC))
                {
                    previousBtn.BackColor = Color.FromArgb(27, 41, 56);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Sitka Heading", 14.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void OpenChildForm1(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fORMSS.Home(), sender);
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fORMSS.Patient(), sender);
        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fORMSS.Appointment(), sender);
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fORMSS.Search(), sender);
        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fORMSS.Payment(), sender);
        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new fORMSS.Home(), sender);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_WOC8_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new fORMSS.Appointment(), sender);
        }

        private void panelSide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_WOC7_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new fORMSS.Patient(), sender);
        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new fORMSS.Search(), sender);
        }

        private void button_WOC10_Click(object sender, EventArgs e)
        {
            OpenChildForm1(new fORMSS.Payment(), sender);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
