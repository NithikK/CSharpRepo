using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using MVCTagHelpers.Models;
using System.Diagnostics;
using System.Text;

namespace MVCTagHelpers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)//Constructor based dependency injection
        {
            _configuration = configuration;
            _logger = logger;
        }
        public IActionResult Menu()
        {
            String conString = _configuration.GetConnectionString("DefaultConnection");//just name can shange to testdbconnection too but same as in appsettingsconfig.json
            _logger.Log(LogLevel.Information, conString);//LogLevel is enum
            return View();
        }
        public ActionResult Echo(String name, String city)
        {
            String s1 = "User : " + name + " from City : " + city;
            ViewData.Add("Data1",s1);
            return View();
        }
        public ActionResult SayHello(String name)
        {
            String s1 = ("Hello ") + name;
            ViewData.Add("Data1", s1);
            return View("Echo");
        }
        public IActionResult Index()
        {
            return View();
        }

        //Method Overload
        [HttpPost]
        public ActionResult Index(int x, IFormCollection collection)
        {
            StringBuilder data = new StringBuilder(500);
            data.Append("x : ");
            data.Append(x);
            data.Append(" ");
            data.Append("name : ");
            data.Append(collection["name"]);
            data.Append(" ");
            data.Append("password : ");
            data.Append(collection["password"]);
            //foreach (var item in collection)
            //{
            //    data.Append(item.Key);
            //    data.Append(" : ");
            //    data.Append(item.Value);
            //    data.Append(" ");
            //}

            //very important
            ViewData["x"] = data.ToString();//here it is hard coded //scope limited to controller and view
            //TempData["globalX"] = x; //scope is global across multiple controllers
            return View("IndexPost");
        }
        public ActionResult DoTask(int? id)
        {
            if (id.HasValue)
            {
                ViewData["id"] = id.Value;
            }
            else
            {
                ViewData["id"] = 0;
            }
            return View();
        }
        public ActionResult Test()
        {
            
            return RedirectToAction("Index");
        }

        /*Passing an Object to ViewData*/
        public ActionResult GetBook()
        {
            Book b1 = new Book() { AuthorName = "H Lee" };
            ViewData["book"] = b1;
            return View();
        }
        //All modern web technology use this feature
        [ResponseCache(Duration = 1)]//15 seconds
        public IActionResult GetTime()
        {
            String todate = DateTime.Now.ToLongTimeString();
            ViewData["data"] = todate;
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