using MySql.Data.MySqlClient;
using SqlConn;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceStation
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Timetable_Load(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            MySqlConnection conn = DataBase.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Timetable` ", conn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                foreach (DbDataRecord result in reader)
                {
                    arrayList.Add(result);
                }
                conn.Close();
                dataGridView1.DataSource = arrayList;
                dataGridView1.Columns[0].HeaderCell.Value = "Код сотрудника";
                dataGridView1.Columns[1].HeaderCell.Value = "Начало смены";
                dataGridView1.Columns[2].HeaderCell.Value = "Конец смены";
                
            }
        }
    }
}
