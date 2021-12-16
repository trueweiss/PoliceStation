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
    public partial class AllStatements : Form
    {
        public AllStatements()
        {
            InitializeComponent();
        }

        private void AllStatements_Load(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            MySqlConnection conn = DataBase.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Statement` ", conn);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                foreach (DbDataRecord result in reader)
                {
                    arrayList.Add(result);
                }
            }
            conn.Close();
            dataGridView1.DataSource = arrayList;
            dataGridView1.Columns[0].HeaderCell.Value = "Номер заявления";
            dataGridView1.Columns[1].HeaderCell.Value = "ФИО заявителя";
            dataGridView1.Columns[2].HeaderCell.Value = "Место работы";
            dataGridView1.Columns[3].HeaderCell.Value = "Телефон";
            dataGridView1.Columns[4].HeaderCell.Value = "Место регистрации";
            dataGridView1.Columns[5].HeaderCell.Value = "ФИО обвиняемого";
            dataGridView1.Columns[6].HeaderCell.Value = "Статья";
            dataGridView1.Columns[7].HeaderCell.Value = "Проверил(а)";
            dataGridView1.Columns[8].HeaderCell.Value = "Статус";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Profile profile = new Profile();
            profile.Show();
        }
    }
}
