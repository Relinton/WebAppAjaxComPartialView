#pragma checksum "D:\ProjetosRelinton\WebAppAjaxComPartialView\WebAppAjaxComPartialView\Views\Home\Partials\_Mensagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e217ef711a2c612003ab07d4930bb3f6164f012"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Partials__Mensagem), @"mvc.1.0.view", @"/Views/Home/Partials/_Mensagem.cshtml")]
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
#line 1 "D:\ProjetosRelinton\WebAppAjaxComPartialView\WebAppAjaxComPartialView\Views\_ViewImports.cshtml"
using WebAppAjaxComPartialView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ProjetosRelinton\WebAppAjaxComPartialView\WebAppAjaxComPartialView\Views\_ViewImports.cshtml"
using WebAppAjaxComPartialView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e217ef711a2c612003ab07d4930bb3f6164f012", @"/Views/Home/Partials/_Mensagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dc05d8bf594446881eab09e835289ed61f30cc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Partials__Mensagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Programador>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card mt-0\">\r\n    <div class=\"card-header\">\r\n        <div class=\"col\">\r\n            <h4 class=\"text-center\">Registro realizado com sucesso</h4>\r\n            <br />\r\n            <h5 class=\"text-center\">");
#nullable restore
#line 8 "D:\ProjetosRelinton\WebAppAjaxComPartialView\WebAppAjaxComPartialView\Views\Home\Partials\_Mensagem.cshtml"
                               Write(DateTime.Now.ToLongTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <hr />\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n                    <h6>Olá ");
#nullable restore
#line 12 "D:\ProjetosRelinton\WebAppAjaxComPartialView\WebAppAjaxComPartialView\Views\Home\Partials\_Mensagem.cshtml"
                       Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <br />\r\n                    <h5 class=\"text-center\">Obrigado por se registrar</h5>\r\n                    <br />\r\n                    <p>enviaremos os detalhes sobre as datas de treinamento para ");
#nullable restore
#line 16 "D:\ProjetosRelinton\WebAppAjaxComPartialView\WebAppAjaxComPartialView\Views\Home\Partials\_Mensagem.cshtml"
                                                                            Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" em breve</p>
                    <p>Não hesite em contactar-nos para qualquer dúvida em relinton.pinheiro.infouniron@gmail.com</p>
                    <h6>Esperamos vê-lo em breve</h6>
                    <br />
                    <hr />
                    <h5 class=""text-center bg-secondary"">bem-vindo ao clube</h5>
                    <h6>Cumprimentos</h6>
                    <h6>Consultoria dev Atendimento ao Cliente</h6>
                </div>
            </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Programador> Html { get; private set; }
    }
}
#pragma warning restore 1591
