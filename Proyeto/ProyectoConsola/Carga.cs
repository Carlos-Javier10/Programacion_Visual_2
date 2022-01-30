using CargaDatos;
using Proyecto.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CargaDatos.Class1;

namespace ProyectoConsola
{
    public class Carga
    {
        public void Datos() 
        {
            Class1 datos = new Class1();
            var lista = datos.CargaDatos();

            //diccionario
            var listaCategotias = (List<Categoria>)lista[ListaTipo.Categorias];
            var listaDistrito = (List<Distrito>)lista[ListaTipo.Distritos];
            var listaCliente = (List<Categoria>)lista[ListaTipo.Clientes];
            var listaEmpleado = (List<Categoria>)lista[ListaTipo.Empleados];
            var listaOrdenPedido = (List<Categoria>)lista[ListaTipo.OrdenPedidos];
            var listaPresentacion = (List<Categoria>)lista[ListaTipo.Presentaciones];
            var listaProveedor = (List<Categoria>)lista[ListaTipo.Proveedores];
            var listaProducto = (List<Categoria>)lista[ListaTipo.Productos];
            var listaDetalleOrdenPedido = (List<Categoria>)lista[ListaTipo.DetalleOrdenPedidos];
            var listaUsuario = (List<Categoria>)lista[ListaTipo.Usuarios];
            var listaBoleta = (List<Categoria>)lista[ListaTipo.Boletas];
        }
    }
}
