using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSurTambienPrograma.Models
{
    public class Ciudad
    {
        public Provincia provincia;

        public Ciudad(Provincia provincia) 
        {
            this.provincia = provincia;
        }
    }
}
