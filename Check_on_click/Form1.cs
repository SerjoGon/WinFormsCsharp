using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_on_click
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mi_theme_darck_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender;
            if (it.Checked == true)
            {
                this.BackColor = Color.DarkGoldenrod;
            }
            mi_theme_green.Checked = false;
            mi_theme_ligth.Checked = false;
        }

        private void mi_theme_ligth_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender;
            if(it.Checked == true)
            {
                this.BackColor = Color.White;
            }
            mi_theme_darck.Checked = false;
            mi_theme_green.Checked = false;
        }

        private void mi_theme_green_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem it = (ToolStripMenuItem)sender;
            if (it.Checked == true)
            {
                this.BackColor = Color.Green;
            }
            mi_theme_ligth.Checked = false;
            mi_theme_darck.Checked = false;
        }
    }
}
