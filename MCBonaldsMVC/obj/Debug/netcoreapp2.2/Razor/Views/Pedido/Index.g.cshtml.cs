#pragma checksum "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67788005fa14605fd4d138e8964bcb4554f51408"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedido/Index.cshtml", typeof(AspNetCore.Views_Pedido_Index))]
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
#line 1 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67788005fa14605fd4d138e8964bcb4554f51408", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57177a2332d7bbd6b3532411ed5e910c130f158a", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<McBonaldsMVC.ViewModels.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 28, true);
            WriteLiteral("<main>\n        <h2>Pede aí, ");
            EndContext();
            BeginContext(76, 17, false);
#line 3 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
                Write(Model.NomeCliente);

#line default
#line hidden
            EndContext();
            BeginContext(93, 15, true);
            WriteLiteral("!</h2>\n        ");
            EndContext();
            BeginContext(108, 2064, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67788005fa14605fd4d138e8964bcb4554f514084429", async() => {
                BeginContext(171, 171, true);
                WriteLiteral("\n            <div>\n                <label for=\"nome\">Nome Completo</label>\n                <br />\n                <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 342, "\"", 369, 1);
#line 8 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 350, Model.Cliente.Nome, 350, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(370, 208, true);
                WriteLiteral(" name=\"nome\"/>\n            </div>\n\n            <div>\n                <label for=\"endereco\">Endereço</label>\n                <br />\n                <input id=\"endereco\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 578, "\"", 609, 1);
#line 14 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 586, Model.Cliente.Endereco, 586, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(610, 224, true);
                WriteLiteral(" name=\"endereco\"/>\n            </div>\n\n            <div>\n                <label for=\"telefone\">Telefone para contato</label>\n                <br />\n                <input id=\"telefone\" type=\"text\" placeholder=\"11 12345 6789\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 834, "\"", 865, 1);
#line 20 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 842, Model.Cliente.Telefone, 842, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(866, 176, true);
                WriteLiteral(" name=\"telefone\"/>\n            </div>\n\n            <div>\n                <label for=\"email\">E-mail</label>\n                <br />\n                <input id=\"email\" type=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1042, "\"", 1070, 1);
#line 26 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1050, Model.Cliente.Email, 1050, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1071, 257, true);
                WriteLiteral(@" name=""email"" />
            </div>

            <div class=""double-field"">
                <div>
                    <label for=""hamburguer"">Hamburguer</label>
                    <select id=""hamburguer"" name=""hamburguer"" required>
                        ");
                EndContext();
                BeginContext(1328, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67788005fa14605fd4d138e8964bcb4554f514087579", async() => {
                    BeginContext(1363, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1381, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 34 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
                         foreach(var h in Model.Hamburgueres)
                        {

#line default
#line hidden
                BeginContext(1470, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1498, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67788005fa14605fd4d138e8964bcb4554f5140810034", async() => {
                    BeginContext(1521, 6, false);
#line 36 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
                                             Write(h.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1527, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1533, 7, false);
#line 36 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
                                                         Write(h.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 36 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
                              WriteLiteral(h.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1549, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 37 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1576, 205, true);
                WriteLiteral("                    </select>\n                </div>\n                <div>\n                    <label for=\"shake\">Shake</label>\n                    <select id=\"shake\" name=\"shake\">\n                        ");
                EndContext();
                BeginContext(1781, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67788005fa14605fd4d138e8964bcb4554f5140812921", async() => {
                    BeginContext(1816, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1834, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 44 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
                         foreach(var s in Model.Shakes)
                        {

#line default
#line hidden
                BeginContext(1917, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1945, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67788005fa14605fd4d138e8964bcb4554f5140815371", async() => {
                    BeginContext(1968, 6, false);
#line 46 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
                                             Write(s.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1974, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1980, 7, false);
#line 46 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
                                                         Write(s.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 46 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
                              WriteLiteral(s.Nome);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1996, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 47 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2023, 142, true);
                WriteLiteral("                    </select>\n                </div>\n            </div>\n            <input type=\"submit\" value=\"Finalizar pedido!\" />\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 4 "C:\Users\44337427830\Desktop\MVC\MCBonaldsMVC\Views\Pedido\Index.cshtml"
AddHtmlAttributeValue("", 136, Url.Action("Registrar","Pedido"), 136, 33, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2172, 13, true);
            WriteLiteral("\n\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<McBonaldsMVC.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
