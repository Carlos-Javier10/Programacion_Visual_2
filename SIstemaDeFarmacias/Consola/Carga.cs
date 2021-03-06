using CargaDatos;
using Modelo.Entidades;
using ModeloDB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CargaDatos.DatosIni;

namespace Consola
{
    public class Carga
    {
        public void Datos() 
        {
            DatosIni datos = new DatosIni();
            var lista = datos.CargaDatos();

            //diccionario
            var listaCategotias = (List<Categoria>)lista[ListaTipo.Categorias];

            var listaDistrito = (List<Distrito>)lista[ListaTipo.Distritos];
            var listaCliente = (List<Cliente>)lista[ListaTipo.Clientes];
            var listaEmpleado = (List<Empleado>)lista[ListaTipo.Empleados];
            var listaOrdenPedido = (List<OrdenPedido>)lista[ListaTipo.OrdenPedidos];
            var listaPresentacion = (List<Presentacion>)lista[ListaTipo.Presentaciones];
            var listaProveedor = (List<Proveedor>)lista[ListaTipo.Proveedores];
            var listaProducto = (List<Producto>)lista[ListaTipo.Productos];
            var listaDetalleOrdenPedido = (List<DetalleOrdenPedido>)lista[ListaTipo.DetalleOrdenPedidos];
            var listaUsuario = (List<Usuario>)lista[ListaTipo.Usuarios];
            var listaBoleta = (List<Boleta>)lista[ListaTipo.Boletas];

            using (Conexion db = ConexionBuilder.Crear()) 
            {
                db.Empleados.AddRange(listaEmpleado);
                db.Categorias.AddRange(listaCategotias);
                db.Distritos.AddRange(listaDistrito);
                db.Clientes.AddRange(listaCliente);
                db.OrdenPedidos.AddRange(listaOrdenPedido);
                db.Presentaciones.AddRange(listaPresentacion);
                db.Proveedores.AddRange(listaProveedor);
                db.Productos.AddRange(listaProducto);
                db.DetalleOrdenPedidos.AddRange(listaDetalleOrdenPedido);
                db.Usuarios.AddRange(listaUsuario);
                db.Boletas.AddRange(listaBoleta);
                

                db.SaveChanges();
            }       
        }
    }
}
