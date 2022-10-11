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
    public partial class Form19 : Form
    {
      
        public Form19()
        {
            InitializeComponent();
             
        }

        private void button_serviceC_Click(object sender, EventArgs e)
        {
           
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 f20 = new Form20();
            f20.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 mf = new Form2();
            mf.Show();
            this.Hide();
            this.Close();
        }
    }
}
