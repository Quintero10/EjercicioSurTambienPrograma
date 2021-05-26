using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSurTambienPrograma.Models.Vendedor
{
    public class VendedorFijo : Salesman
    {

        public VendedorFijo(string unId): base(unId) 
        {
            this.id = unId;
            
        }
        public Ciudad ciudadEnQueVive { get; set; }

        public override bool puedoTrabajarEnLaCiudad(Ciudad unaCiudad)
        {
            return this.ciudadEnQueVive.nombreCiudad == unaCiudad.nombreCiudad;
        }

        public override bool soyInfluyente()
        {
            return false;
        }

     
    }
}
