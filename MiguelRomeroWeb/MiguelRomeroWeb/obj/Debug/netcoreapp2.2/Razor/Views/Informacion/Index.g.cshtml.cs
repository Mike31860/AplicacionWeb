#pragma checksum "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d94f18d30bef7cdfd599738c17c99a6035d888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Informacion_Index), @"mvc.1.0.view", @"/Views/Informacion/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Informacion/Index.cshtml", typeof(AspNetCore.Views_Informacion_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d94f18d30bef7cdfd599738c17c99a6035d888", @"/Views/Informacion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf8c1461c3689bb2e13df44bfb1f64c86c28607", @"/Views/_ViewImports.cshtml")]
    public class Views_Informacion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MiguelRomeroWeb.Models.ClienteInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#FFFFFF"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(99, 63, true);
            WriteLiteral("\r\n<h1 style=\"color:#FFFFFF\">Lista de Clientes</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(162, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d94f18d30bef7cdfd599738c17c99a6035d8885112", async() => {
                BeginContext(207, 19, true);
                WriteLiteral("Crear Nuevo Cliente");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(230, 295, true);
            WriteLiteral(@"
</p>
<table class=""table"">

    <style>
        body {
            background-image: url("" https://handluggageonly.co.uk/wp-content/uploads/2017/12/Hand-Luggage-Only-20.jpg"");
        }
    </style>
    <thead>
        <tr>
            <th style=""color:#FEFE00"" ; >
                ");
            EndContext();
            BeginContext(526, 42, false);
#line 22 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(568, 80, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:#FEFE00\" ; >\r\n                ");
            EndContext();
            BeginContext(649, 45, false);
#line 25 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Necesidad));

#line default
#line hidden
            EndContext();
            BeginContext(694, 80, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:#FEFE00\" ; >\r\n                ");
            EndContext();
            BeginContext(775, 46, false);
#line 28 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoEvento));

#line default
#line hidden
            EndContext();
            BeginContext(821, 80, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:#FEFE00\" ; >\r\n                ");
            EndContext();
            BeginContext(902, 41, false);
#line 31 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Donde));

#line default
#line hidden
            EndContext();
            BeginContext(943, 80, true);
            WriteLiteral("\r\n            </th>\r\n            <th style=\"color:#FEFE00\" ; >\r\n                ");
            EndContext();
            BeginContext(1024, 43, false);
#line 34 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cuantos));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1202, 37, true);
            WriteLiteral("            <tr>\r\n                <td");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1239, "\"", 1379, 7);
            WriteAttributeValue("", 1247, "color:#FFFFFF", 1247, 13, true);
            WriteAttributeValue(" ", 1260, ";", 1261, 2, true);
            WriteAttributeValue(" ", 1262, ">", 1263, 2, true);
#line 43 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
WriteAttributeValue("\r\n                    ", 1264, Html.DisplayFor(modelItem => item.Nombre), 1286, 42, false);

#line default
#line hidden
            WriteAttributeValue("\r\n                ", 1328, "</td>", 1346, 23, true);
            WriteAttributeValue("\r\n                ", 1351, "<td", 1369, 21, true);
            WriteAttributeValue(" ", 1372, "style=", 1373, 7, true);
            EndWriteAttribute();
            BeginContext(1380, 39, true);
            WriteLiteral("color:#FFFFFF\" ;>\r\n                    ");
            EndContext();
            BeginContext(1420, 44, false);
#line 47 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Necesidad));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 92, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"color:#FFFFFF\" ; >\r\n                    ");
            EndContext();
            BeginContext(1557, 45, false);
#line 50 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TipoEvento));

#line default
#line hidden
            EndContext();
            BeginContext(1602, 92, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"color:#FFFFFF\" ; >\r\n                    ");
            EndContext();
            BeginContext(1695, 40, false);
#line 53 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Donde));

#line default
#line hidden
            EndContext();
            BeginContext(1735, 92, true);
            WriteLiteral("\r\n                </td>\r\n                <td style=\"color:#FFFFFF\" ; >\r\n                    ");
            EndContext();
            BeginContext(1828, 42, false);
#line 56 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cuantos));

#line default
#line hidden
            EndContext();
            BeginContext(1870, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(2024, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2044, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d94f18d30bef7cdfd599738c17c99a6035d88813049", async() => {
                BeginContext(2113, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2124, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2148, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d94f18d30bef7cdfd599738c17c99a6035d88815581", async() => {
                BeginContext(2217, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2227, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 64 "C:\Users\Miguel\Desktop\Semestres\Semestre 5\Proyecto Integrador\AplicacionWebMiguel\MiguelRomeroWeb\MiguelRomeroWeb\Views\Informacion\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2282, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MiguelRomeroWeb.Models.ClienteInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
