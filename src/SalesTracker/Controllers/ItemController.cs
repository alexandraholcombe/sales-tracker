using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesTracker.Models;

namespace SalesTracker.Controllers
{
    public class ItemController : Controller
    {
        private SalesTrackerContext db = new SalesTrackerContext();
        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var item = db.Items.FirstOrDefault(items => items.Id == id);
            return View(item);
        }
    }
}
