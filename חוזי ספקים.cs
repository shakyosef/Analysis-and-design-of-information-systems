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
    public partial class Form20 : Form
    {
       

        public Form20()
        {
            
          
            InitializeComponent();
        }
      
 
        private void button2_Click(object sender, EventArgs e)
        {
            Form21 f21 = new Form21();
            f21.Show();
            this.Hide();
           
         //צפייה בכל החוזים
        }

        private void button_serviceC_Click(object sender, EventArgs e)
        {
            Form22 f22 = new Form22();
            f22.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form23 f23 = new Form23();
            f23.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form19 mf = new Form19();
              mf.Show();
            this.Hide();
           
        }
    }
}
