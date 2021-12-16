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
    public partial class Statement : Form
    {
        public Statement()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Statement_Load(object sender, EventArgs e)
        {

        }

        private void AllStatement_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DataBase.GetDBConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Statement` (`NAME_APPLICANT`, `JOB`, `PHONE`, `REGISTERED`, `NAME_ACCUSED`, `ARTICLE`, `CHECKED`, `STATUS`) VALUES (@nameapp, @job, @phone, @reg, @nameacc, @article, @checked, @status)", conn);
            command.Parameters.Add("@nameapp", MySqlDbType.Text).Value = textBox1.Text;
            command.Parameters.Add("@job", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@reg", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@nameacc", MySqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@article", MySqlDbType.VarChar).Value = textBox7.Text;
            command.Parameters.Add("@checked", MySqlDbType.VarChar).Value = textBox8.Text;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = comboBox1.SelectedItem;

            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заявление отправлено");
            }
            else
            {
                MessageBox.Show("Ошибка при отправке, проверьте правильность введенных данных");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Profile profile = new Profile();
            profile.Show();
        }
    }
}
