using Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("validando o acesso ao controller Home e ação Index");
            return View();
        }

        public IActionResult Novo()
        {
            return View();
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

        public IActionResult Cadastrar(ClienteModel model)
        {
            TempData["mensagemSucesso"] = $"Cliente {model.Nome} Cadastrado com sucesso!";

            return RedirectToAction("Index");
        }

        public IActionResult Cadastrar2()
        {
            return View();
        }
    }
}
