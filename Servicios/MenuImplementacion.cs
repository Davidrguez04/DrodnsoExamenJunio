using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrodnsoExamenJunio.Servicios
{
    /// <summary>
    /// David Rodriguez Alonso - 14/06/2024
    /// Clase que contiene el menu de la app
    /// </summary>
    internal class MenuImplementacion:MenuInterfaz
    {
        //Método con las opciones principales del menú
        public int mostrarMenu()
        {
            int opcion = 0;
            Console.WriteLine("\n\tMenu principal:");
            Console.WriteLine("\n\t0.-Cerrar aplicacion");
            Console.WriteLine("\n\t1.-Motrar históricos");
            Console.WriteLine("\n\t2.-Alta nuevo propietario");
            Console.Write("\n\tSeleccione una opción: ");

            opcion=Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }

    }
}
