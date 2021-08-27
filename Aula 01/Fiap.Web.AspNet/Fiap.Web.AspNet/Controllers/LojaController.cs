using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository;
using Fiap.Web.AspNet.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Controllers
{
    public class LojaController : Controller
    {
        private readonly ILojaRepository _lojaRepository;

        public LojaController(
            ILojaRepository lojaRepository)
        {
            _lojaRepository = lojaRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IList<LojaModel> loja = _lojaRepository.FindAll();

            return View(loja);
        }

        [HttpGet]
        public ActionResult Detalhes(int id)
        {
            return View(_lojaRepository.FindById(id));
        }

        [HttpGet]
        public ActionResult Novo()
        {
            return View(new LojaModel());
        }

        [HttpPost]
        public ActionResult Novo(LojaModel lojaModel)
        {
            _lojaRepository.Insert(lojaModel);

            TempData["mensagemSucesso"] = "Loja cadastrada com sucesso";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            return View(_lojaRepository.FindById(id));
        }

        [HttpPost]
        public ActionResult Alterar(LojaModel lojaModel)
        {
            _lojaRepository.Update(lojaModel);

            TempData["mensagemSucesso"] = "Loja alterada com sucesso";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            _lojaRepository.Delete(id);

            TempData["mensagemSucesso"] = "Loja removida com sucesso";

            return RedirectToAction("Index");
        }
    }
}
