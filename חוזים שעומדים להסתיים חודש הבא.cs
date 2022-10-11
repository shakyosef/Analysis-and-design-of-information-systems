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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }

        private void Form22_Load(object sender, EventArgs e)
        {
         
            DateTime currenTime = DateTime.Now;
            int x = currenTime.Month;
            int y = currenTime.Year;
            List<Supplier> Suppliers = Program.Suppliers;
            listView1.Items.Clear();
            foreach (Supplier s in Suppliers)
            {
                if (x == s.getcontractenddate().Month && y == s.getcontractenddate().Year )
                {
                    var row = new string[] { s.getcontractenddate().ToString(), s.getEmail().ToString(), s.getJoinDate().ToString(), s.getid().ToString(), s.getname() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = s;
                    listView1.Items.Add(lvi);
                }
            }
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
         
        }
    }
}
