using System;
using Proyecto.Entidades;
using System.Collections.Generic;

namespace CargaDatos
{
    public class Class1
    {
        private const double V = 12.5;

        public enum ListaTipo
        {
            Boletas, Categorias, Clientes, DetalleOrdenPedidos, Distritos,
            Empleados,OrdenPedidos,Presentaciones, Productos,Proveedores, Usuarios
        };

        public Dictionary<ListaTipo, object> CargaDatos()
        {
            //lista de boleta

            //lista de categorias
            #region
            Categoria aspirina = new Categoria()
            {
                nom_Descripcion = "medicamento para tratar el dolor",
            };
            List<Categoria> listacategorias = new List<Categoria>() { aspirina};
            #endregion
            //lista de clientes

            //lista de DetalleOrdenPedido

            //lista de Distritos
            #region
            Distrito Quito = new Distrito() {nom_Distrito = "Quito" };
            Distrito Montufar = new Distrito() {nom_Distrito = "Montufar" };
            Distrito Esmeraldas = new Distrito() {nom_Distrito = "Esmeraldas" };
            Distrito Quininde = new Distrito() {nom_Distrito = "Quininde" };
            Distrito Ibarra = new Distrito() {nom_Distrito = "Ibarra" };
            Distrito Pimampiro = new Distrito() {nom_Distrito = "Pimampiro" };
            Distrito Cotacachi = new Distrito() {nom_Distrito = "Cotacachi" };
            Distrito Cayambe = new Distrito() {nom_Distrito = "Cayambe" };
            Distrito Mejia = new Distrito() {nom_Distrito = "Mejia" };
            Distrito Sigchos = new Distrito() {nom_Distrito = "Sigchos" };
            Distrito Pangua = new Distrito() {nom_Distrito = "Pangua" };
            Distrito Pujili = new Distrito() {nom_Distrito = "Pujili" };
            Distrito Baños = new Distrito() {nom_Distrito = "Baños" };

            List<Distrito> listadistrito = new List<Distrito>() { Quito, Montufar, Esmeraldas, Quininde, Ibarra, Pimampiro, Cotacachi, Cayambe, Mejia, Sigchos, Pangua, Pujili, Baños };
            #endregion

            //lista de Empleados

            //lista de OrdenPedidos

            //lista de Presentacion
            #region
            Presentacion Bayer = new Presentacion() { nom_Presentacion = "Bayer" };
            List<Presentacion> listapresentacion = new List<Presentacion>() { Bayer };
             #endregion
            //lista de Proveedor
            Proveedor TecnandinaSA = new Proveedor()
            {
                nom_Proveedor = " Tecnandina",
                direc_Proveedor = "Av. Manuel Cordova Galarza KM 6.5",
                Telefono = 2278456,
                Celular = "0987455478",
                Distrito = Quito
            };
            Proveedor ANHEXA = new Proveedor()
            {
                nom_Proveedor = "ANHEXA",
                direc_Proveedor = "Jose Luis Tamayo #1025 y Lizardo Garcia Edificio Tamagar, 2",
                Telefono = 2235474,
                Celular = "0978412458",
                Distrito = Montufar
            };

            List<Proveedor> listaproveedor = new List<Proveedor>() { TecnandinaSA };
            //lista de Producto 
            Producto Aspirina = new Producto()
            {
                nom_Producto = "Aspirina",
                precio_Venta = new decimal(12.5),
                fecha_Venc = new DateTime(2023-12-12),
                Stock = 50,
                Presentacion = Bayer,
                Categoria = aspirina,
                Proveedor = TecnandinaSA
            };
           

            //lista de usuario



            Dictionary<ListaTipo, object> dicListaDatos = new Dictionary<ListaTipo, object>()
            {
                {ListaTipo.Boletas, listaboletas },
                {ListaTipo.Categorias, listacategorias },
                {ListaTipo.Clientes, listaclie },
                {ListaTipo.DetalleOrdenPedidos, listadeta },
                {ListaTipo.Distritos, listadistrito },
                {ListaTipo.Empleados, listaem },
                {ListaTipo.OrdenPedidos, listaorde },
                {ListaTipo.Presentaciones, listapresentacion },
                {ListaTipo.Productos, listadistrito },
                {ListaTipo.Proveedores, listaproveedor },
                {ListaTipo.Usuarios, listau },
            };
            return dicListaDatos;
        }
    }
}
