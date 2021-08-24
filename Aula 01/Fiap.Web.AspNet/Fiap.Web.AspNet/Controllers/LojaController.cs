using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Controllers
{
    public class LojaController : Controller
    {
        private readonly LojaRepository lojaRepository;

        public LojaController()
        {
            lojaRepository = new LojaRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            IList<LojaModel> loja = lojaRepository.FindAll();

            return View(loja);
        }

        [HttpGet]
        public ActionResult Detalhes(int id)
        {
            return View(lojaRepository.FindById(id));
        }

        [HttpGet]
        public ActionResult Novo()
        {
            return View(new LojaModel());
        }

        [HttpPost]
        public ActionResult Novo(LojaModel lojaModel)
        {
            lojaRepository.Insert(lojaModel);

            TempData["mensagemSucesso"] = "Loja cadastrada com sucesso";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            return View(lojaRepository.FindById(id));
        }

        [HttpPost]
        public ActionResult Alterar(LojaModel lojaModel)
        {
            lojaRepository.Update(lojaModel);

            TempData["mensagemSucesso"] = "Loja alterada com sucesso";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            lojaRepository.Delete(id);

            TempData["mensagemSucesso"] = "Loja removida com sucesso";

            return RedirectToAction("Index");
        }
    }
}
