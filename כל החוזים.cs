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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();

        }

     

        private void button_create_Click(object sender, EventArgs e)
        {

        }

       private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form20 mf = new Form20();
            mf.Show();
            this.Hide();
            this.Close();
        }

        private void from21load(object sender, EventArgs e)
        {
            var Suppliers1= Program.Suppliers;
            listView1.Items.Clear();
            foreach (Supplier s in Suppliers1)
             {
                var row = new string[] { s.getcontractenddate().ToString(), s.getEmail(), s.getJoinDate().ToString(), s.getid().ToString(), s.getname() };
                var lvi = new ListViewItem(row);
                lvi.Tag = s;
                listView1.Items.Add(lvi);
            }

        }
    }
}
