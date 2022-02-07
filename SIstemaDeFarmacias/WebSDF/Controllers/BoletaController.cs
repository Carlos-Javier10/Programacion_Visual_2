using Microsoft.AspNetCore.Mvc;
using ModeloDB;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class BoletaController : Controller
    {
        private readonly Conexion db;
        public BoletaController(Conexion db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Boleta> listaboleta = db.Boletas;
            return View(listaboleta);
        }

        //crear boleta
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //guardar
        [HttpPost]
        public IActionResult Create(Boleta boleta)
        {
            db.Boletas.Add(boleta);
            db.SaveChanges();

            TempData["Mensaje"] = $"La Boleta {boleta.num_boleta} ha sido creada";

            return View();
        }

        //editar
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            Boleta boleta = db.Boletas.Find(id);
            return View();
        }

        //eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Boleta boleta = db.Boletas.Find(id);
            return View();
        }
        [HttpPost]
        public IActionResult Delete(Boleta boleta) 
        {
            db.Boletas.Remove(boleta);
            db.SaveChanges();
            TempData["Mensaje"] = $"La Boleta {boleta.num_boleta} ha sido creada";
            return View();
        }
    }
}
