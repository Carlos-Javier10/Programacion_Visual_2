using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Entidades
{
    public class OrdenPedido
    { 
        [Key]
        public int num_ordenPedido { get; set; }
        public DateTime Fecha { get; set; }
        public string cod_tipoPago { get; set; }
        public decimal total { get; set; }


        public Cliente Cliente { get; set; }
        public int cod_Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public int cod_Empleado { get; set; }
        public List<Boleta> Boleta { get; set; }

    }
}
