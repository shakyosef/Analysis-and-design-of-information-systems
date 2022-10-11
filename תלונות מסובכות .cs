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
    
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Form25 f25 = new Form25();
            f25.Show();
            this.Hide();
            
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            DateTime currenTime = DateTime.Now;
            
            List<compensationcomplaint> compensationcomplaints = Program.compensationcomplaints;
            listView1.Items.Clear();
            foreach (compensationcomplaint s in compensationcomplaints)
            {
                var row = new string[] { s.getinquirySummery().ToString(), s.getstatusDirector().ToString(), s.getcomplaint().ToString(), s.getcomplaintNum().ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = s;
                    listView1.Items.Add(lvi);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 mf = new Form16();
            mf.Show();
            this.Hide();
        }
    }
}
