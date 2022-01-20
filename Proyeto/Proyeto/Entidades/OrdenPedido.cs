using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades
{
    public class OrdenPedido
    { 
        [Key]
        public string Num_ordenPerdido { get; set; }
        public DateTime Fecha { get; set; }
        public string cod_Cliente { get; set; }
        public string nom_Clinete { get; set; }
        public string cod_empleado { get; set; }
        public string cod_tipoPago { get; set; }
        public int total { get; set; }

        public List<Cliente> Clientes { get; set; }
        public List<Empleado> Empleados { get; set; }

    }
}
