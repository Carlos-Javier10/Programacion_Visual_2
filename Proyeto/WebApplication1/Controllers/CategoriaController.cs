using Microsoft.AspNetCore.Mvc;
using Proyecto.Entidades;
using ProyectoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly Conexion db;
        public CategoriaController(Conexion db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
