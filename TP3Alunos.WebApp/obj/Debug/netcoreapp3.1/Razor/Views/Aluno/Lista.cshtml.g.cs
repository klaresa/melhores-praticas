#pragma checksum "C:\Users\klari\source\repos\TP3Alunos\TP3Alunos.WebApp\Views\Aluno\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec2c0e2206a476e184e43741918c44064d9820a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_Lista), @"mvc.1.0.view", @"/Views/Aluno/Lista.cshtml")]
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
#line 1 "C:\Users\klari\source\repos\TP3Alunos\TP3Alunos.WebApp\Views\_ViewImports.cshtml"
using TP3Alunos.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\klari\source\repos\TP3Alunos\TP3Alunos.WebApp\Views\_ViewImports.cshtml"
using TP3Alunos.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec2c0e2206a476e184e43741918c44064d9820a4", @"/Views/Aluno/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c1b5669575230ab95da92e1db4320b2cee80f95", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TP3Alunos.Domain.Entity.Aluno>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\klari\source\repos\TP3Alunos\TP3Alunos.WebApp\Views\Aluno\Lista.cshtml"
  
    var alunos = Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"listagem-post\">\r\n    <ul class=\"list-group\">\r\n");
#nullable restore
#line 9 "C:\Users\klari\source\repos\TP3Alunos\TP3Alunos.WebApp\Views\Aluno\Lista.cshtml"
         foreach (var aluno in alunos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item\">\r\n                <div class=\"group-post\">\r\n                    <div class=\"user\">");
#nullable restore
#line 13 "C:\Users\klari\source\repos\TP3Alunos\TP3Alunos.WebApp\Views\Aluno\Lista.cshtml"
                                 Write(aluno.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"matricula\">");
#nullable restore
#line 14 "C:\Users\klari\source\repos\TP3Alunos\TP3Alunos.WebApp\Views\Aluno\Lista.cshtml"
                                      Write(aluno.Matricula.Formatado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <a name=\"id\" class=\"remover\"");
            BeginWriteAttribute("href", " href=\"", 460, "\"", 491, 2);
            WriteAttributeValue("", 467, "/aluno/remover/", 467, 15, true);
#nullable restore
#line 15 "C:\Users\klari\source\repos\TP3Alunos\TP3Alunos.WebApp\Views\Aluno\Lista.cshtml"
WriteAttributeValue("", 482, aluno.Id, 482, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">remover</a>\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 18 "C:\Users\klari\source\repos\TP3Alunos\TP3Alunos.WebApp\Views\Aluno\Lista.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TP3Alunos.Domain.Entity.Aluno>> Html { get; private set; }
    }
}
#pragma warning restore 1591