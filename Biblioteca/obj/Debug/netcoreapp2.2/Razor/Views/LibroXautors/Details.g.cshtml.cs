#pragma checksum "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\LibroXautors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b9b168d28e8ea9675ef27437255afe6840e2298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LibroXautors_Details), @"mvc.1.0.view", @"/Views/LibroXautors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LibroXautors/Details.cshtml", typeof(AspNetCore.Views_LibroXautors_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b9b168d28e8ea9675ef27437255afe6840e2298", @"/Views/LibroXautors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_LibroXautors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Biblioteca.Models.LibroXautor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\LibroXautors\Details.cshtml"
  
    ViewData["Title"] = "Detalle de la asignacion";

#line default
#line hidden
            BeginContext(100, 147, true);
            WriteLiteral("\r\n<h1>Detalle de asignacion</h1>\r\n\r\n<div>\r\n    <h4>Asignacion</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(248, 58, false);
#line 14 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\LibroXautors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AutorNavigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(306, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(370, 54, false);
#line 17 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\LibroXautors\Details.cshtml"
       Write(Html.DisplayFor(model => model.AutorNavigation.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(424, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(487, 58, false);
#line 20 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\LibroXautors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LibroNavigation.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(545, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(609, 54, false);
#line 23 "C:\Users\RoyMa\Desktop\Nueva carpeta (2)\Segunda Prueba\Tercera Parte\Biblioteca\Views\LibroXautors\Details.cshtml"
       Write(Html.DisplayFor(model => model.LibroNavigation.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(663, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(710, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b9b168d28e8ea9675ef27437255afe6840e22985995", async() => {
                BeginContext(732, 8, true);
                WriteLiteral("Regresar");
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
            BeginContext(744, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Biblioteca.Models.LibroXautor> Html { get; private set; }
    }
}
#pragma warning restore 1591