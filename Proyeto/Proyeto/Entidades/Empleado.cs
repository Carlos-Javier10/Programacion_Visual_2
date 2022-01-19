using System;
using System.Collections.Generic;
using System.Text;

namespace Proyeto.Entidades
{
    public class Empleado
    {
        public string cod_Empleado { get; set; }
        public string nom_Empleado { get; set; }
        public string direc_Empleado { get; set; }
        public string cod_Dis { get; set; }
        public string Cargo { get; set; }
        public string Edad { get; set; }
        public int Telefono { get; set; }
        public string Celular { get; set; }
        public DateTime Ingreso { get; set; }
        public string Clave { get; set; }

        public List<Distrito> Distritos { get; set; }

    }
}

