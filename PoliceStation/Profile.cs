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
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void Application_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Statement statement = new Statement();
            statement.Show();
        }

        private void Arrest_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Regdet regdet = new Regdet();
            regdet.Show();
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Employs employs = new Employs();
            employs.Show();
        }

        private void Timetable_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Timetable timetable = new Timetable();
            timetable.Show();
        }

        private void Delay_Click(object sender, EventArgs e)
        {

        }
    }
}
