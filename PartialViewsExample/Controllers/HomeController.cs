using Microsoft.AspNetCore.Mvc;
using PartialViewsExample.Models;

namespace PartialViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["ListTitle"] = "Cities";
            ViewData["ListItems"] = new List<string>()
            {
                "Paris",
                "New York",
                "New Dumbai",
                "Viet Nam"
            };

            return View();
        }

        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }

        [Route("programming-languages")]
        public IActionResult ProgrammingLanguages()
        {
            var listModel = new ListModel();
            listModel.ListTitle = "Programming Languages List";
            listModel.ListItems = new List<string>() 
            { 
               "Java", "C#", "C/C++"     
            };

            return PartialView("_ListPartialView", listModel);
        }
    }
}
