#pragma checksum "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\_LatestSubscribePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c7fa5b6085bb4dc37e99cef40df5402b9655775"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LatestSubscribePartial), @"mvc.1.0.view", @"/Views/Shared/_LatestSubscribePartial.cshtml")]
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
#line 2 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.AboutViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.ProductViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.BlogViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.HomeViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.ContactViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.CategoryViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\_ViewImports.cshtml"
using Estore.ViewModels.AccountViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c7fa5b6085bb4dc37e99cef40df5402b9655775", @"/Views/Shared/_LatestSubscribePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"209deeccd7ac6be9763349b30c3e2d3a2311a0d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LatestSubscribePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LatestSubscribe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!-- Latest subscribe area starts -->\r\n    <section class=\"latest-wrapper plr-60\">\r\n        <div class=\"latest-area latest-height d-flex align-items-center\"");
            BeginWriteAttribute("style", " style=\"", 181, "\"", 240, 4);
            WriteAttributeValue("", 189, "background-image:", 189, 17, true);
            WriteAttributeValue(" ", 206, "url(images/", 207, 12, true);
#nullable restore
#line 4 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\_LatestSubscribePartial.cshtml"
WriteAttributeValue("", 218, Model.BackgroundImg, 218, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 238, ");", 238, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""container"">
                <div class=""row d-flex align-items-center"">
                    <div class=""col-xl-5 col-lg-5 col-md-6 offset-xl-1 offset-lg-1"">
                        <div class=""latest-caption"">
                            <h2>");
#nullable restore
#line 9 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\_LatestSubscribePartial.cshtml"
                           Write(Html.Raw(@Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            <p>");
#nullable restore
#line 10 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\_LatestSubscribePartial.cshtml"
                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-xl-5 col-lg-5 col-md-6 \">\r\n                        <div class=\"latest-subscribe\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c7fa5b6085bb4dc37e99cef40df5402b96557757256", async() => {
                WriteLiteral("\r\n                                <input type=\"email\" placeholder=\"Your email here\">\r\n                                <button>Shop Now</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"latest-man\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1185, "\"", 1208, 2);
            WriteAttributeValue("", 1191, "images/", 1191, 7, true);
#nullable restore
#line 24 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\_LatestSubscribePartial.cshtml"
WriteAttributeValue("", 1198, Model.Img, 1198, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1209, "\"", 1215, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!-- Latest subscribe area ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LatestSubscribe> Html { get; private set; }
    }
}
#pragma warning restore 1591
