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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            MySqlConnection conn = DataBase.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Employees` " , conn);
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            AddUser adduser = new AddUser();
            adduser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Simulation sim = new Simulation();
            sim.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            ArrayList arrayList = new ArrayList();
            MySqlConnection conn = DataBase.GetDBConnection();
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `Employees` ", conn);
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
        }

        //private void AddUser_Click(object sender, EventArgs e)
        //{
        //    DataBase database = new DataBase();
        //    MySqlCommand command = new MySqlCommand("INSERT INTO `Employees` (`FULL_NAME`, `RANK`, `POST`, `LOGIN`, `PASSWORD`) VALUES ('@fullname', '@rank', '@post', '@login', '@pass');");
        //   command.Parameters.Add("@fullname", My)
        //}
    }
}
