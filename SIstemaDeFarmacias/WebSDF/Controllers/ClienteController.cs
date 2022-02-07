using Microsoft.AspNetCore.Mvc;
using System;
using ModeloDB;
using Modelo.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSDF.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Conexion db;
        public ClienteController(Conexion db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
