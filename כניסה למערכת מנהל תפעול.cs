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
    public partial class Form27 : Form
    {
       private operationdirector operationdirector;
        public Form27()
        {
            InitializeComponent();
            textBox3.Enabled = true;
          
          
        }
        public String getoperationdirectorMaill()
        {
            return operationdirector.getemail(); 
        }

         private void Form27_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
        private bool goodtextid(string text)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                string m = "  אנא הזן ערך";
                MessageBox.Show(m);
                return false;
            }


            for ( int i=0; i< textBox3.Text.Length; i++)
                {
                    if ('0'>=textBox3.Text[i] &&  textBox3.Text[i]>= '9')
                    {
                        return false;
                    }
                }
              
           
            return true;

        }
    
    private void button_serviceC_Click(object sender, EventArgs e)
        {
            if (goodtextid(textBox3.Text) == true)
            {


                //איתור המופע המתאים וכניסה
                operationdirector = Program.seekoperationdirector(int.Parse(textBox3.Text));
                if (operationdirector != null)
                {
                    if (Program.operationdirectorMaill(operationdirector) != null)
                    {
                        Form19 f19 = new Form19();
                        f19.Show();
                      
                        textBox3.Enabled = false;
                     
                       this.Hide();
                    }
                    else
                    {
                        string k = " אימייל לא נכון - נסה שנית";
                        MessageBox.Show(k);

                    }
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
                string m = " קלט לא תקין - להכניס רק מספרים בתעודת הזהות";
                MessageBox.Show(m);
            }
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
