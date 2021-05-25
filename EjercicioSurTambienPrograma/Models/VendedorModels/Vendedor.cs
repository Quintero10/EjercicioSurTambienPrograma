using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSurTambienPrograma.Models
{
    public abstract class Salesman
    {


        public List<Certificacion> certificaciones;
        public string id { get; set; }
        public abstract Boolean soyInfluyente();
        public abstract Boolean puedoTrabajarEnLaCiudad(Ciudad unaCiudad);

        public Salesman(string unId) 
        {
            this.certificaciones = new List<Certificacion>();
            this.id = unId;
        }

        internal bool esMiId(string id)
        {
            return this.id == id;
        }

        public bool soyVersatil() 
        {
            return certificaciones.Count >= 3 && condicionVersatilidadProducto();
        }

        private bool condicionVersatilidadProducto()
        {
            try {
                int i = 0;
                bool tengoCertiProducto = false;
                bool tengoCertiNoProducto = false;
                bool tengoVersatilidad = false;
                while ((i < this.certificaciones.Count && !(tengoCertiProducto && tengoCertiNoProducto)))
                {
                    if (this.certificaciones[i].esSobreproducto)
                    {
                        tengoCertiProducto = true;
                    }
                    else
                    {
                        tengoCertiNoProducto = true;
                    }
                    i++;
                }
                if (tengoCertiNoProducto && tengoCertiNoProducto) tengoVersatilidad = true;
                return tengoVersatilidad;
            }
            catch(Exception e)
            { 
                throw new Exception("Excepción en condiciónVersatilidad"); 
            }
           
        }

        public int dameTotalPuntajeCertificaciones()
        {
            int acumulador = 0;
            foreach(var certificacion in this.certificaciones) 
            {
                acumulador += certificacion.cantidadPuntos;
            }
            return acumulador;
        }

        public bool soyFirme() 
        {
            //return necesitoUnaODosPastillitasParaElCoito();
            bool soyFirme = false;
            int acumulador = 0;
            int i= 0;
            while(i<this.certificaciones.Count && !soyFirme) 
            {
                acumulador += this.certificaciones[i].cantidadPuntos;
                if (acumulador >= 30) soyFirme = true;
                i++;
            }
            return soyFirme;
        }

        internal bool tengoAlMenosUnaCertificacionNoProducto()
        {
            bool tengo = false;
            int i = 0;
            while(i<this.certificaciones.Count && !tengo) 
            {
                if (!this.certificaciones[i].esSobreproducto) tengo = true;
            }

            return tengo;
        }
    }
}
