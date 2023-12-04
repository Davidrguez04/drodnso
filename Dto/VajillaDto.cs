using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drodnso.Dto
{
    /// <summary>
    /// 041223 David Rodriguez Alonso
    /// Clase para crear los datos de los elementos de la vajilla
    /// </summary>
    internal class VajillaDto
    {
        //Atributos
        long idElemento=0;
        string codigoElemento="aaaaa";
        string nombreElemento="aaaaa";
        string descripcionElemento="aaaaa";
        int cantidadElemento=0;


        //Getters y setters
        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }


        //Constructores

        //Constructor Vacío
        public VajillaDto()
        {
        }

        public VajillaDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        //Método ToString()
        override
            public string ToString()
        {
            string vajilla = "\n\tId elemento: "+this.idElemento+
                "\n\tCodigo elemento: "+this.codigoElemento+
                "\n\tNombre elemento: "+this.nombreElemento+
                "\n\tDescripcion elemento: "+this.descripcionElemento+
                "\n\tCantidad elemento: "+this.cantidadElemento;

            return vajilla;
        }
    }
}
