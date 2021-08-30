using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository;
using Fiap.Web.AspNet.Repository.Interface;
using Fiap.Web.AspNet.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ILojaRepository _lojaRepository;

        public ProdutoController(
            IProdutoRepository produtoRepository, 
            ILojaRepository lojaRepository)
        {
            _produtoRepository = produtoRepository;
            _lojaRepository = lojaRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IList<ProdutoModel> produto = _produtoRepository.FindAll();

            return View(produto);
        }

        [HttpGet]
        public ActionResult Detalhes(int id)
        {
            return View(_produtoRepository.FindById(id));
        }

        [HttpGet]
        public ActionResult Novo()
        {
            ViewBag.Lojas = _lojaRepository.FindAll();

            return View();
        }

        [HttpPost]
        public ActionResult Novo(ProdutoLojaViewModel produtoLojaViewModel)
        {
            var produtoModel = produtoLojaViewModel.Produto;

            produtoModel.ProdutoLoja = new List<ProdutoLojaModel>();

            foreach (var loja in produtoLojaViewModel.LojaId)
            {
                var produtoLojaModel = new ProdutoLojaModel()
                {
                    LojaId = loja,
                    Produto = produtoModel
                };

                produtoModel.ProdutoLoja.Add(produtoLojaModel);
            }

            _produtoRepository.Insert(produtoModel);

            TempData["mensagemSucesso"] = "Produto cadastrado com sucesso";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            var lojas = _lojaRepository.FindAll();
            ViewBag.Lojas = new SelectList(lojas, "LojaId", "NomeLoja");

            var produtoModel = _produtoRepository.FindById(id);
            var produtoLojaViewModel = new ProdutoLojaViewModel();
            produtoLojaViewModel.Produto = produtoModel;
            produtoLojaViewModel.LojaId = produtoModel.ProdutoLoja.Select(l => l.LojaId).ToList();

            return View(produtoLojaViewModel);
        }

        [HttpPost]
        public ActionResult Alterar(ProdutoLojaViewModel produtoLojaViewModel)
        {
            ProdutoModel produtoModel = produtoLojaViewModel.Produto;

            produtoModel.ProdutoLoja = new List<ProdutoLojaModel>();

            foreach (var loja in produtoLojaViewModel.LojaId)
            {
                var produtoLojaModel = new ProdutoLojaModel()
                {
                    LojaId = loja,
                    Produto = produtoModel
                };

                produtoModel.ProdutoLoja.Add(produtoLojaModel);
            }

            _produtoRepository.Update(produtoModel);

            TempData["mensagemSucesso"] = "Produto alterado com sucesso";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            _produtoRepository.Delete(id);

            TempData["mensagemSucesso"] = "Produto removido com sucesso";

            return RedirectToAction("Index");
        }
    }
}
