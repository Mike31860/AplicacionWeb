#pragma checksum "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae20834ef4c936369c1d5e36fc277ec0b7a88c4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\_ViewImports.cshtml"
using MiguelRomeroWeb;

#line default
#line hidden
#line 2 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\_ViewImports.cshtml"
using MiguelRomeroWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae20834ef4c936369c1d5e36fc277ec0b7a88c4d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf8c1461c3689bb2e13df44bfb1f64c86c28607", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 629, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 style=""color:#FEFE00"" ; class=""display-4"">Es momento de Celebrar </h1>
    <h5 style=""color:#FEFE00"" ; class=""display-4"">Cotiza con nosotros y recibe las mejores ofertas </h5>
    <style>
        body {
            background-image: url("" http://www.ee-today.com/wp-content/uploads/2017/05/verdad-o-reto1.jpg"");
        }
    </style>

    <p style=""color:#FFFFFF"" ;>Cotiza con nosotros y recibe las mejores ofertas</p>
    
        <input style=""color:#ff0000"" ; onclick="" location.href='https://localhost:44377/Cliente' ""; type=""button"" value=""Solicita tu cotización"">

</div>
");
            EndContext();
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
