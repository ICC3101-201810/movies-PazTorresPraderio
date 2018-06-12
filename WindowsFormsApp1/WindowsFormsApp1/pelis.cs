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
    public partial class pelis : Form
    {
        Form2 f2;
        public pelis(Form2 f2)
        {
            this.f2 = f2;
            InitializeComponent();
            foreach (Pelicula p in BBDD.peliculas)
            {
                listBox1.Items.Add(p.nombre);
            }
        }
        Pelicula PeliculaSelect;
        protected override void OnClosed(EventArgs e)
        {
            f2.Show();
            base.OnClosed(e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            string selectItem = listBox1.Items[listBox1.SelectedIndex].ToString();
            for (int i = BBDD.peliculas.Count -1; i >= 0; i--)
            {
                if (selectItem== BBDD.peliculas[i].nombre)
                {
                    PeliculaSelect = BBDD.peliculas[i];
                    Info info = new Info(this, PeliculaSelect);
                    this.Hide();
                    info.Show();

                }
            }
        }
    }
}
