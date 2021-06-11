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

namespace diploma_app
{
    public partial class autoriz : Form
    {
        public autoriz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = login_aut.Text;
            String passUser = password_aut.Text;

            DB dB = new DB();
           
            DataTable table = new DataTable();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
           
            MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE login = @usLogin AND parola = @usPassword", dB.getConnection());
            command.Parameters.Add("@usLogin", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@usPassword", MySqlDbType.VarChar).Value = passUser;
           
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count>0)
            {
                MessageBox.Show("Пользователь найден");
                teacher teacher_form = new teacher();
                teacher_form.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Польователь не найден. Попробуй еще раз");
            }

        }
    }
}
