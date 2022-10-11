using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ourproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



    
        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void button_EMPLOYEE_Click(object sender, EventArgs e)
        {
            Form_employee fme = new Form_employee();
            fme.Show();
       
            this.Hide();
        }

      

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_product_Click(object sender, EventArgs e)
        {
         
        }

        private void button_opertion_Click(object sender, EventArgs e)
        {
            Form27 f27 = new Form27();
            f27.Show();
            this.Hide();
          
        }

        private void button_serviceC_Click(object sender, EventArgs e)
        {
            Form28 f28 = new Form28();
            f28.Show();
            this.Hide();
        
        }

        private void button_desagin_Click(object sender, EventArgs e)
        {

        }

        private void button_FAINNCE_Click(object sender, EventArgs e)
        {

        }

        private void button_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

   