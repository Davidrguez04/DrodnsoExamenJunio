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
    /// Interfaz que contiene los métodos de los ficheros
    /// </summary>
    internal interface FicherosInterfaz
    {
        public void crearFicheroLog(string mensaje, string ruta);

        public void cargaInicialFiVehiculo(string ruta, List<DtoVehiculo> listaVehiculos);


        public void cargaInicialFiPropietario(string ruta, List<DtoPropietario> listaPropietarios);
        
        }
}
