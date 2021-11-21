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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Введите логин";
            textBox1.ForeColor = Color.Gray;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String login = textBox1.Text;
            String pass = textBox2.Text;
            if (textBox1.Text == "admin" && textBox2.Text == "admin123")
            {
                MessageBox.Show("Вы вошли от лица администратора.");
                ActiveForm.Hide();
                Admin admin = new Admin();
                admin.Show();
            }
            else
            {
                MySqlConnection conn = DataBase.GetDBConnection();
                conn.Open();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `Employees` WHERE `LOGIN` = @UserLogin AND `PASSWORD` = @UserPassword", conn);
                command.Parameters.Add("@UserLogin", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@UserPassword", MySqlDbType.VarChar).Value = pass;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Подтверждение личности выполнено успешно");
                    ActiveForm.Hide();
                    Profile profile = new Profile();
                    profile.Show();
                }


                else
                    MessageBox.Show("Ошибка авторизации");
                conn.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите логин")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите логин";
                textBox1.ForeColor = Color.Gray;
            }
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
