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
    public partial class web22_inf : Form
    {
        public web22_inf()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            group group1 = new group();
            group1.Show();
            this.Close();

        }
    }
}
