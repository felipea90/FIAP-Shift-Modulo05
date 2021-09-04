using Fiap.Web.AspNet.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (loginViewModel.Usuario.Equals("admin") && loginViewModel.Senha.Equals("1234"))
            {
                loginViewModel.NomeUsuario = "Usuário Administrador do Site";

                HttpContext.Session.SetString("usuarioLogado", loginViewModel.NomeUsuario);
                TempData["mensagemSucesso"] = $"Acesso realizado com sucesso!";
            }
            else
            {
                HttpContext.Session.Clear();
                TempData["mensagemSucesso"] = $"Acesso Negado!";
            }

            return RedirectToAction("Index");
        }
    }
}
