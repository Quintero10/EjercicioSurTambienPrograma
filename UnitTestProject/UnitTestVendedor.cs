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
        public void TestMethodComercioCorresponsalPuedeTrabajarEnCiudad()
        {

            ComercioCorresponsal vendedor = new ComercioCorresponsal("27");
            Ciudad ciudadPrueba = new Ciudad(Provincia.CORDOBA, "Villa Luzuriaga");
            vendedor.ciudadesConSucursal.Add(ciudadPrueba);
            Ciudad ciudadPruebaTarget = new Ciudad(Provincia.CORDOBA, "Villa Luzuriaga");
            bool result = vendedor.puedoTrabajarEnLaCiudad(ciudadPruebaTarget);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void TestMethodVendedorViajantePuedeTrabajarEnCiudad()
        {
            
            Viajante vendedor = new Viajante("25");
            vendedor.provinciasHabilitado.Add(Provincia.CORDOBA);
            Ciudad ciudadPrueba = new Ciudad(Provincia.CORDOBA, "Villa María");
            bool result = vendedor.puedoTrabajarEnLaCiudad(ciudadPrueba);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void TestMethodVendedorFijoPuedeTrabajarEnCiudad()
        {
            //Duda: 
            // El ejercicio plantea que de la ciudad solo se registra la provincia.
            // Al comparar dos objetos ciudades, los Assert siempre dan false. (No hago referencia al mismo objeto, porque en espacioMemoria son <> 
            // por más que sus atributos sean iguales.
            // Se me ocurre , además de guardar la provincia como atributo, guardar como string el nombre de la ciudad .
            // el método "puedoTrabajarEnLaCiudad" , recibe un objeto Ciudad como plantea el ejercicio, pero la comparación la hace con su atributo nombre (String).
            // Entonces , en el assert, puedo comparar por Strings.

            VendedorFijo vendedor = new VendedorFijo("23");
            vendedor.ciudadEnQueVive = new Ciudad(Provincia.CORDOBA,"Villa María");
            Ciudad ciudadPrueba = new Ciudad(Provincia.CORDOBA,"Villa María");
            bool result = vendedor.puedoTrabajarEnLaCiudad(ciudadPrueba);
            Assert.AreEqual(true, result);

        }

        [TestMethod]
        public void TestMethodVendedorVersatil()
        {
            VendedorFijo vendedor = new VendedorFijo("23");
            List<Certificacion> certificaciones = generarListaVersatilDeCertificaciones();
            vendedor.certificaciones = certificaciones;
            bool result = vendedor.soyVersatil();
            Assert.AreEqual(true, result);


        }

        [TestMethod]
        public void TestMethodVendedorFirme()
        {
            VendedorFijo vendedor = new VendedorFijo("24");
            List<Certificacion> certificaciones = generarListaVersatilDeCertificaciones();
            vendedor.certificaciones = certificaciones;
            bool result = vendedor.soyFirme();
            Assert.AreEqual(true, result);


        }
        [TestMethod]
        public void TestMethodComercioCorresponsalInfluyente()
        {
            ComercioCorresponsal vendedor = new ComercioCorresponsal("100");
            //vendedor.ciudadesConSucursal.Add(new Ciudad(Provincia.BUENOS_AIRES, "Tandil"));
            //vendedor.ciudadesConSucursal.Add(new Ciudad(Provincia.BUENOS_AIRES, "San Clemente"));
            //vendedor.ciudadesConSucursal.Add(new Ciudad(Provincia.BUENOS_AIRES, "Bahía Blanca"));
            //endedor.ciudadesConSucursal.Add(new Ciudad(Provincia.BUENOS_AIRES, "Tres Arroyos"));
            //endedor.ciudadesConSucursal.Add(new Ciudad(Provincia.BUENOS_AIRES, "Necochea"));
            vendedor.ciudadesConSucursal.Add(new Ciudad(Provincia.BUENOS_AIRES, "Tandil"));
            vendedor.ciudadesConSucursal.Add(new Ciudad(Provincia.CORDOBA, "Tanti"));
            vendedor.ciudadesConSucursal.Add(new Ciudad(Provincia.SANTA_FE, "Monte Vera"));
            bool result = vendedor.soyInfluyente();
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethodViajanteInfluyente()
        {
            Viajante vendedor = new Viajante("90");
            vendedor.provinciasHabilitado.Add(Provincia.CORDOBA);
            vendedor.provinciasHabilitado.Add(Provincia.BUENOS_AIRES);
            bool result = vendedor.soyInfluyente();
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
