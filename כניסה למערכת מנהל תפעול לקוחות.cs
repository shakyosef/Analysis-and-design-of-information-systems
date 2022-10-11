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
    public partial class Form28 : Form
    {
        private Customerservicedirector Customerservicedirector;
        public Form28()
        {
            InitializeComponent();
            textBox3.Enabled = true;
            
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

         
         

    private void button_serviceC_Click(object sender, EventArgs e)
        {


            if (good(textBox3.Text))
            {
                //איתור המופע המתאים וכניסה
                Customerservicedirector = Program.seekCustomerservicedirector(int.Parse(textBox3.Text));
                if (Customerservicedirector != null)
                {

                    Form16 f16 = new Form16();
                    f16.Show();
                    textBox3.Enabled = false;

                    this.Hide();
                }


                else
                {
                    string m = " המשתמש לא זוהה במערכת";
                    MessageBox.Show(m);
                    textBox3.Enabled = true;


                }


            }
            else
            {
                string k = "ערך לא תקין- נסה שנית";
                MessageBox.Show(k);
            }
        }

            private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 mf = new Form2();
            mf.Show();
            textBox3.Enabled = false;
          
            this.Hide();
        }
    }
}
