using Mayo282021.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo282021.servicio
{
    public class EncomiendaServicio
    {
        // no puedo ocupar campos.
        // Deterministico = ???
        public static bool Validar(Encomienda enc)
        {
            var ok=true;
            // falla la validacion si el alto, largo o ancho es menor a cero.
            if(enc.Alto<0 || enc.Largo<0 || enc.Ancho<0)
            {
                ok= false;
            }
            if(String.IsNullOrEmpty(enc.Direccion) || String.IsNullOrEmpty(enc.NombreCliente))
            {
                ok=false;
            }
            return ok;
        }
        public static void Mostrar(Encomienda enc)
        {
            Console.WriteLine("Nombre del cliente :"+enc.NombreCliente);
            Console.WriteLine("Direccion :"+enc.Direccion);
        }
    }
}
