using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSurTambienPrograma.Models
{
    public class Centro
    {
        private Ciudad ciudad;
        private List<Salesman> vendedores;

        public Centro(Ciudad unaCiudad) 
        {
            this.ciudad = unaCiudad;
            this.vendedores=new List<Salesman>();
        }

        public void agregarVendedor(Salesman unVendedor) 
        {
            if (!yaExisteVendedor(unVendedor)) 
            {
                this.vendedores.Add(unVendedor);
            }
            else 
            {
                throw new Exception("El vendedor ya existe!");
            }
        }

        private bool yaExisteVendedor(Salesman unVendedor)
        {
            try {
                bool existe = buscarVendedor(unVendedor);
                return existe;
            }
            catch(Exception e) 
            {
                throw new Exception("Excepción en Centro: " + e.Message);
            }

           
        }

        public bool sePuedeCubrirCiudad(Ciudad unaCiudad) 
        {
            try {
                bool sePuede;
                sePuede = buscarCiudadEnVendedores(unaCiudad);

                return sePuede;

            }
            catch(Exception e)
            {
                throw new Exception("Excepción en sePuedeCubrirCiudad: " + e.Message);

            }
          
        }

        public List<Salesman> dameVendedoresGenericos() 
        {
            List<Salesman> listaADevolver = new List<Salesman>();
            foreach(var vendedor in this.vendedores) 
            {
                if (vendedor.tengoAlMenosUnaCertificacionNoProducto()) 
                {
                    listaADevolver.Add(vendedor);
                }
            }

            return listaADevolver;
        }

        private bool buscarCiudadEnVendedores(Ciudad unaCiudad)
        {
            int i = 0;
            bool seEncuentra = false;
            while(i<this.vendedores.Count && !seEncuentra) 
            {
                if (this.vendedores[i].puedoTrabajarEnLaCiudad(unaCiudad))
                {
                    seEncuentra = true;
                }
            }

            return seEncuentra;
        }

        public Salesman dameVendedorEstrella() 
        {
            Salesman vendedorBuscado = null;
            int maxPuntaje = 0;
            foreach(Salesman vendedor in this.vendedores) 
            {
                int puntaje = vendedor.dameTotalPuntajeCertificaciones();
                if (puntaje > maxPuntaje) 
                {
                    maxPuntaje = puntaje;
                    vendedorBuscado = vendedor;
                }
            }

            return vendedorBuscado;
        }

        private bool buscarVendedor(Salesman unVendedor)
        {

            bool existe =false;
            int i = 0;
            while (i < this.vendedores.Count && !existe)
            {
                bool esElvendedor = this.vendedores[i].esMiId(unVendedor.id);
                if (esElvendedor)
                {
                    existe = true;
                }
                i++;
            }

            return existe;
        }

        public bool soyFirme() 
        {
            bool soyFirme = false;
            int contador = 0;
            int i = 0;
            while(i<this.vendedores.Count && contador < 3) 
            {
                if (this.vendedores[i].soyFirme()) contador++;
                i++;
            }

            return soyFirme;
        }
    }
}
