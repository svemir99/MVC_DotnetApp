using FirsttMvcApps.Filters;
using FirsttMvcApps.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Identity.Client;

namespace FirsttMvcApps.Controllers
{
    public class HomeController : Controller
    {

        [MyAction]
        public IActionResult Index()
        {

            Console.WriteLine("Hello from action method");
            return View();
        }


        [HttpPost]
        public IActionResult Index(Person person)


        {





            if (ModelState.IsValid)
            {

                Attendance.AddAttendant(person);
                TempData["FirstName"] = person.FirstName + " " + person.LastName;

                return RedirectToAction("Index");

            }
            else
            {
                return View();
            }







        }

        public IActionResult AttendantDetails(string firstName, string lastName)
        {
            PeopleContext db = new PeopleContext();
            Person person = db.People.Where(p => p.FirstName.ToLower().Equals(firstName.ToLower()) && p.LastName.ToLower().Equals(lastName.ToLower())).FirstOrDefault();


            if (person == null)
            {
                return NotFound();
            }
            return View("Attendant", person);



        }



        [ResponseCache(Duration = 20)]

        public IActionResult About()
        {
            return View();
        }



    }

}
