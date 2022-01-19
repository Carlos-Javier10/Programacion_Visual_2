using System;
using System.Collections.Generic;
using System.Text;

namespace Proyeto.Entidades
{
    public class Proveedor
    {
        public string cod_Proveedor { get; set; }
        public string nom_Proveedor { get; set; }
        public string direc_Proveedor { get; set; }
        public int Telefono { get; set; }
        public string Celular { get; set; }
        public string cod_distrito { get; set; }

        public List<Distrito> Distritos { get; set; }
    }
}
