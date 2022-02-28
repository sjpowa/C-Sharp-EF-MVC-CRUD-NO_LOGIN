using CeLaFaremoMVC.Data;
using CeLaFaremoMVC.Enums;
using CeLaFaremoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CeLaFaremoMVC.Controllers
{
    public class ElectronicController : Controller
    {
        // per ottenere i nostri dati dal database e poi mostrarli tramite le View
        // dobbiamo passare dal controller usando la dependency injection

        // iniziamo scrivendo un private ApplicationDbContext chiamato _db
        private readonly ApplicationDbContext _db;

        // ora abbiamo bisogno di un costruttore dove poi prenderemo il database context
        public ElectronicController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET LIST
        public IActionResult Index()
        {
            IEnumerable<Electronic> objList = _db.Electronics;

            return View(objList);
        }

        // con questa view io dopo il click su Create vado a far mostrare la pagina con il form del Create
        // ma non vado ad effettuare la Post... quindi qui non va nessun httpPost ie-KTM
        // Get Create Electronic Form / Page Form

        // GET CREATE
        public IActionResult Create()
        {
            return View();
        }

        // POST CREATE
        [HttpPost]
        public IActionResult Create(Electronic obj, Categories cat)
        {
            _db.Electronics.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET DELETE
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Electronics.Find(id);
            if (obj == null)
            {
                return NotFound();
            }   
            return View(obj);
        }

        // POST DELETE
        [HttpPost]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Electronics.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Electronics.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET UPDATE
        public IActionResult Update(int? id)
        {
            if (id == 0 || id == null)
            {
                return NotFound();
            }
            var obj = _db.Electronics.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST UPDATE
        [HttpPost]
        public IActionResult UpdatePost(Electronic obj)
        {
            if (ModelState.IsValid)
            {
                _db.Electronics.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
