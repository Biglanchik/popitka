using MySql.Data.MySqlClient;
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

namespace popitka
{
    public partial class Simulac : Form
    {
        public Simulac()
        {
            InitializeComponent();
        }

        private bool working = false;
        private int countUser = 0;

        //Исполнители
        public void Simulacia()
        {
            string name;

            string[] Aname = { "Andrey", "Ivan", "Ashot", "Anton" };


            Random random = new Random();

            while (working)
            {
                name = Aname[random.Next(0, Aname.Length - 1)] + random.Next(0, 999);

                Db db = new Db();
                MySqlCommand command = new MySqlCommand("INSERT INTO `ispolnitel` ( `name`) VALUES ( @name)", db.getConnection());

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;


                db.openConnection();


                if (command.ExecuteNonQuery() == 1)
                {

                }

                else
                {

                }

                db.closeConnection();

                countUser++;

                label1.Invoke(new Action(() => label1.Text = countUser.ToString()));

                Thread.Sleep(1000);
            }
            
        }

        //Кнопка 1
        private void Start()
        {
            working = true;
            Task.Run(() => Simulacia());
        }

        private void Stop()
        {
            working = false;
        }


        private void Start1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Stop1_Click(object sender, EventArgs e)
        {
            Stop();
        }



        private void closeButt_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // //Кнопка 2
        //private void Start2_Click(object sender, EventArgs e)
        //{
        //    Start();
        //}

        //private void Stop2_Click(object sender, EventArgs e)
        //{
        //    Stop();
        //}
    }
}
