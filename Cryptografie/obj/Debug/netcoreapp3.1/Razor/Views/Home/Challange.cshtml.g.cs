#pragma checksum "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90381d38a212189777fe52c8012f82226b45c984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Challange), @"mvc.1.0.view", @"/Views/Home/Challange.cshtml")]
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
#line 1 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\_ViewImports.cshtml"
using Cryptografie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\_ViewImports.cshtml"
using Cryptografie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90381d38a212189777fe52c8012f82226b45c984", @"/Views/Home/Challange.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd3a47384eb4e8437f06690e12f65a1780646e72", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Challange : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CryptedMessage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Solve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 10px 0px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
  
    ViewData["Title"] = "Challange";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h3>kid:</h3>\r\n    <p>");
#nullable restore
#line 7 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
  Write(Model.kid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h3>key:</h3>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
  Write(Model.key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h3>challange:</h3>\r\n    <p>");
#nullable restore
#line 11 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
  Write(Model.challenge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h3>nonce:</h3>\r\n    <p>");
#nullable restore
#line 13 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
  Write(Model.nonce);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <button id=\"toggleButton\" class=\"btn-secondary\" onclick=\"myFunction()\" style=\"margin: 10px 0px\">Show plaintext</button>\r\n    <div id=\"plaintext\" class=\"alert-success\" style=\"display:none\">\r\n        <h3>plaintext:</h3>\r\n        <p>");
#nullable restore
#line 17 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
      Write(ViewBag.Plaintext);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 550, "\"", 570, 1);
#nullable restore
#line 20 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
WriteAttributeValue("", 557, ViewBag.Link, 557, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"btn-secondary btn-sm\">Check if challange exist</a>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90381d38a212189777fe52c8012f82226b45c9846741", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"kid\"");
                BeginWriteAttribute("value", " value=\"", 790, "\"", 808, 1);
#nullable restore
#line 23 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
WriteAttributeValue("", 798, Model.kid, 798, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"key\"");
                BeginWriteAttribute("value", " value=\"", 853, "\"", 871, 1);
#nullable restore
#line 24 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
WriteAttributeValue("", 861, Model.key, 861, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"challange\"");
                BeginWriteAttribute("value", " value=\"", 922, "\"", 946, 1);
#nullable restore
#line 25 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
WriteAttributeValue("", 930, Model.challenge, 930, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"nonce\"");
                BeginWriteAttribute("value", " value=\"", 993, "\"", 1013, 1);
#nullable restore
#line 26 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
WriteAttributeValue("", 1001, Model.nonce, 1001, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"plaintext\"");
                BeginWriteAttribute("value", " value=\"", 1064, "\"", 1090, 1);
#nullable restore
#line 27 "C:\Users\xhian\source\repos\CryptografieASP\Cryptografie\Views\Home\Challange.cshtml"
WriteAttributeValue("", 1072, ViewBag.Plaintext, 1072, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <button class=\"btn-danger btn-lg\" type=\"submit\">Challange oplossen</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CryptedMessage> Html { get; private set; }
    }
}
#pragma warning restore 1591
