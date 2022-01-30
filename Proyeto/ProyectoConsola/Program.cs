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
            Carga carga = new Carga();
            carga.Datos();
        }
    }
}
