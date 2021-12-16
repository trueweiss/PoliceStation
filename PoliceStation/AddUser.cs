using MySql.Data.MySqlClient;
using SqlConn;
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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DataBase.GetDBConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Employees` (`FULL_NAME`, `RANK`, `POST`, `LOGIN`, `PASSWORD`) VALUES (@fullname, @rank, @post, @login, @pass)", conn);
            command.Parameters.Add("@fullname", MySqlDbType.Text).Value =  textBox1.Text;
            command.Parameters.Add("@rank", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@post", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox5.Text;

            conn.Open();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан");
            }
            else
            {
                MessageBox.Show("Ошибка при создании аккаунта");
            }
            conn.Close();

        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Admin adm = new Admin();
            adm.Show();
        }
    }
}
