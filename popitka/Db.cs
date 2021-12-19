using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace popitka
{
    class Db
    {
        MySqlConnection connection = new MySqlConnection("server= localhost; port=3306; username=root; password= root; database=laba");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
        //public bool Registration(string login, string password, string name, string sername)
        //{
        //    bool flag = false;
        //    MySqlCommand command = new MySqlCommand("INSERT INTO `users` ( `login`, `pass`, `name`, `sername`) VALUES (@login, @pass, @name, @sername)", connection);

        //    command.Parameters.AddWithValue("@login", login);
        //    command.Parameters.AddWithValue("@pass", password);
        //    command.Parameters.AddWithValue("@name", name);
        //    command.Parameters.AddWithValue("@sername", sername);

        //    if (command.ExecuteNonQuery()== 1)
        //    {
        //        flag = true;
        //    }
        //    return flag;
        //}

    }
}
