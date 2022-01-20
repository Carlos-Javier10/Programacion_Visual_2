using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades
{
    public class Boleta
    {
        [Key]
        public string num_boleta { get; set; }
        public DateTime Fecha { get; set; }
        public string cod_Emple { get; set; }
        public string cod_Clie { get; set; }
        public string num_OrdenPedido { get; set; }
        public decimal sub_Total { get; set; }
        public decimal descuento { get; set; }
        public decimal Total { get; set; }

        public List<OrdenPedido> OrdenesPedidos { get; set; }
    }
}
