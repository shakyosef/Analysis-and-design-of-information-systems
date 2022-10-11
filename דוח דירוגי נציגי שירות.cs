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
    public partial class Form26 : Form
    {
        public Form26()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form26_Load(object sender, EventArgs e)
        {
           
            var rates1 = Program.rates;
            listView1.Items.Clear();
            foreach (Rate s in rates1)
            {
                var row = new string[] { s.getcustomerid().ToString(), s.getrate().ToString(), s.getCustomerServiceClerckid().ToString(),s.getRateTime().ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = s;
                listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }
    }
}
