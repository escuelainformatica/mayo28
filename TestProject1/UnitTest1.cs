using Mayo282021.modelo;
using Mayo282021.servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // test unitario

            Encomienda enc=new Encomienda(1,2,3,"aaa","bbb");
            Assert.AreEqual(true, EncomiendaServicio.Validar(enc) );

            enc=new Encomienda() {Alto=1,Ancho=2,Largo=3, NombreCliente="aaa",Direccion="bbb" };
            Assert.AreEqual(true, EncomiendaServicio.Validar(enc) );

            enc=new Encomienda(-1,2,3,"aaa","bbb");
            Assert.AreEqual(false, EncomiendaServicio.Validar(enc) );

            enc=new Encomienda(-1,2,3,"aaa","");
            Assert.AreEqual(false, EncomiendaServicio.Validar(enc) );

            // probar base de datos
            // base de datos falsa (mockup)


            // probar con una base de datos real (test de integracion)

            // coberturas de las pruebas.

            Cliente cli=new Cliente {Nombre="john",Edad=33, Deuda=5};
            Assert.AreEqual(true,ClienteServicio.ValidarEstatica(cli));

            cli=new Cliente {Nombre="john",Edad=-5, Deuda=5};
            Assert.AreEqual(false,ClienteServicio.ValidarEstatica(cli));
            cli=new Cliente {Nombre="",Edad=-5, Deuda=-5};
            Assert.AreEqual(false,ClienteServicio.ValidarEstatica(cli));



            ClienteServicio srv=new ClienteServicio();
            cli=new Cliente {Nombre="john",Edad=33, Deuda=5};
            Assert.AreEqual(true,srv.Validar(cli));
            cli=new Cliente {Nombre="",Edad=-1, Deuda=-1};
            Assert.AreEqual(false,srv.Validar(cli));

        }
    }
}
