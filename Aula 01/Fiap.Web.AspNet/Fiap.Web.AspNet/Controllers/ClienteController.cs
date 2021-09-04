using Fiap.Web.AspNet.Controllers.Filters;
using Fiap.Web.AspNet.Data;
using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository;
using Fiap.Web.AspNet.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Web.AspNet.Controllers
{
    [FiapFilter]
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IRepresentanteRepository _representanteRepository;

        public ClienteController(
            IClienteRepository clienteRepository,
            IRepresentanteRepository representanteRepository)
        {
            _clienteRepository = clienteRepository;
            _representanteRepository = representanteRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Console.WriteLine("validando o acesso ao controller Home e ação Index");

            //IList<ClienteModel> clientes = _clienteRepository.FindAll();

            IList<ClienteModel> clientes = _clienteRepository.FindByEmailOrRepresentante("", 0);

            return View(clientes);
        }

        [HttpGet]
        [FiapFilter]
        public IActionResult Novo()
        {
            IList<RepresentanteModel> representantes = _representanteRepository.FindAll();

            ViewBag.Representantes = new SelectList(representantes, "RepresentanteId", "NomeRepresentante");

            return View(new ClienteModel());
        }

        [HttpPost]
        public IActionResult Novo(ClienteModel model)
        {
            _clienteRepository.Insert(model);

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
        [FiapFilter]
        public IActionResult Alterar(int id)
        {
            IList<RepresentanteModel> representantes = _representanteRepository.FindAll();

            ViewBag.Representantes = new SelectList(representantes, "RepresentanteId", "NomeRepresentante");

            ClienteModel clienteModel = _clienteRepository.FindById(id);

            return View(clienteModel);
        }

        //Capturando os dados, gravando no banco e exibindo a mensagem de sucesso.
        [HttpPost]
        public IActionResult Alterar(ClienteModel model)
        {
            _clienteRepository.Update(model);

            TempData["mensagemSucesso"] = $"Cliente {model.Nome} ALTERADO com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        [FiapFilter]
        public IActionResult Excluir(int id)
        {
            _clienteRepository.Delete(id);

            TempData["mensagemSucesso"] = $"Cliente REMOVIDO com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        [FiapFilter]
        public IActionResult Detalhes(int id)
        {
            //var usuarioLogado = HttpContext.Session.GetString("usuarioLogado");

            //if (string.IsNullOrEmpty(usuarioLogado))
            //{
            //    TempData["mensagemSucesso"] = "Sessão Expirada, efetue novamente o Login!";
            //    return RedirectToAction("Index", "Login");
            //}

            var cliente = _clienteRepository.FindById(id);
            return View(cliente);
        }

        [HttpGet]
        [FiapFilter]
        public IActionResult Detalhe(int id)
        {
            var clienteModel = _clienteRepository.FindById(id);

            var representanteModel = _representanteRepository.FindById(clienteModel.RepresentanteId);

            clienteModel.Representante = representanteModel;

            return View(clienteModel);
        }
    }
}
