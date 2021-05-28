using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo282021.modelo
{
    public class Encomienda
    {
        public int Alto {set; get;}
        public int Ancho {set; get;}
        public int Largo {set; get;}
        public string NombreCliente {set; get;}
        public string Direccion {set; get;}

        public Encomienda(int alto, int ancho, int largo, string nombreCliente, string direccion)
        {
            Alto = alto;
            Ancho = ancho;
            Largo = largo;
            NombreCliente = nombreCliente;
            Direccion = direccion;
        }

        public Encomienda()
        {
        }
    }
}
