using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modelo.Entidades
{
    public class DetalleOrdenPedido
    {
        [Key]
        public int num_OrdenPedido { get; set; }
        public int Catidad { get; set; }
        public decimal precio_venta { get; set; }
        public decimal importe { get; set; }

        public Producto Producto { get; set; }
        public int cod_Prodructo { get; set; }
    }
}
