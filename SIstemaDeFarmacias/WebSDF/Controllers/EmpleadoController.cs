using Microsoft.AspNetCore.Mvc;
using System;
using ModeloDB;
using Modelo.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebASDF.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly Conexion db;
        public EmpleadoController(Conexion db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
