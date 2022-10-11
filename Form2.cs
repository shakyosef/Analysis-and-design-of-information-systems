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
    public partial class MAIN_FORM : Form
    {
        public MAIN_FORM()
        {
            InitializeComponent();
        }

        private void button_EMPLOYEE_Click(object sender, EventArgs e)
        {
           
                }

        private void button_CREATE_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void button_LOOK_Click(object sender, EventArgs e)
        {
            new Form7().ShowDialog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }
    }
}
