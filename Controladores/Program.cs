using drodnso.Dto;
using drodnso.Servicios;

namespace drodnso.Controladores
{
    /// <summary>
    /// 041223 David Rodriguez Alonso
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// 041223 David Rodriguez Alonso
        /// Método que contiene el flujo de procedimientos de la aplicación
        /// Es el método de entrada de la aplicación
        /// </summary>
        static void Main(string[] args)
        {
            InterfazMenu mi=new ImplMenu();
            InterfazOperativa ni = new ImplOperativa();

            List<VajillaDto> listaVajilla = new List<VajillaDto>();

            mi.mensajeBienvenida();

            bool salir = false;
            int opcion;

            while (!salir)
            {
                opcion = mi.mostrarMenu();
                Console.Clear();

                switch(opcion)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("\n\tHa seleccionado la opcion para salir, muchas gracias por usar nuestro programa!!!!");
                        salir = true;
                        break;

                    case 1:
                        Console.WriteLine("\n\n[INFO]--Se efectua el alta del nuevo elemento ");
                        ni.darAltaVajilla(listaVajilla);

                        Console.WriteLine("\nElementos: ");
                        foreach (VajillaDto vajilla in listaVajilla)
                        {
                            
                            Console.Write("\n\t"+vajilla.NombreElemento);
                            Console.WriteLine("  " + vajilla.CantidadElemento);
                            
                        }

                        break;

                    case 2:
                        Console.WriteLine("\n\t[INFO]--Opcion introducida= borrar cantidad de elementos de stock");
                        ni.borrarCantidad(listaVajilla);

                        foreach (VajillaDto vajilla in listaVajilla)
                        {
                            Console.Write("\n\t" + vajilla.NombreElemento);
                            Console.WriteLine("\n\t" + vajilla.CantidadElemento);
                            
                        }

                        break;

                    default:
                        Console.WriteLine("\n\t[ERROR]--La opción seleccionada no es correcta por favor vuelva a intentarlo: ");
                        break;
                }
            }
        }
    }
}
