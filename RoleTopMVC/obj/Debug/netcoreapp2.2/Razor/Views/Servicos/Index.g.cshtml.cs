#pragma checksum "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2c9d9fe419aee38075665cf49055be7a60341e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Servicos_Index), @"mvc.1.0.view", @"/Views/Servicos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Servicos/Index.cshtml", typeof(AspNetCore.Views_Servicos_Index))]
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
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c9d9fe419aee38075665cf49055be7a60341e3", @"/Views/Servicos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Servicos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.PedidoViewModel>
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
            BeginContext(46, 29, true);
            WriteLiteral("<main>\r\n        <h2>Pede aí, ");
            EndContext();
            BeginContext(76, 17, false);
#line 3 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
                Write(Model.NomeCliente);

#line default
#line hidden
            EndContext();
            BeginContext(93, 16, true);
            WriteLiteral("!</h2>\r\n        ");
            EndContext();
            BeginContext(109, 2114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2c9d9fe419aee38075665cf49055be7a60341e34435", async() => {
                BeginContext(174, 175, true);
                WriteLiteral("\r\n            <div>\r\n                <label for=\"nome\">Nome Completo</label>\r\n                <br />\r\n                <input id=\"nome\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 349, "\"", 376, 1);
#line 8 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
WriteAttributeValue("", 357, Model.Cliente.Nome, 357, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(377, 214, true);
                WriteLiteral(" name=\"nome\"/>\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"endereco\">Endereço</label>\r\n                <br />\r\n                <input id=\"endereco\" type=\"text\" maxlength=\"20\" minlength=\"3\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 591, "\"", 622, 1);
#line 14 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
WriteAttributeValue("", 599, Model.Cliente.Endereco, 599, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(623, 230, true);
                WriteLiteral(" name=\"endereco\"/>\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"telefone\">Telefone para contato</label>\r\n                <br />\r\n                <input id=\"telefone\" type=\"text\" placeholder=\"11 12345 6789\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 853, "\"", 884, 1);
#line 20 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
WriteAttributeValue("", 861, Model.Cliente.Telefone, 861, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(885, 182, true);
                WriteLiteral(" name=\"telefone\"/>\r\n            </div>\r\n\r\n            <div>\r\n                <label for=\"email\">E-mail</label>\r\n                <br />\r\n                <input id=\"email\" type=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1067, "\"", 1095, 1);
#line 26 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
WriteAttributeValue("", 1075, Model.Cliente.Email, 1075, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1096, 264, true);
                WriteLiteral(@" name=""email"" />
            </div>

            <div class=""double-field"">
                <div>
                    <label for=""hamburguer"">Hamburguer</label>
                    <select id=""hamburguer"" name=""hamburguer"" required>
                        ");
                EndContext();
                BeginContext(1360, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2c9d9fe419aee38075665cf49055be7a60341e37636", async() => {
                    BeginContext(1395, 9, true);
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
                BeginContext(1413, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
                         foreach(var h in Model.Hamburgueres)
                        {

#line default
#line hidden
                BeginContext(1505, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1533, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2c9d9fe419aee38075665cf49055be7a60341e310095", async() => {
                    BeginContext(1556, 6, false);
#line 36 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
                                             Write(h.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1562, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1568, 7, false);
#line 36 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
                                                         Write(h.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 36 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
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
                BeginContext(1584, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 37 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(1613, 210, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n                <div>\r\n                    <label for=\"shake\">Shake</label>\r\n                    <select id=\"shake\" name=\"shake\">\r\n                        ");
                EndContext();
                BeginContext(1823, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2c9d9fe419aee38075665cf49055be7a60341e312995", async() => {
                    BeginContext(1858, 9, true);
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
                BeginContext(1876, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
                         foreach(var s in Model.Shakes)
                        {

#line default
#line hidden
                BeginContext(1962, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1990, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2c9d9fe419aee38075665cf49055be7a60341e315449", async() => {
                    BeginContext(2013, 6, false);
#line 46 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
                                             Write(s.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(2019, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(2025, 7, false);
#line 46 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
                                                         Write(s.Preco);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 46 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
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
                BeginContext(2041, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 47 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2070, 146, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n            </div>\r\n            <input type=\"submit\" value=\"Finalizar pedido!\" />\r\n        ");
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
#line 4 "C:\Users\44337427830\Desktop\MVC\RoleTopMVC\Views\Servicos\Index.cshtml"
AddHtmlAttributeValue("", 137, Url.Action("Registrar","Servicos"), 137, 35, false);

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
            BeginContext(2223, 15, true);
            WriteLiteral("\r\n\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
