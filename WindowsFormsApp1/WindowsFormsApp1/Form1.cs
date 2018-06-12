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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Persona actor = new Persona("Actor", "Brad", "Pitt", "13/07/1979", "Dejo a Jennifer Aniston por Angelina Jolie");
            Persona productor = new Persona("Productor", "Javier", "Sepulveda", "10/11/1996", "No va al Lab de termo");
            Persona director = new Persona("Director", "Paz", "Torres", "13/12/1995", "Probablemente me eche este ramo");
            Estudio e1 = new Estudio("Panda Movies", "Las Hualtatas 774", "05/03/2000");
            Pelicula p1 = new Pelicula("El ataque del Software", director, "13/12/2017", "Un software que se vuelve mas inteligente que los del FicaCom", 150000, e1, null , productor);
            p1.actores.Add(actor);
            BBDD.estudio.Add(e1);
            BBDD.peliculas.Add(p1);
            BBDD.personas.Add(actor);
            BBDD.personas.Add(productor);
            BBDD.personas.Add(director);
        }   
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }
        void timer_Tick(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2(this);
            f2.Show();
            timer.Stop();

        }
    }
}
