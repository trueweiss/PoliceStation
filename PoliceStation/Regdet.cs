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
    public partial class Regdet : Form
    {
        public Regdet()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DataBase.GetDBConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Regdet` (`FN_EMP`, `RANK`, `POST`, `FN_APP`, `WORK`, `PLACE`, `REASON`) VALUES (@fnemp, @rank, @post, @fnapp, @work, @place, @reason)", conn);
            command.Parameters.Add("@fnemp", MySqlDbType.Text).Value = textBox1.Text;
            command.Parameters.Add("@rank", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@post", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@fnapp", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@work", MySqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@place", MySqlDbType.VarChar).Value = textBox6.Text;
            command.Parameters.Add("@reason", MySqlDbType.VarChar).Value = textBox7.Text;

            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Задержание успешно зарегистрировано");
            }
            else
            {
                MessageBox.Show("Ошибка при регистрации");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Profile profile = new Profile();
            profile.Show();
        }
    }
}
