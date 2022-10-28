using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("форма без переключения ");
            f.Pubtext = "Hello from mother form!";
            f.ShowDialog();
            f.Close();
            Form2 f2 = new Form2("форма c переключением");
            f2.Pubtext = "Hello from mother form2!";
            f2.ShowDialog();
            f2.Close();
        }
    }
}
