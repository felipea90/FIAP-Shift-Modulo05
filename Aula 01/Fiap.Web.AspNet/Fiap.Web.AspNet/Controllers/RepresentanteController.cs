using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Controllers
{
    public class RepresentanteController : Controller
    {
        private readonly ClienteRepository clienteRepository;
        private readonly RepresentanteRepository representanteRepository;

        public RepresentanteController()
        {
            clienteRepository = new ClienteRepository();
            representanteRepository = new RepresentanteRepository();
        }

        [HttpGet]
        public IActionResult Index()
        {
            IList<RepresentanteModel> representantes = representanteRepository.FindAll();

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
            representanteRepository.Insert(model);

            TempData["mensagemSucesso"] = $"Representante {model.NomeRepresentante} CADASTRADO com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            var representante = representanteRepository.FindById(id);

            return View(representante);
        }

        [HttpPost]
        public IActionResult Alterar(RepresentanteModel model)
        {
            representanteRepository.Update(model);

            TempData["mensagemSucesso"] = $"Representante {model.NomeRepresentante} ALTERADO com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            representanteRepository.Delete(id);

            TempData["mensagemSucesso"] = $"Representante REMOVIDO com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            var representante = representanteRepository.FindByIdWithClientes(id);

            return View(representante);
        }
    }
}
