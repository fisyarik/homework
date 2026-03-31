using mvc2.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc2.Controllers
{


    public class Lab2Controller : Controller
    {
        // GET: Lab2
        public ActionResult ListOfPeople()
        {
            List<Person> people = new List<Person>();
            using (var db = new MVCEntities())
            {
                people = db.Person.OrderByDescending(x => x.Age)
                    .ThenBy(x => x.LastName)
                    .ThenBy(x => x.FirstName).ToList();
            }
            return View(people);
        }

        [HttpGet]
        public ActionResult PersonDetails(Guid personId)
        {
            Person model = new Person();
            using (var db = new MVCEntities())
            {
                model = db.Person.Find(personId);
            }
            return View(model);
        }

    }
}
