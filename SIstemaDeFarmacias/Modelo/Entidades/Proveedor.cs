using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Entidades
{
    public class Proveedor
    {
        [Key]
        public int cod_Proveedor { get; set; }
        public string nom_Proveedor { get; set; }
        public string direc_Proveedor { get; set; }
        public int Telefono { get; set; }
        public string Celular { get; set; }
        

        public Distrito Distrito { get; set; }
        public int cod_distrito { get; set; }
        public List<Producto> Producto { get; set; }
    }
}
