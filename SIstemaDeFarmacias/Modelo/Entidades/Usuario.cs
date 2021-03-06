using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Entidades
{
    public class Usuario
    {
        [Key]
        public int cod_Usuario { get; set; }
        public string nom_Usuario { get; set; }
        public int nivel_Us { get; set; }
        public string password { get; set; }
        public string activo { get; set; }

        public Empleado Empleado { get; set; }
        public int cod_Empleado { get; set; }
    }
}
