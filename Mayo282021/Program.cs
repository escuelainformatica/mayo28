using System;

namespace Mayo282021
{
    class Program
    {
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













        }
    }
}
