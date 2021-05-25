using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSurTambienPrograma.Models.Vendedor
{
    public class ComercioCorresponsal : Salesman
    {

        private List<Ciudad> ciudadesConSucursal;
        private readonly int NRO_CIUDADES_INFLUYENTE = 5;

        public ComercioCorresponsal(string unId) : base(unId) 
        {
            this.ciudadesConSucursal = new List<Ciudad>();
            this.id = unId;
        }
        public override bool soyInfluyente()
        {
            return (tengoCincoCiudades() || tengoTresProvincias());
        }

        private bool tengoTresProvincias()
        {
            bool tengoAlMenosTresProvincias = false;
            int contadorProvincias = 0;
            int i = 0;
            while(contadorProvincias <3 && i < this.ciudadesConSucursal.Count) 
            {
                List<Provincia> provincias = new List<Provincia>();
                Provincia provincia=this.ciudadesConSucursal[i].provincia;
                if(noSeEncuentraEnLaLista(provincias,provincia))
                {
                    provincias.Add(provincia);
                    contadorProvincias=provincias.Count;
                }
                i++;
            }

            return tengoAlMenosTresProvincias;
        }

        private bool noSeEncuentraEnLaLista(List<Provincia> provincias, Provincia provincia)
        {
            bool esta = false;
            int i = 0;
            while(i<provincias.Count && !esta) 
            {
                if (provincias[i].Equals(provincia))
                {
                    esta = true;
                }
            }

            return esta;

        }

        private bool tengoCincoCiudades()
        {
            return this.ciudadesConSucursal.Count >= NRO_CIUDADES_INFLUYENTE;
        }

        public override bool puedoTrabajarEnLaCiudad(Ciudad unaCiudad)
        {
            //Si tuviera una lista ordenada, usaría el key de la ciudad enviada por parámetro y un método .search(K) que me devuelta si se encuentra.
            bool puedo =false;
            int i = 0;
            while(i<this.ciudadesConSucursal.Count && !puedo) 
            {
                if (this.ciudadesConSucursal[i].Equals(unaCiudad)) 
                {
                    puedo = true;
                }
            }

            return puedo;
        }

        
    }
}

