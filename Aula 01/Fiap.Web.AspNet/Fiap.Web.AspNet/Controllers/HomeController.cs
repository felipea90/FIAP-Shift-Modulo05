using Fiap.Web.AspNet.Data;
using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            context = new DataContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //var produto = context.Produtos
            //    .Include(p => p.ProdutoLoja)
            //    .ThenInclude(l => l.Loja)
            //    .SingleOrDefault(p => p.ProdutoId == 3);

            //var loja = context.Lojas
            //    .Include(l => l.ProdutoLoja)
            //    .ThenInclude(p => p.Produto)
            //    .ToList();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
