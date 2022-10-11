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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox5.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {



            operationdirector d = new operationdirector(int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox5.Text), DateTime.Parse(textBox3.Text), textBox4.Text, Program.Suppliers, Program.Complaintfroms, true); // יצירת מעצבת חדשה
            string m = "  מנהל חדש נכנס למערכת";
            MessageBox.Show(m);
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox5.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;

            // this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                string m = "  הזן ערך";
                MessageBox.Show(m);
            }
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
