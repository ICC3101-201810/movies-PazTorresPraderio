using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Estudio
    {
        public string nombre;
        string direccion;
        string fecha;
        public Estudio(string nombre,string direccion,string fecha)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.fecha = fecha;
        }
    }
}
