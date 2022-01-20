﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Proyecto.Entidades
{
    public class Producto
    {
        [Key]
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
        public List<OrdenPedido> OrdenPedidos { get; set; }
    }
}
