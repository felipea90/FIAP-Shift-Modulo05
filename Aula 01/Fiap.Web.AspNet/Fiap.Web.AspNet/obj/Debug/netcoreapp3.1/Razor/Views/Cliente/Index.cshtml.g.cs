#pragma checksum "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96a155c79a0b3c5191ad940907c87e076dd721aa"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96a155c79a0b3c5191ad940907c87e076dd721aa", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6fd60f873f705776915ea8f460588d647ba60de", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ClienteModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ClienteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">

            <h1 class=""bg-dark p-5 mb-3 text-light text-center""><strong>Clientes - Lista</strong></h1>

            <p class=""toolbar btn btn-outline-primary"">
                <a class=""create btn btn-lg"" href=""/Cliente/Novo""><strong>Novo Cliente</strong></a>
            </p>

");
#nullable restore
#line 17 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml"
             if (!string.IsNullOrEmpty((string)TempData["mensagemSucesso"]))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-warning\" role=\"alert\">\r\n                    <h5>");
#nullable restore
#line 20 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml"
                   Write(TempData["mensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </div>\r\n");
#nullable restore
#line 22 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 24 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml"
             if (Model.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-striped text-center"" border=""1"" cellspacing=""0"" cellpadding=""0"">
                    <thead class=""table-dark text-md-center"">
                        <tr>
                            <th data-field=""id"">Id</th>
                            <th data-field=""name"">Nome</th>
                            <th class=""actions"" width=""220"">Ações</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 35 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml"
                         foreach (var cliente in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "96a155c79a0b3c5191ad940907c87e076dd721aa6100", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 37 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = cliente;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 41 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-warning\" role=\"alert\">\r\n                    <h1>Não existem clientes cadastrados!</h1>\r\n                </div>\r\n");
#nullable restore
#line 47 "E:\FIAP - Shift\Mastering C\Modulo 05\FIAP-Shift-Modulo05\Aula 01\Fiap.Web.AspNet\Fiap.Web.AspNet\Views\Cliente\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ClienteModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
