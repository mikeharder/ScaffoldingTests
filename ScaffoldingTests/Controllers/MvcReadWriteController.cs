using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScaffoldingTests.Models;

namespace ScaffoldingTests.Controllers
{
    public class MvcReadWriteController : Controller
    {
        private static readonly List<Person> _people = new List<Person> {
            new Person { ID=0, Name="Default", Age=19 }
        };

        // GET: MvcReadWrite
        public ActionResult Index()
        {
            return View(_people);
        }

        // GET: MvcReadWrite/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MvcReadWrite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MvcReadWrite/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var person = new Person
                {
                    ID = Int32.Parse(collection["ID"]),
                    Name = collection["Name"],
                    Age = Int32.Parse(collection["Age"])
                };

                _people.Add(person);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MvcReadWrite/Edit/5
        public ActionResult Edit(int id)
        {
            var person = (from p in _people where p.ID == id select p).SingleOrDefault();
            return View(person);
        }

        // POST: MvcReadWrite/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var person = (from p in _people where p.ID == id select p).SingleOrDefault();

                person.ID = Int32.Parse(collection["ID"]);
                person.Name = collection["Name"];
                person.Age = Int32.Parse(collection["Age"]);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MvcReadWrite/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MvcReadWrite/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
