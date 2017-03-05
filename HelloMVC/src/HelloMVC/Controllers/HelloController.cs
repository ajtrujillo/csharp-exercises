using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index(string name)
        {
            string html = "<form method='post'>" +
                "<input type = 'text' name = 'name'/>" +
                "<select id='langs' name = 'select'>" +
                    "<option value = 'value1'>English</option>" +
                    "<option value = 'value2'>French</option>" +
                    "<option value = 'value3'>German</option>" +
                    "<option value = 'value3'>Spanish</option>" +
                    "<option value = 'value3'>Italian</option>" +
               "</select>" +
                "<input type = 'submit' value = 'Greet me!' />" +
                "</form>";
            //greeting = "langs.Value";
            return Content(html, "text/html");
        }

        [Route("/Hello")]
        [HttpPost]

        public static IActionResult HelloController.CreateMessage(string name, string language);
            class Interpreter { 
                public string language { get; set; }
                public string value { get;, set; }
                }

        class CollInit
        {
            Dictionary<Interpreter, greeting> translation = new Dictionary<Interpreter, greeting>()
            {

            }
            }
}

//public IActionResult Display(string name = "World")
//{
//return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
//}

// Handle requests to /Hello/NAME (URL segment)
//[Route("/Hello/{name}")]
//public IActionResult Index2(string name)
//{
//return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
//}


public IActionResult Goodbye()
{
    return Content("Goodbye");
}
    }
}
