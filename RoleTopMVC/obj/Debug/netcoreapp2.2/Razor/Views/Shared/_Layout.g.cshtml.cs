#pragma checksum "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "145cf0443a7ff1c6f2fdb9a3a158dd390a867c46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTOP;

#line default
#line hidden
#line 2 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTOP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"145cf0443a7ff1c6f2fdb9a3a158dd390a867c46", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42629236f4132e65268b414d1899fd5d49ccfb6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 37, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"pt-br\">\n\n");
            EndContext();
            BeginContext(37, 202, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "145cf0443a7ff1c6f2fdb9a3a158dd390a867c463345", async() => {
                BeginContext(43, 189, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\n    <title>Rolê TOP</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(239, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(241, 1410, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "145cf0443a7ff1c6f2fdb9a3a158dd390a867c464728", async() => {
                BeginContext(247, 916, true);
                WriteLiteral(@"
    <nav>
        <div class=""Menu"">
            <link rel=""stylesheet"" href=""CSS/Style.css"" type=""text/css"">
            <link href=""https://fonts.googleapis.com/css?family=Patua+One&display=swap"" rel=""stylesheet"">
            <link href=""https://fonts.googleapis.com/css?family=Teko&display=swap"" rel=""stylesheet"">
            <ul>
                <li><a id=""bt-Login"" href=""Login.html"">Login</a></li>
                <li><a href=""Rolê TOP.html#Eventos"">Eventos</a></li>
                <li><a href=""Rolê TOP.html#Quem"">Quem somos</a></li>
                <li><a id=""bt-Facebook"" href=""https://www.facebook.com/Rol%C3%AATop-106506047400870/?modal=admin_todo_tour"">Facebook</a></li>
                <li><a href=""Rolê TOP.html#Sobre o Local"">Reservar</a></li>
            </ul>
        </div>
    </nav>
    <div id=""logo-area"">
        <img src=""IMG/Logo.png.png"" alt=""Logo tipo TOP "" title=""Logo"">
    </div>
    ");
                EndContext();
                BeginContext(1164, 12, false);
#line 29 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1176, 468, true);
                WriteLiteral(@"
    <footer>
        <div class=""Menu"">
            <address>
                            Avenida de Limeira, 539 - Campos Elíseos - SP (São Paulo)
                            <br />
                            roletop@email.com
                            <br />
                            +55 11 98456-4534
                            +55 11 0230-6789
                        </address>
            <a href=""#"">Voltar para o topo!</a>
        </div>
    </footer>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1651, 19, true);
            WriteLiteral("\n\n</html>\n\n</html>\n");
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
