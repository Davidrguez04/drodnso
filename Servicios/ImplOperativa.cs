using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using drodnso.Dto;

namespace drodnso.Servicios
{
    /// <summary>
    /// 041223 David Rodriguez Alonso
    /// Clase para la operativa de la aplicacion
    /// Contiene el alta de un nuevo elemento y 
    /// la eliminación de la cantidad de elementos
    /// </summary>
    internal class ImplOperativa:InterfazOperativa
    {
        //Método para el alta de un nuevo elemento para la vajilla
        public void darAltaVajilla(List<VajillaDto> listaVajilla)
        {
            VajillaDto vajilla = crearNuevoElemento();
             listaVajilla.Add(vajilla);
        }

        //Método privado para la peticion de valores del elemento nuevo y pasarselo al método del alta para terminar
        private VajillaDto crearNuevoElemento()
        {
            VajillaDto vajilla = new VajillaDto();

            Console.Write("\n\tIntroduzca el id del elemento nuevo: ");
            vajilla.IdElemento = Convert.ToInt64(Console.ReadLine());

            Console.Write("\n\tIntroduzca el nombre del elemento nuevo: ");
            vajilla.NombreElemento = Convert.ToString(Console.ReadLine());

            Console.Write("\n\tIntroduzca la descripcion del elemento nuevo: ");
            vajilla.DescripcionElemento = Convert.ToString(Console.ReadLine());

            Console.Write("\n\tIntroduzca la cantidad del elemento nuevo: ");
            vajilla.CantidadElemento = Convert.ToInt32(Console.ReadLine());

            vajilla.CodigoElemento = vajilla.IdElemento + vajilla.NombreElemento;

            return vajilla;
        }

        //Método para la eliminación de una cierta cantidad de un cierto elemento pedido por pantalla mediante el codigo
        public void borrarCantidad(List<VajillaDto> listaVajilla)
        {
            VajillaDto vajilla=new VajillaDto();

            Console.Write("\n\tIntroduzca el codigo del elemento que desea borrar cantidades: ");
            string codigoElem=Convert.ToString(Console.ReadLine());

            int cantidadElemen; 
            

            foreach(VajillaDto vajillaDto in listaVajilla)
            {
                if (vajillaDto.CodigoElemento.Equals(codigoElem))
                {
                    vajilla = vajillaDto;
        
                        Console.WriteLine("\nQue cantidad de " + vajillaDto.NombreElemento + " quiere borrar?: ");
                        cantidadElemen = Convert.ToInt32(Console.ReadLine());

                        vajillaDto.CantidadElemento = vajillaDto.CantidadElemento - cantidadElemen;


                }
                
                
                    
                
            }
        }
    }
}
