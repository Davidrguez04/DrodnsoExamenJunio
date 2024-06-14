using DrodnsoExamenJunio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DrodnsoExamenJunio.Servicios
{
    /// <summary>
    /// David Rodriguez Alonso - 14/06/2024
    /// Clase que contiene toda la operativa de la app
    /// </summary>
    internal class OperativaImplementacion:OperativaInterfaz
    {
        //Método que muestra los coches de mas de 25 años por consola
        public void mostrarHistoricos(List<DtoVehiculo>listaVehiculo, List<DtoPropietario>listaPorpietarios)
        {
            DtoVehiculo vehiculo=new DtoVehiculo();
            DtoPropietario propietario=new DtoPropietario();

            DateTime fechaHoy = DateTime.Now;
            int numeroTotal=0;

            foreach(DtoVehiculo vehiculos in listaVehiculo)
            {
                vehiculos.Diferencia = fechaHoy.Date - vehiculos.FchMatriculacion.Date;
                
                if (vehiculos.Diferencia.Days>9125)
                {
                    foreach (DtoPropietario propietarios in listaPorpietarios)
                    {
                        propietarios.EsHistorico = true;
                    }
                    
                    numeroTotal++;
                }
                else
                {
                    propietario.EsHistorico = false;
                }
            }

            Console.WriteLine("\n\tN. Históricos:"+numeroTotal);
        }

        //Método que hace un nuevo alta de un propietario pidiendo datos por consola
        public void altaPropietario(List<DtoPropietario> listaPropietarios)
        {
            DtoPropietario propietario = datosPropietario();

            int id = 1;

            foreach (DtoPropietario propietarios in listaPropietarios)
            {
                propietarios.Id = id++; 
                
            }
            Console.WriteLine(propietario.ToString());
            listaPropietarios.Add(propietario);
        }
       //Mñetodo privato para pedir los datos del propietario
        private DtoPropietario datosPropietario()
        {
            DtoPropietario propietario= new DtoPropietario();

            Console.Write("\n\tIntroduzca su dni: ");
            propietario.Dni = Console.ReadLine();

            /*char caracteres= Convert.ToChar(propietario.Dni);

            while (caracteres == 9)
            {
                Console.WriteLine("\n\tVuelva a introducir su dni: ");
                propietario.Dni = Console.ReadLine();
            }
            */
            return propietario;
        }

    }
}
