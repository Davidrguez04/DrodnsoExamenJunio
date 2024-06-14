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
    /// Clase que contiene los métodos de uso de ficheros de la app
    /// </summary>
    internal class FicherosImplementacion:FicherosInterfaz
    {
        //Método que crea un fichero Log con las opciones que se van introduciendo por consola en el menú
        public void crearFicheroLog(string mensaje, string ruta)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(ruta, true);
                sw.WriteLine(mensaje);
            }catch (Exception ex)
            {
                Console.WriteLine("ERROR" + ex);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }

        }

        //Método de carga del fichero para guardar los datos del objeto vehículo
        public void cargaInicialFiVehiculo(string ruta, List<DtoVehiculo>listaVehiculos)
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string line in lineas)
                {
                    string[] vehiculos = line.Split(":");

                    DtoVehiculo vehiculo = new DtoVehiculo();

                    vehiculo.Matricula = vehiculos[0];
                    vehiculo.FchMatriculacion = Convert.ToDateTime(vehiculos[1]);

                    listaVehiculos.Add(vehiculo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\tNo se abre el fichero " + ex);
            }
        }

        //Método que carga el fichero datosIniciales para coger los datos del propietario
        public void cargaInicialFiPropietario(string ruta, List<DtoPropietario> listaPropietarios)
        {
            try
            {
                string[] lineas = File.ReadAllLines(ruta);
                
                foreach (string line in lineas)
                {
                    string[] propietarios = line.Split(":");

                    string dni = propietarios[2];
                    DateTime fchCompra= Convert.ToDateTime(propietarios[3]);
                    string matricula = propietarios[0];

                    DtoPropietario propietario= new DtoPropietario(dni, fchCompra, matricula);

                    listaPropietarios.Add(propietario);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\tNo se abre el fichero " + ex);
            }
        }

    }
}
