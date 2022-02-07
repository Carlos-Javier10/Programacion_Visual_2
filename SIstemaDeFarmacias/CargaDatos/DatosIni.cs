using System;
using Modelo.Entidades;
using System.Collections.Generic;

namespace CargaDatos
{
    public class DatosIni
    {
        public enum ListaTipo
        {
            Boletas, Categorias, Clientes, DetalleOrdenPedidos, Distritos,
            Empleados, OrdenPedidos, Presentaciones, Productos, Proveedores, Usuarios
        };

        public Dictionary<ListaTipo, object> CargaDatos()
        {

            //lista de categorias
            #region
            Categoria aspirina = new Categoria()
            {
                nom_Descripcion = "medicamento para tratar el dolor",
            };
            Categoria diclofenaco = new Categoria()
            {
                nom_Descripcion = "tratamiento de artrosis"
            };
            Categoria digoxina = new Categoria()
            {
                nom_Descripcion = "antiarrítmico"
            };
            Categoria dimercaprol = new Categoria()
            {
                nom_Descripcion = "medicamento quelante",
            };
            Categoria ibuprofeno = new Categoria()
            {
                nom_Descripcion = "medicamento antiinflamatorio"
            };
            Categoria levofloxacina = new Categoria()
            {
                nom_Descripcion = "medicamento antibiotico"
            };
            Categoria paracetamol = new Categoria()
            {
                nom_Descripcion = "medicamento analgesico para la fiebre y dolor leve"
            };
            Categoria metotrexato = new Categoria()
            {
                nom_Descripcion = "medicamento analogo bloque la sisntesis de purinas"
            };

            List<Categoria> listacategorias = new List<Categoria>() { aspirina };
            #endregion
            //lista de Distritos
            #region
            Distrito Quito = new Distrito() { nom_Distrito = "Quito" };
            Distrito Montufar = new Distrito() { nom_Distrito = "Montufar" };
            Distrito Esmeraldas = new Distrito() { nom_Distrito = "Esmeraldas" };
            Distrito Quininde = new Distrito() { nom_Distrito = "Quininde" };
            Distrito Ibarra = new Distrito() { nom_Distrito = "Ibarra" };
            Distrito Pimampiro = new Distrito() { nom_Distrito = "Pimampiro" };
            Distrito Cotacachi = new Distrito() { nom_Distrito = "Cotacachi" };
            Distrito Cayambe = new Distrito() { nom_Distrito = "Cayambe" };
            Distrito Mejia = new Distrito() { nom_Distrito = "Mejia" };
            Distrito Sigchos = new Distrito() { nom_Distrito = "Sigchos" };
            Distrito Pangua = new Distrito() { nom_Distrito = "Pangua" };
            Distrito Pujili = new Distrito() { nom_Distrito = "Pujili" };
            Distrito Baños = new Distrito() { nom_Distrito = "Baños" };

            List<Distrito> listadistrito = new List<Distrito>() { Quito, Montufar, Esmeraldas, Quininde, Ibarra, Pimampiro, Cotacachi, Cayambe, Mejia, Sigchos, Pangua, Pujili, Baños };
            #endregion
            //lista de clientes
            #region
            Cliente Javier = new Cliente()
            {
                nom_Clinete = "Javier",
                direc_Cliente = "Checa",
                Distrito = Quito,
                sexo = "m",
                DNI = 1745784785,
                RUC = 101745784785,
                Telefono = 2478554,
                Celular = "0985477845"
            };
            Cliente Juan = new Cliente()
            {
                nom_Clinete = "Juan",
                direc_Cliente = "El Quinche",
                Distrito = Mejia,
                sexo = "m",
                DNI = 1778547855,
                RUC = 101778547855,
                Telefono = 2241542,
                Celular = "0995745996"
            };
            Cliente Maria = new Cliente()
            {
                nom_Clinete = "Maria",
                direc_Cliente = "Pifo",
                Distrito = Quito,
                sexo = "f",
                DNI = 1711784451,
                RUC = 101711784451,
                Telefono = 2235325,
                Celular = "0987478512"
            };

            List<Cliente> listacliente = new List<Cliente>() { Javier, Juan, Maria };
            #endregion
            //lista de Empleados
            #region
            Empleado Carlos = new Empleado()
            {
                nom_Empleado = "Carlos",
                direc_Empleado = "Checa",
                Distrito = Quito,
                Cargo = "Admin",
                Edad = "20",
                Telefono = 2245417,
                Celular = "0987457547",
                Ingreso = new DateTime(2021 - 02 - 02),
                Clave = "carlos123"
            };
            //Empleado Marco = new Empleado()
            //{
            //    nom_Empleado = "Marco",
            //    direc_Empleado = "Tumbaco",
            //    Distrito = Quito,
            //    Cargo = "User",
            //    Edad = "21",
            //    Telefono = 2245414,
            //    Celular = "0984745618",
            //    Ingreso = new DateTime(2021 - 02 - 04),
            //    Clave = "marco123"
            //};

            List<Empleado> listaempleado = new List<Empleado>() { Carlos};
            #endregion
            //lista de OrdenPedidos
            #region
            OrdenPedido p1 = new OrdenPedido()
            {
                Fecha = new DateTime(2022 - 02 - 10),
                Cliente = Javier,
                Empleado = Carlos,
                cod_tipoPago = "efectivo",
                total = new decimal(1.5)

            };

            List<OrdenPedido> listaordenpedido = new List<OrdenPedido>() { p1 };
            #endregion
            //lista de Presentacion
            #region
            Presentacion Bayer = new Presentacion() { nom_Presentacion = "Bayer" };
            Presentacion Laboratorio_Chile = new Presentacion() { nom_Presentacion = "Laboratorio Chile" };
            Presentacion MK = new Presentacion() { nom_Presentacion = "MK" };
            Presentacion BAL = new Presentacion() { nom_Presentacion = "B.A.L" };


            List<Presentacion> listapresentacion = new List<Presentacion>() { Bayer, Laboratorio_Chile };
            #endregion
            //lista de Proveedor
            #region
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
            Proveedor Abbott = new Proveedor()
            {
                nom_Proveedor = "Abbott",
                direc_Proveedor = "Apartado 09-01-1292 Calicuchima 601",
                Telefono = 2145457,
                Celular = "0999478525",
                Distrito = Ibarra
            };
            Proveedor Baxter = new Proveedor()
            {
                nom_Proveedor = "Baxter",
                direc_Proveedor = "Casilla 17-17-1837 Diguja 190 y Vozandes",
                Telefono = 2278456,
                Celular = "0987455478",
                Distrito = Cayambe
            };
            Proveedor Calox = new Proveedor()
            {
                nom_Proveedor = "Calox",
                direc_Proveedor = "Panamericana Norte No. 10265",
                Telefono = 2354415,
                Celular = "0989741458",
                Distrito = Sigchos
            };

            List<Proveedor> listaproveedor = new List<Proveedor>() { TecnandinaSA };
            #endregion
            //lista de Producto 
            #region
            Producto Aspirina = new Producto()
            {
                nom_Producto = "Aspirina",
                precio_Venta = new decimal(0.5),
                fecha_Venc = new DateTime(2023 - 12 - 12),
                Stock = 50,
                Presentacion = Bayer,
                Categoria = aspirina,
                Proveedor = TecnandinaSA
            };
            Producto Diclofenaco = new Producto()
            {
                nom_Producto = "Diclofenaco",
                precio_Venta = new decimal(1.5),
                fecha_Venc = new DateTime(2023 - 11 - 12),
                Stock = 40,
                Presentacion = Laboratorio_Chile,
                Categoria = diclofenaco,
                Proveedor = Calox
            };
            Producto Digoxina = new Producto()
            {
                nom_Producto = "Digoxina",
                precio_Venta = new decimal(2.5),
                fecha_Venc = new DateTime(2024 - 12 - 12),
                Stock = 55,
                Presentacion = Laboratorio_Chile,
                Categoria = digoxina,
                Proveedor = Abbott
            };
            Producto Dimercaprol = new Producto()
            {
                nom_Producto = "Dimercaprol",
                precio_Venta = new decimal(2.5),
                fecha_Venc = new DateTime(2023 - 07 - 12),
                Stock = 65,
                Presentacion = BAL,
                Categoria = dimercaprol,
                Proveedor = ANHEXA
            };
            Producto Ibuprofeno = new Producto()
            {
                nom_Producto = "Ibuprofeno",
                precio_Venta = new decimal(1.65),
                fecha_Venc = new DateTime(2023 - 07 - 12),
                Stock = 85,
                Presentacion = BAL,
                Categoria = ibuprofeno,
                Proveedor = Calox
            };
            Producto Levofloxacina = new Producto()
            {
                nom_Producto = "Levofloxacina",
                precio_Venta = new decimal(4.5),
                fecha_Venc = new DateTime(2023 - 09 - 12),
                Stock = 15,
                Presentacion = MK,
                Categoria = levofloxacina,
                Proveedor = Baxter
            };
            Producto Paracetamol = new Producto()
            {
                nom_Producto = "Paracetamol",
                precio_Venta = new decimal(1.8),
                fecha_Venc = new DateTime(2023 - 04 - 12),
                Stock = 96,
                Presentacion = MK,
                Categoria = paracetamol,
                Proveedor = ANHEXA
            };
            Producto Metotrexato = new Producto()
            {
                nom_Producto = "Metotrexato",
                precio_Venta = new decimal(3.55),
                fecha_Venc = new DateTime(2023 - 02 - 12),
                Stock = 44,
                Presentacion = Laboratorio_Chile,
                Categoria = metotrexato,
                Proveedor = Abbott
            };

            List<Producto> listaproducto = new List<Producto>() { Aspirina, Diclofenaco, Digoxina, Dimercaprol, Ibuprofeno, Levofloxacina,
                Paracetamol, Metotrexato};
            #endregion
            //lista de DetalleOrdenPedido
            #region
            DetalleOrdenPedido dpaspirina = new DetalleOrdenPedido()
            {
                Producto = Aspirina,
                Catidad = 30,
                precio_venta = new decimal(12.5),
                importe = new decimal(0.12)
            };
            DetalleOrdenPedido dpdiclofenato = new DetalleOrdenPedido()
            {
                Producto = Diclofenaco,
                Catidad = 40,
                precio_venta = new decimal(15.5),
                importe = new decimal(0.12)
            };
            DetalleOrdenPedido dpdigoxina = new DetalleOrdenPedido()
            {
                Producto = Digoxina,
                Catidad = 45,
                precio_venta = new decimal(22.5),
                importe = new decimal(0.14)
            };
            DetalleOrdenPedido dpdimercaprol = new DetalleOrdenPedido()
            {
                Producto = Dimercaprol,
                Catidad = 30,
                precio_venta = new decimal(12.5),
                importe = new decimal(0.12)
            };
            DetalleOrdenPedido dpibuprofeno = new DetalleOrdenPedido()
            {
                Producto = Ibuprofeno,
                Catidad = 63,
                precio_venta = new decimal(10.5),
                importe = new decimal(0.14)
            };
            DetalleOrdenPedido dplevofloxacina = new DetalleOrdenPedido()
            {
                Producto = Levofloxacina,
                Catidad = 25,
                precio_venta = new decimal(8.5),
                importe = new decimal(0.12)
            };
            DetalleOrdenPedido dpparacetamol = new DetalleOrdenPedido()
            {
                Producto = Paracetamol,
                Catidad = 26,
                precio_venta = new decimal(10.7),
                importe = new decimal(0.12)
            };
            DetalleOrdenPedido dpmetotrexato = new DetalleOrdenPedido()
            {
                Producto = Metotrexato,
                Catidad = 40,
                precio_venta = new decimal(17.2),
                importe = new decimal(0.14)
            };

            List<DetalleOrdenPedido> listadetalleOrdenPedidos = new List<DetalleOrdenPedido>() { dpaspirina, dpdiclofenato, dpdigoxina, dpdimercaprol,
                    dpibuprofeno, dplevofloxacina, dpparacetamol, dpmetotrexato};
            #endregion
            //lista de usuario
            #region
            Usuario carlos = new Usuario()
            {
                Empleado = Carlos,
                nivel_Us = 1,
                nom_Usuario = "Carlos",
                password = "1234",
                activo = "si"
            };
            //Usuario marco = new Usuario()
            //{
            //    Empleado = Marco,
            //    nivel_Us = 2,
            //    nom_Usuario = "Marco",
            //    password = "1234",
            //    activo = "si"
            //};

            List<Usuario> listausuario = new List<Usuario>() { carlos };
            #endregion
            //lista de boleta
            #region
            Boleta b1 = new Boleta()
            {
                Fecha = new DateTime(2022 - 02 - 12),
                OrdenPedido = p1,
                sub_Total = new decimal(12.5),
                Total = new decimal(13)
            };

            List<Boleta> listaboleta = new List<Boleta>() { b1 };
            #endregion

            Dictionary<ListaTipo, object> dicListaDatos = new Dictionary<ListaTipo, object>()
                {
                    {ListaTipo.Boletas, listaboleta },
                    {ListaTipo.Categorias, listacategorias },
                    {ListaTipo.Clientes, listacliente },
                    {ListaTipo.DetalleOrdenPedidos, listadetalleOrdenPedidos },
                    {ListaTipo.Distritos, listadistrito },
                    {ListaTipo.Empleados, listaempleado },
                    {ListaTipo.OrdenPedidos, listaordenpedido },
                    {ListaTipo.Presentaciones, listapresentacion },
                    {ListaTipo.Productos, listaproducto },
                    {ListaTipo.Proveedores, listaproveedor },
                    {ListaTipo.Usuarios, listausuario },
                };
            return dicListaDatos;
        }
    }
}