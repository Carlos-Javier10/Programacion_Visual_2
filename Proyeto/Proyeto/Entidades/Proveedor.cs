using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades
{
    public class Proveedor
    {
        [Key]
        public string cod_Proveedor { get; set; }
        public string nom_Proveedor { get; set; }
        public string direc_Proveedor { get; set; }
        public int Telefono { get; set; }
        public string Celular { get; set; }
        public string cod_distrito { get; set; }

        public List<Distrito> Distritos { get; set; }
    }
}
