using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Pelicula
    {
        public string nombre;
        public Persona director;
        public string fechaEstreno;
        public string descripcion;
        public int presupuesto;
        public Estudio estudio;
        public List<Persona> actores;
        public Persona productor;
        public Pelicula(string nombre,Persona director, string fechaEstreno,string descripcion,int presupuesto,Estudio estudio,List<Persona> actores, Persona productor)
        {
            this.nombre = nombre;
            this.director = director;
            this.fechaEstreno = fechaEstreno;
            this.descripcion = descripcion;
            this.presupuesto = presupuesto;
            this.estudio = estudio;
            this.actores = new List<Persona>();
            this.productor = productor;
        }

    }
}
