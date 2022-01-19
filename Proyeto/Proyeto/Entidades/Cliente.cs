using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Entidades
{
    public class Cliente
    {
        public string cod_Cliente { get; set; }
        public string nom_Clinete { get; set; }
        public string direc_Cliente { get; set; }
        public string cod_Distr { get; set; }
        public string sexo { get; set; }
        public int DNI { get; set; }
        public int RUC { get; set; }
        public int Telefono { get; set; }
        public string Celular { get; set; }
    }
}
