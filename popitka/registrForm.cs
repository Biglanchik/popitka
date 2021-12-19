using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace popitka
{
    public partial class registrForm : Form
    {
        public registrForm()
        {
            InitializeComponent();

            UserNameFild.Text = "Введите Имя";
            UserSernameFild.Text = "Введите Фамилию";
            log.Text = "Введите логин";
            pass.Text = "Введите пароль";

        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void UserNameFild_Enter(object sender, EventArgs e)
        {
            if (UserNameFild.Text == "Введите Имя")
                UserNameFild.Text = "";
            UserNameFild.ForeColor = Color.Black;
        }

        private void UserNameFild_Leave(object sender, EventArgs e)
        {
            if (UserNameFild.Text == "")
            {
                UserNameFild.Text = "Введите Имя";
                UserNameFild.ForeColor = Color.Gray;
            }
        }

        private void UserSernameFild_Enter(object sender, EventArgs e)
        {
            if (UserSernameFild.Text == "Введите Фамилию")
            {
                UserSernameFild.Text = "";
                UserSernameFild.ForeColor = Color.Black;
            }

        }

        private void UserSernameFild_Leave(object sender, EventArgs e)
        {
            if (UserSernameFild.Text == "")
            {
                UserSernameFild.Text = "Введите Фамилию";
                UserSernameFild.ForeColor = Color.Gray;
            }
        }

        private void log_Enter(object sender, EventArgs e)
        {
            if (log.Text == "Введите логин")
            {
                log.Text = "";
                log.ForeColor = Color.Black;
            }
        }

        private void log_Leave(object sender, EventArgs e)
        {
            if (log.Text == "")
            {
                log.Text = "Введите логин";
                log.ForeColor = Color.Gray;
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Введите пароль")
            {
                pass.Text = "";
                pass.ForeColor = Color.Black;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Введите пароль";
                pass.ForeColor = Color.Gray;
            }
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            if (UserNameFild.Text == "Введите Имя")
            {
                MessageBox.Show("Введите Имя!");
                return;
            }

            if (UserSernameFild.Text == "Введите Фамилию")
            {
                MessageBox.Show("Введите Фамилию!");
                return;
            }

            if (log.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин!");
                return;
            }

            if (pass.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            if (isUserExist())
                return;

            Db db = new Db();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `pass`, `name`, `sername`) VALUES (@login, @pass, @name, @sername)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = log.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserNameFild.Text;
            command.Parameters.Add("@sername", MySqlDbType.VarChar).Value = UserSernameFild.Text;

            db.openConnection();

            
            if (command.ExecuteNonQuery()==1)
                {
                  MessageBox.Show("Аккаунт был создан");
                }
          
             else
            {
                MessageBox.Show("Аккаунт не был создан");
            }

            db.closeConnection(); 
        }

        public Boolean isUserExist()
        {
            Db db = new Db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = log.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Другой логин");
                return true;
            }

            else
                return false;
        }

        private void RegistLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            login loginForms = new login();
            loginForms.Show();
        }
    }
}
