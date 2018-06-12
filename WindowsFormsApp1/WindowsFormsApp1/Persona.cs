using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Persona
    {
        public string tipo;
        public string nombre;
        public string apellido;
        public string fechaNac;
        public string biografia;
        public Persona(string tipo,string nombre,string apellido,string fechaNac,string biografia)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.biografia = biografia;
        }
    }
}
