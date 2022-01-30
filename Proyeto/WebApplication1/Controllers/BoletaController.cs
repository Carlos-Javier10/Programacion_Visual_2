using Microsoft.AspNetCore.Mvc;
using ProyectoDB;
using Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class BoletaController : Controller
    {
        private readonly Conexion db;

        public IActionResult Index()
        {
            return View();
        }
    }
}
