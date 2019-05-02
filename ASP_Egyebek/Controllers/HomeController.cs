using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_Egyebek.Models;
using ASP_Egyebek.Data;

namespace ASP_Egyebek.Controllers
{
    public class HomeController : Controller
    {
        TodoRepository repo;
        public HomeController(TodoRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            TodoDay newday = new TodoDay();
            newday.Date = DateTime.Now;
            newday.Todos.Add(new Todo()
            {
                Name = "almaszedés",
                Hours = 3,
            });
            newday.Todos.Add(new Todo()
            {
                Name = "porszívózás",
                Hours = 5,
            });
            repo.TodoDays.Add(newday);
            repo.SaveChanges();



            return View();
        }

        public IActionResult About()
        {

            var abc = repo.TodoDays.First();

            return View();
        }

        public string AddPerson(string name)
        {
            repo.Persons.Add(new Person() { Name = name });
            repo.SaveChanges();
            if (repo.Persons.Last().Name == name)
            {
                return "ok_" + repo.Persons.Last().PersonId;
            }
            else
            {
                return "error";
            }
        }

        public JsonResult GetPersons()
        {
            return new JsonResult(repo.Persons);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
