#pragma checksum "C:\dev\SistemaWebDotnetCoreDapper\Application\Views\Home\Remover.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a6b2bff932b71d0951e335df4781bd9b9c03830"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Remover), @"mvc.1.0.view", @"/Views/Home/Remover.cshtml")]
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
#line 1 "C:\dev\SistemaWebDotnetCoreDapper\Application\Views\_ViewImports.cshtml"
using Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\SistemaWebDotnetCoreDapper\Application\Views\_ViewImports.cshtml"
using Application.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6b2bff932b71d0951e335df4781bd9b9c03830", @"/Views/Home/Remover.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ea476b5db410d4405042b0a5ed991b4e6710c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Remover : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.Todo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\dev\SistemaWebDotnetCoreDapper\Application\Views\Home\Remover.cshtml"
  
    ViewData["Title"] = "Remover";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">Editar Tarefa</div>\r\n    <div class=\"card-body\">\r\n        Você deseja remover a tarefa ");
#nullable restore
#line 9 "C:\dev\SistemaWebDotnetCoreDapper\Application\Views\Home\Remover.cshtml"
                                Write(Model.Tarefa);

#line default
#line hidden
#nullable disable
            WriteLiteral("?<br/>\r\n        ");
#nullable restore
#line 10 "C:\dev\SistemaWebDotnetCoreDapper\Application\Views\Home\Remover.cshtml"
   Write(Html.ActionLink("Sim", "ConfirmaRemover", "Home", new { id = Model.Id}, new { @class="btn btn-danger btn-sm"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\dev\SistemaWebDotnetCoreDapper\Application\Views\Home\Remover.cshtml"
   Write(Html.ActionLink("Voltar", "Index", "Home", null, new { @class="btn btn-light btn-sm"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.Todo> Html { get; private set; }
    }
}
#pragma warning restore 1591