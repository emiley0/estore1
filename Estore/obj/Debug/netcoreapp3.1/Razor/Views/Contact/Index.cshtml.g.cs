#pragma checksum "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f123a363dc230a3a8ff3005926b2068674f8107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f123a363dc230a3a8ff3005926b2068674f8107", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"209deeccd7ac6be9763349b30c3e2d3a2311a0d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  ");
#nullable restore
#line 6 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
Write(await Component.InvokeAsync("Banner",new { Title = "Contact Us" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <!-- Contact area starts -->\r\n    <section class=\"contact-area\">\r\n        <div class=\"container\">\r\n            <div class=\"google-map  d-flex justify-content-center align-items-center mb-5\">\r\n                <iframe");
            BeginWriteAttribute("src", " src=\"", 355, "\"", 381, 1);
#nullable restore
#line 13 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
WriteAttributeValue("", 361, Model.Map.GoogleMap, 361, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                    width=""100%"" height=""450px"" style=""border:0;"" allowfullscreen=""true"" loading=""lazy""></iframe>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    <h2 class=""contact-title"">Get in Touch</h2>
                </div>
                <div class=""col-lg-8"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f123a363dc230a3a8ff3005926b2068674f81077406", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <textarea class=""form-control w-100 h-100"" name=""message"" id=""message"" cols=""30"" rows=""9"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter Message'"" placeholder=""Enter Message"" style=""margin-top: 0px; margin-bottom: 0px; height: 87px;""></textarea>
                                </div>
                            </div>
                            <div style=""right:8px;"" class=""col-sm-6 position-relative"">
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""name"" id=""name"" type=""text"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter your name'"" placeholder=""Enter your name"">
                                </div>
                            </div>
                            <div style=""left:8px"" class=""col-s");
                WriteLiteral(@"m-6 position-relative"">
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""email"" id=""email"" type=""email"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter email address'"" placeholder=""Email"">
                                </div>
                            </div>
                            <div class=""col-12"">
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""subject"" id=""subject"" type=""text"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter Subject'"" placeholder=""Enter Subject"">
                                </div>
                            </div>
                        </div>
                        <div class=""form-group mt-3"">
                            <button type=""submit"" class=""btn"">Send</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-lg-3 offset-lg-1\">\r\n");
#nullable restore
#line 50 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                 foreach (ContactInfo contact in Model.ContactInfos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"contact-info\">\r\n");
#nullable restore
#line 53 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                         if (contact.ContactType == "Email")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"contact-info-icon\"><i class=\"far fa-envelope\"></i></span>\r\n");
#nullable restore
#line 56 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                    }
                        else if (contact.ContactType == "Address")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"contact-info-icon\"><i class=\"fas fa-home\"></i></span>\r\n");
#nullable restore
#line 60 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"


                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <span class=\"contact-info-icon\"><i class=\"fas fa-mobile-alt\"></i></span>\r\n");
#nullable restore
#line 66 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                            
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        \r\n                        <div class=\"contact-info-body\">\r\n                            <h3>");
#nullable restore
#line 71 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                           Write(contact.Contactinfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            <p>");
#nullable restore
#line 72 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                          Write(contact.ContactText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 75 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <!-- Contact area ends -->\r\n\r\n    ");
#nullable restore
#line 85 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Contact\Index.cshtml"
Write(await Html.PartialAsync("_GalleryPartial",Model.Galleries));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
