using Microsoft.AspNetCore.Mvc;
using System;
using ProyectoDB;
using Proyecto.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Conexion db;
        public UsuarioController(Conexion db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
