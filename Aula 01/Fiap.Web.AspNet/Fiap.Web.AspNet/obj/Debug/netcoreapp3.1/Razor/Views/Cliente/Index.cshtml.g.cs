#pragma checksum "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d442fe19ee2922f8952f76e9517bbfb1bfa6404"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using Fiap.Web.AspNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using Fiap.Web.AspNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d442fe19ee2922f8952f76e9517bbfb1bfa6404", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6fd60f873f705776915ea8f460588d647ba60de", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n\r\n            <h1>Clientes</h1>\r\n\r\n            <h3>");
#nullable restore
#line 13 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml"
           Write(TempData["mensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

            <p class=""toolbar"">
                <a class=""create btn btn-default"" href=""/Cliente/Novo"">Novo Cliente</a>
            </p>

            <table class=""table table-striped"" border=""1"" cellspacing=""0"" cellpadding=""0"">
                <thead>
                    <tr>
                        <th data-field=""id"">Id</th>
                        <th data-field=""name"">Nome</th>
                        <th class=""actions"" width=""220"">Ações</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>#1</td>
                        <td>Flávio</td>
                        <td>
                            <a class=""btn btn-success btn-sm"" href=""#"">Detalhes</a>
                            <a class=""btn btn-warning btn-sm"" href=""#"">Editar</a>
                            <a class=""btn btn-danger btn-sm"" href=""#"">Excluir</a>
                        </td>
                    </tr>
                    <tr>
     ");
            WriteLiteral(@"                   <td>#2</td>
                        <td>Eduardo</td>
                        <td>
                            <a class=""btn btn-success btn-sm"" href=""#"">Detalhes</a>
                            <a class=""btn btn-warning btn-sm"" href=""#"">Editar</a>
                            <a class=""btn btn-danger btn-sm"" href=""#"">Excluir</a>
                        </td>
                    </tr>
                    <tr>
                        <td>#3</td>
                        <td>Moreni</td>
                        <td>
                            <a class=""btn btn-success btn-sm"" href=""#"">Detalhes</a>
                            <a class=""btn btn-warning btn-sm"" href=""#"">Editar</a>
                            <a class=""btn btn-danger btn-sm"" href=""#"">Excluir</a>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
</div>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
