using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades
{
    public class Usuario
    {
        public string cod_Usuario { get; set; }
        public string cod_Emple { get; set; }
        public string nivel_Us { get; set; }
        public string password { get; set; }
        public string activo { get; set; }

        public List<Empleado> Empleados { get; set; }
    }
}
