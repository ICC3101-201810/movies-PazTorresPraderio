using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Form1 parent;
        public Form2(Form1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pelis pelis = new pelis(this);
            this.Hide();
            pelis.Show();
        }
    }
}
