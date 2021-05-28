using Mayo282021.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayo282021.servicio
{
    // clase de servicio es una coleccion de metodos o funciones.
    // y por lo general no quiero tener campos.
    public class ClienteServicio
    {
        public int campo;

        // no deberia usarlos. (por defecto, son singleton)
        // porque si dos o mas usuarios modifican el valor, es la misma variable
        // y el resultado seria inesperado.
        public static int campoEstatico;

        public bool Validar(Cliente cli)
        {
            var resultado=true;

            campo=2;

            if(cli.Nombre=="")
            {
                resultado=false;
            }
            if(cli.Edad<0 || cli.Edad>150)
            {
                resultado=false;
            }
            if(cli.Deuda<0)
            {
                resultado=false;
            }
            return resultado;
        }


        public static bool ValidarEstatica(Cliente cli)
        {
            //campoEstatico=20;

            var resultado=true;
            if(cli.Nombre=="")
            {
                resultado=false;
            }
            if(cli.Edad<0 || cli.Edad>150)
            {
                resultado=false;
            }
            if(cli.Deuda<0)
            {
                resultado=false;
            }
            return resultado;
        }
    }
}
