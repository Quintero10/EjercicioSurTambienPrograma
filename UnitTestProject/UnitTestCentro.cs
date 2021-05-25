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
        public void TestMethodVendedorEstrella() 
        {

                Centro centro = new Centro();
                centro.agregarVendedor(generarVendedorGanador());
                centro.agregarVendedor(generarVendedorPerdedor());
                Salesman vendedorEstrella = centro.dameVendedorEstrella();
                Salesman vGenericoGanador = generarVendedorPerdedor();
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
