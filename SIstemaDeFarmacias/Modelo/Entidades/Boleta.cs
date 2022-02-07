using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Entidades
{
    public class Boleta
    {
        [Key]
        public int num_boleta { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public decimal sub_Total { get; set; }
        public decimal Total { get; set; }

        public OrdenPedido OrdenPedido { get; set; }
        public int num_OrdenPedido { get; set; }
    }
}
