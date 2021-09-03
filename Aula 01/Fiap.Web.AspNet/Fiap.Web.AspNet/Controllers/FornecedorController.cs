using Fiap.Web.AspNet.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Controllers
{
    public class FornecedorController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FornecedorViewModel fornecedorViewModel)
        {
            //if (string.IsNullOrEmpty(fornecedorViewModel.Cnpj))
            //{
            //    ModelState.AddModelError("Cnpj", "Campo CNPJ não pode ser nulo");
            //}
            
            //if (string.IsNullOrEmpty(fornecedorViewModel.RazaoSocial))
            //{
            //    ModelState.AddModelError("RazaoSocial", "Campo Razão Social não pode ser nulo");
            //}

            //if (string.IsNullOrEmpty(fornecedorViewModel.Telefone))
            //{
            //    ModelState.AddModelError("Telefone", "Campo Telefone não pode ser nulo");
            //}

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //return Json(ModelState);

                return View();
            }
        }
    }
}
