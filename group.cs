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
    public partial class group : Form
    {
        public group()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         
            int i = comboBox1.SelectedIndex;
            int j = comboBox2.SelectedIndex;
            switch( i)
            {
                case 0:

                    {
                        switch (j)
                        {
                            case 0:
                                {
                                    
                                    
                                    web22_fiz web22_form1 = new web22_fiz();
                                    web22_form1.Show();
                                    this.Close();
                                    break;
                                }
                            case 1:
                                {
                                    
                                   
                                    web22_inf web22_form2 = new web22_inf();
                                    web22_form2.Show();
                                    this.Close();
                                    break;
                                }
                        }
                        break;
                        
                    }
                   
                case 1:
                    {
                        switch (j)
                        {
                            case 0:
                                {
                                    
                                    
                                    web32_fiz web32_form1 = new web32_fiz();
                                    web32_form1.Show();
                                    this.Close();
                                    break;
                                }
                            case 1:
                                {
                                    
                                   
                                    web32_inf web32_form2 = new web32_inf();
                                    web32_form2.Show();
                                    this.Close();
                                    break;
                                }
                        }
                        break;
                    }

                   

            }
          
        }

      
    }
}
