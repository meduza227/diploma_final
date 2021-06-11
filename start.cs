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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registration form2 = new registration();
            form2.Show();
         

        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoriz form3 = new autoriz();
            form3.Show();
       
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello, world");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
