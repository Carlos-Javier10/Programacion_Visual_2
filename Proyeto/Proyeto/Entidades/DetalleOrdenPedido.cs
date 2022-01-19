using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades
{
    public class DetalleOrdenPedido
    {
        public string num_OrdenPedido { get; set; }
        public string cod_Prod { get; set; }
        public string nom_Prod { get; set; }
        public int Catidad { get; set; }
        public decimal precio_venta { get; set; }
        public decimal importe { get; set; }

        public List<Producto> Productos { get; set; }
    }
}
