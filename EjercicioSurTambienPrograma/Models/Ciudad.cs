using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSurTambienPrograma.Models
{
    public class Ciudad
    {
        public Provincia provincia;
        public String nombreCiudad;

        public Ciudad(Provincia provincia,String unNombre) 
        {
            this.provincia = provincia;
            this.nombreCiudad = unNombre;
        }
    }
}
