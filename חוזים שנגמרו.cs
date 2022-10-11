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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
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

        private void Form23_Load(object sender, EventArgs e)
        {
            DateTime currenTime = DateTime.Now;
            List<Supplier> Suppliers = Program.Suppliers;
            listView1.Items.Clear();
            foreach (Supplier s in Suppliers)
            {
                if (currenTime > s.getcontractenddate())
                {
                    var row = new string[] { s.getcontractenddate().ToString(), s.getEmail().ToString(), s.getJoinDate().ToString(), s.getid().ToString(), s.getname() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = s;
                    listView1.Items.Add(lvi);
                }
            }
        }
    }
}
