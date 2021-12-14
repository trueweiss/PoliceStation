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
    public partial class Employs : Form
    {
        public Employs()
        {
            InitializeComponent();
        }

        private void Employs_Load(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            MySqlConnection conn = DataBase.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT `ID`, `FULL_NAME`, `RANK`, `POST` FROM `Employees` ", conn);
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
            dataGridView1.Columns[0].HeaderCell.Value = "Код сотрудника";
            dataGridView1.Columns[1].HeaderCell.Value = "ФИО";
            dataGridView1.Columns[2].HeaderCell.Value = "Звание";
            dataGridView1.Columns[3].HeaderCell.Value = "Должность";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
