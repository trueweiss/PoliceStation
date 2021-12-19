using MySql.Data.MySqlClient;
using SqlConn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoliceStation
{
    public partial class Simulation : Form
    {
        public Simulation()
        {
            InitializeComponent();
        }




            private bool working = false;
            private int countUser = 0;


            public void SimpleGenerateUser()
            {
                string login, password, name, rank, post;

                string[] Arrlogin = { "Policeman1", "Policeman2", "Policeman3", "Policeman4" };
                string[] Arrpassword = { "Abc1", "Abc2", "Abc3", "Abc4" };
                string[]  fullname = { "Васильев Григорий Викторович", "Жмышенко Петр Павлович", "Лобузенко Тигран Юрьевич", "Догонялов Пузан Стробоскопович" };
                string[] ranks = { "Звание1", "Звание2", "Звание3", "Звание4" };
                string[] posts = { "Должность1", "Должность2", "Должность3", "Должность4" };

            Random random = new Random();

                while (working)
                {

                    login = Arrlogin[random.Next(0, Arrlogin.Length - 1)];
                    password = Arrpassword[random.Next(0, Arrpassword.Length - 1)];
                    name = fullname[random.Next(0, fullname.Length - 1)];
                    rank = ranks[random.Next(0, ranks.Length - 1)];
                post = posts[random.Next(0, posts.Length - 1)];


                countUser++;


                     label1.Invoke(new Action(() => label1.Text = countUser.ToString()));

                reguser(name, rank, post, login, password);
                Thread.Sleep(1000);

                }

          

            }




            private void Start()
            {
                working = true;
                Task.Run(() => SimpleGenerateUser());
            }

            private void Stop()
            {
                working = false;
            }



        private void reguser(string fullname, string rank, string post, string login, string pass)
        {
            MySqlConnection conn = DataBase.GetDBConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Employees` (`FULL_NAME`, `RANK`, `POST`, `LOGIN`, `PASSWORD`) VALUES (@fullname, @rank, @post, @login, @pass)", conn);
            command.Parameters.Add("@fullname", MySqlDbType.Text).Value = fullname;
            command.Parameters.Add("@rank", MySqlDbType.VarChar).Value = rank;
            command.Parameters.Add("@post", MySqlDbType.VarChar).Value = post;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;

            conn.Open();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан");
            }
            else
            {
                MessageBox.Show("Ошибка при создании аккаунта");
            }
            conn.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
        Start();
    }

        private void button2_Click(object sender, EventArgs e)
        {
        Stop();
    }

        private void Simulation_Load(object sender, EventArgs e)
        {

        }
    }
}
