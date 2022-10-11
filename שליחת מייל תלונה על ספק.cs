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
    

    
    public partial class Form1 : Form
    {
        private Complaintfroms Complaintfroms1;
        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
            textBox2.Enabled = true;
            textBox1.Enabled = false;
            textBox4.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

      

    private void button_serviceC_Click(object sender, EventArgs e)
        {
            if (good(textBox2.Text))
            {
                //איתור המופע המתאים והצגת הפרטים
                Complaintfroms1 = Program.seeComplaintfroms(int.Parse(textBox2.Text));
                if (Complaintfroms1 != null)
                {
                    Supplier s = Program.seekSupplier(Complaintfroms1.getSupplierid());
                    textBox1.Text = s.getname();
                    textBox3.Text = s.getEmail();
                    textBox1.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = true;



                }
                else
                {
                    listView1.Items.Clear();
                    string t = " לא מצאנו עבור תלונה זו ספר";
                    var row = new string[] { t.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = Complaintfroms1;
                    listView1.Items.Add(lvi);
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                string m = "  אנא הזן ערך";
                MessageBox.Show(m);
            } 

            string mto = textBox3.Text;
            string mfor = "nununuoperationdirector@gmail.com";
            string subject = " nununu הנדון: בירור תלונה מחברת ";
            string fromName = "   nununu מנהל תפעול חברת ";
            string pass = "nununu123";

            sendMail(mto, mfor, fromName, subject, textBox4.Text, pass);
            this.Hide();
        }
        public static void sendMail(string toEmail, string fromEm, string fromName, string subject, string body, string pass)
        {

            MailAddress fromAddress = new MailAddress(fromEm, fromName);
            string fromPassword = pass;
            MailAddress toAddress = new MailAddress(toEmail);

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (MailMessage message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
                IsBodyHtml = true,


            })
            {
                smtp.Send(message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

              var Complaintfroms1 = Program.Complaintfroms;
              listView1.Items.Clear();
               foreach (Complaintfroms s in Complaintfroms1)
               {
                  var row = new string[] { s.getinquirysummary().ToString(), s.getstatus().ToString(), s.getdescription().ToString(), s.getDesignerid().ToString(), s.getSupplierid().ToString(),s.getnumofcimplaint().ToString() };
                  var lvi = new ListViewItem(row);
                  lvi.Tag = s;
                 listView1.Items.Add(lvi);
               }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form19 f1 = new Form19();
            f1.Show();
            this.Hide();
        }
    }
}
