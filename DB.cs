using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace diploma_app
{
    public class DB
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; user = root; password = meduza227; database = xenia");

        public void openConnection()
        {
            try
            {

                conn.Open();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void closeConnection()
        {
            try
            {

                conn.Close();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public MySqlConnection getConnection()
        {


            return conn;
        }
    }
}
