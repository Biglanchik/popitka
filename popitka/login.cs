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
    public partial class login : Form
    {
        sqlfunction sql = new sqlfunction();
        public login()
        {
            InitializeComponent();

            this.pass.AutoSize = false;
            this.pass.Size = new Size(this.pass.Size.Width, 64);
        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButt_MouseEnter(object sender, EventArgs e)
        {
            closeButt.ForeColor = Color.Green;
        }

        private void closeButt_MouseLeave(object sender, EventArgs e)
        {
            closeButt.ForeColor = Color.Black;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = log.Text;
            String passUser = pass.Text;

            Db db = new Db();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass`=@uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                mainForm mainForm = new mainForm();
                mainForm.Show();
            }

            else
                MessageBox.Show("No");
        }

        private void RegistLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrForm registrForm = new registrForm();
            registrForm.Show();
        }



        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            String loginUser = log.Text;
            String passUser = pass.Text; 
            if (loginUser == "admin" && passUser == "admin")
            {
                this.Hide();
                formAdmin adminForm = new formAdmin();
                adminForm.Show();
            }
            else
            {
                buttonLogin_Click(sender, e);

                //if (sql.loginuser(loginUser, passUser))
                //{

                //    this.Hide();
                //    formAdmin form = new formAdmin();
                //    formAdmin.show();
                //}

                //else
                //    MessageBox.Show("Ошибка авторизации");


            }


        }
    }

    internal class sqlfunction
    {
        internal bool loginuser(string loginUser, string passUser)
        {
            throw new NotImplementedException();
        }
    }
}
