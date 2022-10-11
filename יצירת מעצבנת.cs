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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox8.Enabled = true;
            textBox6.Enabled = true;
            textBox4.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            
                
               

                Designer d = new Designer(int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox8.Text), DateTime.Parse(textBox6.Text), textBox4.Text,Program.Suppliers,Program.Complaintfroms,true); // יצירת מעצבת חדשה
                 //string m = " מעצבת חדשה נכנסה למערכת";
         //   MessageBox.Show(m);
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox8.Enabled = true;
            textBox6.Enabled = true;
            textBox4.Enabled = true;
         


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

  

      
     
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
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
