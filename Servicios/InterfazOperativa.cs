using drodnso.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drodnso.Servicios
{
    /// <summary>
    /// 041223 David Rodriguez Alonso
    /// Interfaz de la operativa de la aplicación
    /// para el alta y la eliminación de elementos
    /// del stock
    /// </summary>
    internal interface InterfazOperativa
    {
        
        public void darAltaVajilla(List<VajillaDto> listaVajilla);

        public void borrarCantidad(List<VajillaDto> listaVajilla);
    }
}
