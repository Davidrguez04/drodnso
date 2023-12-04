using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drodnso.Servicios
{
    /// <summary>
    /// 041223 David Rodriguez Alonso
    /// Clase que se encarga del uso y procedimientos del menu de la aplicación
    /// </summary>
    internal class ImplMenu:InterfazMenu
    {
        //Método para mostrar por pantalla un mensaje de bienvenida a la aplicación
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido al programa para control de stock de vajilla";
            Console.WriteLine("\n\t\t\t"+mensaje);
        }

        //Método para mostrar el menú y recoger la opción seleccionada
        public int mostrarMenu()
        {
            int opcion;

            Console.WriteLine("\n\t------------------- ");
            Console.WriteLine("\n\tMenu: ");
            Console.WriteLine("\n\t1-> Dar de alta nuevo elemento");
            Console.WriteLine("\n\t2-> Eliminar cantidad de elementos");
            Console.WriteLine("\n\t0-> Salir");
            Console.Write("\n\t Seleccione una opción del menu: ");
            
            opcion=Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }
    }
}
