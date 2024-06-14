using DrodnsoExamenJunio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrodnsoExamenJunio.Servicios
{
    /// <summary>
    /// David Rodriguez Alonso - 14/06/2024
    /// Interfaz de la operativa de la aplicación
    /// </summary>
    internal interface OperativaInterfaz
    {
        public void mostrarHistoricos(List<DtoVehiculo> listaVehiculo, List<DtoPropietario> listaPorpietarios);


        public void altaPropietario(List<DtoPropietario> listaPropietarios);
        
        }
}
