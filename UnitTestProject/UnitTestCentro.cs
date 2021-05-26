using EjercicioSurTambienPrograma;
using EjercicioSurTambienPrograma.Models;
using EjercicioSurTambienPrograma.Models.Vendedor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject
{

    [TestClass]
    public class UnitTestCentro
    {

        [TestMethod]
        public void TestMethodCentroRobusto()
        {

            Centro centro = new Centro();
            centro.agregarVendedor(agregarVendedorFirme("1"));
            centro.agregarVendedor(agregarVendedorNoFirme("2"));
            centro.agregarVendedor(agregarVendedorFirme("3"));
            centro.agregarVendedor(agregarVendedorFirme("4"));
            centro.agregarVendedor(agregarVendedorFirme("5"));
            centro.agregarVendedor(agregarVendedorFirme("6"));
            bool result = centro.soyFirme();
            Assert.AreEqual(true, result);

        }

        private Salesman agregarVendedorNoFirme(string id)
        {
            Certificacion c1 = new Certificacion(10, true);
            VendedorFijo vendedorFijo = new VendedorFijo(id);
            vendedorFijo.certificaciones.Add(c1);
            return vendedorFijo;
        }

        private Salesman agregarVendedorFirme(string id)
        {
            Certificacion c1 = new Certificacion(35, false);
            VendedorFijo vendedorFijo = new VendedorFijo(id);
            vendedorFijo.certificaciones.Add(c1);
            return vendedorFijo;
        }

        [TestMethod]
        public void TestMethodVendedorEstrella() 
        {

                Centro centro = new Centro();
                centro.agregarVendedor(generarVendedorGanador());
                centro.agregarVendedor(generarVendedorPerdedor());
                Salesman vendedorEstrella = centro.dameVendedorEstrella();
                Salesman vGenericoGanador = generarVendedorGanador();
                int certificacionesEstrella = vendedorEstrella.dameTotalPuntajeCertificaciones();
                int certificacionesvGenericoGanador = vGenericoGanador.dameTotalPuntajeCertificaciones();
                Assert.AreEqual(certificacionesvGenericoGanador, certificacionesEstrella);
            
        }

        private Salesman generarVendedorPerdedor()
        {
            VendedorFijo vFijo = new VendedorFijo("2");
            vFijo.certificaciones.Add(new Certificacion(20, false));
            return vFijo;
        }

        private Salesman generarVendedorGanador()
        {
            Viajante vViajante = new Viajante("1");
            vViajante.certificaciones.Add(new Certificacion(30, true));
            return vViajante;
        }
    }
}
