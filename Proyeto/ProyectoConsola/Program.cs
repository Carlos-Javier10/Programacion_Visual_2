using System;
using System.Collections.Generic;
using Proyecto.Entidades;
using ProyectoDB;

namespace ProyectoConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            //creacion de usuarios
            Usuario admin = new Usuario() { activo="si", cod_Emple}


            //Creacion de Distritos
            Distrito Quito = new Distrito() { cod_Distrito = "001", nom_Distrito="Quito" };
            Distrito Montufar = new Distrito() { cod_Distrito = "002", nom_Distrito = "Montufar" };
            Distrito Esmeraldas = new Distrito() { cod_Distrito = "003", nom_Distrito = "Esmeraldas" };
            Distrito Quininde = new Distrito() { cod_Distrito = "004", nom_Distrito = "Quininde" };
            Distrito Ibarra= new Distrito() { cod_Distrito = "005", nom_Distrito = "Ibarra" };
            Distrito Pimampiro = new Distrito() { cod_Distrito = "006", nom_Distrito = "Pimampiro" };
            Distrito Cotacachi = new Distrito() { cod_Distrito = "007", nom_Distrito = "Cotacachi" };
            Distrito Cayambe = new Distrito() { cod_Distrito = "008", nom_Distrito = "Cayambe" };
            Distrito Mejia = new Distrito() { cod_Distrito = "009", nom_Distrito = "Mejia" };
            Distrito Sigchos = new Distrito() { cod_Distrito = "010", nom_Distrito = "Sigchos" };
            Distrito Pangua = new Distrito() { cod_Distrito = "011", nom_Distrito = "Pangua" };
            Distrito Pujili = new Distrito() { cod_Distrito = "012", nom_Distrito = "Pujili" };
            Distrito Baños = new Distrito() { cod_Distrito = "013", nom_Distrito = "Baños" };

            //creacion de lista de distritos
            List<Distrito> listaDistrito = new List<Distrito> { Quito, Montufar, Esmeraldas, Quininde, Ibarra, Pimampiro, Cotacachi, Cayambe, Mejia, Sigchos, Pangua, Pujili, Baños };

            Conexion conex = new Conexion();
            conex.Distritos.AddRange(listaDistrito);
            conex.SaveChanges();


        }
    }
}
