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
            if(enc.Alto<0 || enc.Largo<0 || enc.Ancho<0)
            {
                ok= false;
            }
            if(enc.Direccion=="" || enc.NombreCliente=="")
            {
                ok=false;
            }
            return ok;
        }
    }
}
