using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrodnsoExamenJunio.Dtos
{
    internal class DtoPropietario
    {
        //Atributos
        int id;
        string dni="aaaaaaaaa";
        DateTime fchCompra;
        string matricula = "aaaaaaa";
        bool esHistorico=false;
        


        //Getter y setters
        public int Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FchCompra { get => fchCompra; set => fchCompra = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }
       


        //Construtores
        public DtoPropietario(string dni, DateTime fchCompra, string matricula)
        {
            
            this.dni = dni;
            this.fchCompra = fchCompra;
            this.matricula = matricula;
            
        }

        public DtoPropietario()
        {
        }

        //Método ToString
        override
            public string ToString()
        {
            string mensaje = "Nuevo propietario: " + this.id + " - " + this.dni;
            return mensaje;
        }

    }
}
