using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioSurTambienPrograma.Utils
{
    public class Utils
    {

        public bool seEncuentraEnLaLista(List<Object> listaElementos, Object Elemento) 
        {
            try {
                bool esta = false;
                int i = 0;
                while (i < listaElementos.Count && !esta)
                {
                    if (listaElementos[i].Equals(Elemento))
                    {
                        esta = true;
                    }
                }
                return esta;
            }
            catch(Exception e) {

                throw new Exception("Excepción en Utils.seEncuentraEnLaLista: " + e.Message);
            }
            
        }
    }
}
