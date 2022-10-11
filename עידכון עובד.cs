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

    public partial class Form8 : Form
    {
        private operationdirector operationdirector;
        private Designer Designer;
        private CustomerServiceClerck CustomerServiceClerck;
        private Customerservicedirector Customerservicedirector;

        public Form8()
        {
            InitializeComponent();
            // נטרול תיבות טקסט
            textBox10.Enabled = false;
            textBox9.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox6.Enabled = false;
            textBox1.Enabled = true;
        }

        private void button_UPDATE_Click(object sender, EventArgs e)
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
                if (operationdirector == null && Designer == null && CustomerServiceClerck == null && Customerservicedirector == null)
                {
                    string k = "לא קיים עובד כזה נסה שנית";
                    MessageBox.Show(k);
                }
                else
                {
                    if (Customerservicedirector != null)
                    {
                        Customerservicedirector s = Customerservicedirector;
                        textBox9.Text = s.getname();
                        textBox10.Text = s.getID().ToString();
                        textBox6.Text = s.getemail();
                        textBox7.Text = s.getexpirience().ToString();
                        textBox8.Text = s.getbirthdate().ToString();
                        textBox10.Enabled = false;
                        textBox9.Enabled = true;
                        textBox7.Enabled = true;
                        textBox8.Enabled = true;
                        textBox6.Enabled = true;
                        textBox1.Enabled = false;

                    }
                    if (operationdirector != null)
                    {

                        operationdirector s = operationdirector;
                        textBox9.Text = s.getname();
                        textBox10.Text = s.getID().ToString();
                        textBox6.Text = s.getemail();
                        textBox7.Text = s.getexpirience().ToString();
                        textBox8.Text = s.getbirthdate().ToString();
                        textBox10.Enabled = false;
                        textBox9.Enabled = true;
                        textBox7.Enabled = true;
                        textBox8.Enabled = true;
                        textBox6.Enabled = true;
                        textBox1.Enabled = false;

                    }
                    if (Designer != null)
                    {

                        Designer s = Designer;
                        textBox9.Text = s.getname();
                        textBox10.Text = s.getID().ToString();
                        textBox6.Text = s.getemail();
                        textBox7.Text = s.getexpirience().ToString();
                        textBox8.Text = s.getbirthdate().ToString();
                        textBox10.Enabled = false;
                        textBox9.Enabled = true;
                        textBox7.Enabled = true;
                        textBox8.Enabled = true;
                        textBox6.Enabled = true;
                        textBox1.Enabled = false;

                    }
                    if (CustomerServiceClerck != null)
                    {

                        CustomerServiceClerck s = CustomerServiceClerck;
                        textBox9.Text = s.getname();
                        textBox10.Text = s.getID().ToString();
                        textBox6.Text = s.getemail();
                        textBox7.Text = s.getexpirience().ToString();
                        textBox8.Text = s.getbirthdate().ToString();
                        textBox10.Enabled = false;
                        textBox9.Enabled = true;
                        textBox7.Enabled = true;
                        textBox8.Enabled = true;
                        textBox6.Enabled = true;
                        textBox1.Enabled = false;
                    }
                }
            }
            else
            {
                string k = "ערך לא תקין- נסה שנית";
                MessageBox.Show(k);
            }
        }


            private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Customerservicedirectorhave();
            operationdirectorhave();
            Designerhave();
            CustomerServiceClerckhave();
            textBox10.Enabled = false;
            textBox9.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox6.Enabled = false;
            textBox1.Enabled = true;



        }
       
         
        


public void operationdirectorhave()
{
    if (operationdirector != null)
    {
        operationdirector s = operationdirector;
                s.update_operationdirector(int.Parse(textBox10.Text), textBox9.Text, int.Parse(textBox7.Text), DateTime.Parse(textBox8.Text), textBox6.Text);

   

    }
   
}
public void Designerhave()
{
    if (Designer != null)
    {
        Designer s = Designer;
               
         s.update_Designer(int.Parse(textBox10.Text), textBox9.Text, int.Parse(textBox7.Text), DateTime.Parse(textBox8.Text), textBox6.Text);
            


    }
   
}
public void CustomerServiceClerckhave()
{
    if (CustomerServiceClerck != null)
    {
        CustomerServiceClerck s = CustomerServiceClerck;
                s.update_CustomerServiceClerck(int.Parse(textBox10.Text), textBox9.Text, int.Parse(textBox7.Text), DateTime.Parse(textBox8.Text), textBox6.Text);

           


    }
    
}
public void  Customerservicedirectorhave()
{
    if (Customerservicedirector != null)
    {
        Customerservicedirector s = Customerservicedirector;
                s.update_Customerservicedirector(int.Parse(textBox10.Text), textBox9.Text, int.Parse(textBox7.Text), DateTime.Parse(textBox8.Text), textBox6.Text);

                


    }
  
}

        private void Form8_Load(object sender, EventArgs e)
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
