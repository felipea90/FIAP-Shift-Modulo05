using AutoMapper;
using Fiap.Web.AspNet.Data;
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
    public class RepresentanteController : Controller
    {
        private readonly IRepresentanteRepository _representanteRepository;
        private readonly IMapper _mapper;

        public RepresentanteController(
            IRepresentanteRepository representanteRepository,
            IMapper mapper)
        {
            _representanteRepository = representanteRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var representanteVM = _mapper
                .Map<IEnumerable<RepresentanteViewModel>>(_representanteRepository.FindAll());

            //IList<RepresentanteModel> representante = _representanteRepository.FindAll();

            //representanteVM.Representantes = _representanteRepository.FindAll()
            //    .Select(item => 
            //    new RepresentanteViewModel(item.RepresentanteId, item.NomeRepresentante))
            //    .ToList();
            
            return View(representanteVM);
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View(new RepresentanteViewModel());
        }

        [HttpPost]
        public IActionResult Novo(RepresentanteViewModel representanteVM)
        {
            //var representanteModel = new RepresentanteModel();
            //representanteModel.RepresentanteId = representanteVM.RepresentanteId;
            //representanteModel.NomeRepresentante = representanteVM.NomeRepresentante;

            var representanteModel = _mapper.Map<RepresentanteModel>(representanteVM);

            _representanteRepository.Insert(representanteModel);

            TempData["mensagemSucesso"] = $"Representante {representanteVM.NomeRepresentante} CADASTRADO com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Alterar(int id)
        {
            var representanteModel = _representanteRepository.FindById(id);

            var representanteVM = _mapper.Map<RepresentanteViewModel>(representanteModel);

            return View(representanteVM);
        }

        [HttpPost]
        public IActionResult Alterar(RepresentanteViewModel representanteVM)
        {
            var representanteModel = _mapper.Map<RepresentanteModel>(representanteVM);

            _representanteRepository.Update(representanteModel);

            TempData["mensagemSucesso"] = $"Representante {representanteVM.NomeRepresentante} ALTERADO com sucesso!";

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
            var representanteVM = _representanteRepository.FindByIdWithClientes(id);

            var representanteModel = _mapper.Map<RepresentanteViewModel>(representanteVM);

            return View(representanteModel);
        }
    }
}
