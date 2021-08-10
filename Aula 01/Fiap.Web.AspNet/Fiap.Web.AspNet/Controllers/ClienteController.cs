using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View("Index2");
        }

        public IActionResult Content()
        {
            return Content("Teste de Content");
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }

        public IActionResult RedirectToRoute()
        {
            return RedirectToRoute( new { controller = "home", action = "index"} );
        }
    }
}
