using Fiap.Web.AspNet.Data;
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
    public class RepresentanteController : Controller
    {
        private readonly IRepresentanteRepository _representanteRepository;

        public RepresentanteController(
            IRepresentanteRepository representanteRepository)
        {
            _representanteRepository = representanteRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IList<RepresentanteModel> representantes = _representanteRepository.FindAll();

            return View(representantes);
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View(new RepresentanteModel());
        }

        [HttpPost]
        public IActionResult Novo(RepresentanteModel model)
        {
            _representanteRepository.Insert(model);

            TempData["mensagemSucesso"] = $"Representante {model.NomeRepresentante} CADASTRADO com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            var representante = _representanteRepository.FindById(id);

            return View(representante);
        }

        [HttpPost]
        public IActionResult Alterar(RepresentanteModel model)
        {
            _representanteRepository.Update(model);

            TempData["mensagemSucesso"] = $"Representante {model.NomeRepresentante} ALTERADO com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            _representanteRepository.Delete(id);

            TempData["mensagemSucesso"] = $"Representante REMOVIDO com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            var representante = _representanteRepository.FindByIdWithClientes(id);

            return View(representante);
        }
    }
}
