using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSurTambienPrograma.Models.Vendedor
{
    public class Viajante : Salesman
    {
        public List<Provincia> provinciasHabilitado;

        public Viajante(string unId) : base(unId)
        {
            this.id = unId;
            this.provinciasHabilitado = new List<Provincia>();
        }

        public override bool puedoTrabajarEnLaCiudad(Ciudad unaCiudad)
        {
            bool puedo = false;
            int i = 0;
            while(i<this.provinciasHabilitado.Count && !puedo) 
            {
                if (this.provinciasHabilitado[i].Equals(unaCiudad.provincia)) 
                {
                    puedo = true;
                }
                i++;
            }

            return puedo;
        }

        public override bool soyInfluyente()
        {
            return sumaDePoblacionProvincias() > 10000000;
        }

        private int sumaDePoblacionProvincias()
        {
           
            int acumulador = 0;
            foreach(Provincia provincia in provinciasHabilitado) 
            {
                acumulador += (int)provincia;
            }
            return acumulador;
        }
    }
}
