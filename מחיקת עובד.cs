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
    public partial class Form9 : Form
    {
        private operationdirector operationdirector;
        private Designer Designer;
        private CustomerServiceClerck CustomerServiceClerck;
        private Customerservicedirector Customerservicedirector;
        public Form9()
        {
            InitializeComponent();
            textBox1.Enabled = true;
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


                operationdirector = Program.seekoperationdirector(int.Parse(textBox1.Text));
                Designer = Program.seekdesignerg(int.Parse(textBox1.Text));
                CustomerServiceClerck = Program.seekCustomerServiceClerck(int.Parse(textBox1.Text));
                Customerservicedirector = Program.seekCustomerservicedirector(int.Parse(textBox1.Text));
                if (Customerservicedirector == null && CustomerServiceClerck == null && Designer == null && operationdirector == null)
                {
                    string k = "לא קיים עובד כזה נסה שנית";
                    MessageBox.Show(k);

                }
                if (Customerservicedirector != null)
                {
                    Customerservicedirector.Delete_Customerservicedirector();
                    string k = "העובד נמחק בהצלחה";
                    MessageBox.Show(k);

                }
                if (operationdirector != null)
                {

                    operationdirector.Delete_operationdirector();
                    string k = "העובד נמחק בהצלחה";
                    MessageBox.Show(k);

                }
                if (Designer != null)
                {

                    Designer.Delete_Designer();
                    string k = "העובד נמחק בהצלחה";
                    MessageBox.Show(k);

                }
                if (CustomerServiceClerck != null)
                {

                    CustomerServiceClerck.Delete_CustomerServiceClerck();
                    string k = "העובד נמחק בהצלחה";
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

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_employee fme = new Form_employee();
            fme.Show();
            this.Hide();
        }
    }
}
