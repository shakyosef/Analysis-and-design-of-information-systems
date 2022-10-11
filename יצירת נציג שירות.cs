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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox8.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
            textBox3.Enabled = true;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Customerservicedirector m = Program.seekCustomerservicedirector(int.Parse(textBox8.Text));
            if (m != null)
            {
                CustomerServiceClerck d = new CustomerServiceClerck(int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox5.Text), DateTime.Parse(textBox3.Text), textBox4.Text, m, Program.rates, Program.Complaints, true); // יצירת מעצבת חדשה
                string k = "העובד נכנס למערכת ";
                MessageBox.Show(k);
            }
            else
            { 
            string k = "לא קיים מנהל כזה במערכת אנה נסה שנית ";
            MessageBox.Show(k);
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
