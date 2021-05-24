using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSurTambienPrograma
{
    public class Certificacion
    {
        public int cantidadPuntos { get; set; }
        public bool esSobreproducto { get; set; }

        public Certificacion(int unaCantidadDePuntos, bool esSobreProductos) 
        {
            this.cantidadPuntos = unaCantidadDePuntos;
            this.esSobreproducto = esSobreproducto;
        }
    }
}
