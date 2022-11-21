using CrudData.Data;
using CrudData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CrudData.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationContext context;

        //dependancy injection will enject that will pass to contructor
        public CategoryController(ApplicationContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> obj = context.Categories;
            return View(obj);
        }
        //this is for get--Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            context.Categories.Add(obj);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            if (id == null||id==0)
            {
                return NotFound();
            }
            var obj = context.Categories.Find(id);
            if(obj==null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            var obj = context.Categories.Find(id);
            if(obj== null)
            {
                return NotFound();
            }
            context.Categories.Remove(obj);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = context.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult EditPost(Category obj)
        {
            context.Categories.Update(obj);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
