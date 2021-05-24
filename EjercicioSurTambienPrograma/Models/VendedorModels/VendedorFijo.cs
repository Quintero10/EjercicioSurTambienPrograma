using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSurTambienPrograma.Models.Vendedor
{
    public class VendedorFijo : Salesman
    {
        private Ciudad ciudadEnQueVive { get; set; }

        public override bool puedoTrabajarEnLaCiudad(Ciudad unaCiudad)
        {
            return this.ciudadEnQueVive == unaCiudad;
        }

        public override bool soyInfluyente()
        {
            return false;
        }

     
    }
}
