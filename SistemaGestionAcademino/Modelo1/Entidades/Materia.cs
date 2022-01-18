using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo1.Entidades
{
    public class Materia
    {
        public string Area { get; set; }
        public int Creditos { get; set; }
        //falta 
        public Malla Malla { get; set; }
        public int MateriaId { get; set; }
        public string Nombre { get; set; }
        //falta
    }
}
