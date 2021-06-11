using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace diploma_app
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB dB = new DB();

            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO users (firstname, lastname, email, login, parola) VALUES (@nume, @prenume, @mail, @log, @pass)", dB.getConnection());
            mySqlCommand.Parameters.Add("@nume", MySqlDbType.VarChar).Value = name.Text;
            mySqlCommand.Parameters.Add("@prenume", MySqlDbType.VarChar).Value = lastname.Text;
            mySqlCommand.Parameters.Add("@mail", MySqlDbType.VarChar).Value = mail.Text;
            mySqlCommand.Parameters.Add("@log", MySqlDbType.VarChar).Value = login.Text;
            mySqlCommand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passw.Text;
            dB.openConnection();

            if (String.Equals(passw.Text, textBox1.Text))
            {
                MessageBox.Show("Пароль совпадает. Молодец");
            }   
            else
            {
                MessageBox.Show("Проверь правильность пароля и попрубуй еще раз");
            }

            if (mySqlCommand.ExecuteNonQuery() == 1)
                MessageBox.Show("Succesful");
            else
                MessageBox.Show("Try again");



            dB.closeConnection();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
