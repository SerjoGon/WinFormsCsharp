﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsless3
{
    public partial class Form2 : Form
    {
        public string Pubtext {
             
            set 
            {
                lb_outText.Text = value;
            }
        }
        public Form2(string s)
        {
            InitializeComponent();
            this.Text = s;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
