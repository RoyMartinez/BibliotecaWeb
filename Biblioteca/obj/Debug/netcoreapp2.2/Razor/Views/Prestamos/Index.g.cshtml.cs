#pragma checksum "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be65f69f365f54c84a866d3c3c0f35a5b1b1a036"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prestamos_Index), @"mvc.1.0.view", @"/Views/Prestamos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Prestamos/Index.cshtml", typeof(AspNetCore.Views_Prestamos_Index))]
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
#line 1 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#line 2 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be65f69f365f54c84a866d3c3c0f35a5b1b1a036", @"/Views/Prestamos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Prestamos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Biblioteca.Models.Prestamo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 31, true);
            WriteLiteral("\r\n<h1>Listado</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(122, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be65f69f365f54c84a866d3c3c0f35a5b1b1a0363944", async() => {
                BeginContext(145, 14, true);
                WriteLiteral("Ingresar Nuevo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(163, 106, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\" id=\"table_id\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(270, 63, false);
#line 16 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EstudianteNavigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(333, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(389, 58, false);
#line 19 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LibroNavigation.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(447, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(503, 51, false);
#line 22 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaDevolucion));

#line default
#line hidden
            EndContext();
            BeginContext(554, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(672, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(721, 62, false);
#line 31 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EstudianteNavigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(783, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(839, 57, false);
#line 34 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LibroNavigation.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(896, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(952, 50, false);
#line 37 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaDevolucion));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1058, 145, false);
#line 40 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
           Write(Html.ActionLink("Detalle", "Details", new { id1 = item.EstudianteNavigation.Id, id2 = item.LibroNavigation.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1222, 144, false);
#line 41 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
           Write(Html.ActionLink("Editar", "Edit", new { id1 = item.EstudianteNavigation.Id, id2 = item.LibroNavigation.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1385, 147, false);
#line 42 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
           Write(Html.ActionLink("Eliminar", "Delete", new { id1 = item.EstudianteNavigation.Id, id2 = item.LibroNavigation.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\Prestamos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1571, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Biblioteca.Models.Prestamo>> Html { get; private set; }
    }
}
#pragma warning restore 1591