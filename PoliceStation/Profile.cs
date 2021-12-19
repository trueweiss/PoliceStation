using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceStation
{
    public partial class Profile : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Profile()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Turquoise;
                    //currentButton.ForeColor = Color.White;
                    //currentButton.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel2.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.DarkCyan;
                    //previousBtn.ForeColor = Color.WhiteSmoke;
                    //previousBtn.Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

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
            this.Forms.Controls.Add(childForm);
            this.Forms.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void Application_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Statement(), sender);
        }

        private void Arrest_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Regdet(), sender);
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Employs(), sender);
        }

        private void Timetable_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Timetable(), sender);
        }

        private void Delay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Alldet(), sender);
        }

        private void AllStatements_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllStatements(), sender);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
