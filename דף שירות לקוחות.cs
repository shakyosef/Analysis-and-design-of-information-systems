﻿using System;
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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
          
            this.Hide();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Form26 f26 = new Form26();
            f26.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
           
            this.Hide();
        }

        private void button_serviceC_Click(object sender, EventArgs e)
        {

        }
    }
}
