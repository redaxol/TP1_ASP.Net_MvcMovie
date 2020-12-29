/*using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
*/



using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            //return "This is my default action...";
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int ID = 1)
        {
            //return "This is the Welcome action method...";
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
            //return HtmlEncoder.Default.Encode($"Bonjour {name}, ID: {ID}");
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

            ViewData["Message"] = "Hello " + name;
            ViewData["ID"] = ID;

            return View();
        }
    }
}