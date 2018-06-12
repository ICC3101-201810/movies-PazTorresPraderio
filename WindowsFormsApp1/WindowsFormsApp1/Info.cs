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
    public partial class Info : Form
    {
        pelis p;
        Pelicula peli;
        public Info(pelis p , Pelicula peli)
        {
            this.p = p;
            this.peli = peli;
            InitializeComponent();
            listBox1.Items.Add("Nombre" + " " + peli.nombre);
            listBox1.Items.Add("Director" + " " + peli.director.nombre + " " + peli.director.apellido);
            listBox1.Items.Add("Estudio" + " " + peli.estudio.nombre);
            foreach (Persona actor in peli.actores)
            {
                listBox1.Items.Add(actor.nombre + " " + actor.apellido);
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            p.Show();
            base.OnClosed(e);
        }
    }
}
