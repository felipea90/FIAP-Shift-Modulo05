using Fiap.Web.AspNet.Controllers;
using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository;
using Fiap.Web.AspNet.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Fiap.Web.AspNet.Test
{
    public class RepresentanteControllerTest
    {
        // Lista de Representantes igual ao banco
        [Fact]
        public Task IndexReturnsViewResultWithListOfRepresentantes()
        {
            var repositoryMock = new Mock<IRepresentanteRepository>();

            //repositoryMock.Setup(r => r.FindAll()).Returns((IList<RepresentanteModel>)null);

            repositoryMock.Setup(r => r.FindAll()).Returns(ListaRepresenantes3());

            var controller = new RepresentanteController(repositoryMock.Object);

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);

            var model = Assert.IsAssignableFrom<IEnumerable<RepresentanteModel>>(viewResult.Model);

            Assert.Equal(3, model.Count());

            return Task.CompletedTask;
        }

        // Lista Sem Representantes
        [Fact]
        public Task IndexReturnsViewResultWithNoRepresentantes()
        {
            var repositoryMock = new Mock<IRepresentanteRepository>();

            repositoryMock.Setup(r => r.FindAll()).Returns(new List<RepresentanteModel>());

            var controller = new RepresentanteController(repositoryMock.Object);

            var result = controller.Index();

            var viewResult = Assert.IsType<ViewResult>(result);

            var model = Assert.IsAssignableFrom<IEnumerable<RepresentanteModel>>(viewResult.Model);

            Assert.Empty(model);

            return Task.CompletedTask;
        }

        // Lista com 1 Representante
        //[Fact]
        //public Task IndexReturnsViewResultWithOneRepresentantes()
        //{
        //    return null;
        //}

        private IList<RepresentanteModel> ListaRepresenantes3()
        {
            return new List<RepresentanteModel>()
            {
            new RepresentanteModel(1,"Flávio"),
            new RepresentanteModel(2,"Eduardo"),
            new RepresentanteModel(3,"Moreni"),
            };
        }
    }
}
