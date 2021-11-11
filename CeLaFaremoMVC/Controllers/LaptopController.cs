using CeLaFaremoMVC.Data;
using CeLaFaremoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CeLaFaremoMVC.Controllers
{
    public class LaptopController : Controller
    {
        // il controller una volta ricevuta una richiesta a chi si deve collegare?
        // quindi andiamo a collegarci al Data/DbContext
        private readonly ApplicationDbContext _db;

        // quindi una volta che abbiamo letto il dbcontext
        // facciamo u costruttore vuoto per collegarci al db
        // questo db poi lo useremo per collegarci alla "tabella" che vogliamo del nostro database
        public LaptopController(ApplicationDbContext db)
        { 
            _db = db;
        }

        public IActionResult Index()
        {
            // quindi andiamo a prendere la collection delle proprieta' della nostra classe che vogliamo usare qui
            IEnumerable<Laptop> objList = _db.Laptops;
            return View(objList);
        }

        // GET CREATE
        public IActionResult Create()
        {
            return View();
        }

        // POST CREATE
        [HttpPost]
        public IActionResult Create(Laptop obj)
        {
            _db.Laptops.Add(obj);
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
            var obj = _db.Laptops.Find(id);
            if (obj == null)
            {
                return NotFound();
            };
            return View(obj);
        }

        // POST DELETE
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Laptops.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Laptops.Remove(obj);
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
            var obj = _db.Laptops.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        // POST UPDATE
        public IActionResult UpdatePost(Laptop obj)
        {
            if (ModelState.IsValid)
            {
                _db.Laptops.Update(obj);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
