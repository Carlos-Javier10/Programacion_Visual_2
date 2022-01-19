using System;
using System.Collections.Generic;
using System.Text;

namespace Proyeto.Entidades
{
    public class Producto
    {
        public string cod_Producto { get; set; }
        public string nom_Producto { get; set; }
        public string precio_Venta { get; set; }
        public string precio_Compra { get; set; }
        public DateTime fecha_Venc { get; set; }
        public int Stock { get; set; }
        public string cod_Cate { get; set; }
        public string cod_Prov { get; set; }
        public string cod_Pres { get; set; }

        public List<Categoria> Categorias { get; set; }
        public List<Proveedor> Proveedores { get; set; }
        public List<Presentacion> Presentaciones { get; set; }
    }
}
