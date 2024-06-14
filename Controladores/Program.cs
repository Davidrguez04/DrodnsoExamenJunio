/**/

using DrodnsoExamenJunio.Dtos;
using DrodnsoExamenJunio.Servicios;

namespace DrodnsoExamenJunio.Controladores
{
    /// <summary>
    /// David Rodriguez Alonso - 14/06/2024
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        public static DateTime fechaHoy = DateTime.Now;
        public static string hoy=fechaHoy.ToString("ddMMyyyy");
        public static string rutaLog = "C:\\Users\\David\\source\\repos\\DrodnsoExamenJunio\\Logs\\log-" + hoy + ".txt";
        public static string rutaFichero = "C:\\Users\\David\\source\\repos\\DrodnsoExamenJunio\\bin\\Debug\\net6.0\\datosIniciales.txt";

        /// <summary>
        /// David Rodriguez Alonso - 14/06/2024
        /// Método principal que controla el orden y ejecucion del programa
        /// </summary>
        static void Main(string[] args)
        {
            FicherosInterfaz fi=new FicherosImplementacion();
            MenuInterfaz mn=new MenuImplementacion();
            OperativaInterfaz op=new OperativaImplementacion();

            List<DtoPropietario> listaPropietarios = new List<DtoPropietario>();
            List<DtoVehiculo>listaVehiculos=new List<DtoVehiculo>();

            int opcionSeleccionada = 0;
            bool salirMenu = false;

            fi.cargaInicialFiVehiculo(rutaFichero, listaVehiculos);
            fi.cargaInicialFiPropietario(rutaFichero, listaPropietarios);

            while (!salirMenu){
                opcionSeleccionada = mn.mostrarMenu();

                switch( opcionSeleccionada )
                {
                    case 0:
                        fi.crearFicheroLog("Opcion salir", rutaLog);
                        salirMenu = true;
                        break;

                    case 1:
                        fi.crearFicheroLog("Opcion mostrar Históricos", rutaLog);
                        op.mostrarHistoricos(listaVehiculos, listaPropietarios);
                        break;

                    case 2:
                        fi.crearFicheroLog("Opcion alta nuevo propietario", rutaLog);
                        op.altaPropietario(listaPropietarios);
                        break;

                    default:
                        fi.crearFicheroLog("ERROR!! Opcion incorrecta", rutaLog);
                        Console.WriteLine("\n\tError!! Opción introducida incorrecta!!!");
                        break;

                }
            }



        }
    }
}
