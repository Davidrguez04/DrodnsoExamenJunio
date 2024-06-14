using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrodnsoExamenJunio.Dtos
{
    internal class DtoVehiculo
    {
        //Atributos
        long id;
        string matricula="aaaaaaa";
        DateTime fchMatriculacion;
        TimeSpan diferencia;

        //Getter y setters
        public long Id { get => id; set => id = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FchMatriculacion { get => fchMatriculacion; set => fchMatriculacion = value; }
        public TimeSpan Diferencia { get => diferencia; set => diferencia = value; }


        //Construtores
        public DtoVehiculo()
        {
        }

       
    }
}
