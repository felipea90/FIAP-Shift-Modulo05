using Fiap.Web.AspNet.Data;
using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Web.AspNet.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteRepository clienteRepository;
        private readonly RepresentanteRepository representanteRepository;
        private readonly DataContext context;

        public ClienteController()
        {
            clienteRepository = new ClienteRepository();
            representanteRepository = new RepresentanteRepository();
            context = new DataContext();
        }

        [HttpGet]
        public IActionResult Index()
        {
            Console.WriteLine("validando o acesso ao controller Home e ação Index");

            IList<ClienteModel> clientes = clienteRepository.FindAll();

            return View(clientes);
        }

        [HttpGet]
        public IActionResult Novo()
        {
            IList<RepresentanteModel> representantes = representanteRepository.FindAll();

            ViewBag.Representantes = new SelectList(representantes, "RepresentanteId", "NomeRepresentante");

            return View(new ClienteModel());
        }

        [HttpPost]
        public IActionResult Novo(ClienteModel model)
        {
           clienteRepository.Insert(model);

            TempData["mensagemSucesso"] = $"Cliente {model.Nome} CADASTRADO com sucesso!";

            return RedirectToAction("Index");
        }

        //public IActionResult Cadastrar(ClienteModel model)
        //{
        //    Console.WriteLine("Validando o acesso ao Controller Cliente e ação Cadastrar");
        //    Console.WriteLine(model);

        //    Console.WriteLine("Gravando no Banco de Dados e Recuperando o ID");

        //    model.ClienteId = 199; //fake

        //    ViewData["ClienteId"] = model.ClienteId;
        //    ViewBag.NomeCliente = model.Nome;

        //    ViewData["ClienteModel"] = model;
        //    ViewBag.ClienteModel = model;

        //    TempData["ClienteModel"] = model;

        //    //return RedirectToAction("Index");

        //    return View();
        //}


        [HttpGet]
        public IActionResult Alterar(int id)
        {
            IList<RepresentanteModel> representantes = representanteRepository.FindAll();

            ViewBag.Representantes = new SelectList(representantes, "RepresentanteId", "NomeRepresentante");

            ClienteModel clienteModel = clienteRepository.FindById(id);

            return View(clienteModel);
        }

        //Capturando os dados, gravando no banco e exibindo a mensagem de sucesso.
        [HttpPost]
        public IActionResult Alterar(ClienteModel model)
        {
            clienteRepository.Update(model);

            TempData["mensagemSucesso"] = $"Cliente {model.Nome} ALTERADO com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            clienteRepository.Delete(id);

            TempData["mensagemSucesso"] = $"Cliente REMOVIDO com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Detalhes(int id)
        {
            var cliente = clienteRepository.FindById(id);

            return View(cliente);
        }

        [HttpGet]
        public IActionResult Detalhe(int id)
        {
            var clienteModel = clienteRepository.FindById(id);

            var representanteModel = representanteRepository.FindById(clienteModel.RepresentanteId);

            clienteModel.Representante = representanteModel;

            return View(clienteModel);
        }
    }
}
