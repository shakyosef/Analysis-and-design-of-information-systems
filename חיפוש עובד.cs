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
    public partial class Form7 : Form
    {
        private operationdirector operationdirector;
        private Designer Designer;
        private CustomerServiceClerck CustomerServiceClerck;
        private Customerservicedirector Customerservicedirector; 

        public Form7()
        {
            InitializeComponent();
            textBox1.Enabled = true;
            textBox10.Enabled = false;
            textBox9.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox6.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public bool good(string s)
        {
       

                if (String.IsNullOrEmpty(s)) {
          
                return false;
            }
             
            for (int i=0; i<s.Length; i++)
            {
                if (!(s[i] >= '0' && s[i] <= '9'))
                    return false;
            
            }
            return true;
        }

        private void button_create_Click(object sender, EventArgs e)
        {
           if (textBox1 == null)
            {
                string k = "חייב להכניס מספר עובד";
                MessageBox.Show(k);

            }
            else
            {
            
                if (good(textBox1.Text))
                {
                    //איתור המופע המתאים והצגת הפרטים
                    operationdirector = Program.seekoperationdirector(int.Parse(textBox1.Text));
                    Designer = Program.seekdesignerg(int.Parse(textBox1.Text));
                    CustomerServiceClerck = Program.seekCustomerServiceClerck(int.Parse(textBox1.Text));
                    Customerservicedirector = Program.seekCustomerservicedirector(int.Parse(textBox1.Text));

                    if ((!Customerservicedirectorhave()) && (!operationdirectorhave()) && (!Designerhave()) && (!CustomerServiceClerckhave()))
                    {

                        string k = "לא נמצא עובד זה - נסה שנית";
                        MessageBox.Show(k);

                    }
                }

                else
                {
                    string k = "ערך לא תקין- נסה שנית";
                    MessageBox.Show(k);
                }
            }
          
        }
        public bool operationdirectorhave()
        {
            if (operationdirector != null)
            {
                operationdirector s = operationdirector;
                textBox10.Text = s.getID().ToString() ;
                textBox9.Text = s.getname();
                textBox7.Text = s.getexpirience().ToString();
                textBox8.Text = s.getbirthdate().ToString();
                textBox6.Text = s.getemail().ToString();
                textBox9.Enabled = false;
                textBox7.Enabled = false;
                textBox10.Enabled = false;
                textBox1.Enabled = false;
                textBox8.Enabled = false;
                textBox6.Enabled = false;
                return true; 


            }
            return false; 
        }
        public bool Designerhave()
        {
            if (Designer != null)
            {
                Designer s = Designer;
                textBox10.Text = s.getID().ToString();
                textBox9.Text = s.getname();
                textBox7.Text = s.getexpirience().ToString();
                textBox8.Text = s.getbirthdate().ToString();
                textBox6.Text = s.getemail().ToString();
                textBox9.Enabled = false;
                textBox7.Enabled = false;
                textBox10.Enabled = false;
                textBox1.Enabled = false;
                textBox8.Enabled = false;
                textBox6.Enabled = false;
                return true;


            }
            return false;
        }
        public bool CustomerServiceClerckhave()
            {
                if (CustomerServiceClerck != null)
                {
                    CustomerServiceClerck s = CustomerServiceClerck;
                    textBox10.Text = s.getID().ToString();
                    textBox9.Text = s.getname();
                    textBox7.Text = s.getexpirience().ToString();
                    textBox8.Text = s.getbirthdate().ToString();
                    textBox6.Text = s.getemail().ToString();
                    textBox9.Enabled = false;
                    textBox7.Enabled = false;
                    textBox10.Enabled = false;
                    textBox1.Enabled = false;
                    textBox8.Enabled = false;
                    textBox6.Enabled = false;
                    return true;


                }
           
            return false;
        }
        public bool Customerservicedirectorhave()
        {
            if (Customerservicedirector != null)
            {
                Customerservicedirector s = Customerservicedirector;
                textBox10.Text = s.getID().ToString();
                textBox9.Text = s.getname();
                textBox7.Text = s.getexpirience().ToString();
                textBox8.Text = s.getbirthdate().ToString();
                textBox6.Text = s.getemail().ToString();
                textBox9.Enabled = false;
                textBox7.Enabled = false;
                textBox10.Enabled = false;
                textBox1.Enabled = false;
                textBox8.Enabled = false;
                textBox6.Enabled = false;
                return true;


            }
            return false;
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox9.Enabled = false;
            textBox7.Enabled = false;
            textBox10.Enabled = false;
            textBox1.Enabled = true;
            textBox8.Enabled = false;
            textBox6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_employee fme = new Form_employee();
            fme.Show();
            this.Hide();
        }
    }
}
