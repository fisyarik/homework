using mvc2.Models.Entities;
using mvc2.Models.ViewModels;
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

        List<Tuple<string, string>> GetGendersList()
        {
            List<Tuple<string, string>> genders = new List<Tuple<string, string>>
    {
        new Tuple<string, string>("ж", "Женский"),
        new Tuple<string, string>("м", "Мужской")
    };
            return genders;
        }

        [HttpGet]
        public ActionResult CreatePerson()
        {
            ViewBag.Genders = new SelectList(GetGendersList(), "Item1", "Item2");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult CreatePerson(PersonVM newPerson)
        {
            if (ModelState.IsValid) // Проверка достоверности модели (валидация и очистка данных)
            {
                using (var context = new MVCEntities()) // Создание контекста для работы с БД
                {
                    //создание объекта нужного класса
                    Person person = new Person
                    {
                        Id = Guid.NewGuid(),
                        LastName = newPerson.LastName,
                        FirstName = newPerson.FirstName,
                        Patronymic = newPerson.Patronymic,
                        Gender = newPerson.Gender,
                        Age = newPerson.Age,
                        HasJob = newPerson.HasJob,
                    };
                    //Добавление объекта в локальную коллекцию
                    context.Person.Add(person);

                    // Синхронизация с источником данных
                    // Объект добавится в БД
                    context.SaveChanges();
                }
                // Перенаправление к методу, который вернёт список людей
                return RedirectToAction("ListOfPeople");
            }
            // Восстановление вспомогательных объектов,
            // если такая использовалась....
            // Возвращение к представлению CreatePerson
            return View(newPerson);
        }


        [HttpGet]
        public ActionResult EditPerson(Guid personID)
        {
            PersonVM model;
            using (var context = new MVCEntities())
            {
                Person person = context.Person.Find(personID);
                model = new PersonVM
                {
                    Id = person.Id,
                    LastName = person.LastName,
                    FirstName = person.FirstName,
                    Patronymic = person.Patronymic,
                    Gender = person.Gender,
                    Age = person.Age,
                    HasJob = person.HasJob,
                    Birthday = DateTime.Now.AddYears(-30),
                    InsertedDateTime = DateTime.Now,
                    WakeUpTime = new DateTime(2023, 1, 1, 8, 30, 0)
                };
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult EditPerson(PersonVM model)
        {
            if (ModelState.IsValid)
            {
                using (var context = new MVCEntities())
                {
                    Person editedPerson = new Person
                    {
                        Id = model.Id,
                        LastName = model.LastName,
                        FirstName = model.FirstName,
                        Patronymic = model.Patronymic,
                        Gender = model.Gender,
                        Age = model.Age,
                        HasJob = model.HasJob
                    };

                    context.Person.Attach(editedPerson);
                    context.Entry(editedPerson).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();

                    return RedirectToAction("ListOfPeople");
                }
            }
            // Восстанавливаем вспомогательные объекты,
            // например, данные для выпадающих списков,
            // если такие имеются
            return View(model);
        }






    }
}
