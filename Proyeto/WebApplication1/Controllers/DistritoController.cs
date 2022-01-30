using Microsoft.AspNetCore.Mvc;
using System;
using ProyectoDB;
using Proyecto.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class DistritoController : Controller
    {
        private readonly Conexion db;
        public BoletaController(Conexion db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
