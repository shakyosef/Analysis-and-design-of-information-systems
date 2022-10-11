using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ourproject
{
    public partial class Form25 : Form
    {
        private compensationcomplaint compensationcomplaint1;
        public Form25()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(status));
            textBox1.Enabled = true;
            textBox10.Enabled = false;
            textBox9.Enabled = false;
            textBox7.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            button1.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public bool good(string s)
        {


            if (String.IsNullOrEmpty(s))
            {

                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (!(s[i] >= '0' && s[i] <= '9'))
                    return false;

            }
            return true;
        }

       
    private void button_create_Click(object sender, EventArgs e)
        {
            if (good(textBox1.Text))
            {


                //איתור המופע המתאים והצגת הפרטים
                compensationcomplaint1 = Program.seecompensationcomplaint(int.Parse(textBox1.Text));
                if (compensationcomplaint1 != null)
                {
                    customer s = compensationcomplaint1.getcustomer();
                    textBox9.Text = s.getname();
                    textBox7.Text = s.getEmail();
                    textBox10.Text = compensationcomplaint1.getcomplaintNum().ToString();
                    textBox9.Enabled = false;
                    textBox7.Enabled = false;
                    textBox10.Enabled = false;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    button1.Show();


                }
                else
                {
                    string k = "לא קיימת תלונה כזו - נסה שנית";
                    MessageBox.Show(k);

                }
            }
            else
            {
                string k = "ערך לא תקין- נסה שנית";
                MessageBox.Show(k);
            }

            }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer s = compensationcomplaint1.getcustomer();
            Customerservicedirector cd = compensationcomplaint1.getCustomerservicedirector();
            discount d = new discount(textBox2.Text, double.Parse(textBox3.Text), cd, s, true);
          
            compensationcomplaint1.setstatusDirector((status)Enum.Parse(typeof(status), comboBox1.Text));


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 mf = new Form17();
            mf.Show();
            this.Hide();
        }
    }
}
