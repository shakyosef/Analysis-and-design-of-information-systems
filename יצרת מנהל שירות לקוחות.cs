using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace ourproject
{
    public partial class Form24 : Form
    {
        private Complaintfroms Complaintfroms1;
      

        public Form24()
        {
            InitializeComponent();
          
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form24_Load(object sender, EventArgs e)
        {
          //  var Complaintfroms1 = Program.Complaintfroms;
         //   listView1.Items.Clear();
         //   foreach (Complaintfroms s in Complaintfroms1)
         //   {
          //      var row = new string[] { s.getinquirysummary().ToString(), s.getstatus().ToString(), s.getdescription().ToString(), s.getDesignerid().ToString(), s.getSupplierid().ToString(),s.getnumofcimplaint().ToString() };
          //      var lvi = new ListViewItem(row);
          //      lvi.Tag = s;
          //      listView1.Items.Add(lvi);
        //    }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Customerservicedirector d = new Customerservicedirector(int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox3.Text), DateTime.Parse(textBox4.Text), textBox5.Text, Program.CustomerServiceClercks, Program.discounts, Program.compensationcomplaints, true); // יצירת מעצבת חדשה
            string m = " מעצבת חדשה נכנסה למערכת";
            MessageBox.Show(m);
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            textBox5.Enabled = true;
            textBox4.Enabled = true;
        }
    }
    
    }

