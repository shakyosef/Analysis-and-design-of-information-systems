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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form24 f24 = new Form24();
            f24.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_employee fn = new Form_employee();
            fn.Show();
            this.Hide();
        }
    }
}
