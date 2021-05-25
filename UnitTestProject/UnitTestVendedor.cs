using EjercicioSurTambienPrograma;
using EjercicioSurTambienPrograma.Models;
using EjercicioSurTambienPrograma.Models.Vendedor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestVendedor
    {
        [TestMethod]
        public void TestMethodVendedorVersatilHappyEnding()
        {
            VendedorFijo vendedor = new VendedorFijo("23");
            List<Certificacion> certificaciones = generarListaVersatilDeCertificaciones();
            vendedor.certificaciones = certificaciones;
            bool result = vendedor.soyVersatil();
            Assert.AreEqual(true, result);


        }

        [TestMethod]
        public void TestMethodVendedorFirmHappyEnding()
        {
            VendedorFijo vendedor = new VendedorFijo("24");
            List<Certificacion> certificaciones = generarListaVersatilDeCertificaciones();
            vendedor.certificaciones = certificaciones;
            bool result = vendedor.soyFirme();
            Assert.AreEqual(true, result);


        }
        public List<Certificacion> generarListaVersatilDeCertificaciones()
        {
            List<Certificacion> certificaciones = new List<Certificacion>();
            Certificacion certificacionUno = new Certificacion(20, false);
            Certificacion certificacionDos = new Certificacion(10, true);
            Certificacion certificacionTres = new Certificacion(20, false);
            certificaciones.Add(certificacionUno);
            certificaciones.Add(certificacionDos);
            certificaciones.Add(certificacionTres);
            return certificaciones;
        }


    }
}
