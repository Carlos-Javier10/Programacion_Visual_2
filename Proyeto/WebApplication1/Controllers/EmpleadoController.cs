﻿using Microsoft.AspNetCore.Mvc;
using System;
using ProyectoDB;
using Proyecto.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class EmpleadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
