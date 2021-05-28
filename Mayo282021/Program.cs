using Mayo282021.modelo;
using Mayo282021.servicio;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Mayo282021
{
    class Program
    {

        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            // variables
            // clases (campos, propiedades, metodos)

            // operadores binarios
            int total=20+30;        // 50
            string texto="20"+30; // "2030"

            // operadores de logica            
            bool resultado= true && true; // true y false = false
            bool resultado2= true || false; // true ó false = true

            bool resultado3= 1 < 3;  // true: 1 es menor que 3?
            resultado3= 1 > 3;  // false: 1 es mayor a 3?
            resultado3= 1 == 2; // false: 1 es igual a 2?
            resultado3= 1 != 2; // true: 1 es diferente a 2?
            // <, <=, >, >=, ==, !=

            string productoNombre="cocacola";
            int precio=5000;
            int cantidad=5;

            bool valido= productoNombre!="" && precio>0  && precio<1000000 && cantidad>=0;

            // operadores que son unitarios.
            valido= !valido; // ! es negacion.

            // condiciones o bifurcaciones
            if ( 1 == 2)
            {
                Console.WriteLine("1 es igual a 2");
            } else
            {
                Console.WriteLine("1 no es igual a 2");
            }

            int num1=10;
            int num2=10;

            if(num1<num2)
            {
                Console.WriteLine("num1 es menor");
            } else
            {
                if(num1>num2) {
                    Console.WriteLine("num2 es menor");
                } else
                {
                    Console.WriteLine("son iguales");
                }
            }

            if(num1<num2)
            {
                Console.WriteLine("num1 es menor");
            }
            if(num1>num2)
            {
                Console.WriteLine("num2 es menor");
            }
            if(num1==num2)
            {
                Console.WriteLine("son iguales");
            }


            // switch y case
            int num3=5;

            switch(num3)
            {
                case 1:
                    Console.WriteLine("uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                default:
                    Console.WriteLine("otro numero");
                    break; // salir del bloque de codigo
            }

            // variable esta definida por una clase, se llama objeto
            var john=new Cliente();
            john.Nombre="john";
            john.Edad=33;
            john.Deuda=-5;

            var servicio=new ClienteServicio();
            Console.WriteLine( servicio.Validar(john) );

            Console.WriteLine( ClienteServicio.ValidarEstatica(john) );

            // ejercicio encomienda;

            var enc=new Encomienda();
            enc.Ancho=2;
            enc.Alto=2;
            enc.Largo=2;
            enc.NombreCliente="john";
            enc.Direccion="sunset blv";

            Console.WriteLine( EncomiendaServicio.Validar(enc) );

            var enc2=new Encomienda(2,2,2,"john","sunset blv");

            var enc3=new Encomienda
            {
                Ancho=2,Alto=2,Largo=2,NombreCliente="John",Direccion="Sunset blv"
            };



        }
    }
}
