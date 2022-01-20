using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades
{
    public class Distrito
    {
    [Key]
        public string cod_Distrito { get; set; }
        public string nom_Distrito { get; set; }
    }
}
