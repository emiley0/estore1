#pragma checksum "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db865ae5d96dc8215325559bc003b88a7273350b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Blog_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Blog/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db865ae5d96dc8215325559bc003b88a7273350b", @"/Views/Shared/Components/Blog/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"209deeccd7ac6be9763349b30c3e2d3a2311a0d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Blog_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("srcset", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Blogdetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubscribeEmail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("   <div class=\"col-lg-4\">\r\n                    <div class=\"blog-right-container\">\r\n                        <div class=\"blog-right-item blog-right-search\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db865ae5d96dc8215325559bc003b88a7273350b7999", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <div class=""input-group mb-3"">
                                        <input type=""text"" class=""form-control"" placeholder=""Search Keyword"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Search Keyword'"">
                                        <div class=""input-group-append"">
                                            <button type=""button"" class=""search-btn"">
                                                <i class=""fa fa-search"" aria-hidden=""true""></i>
                                            </button>
                                        </div>

                                    </div>
                                    <button class=""search-submit-btn btn"">Search</button>
                                </div>
                            ");
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
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"blog-right-item blog-categories\">\r\n                            <h4>Category</h4>\r\n\r\n                            <ul>\r\n                               \r\n");
#nullable restore
#line 27 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                               foreach (Category category in Model.Categories)
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <li><a href=\"#\"> ");
#nullable restore
#line 29 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                                          Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 30 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                


                            </ul>
                        </div>
                        <div class=""blog-right-item recent-post"">
                            <h4>
                                Recent Post
                            </h4>
");
#nullable restore
#line 40 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                             foreach (Post post in Model.Posts.OrderByDescending(o=>o.Id).Take(4))
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <div class=\"blog-post-container\">\r\n                                <div style=\"width:46%;height:auto\" class=\"recent-post-img\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "db865ae5d96dc8215325559bc003b88a7273350b12354", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2204, "~/images/", 2204, 9, true);
#nullable restore
#line 44 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
AddHtmlAttributeValue("", 2213, post.Img, 2213, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"recent-post-text mt-0\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db865ae5d96dc8215325559bc003b88a7273350b14292", async() => {
                WriteLiteral("\r\n                                        <h3>");
#nullable restore
#line 48 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                                       Write(post.Title.Substring(0,36));

#line default
#line hidden
#nullable disable
                WriteLiteral("...</h3>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                                                                                        WriteLiteral(post.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n                                    <p>");
#nullable restore
#line 51 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                                  Write(post.CreatedAt.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\n");
#nullable restore
#line 54 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                          
                          

                        </div>
                        <div class=""blog-right-item tag-clouds"">
                            <div class=""blog-post-container"">
                                <h4>
                                    Tag Clouds
                                </h4>
                                <ul>
");
#nullable restore
#line 65 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                                     foreach (Tags tag in Model.Tags)
                                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         <li>\r\n                                        <a href=\"#\">");
#nullable restore
#line 68 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                                               Write(tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\n");
#nullable restore
#line 70 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                  
                                   
                                </ul>
                            </div>
                        </div>
                        <div class=""blog-right-item instagram-feeds"">
                            <h4>
                                Instagram feeds
                            </h4>
                            <div class=""blog-post-container"">
                                <ul>
");
#nullable restore
#line 82 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                                     foreach (InstagramFeed item in @Model.InstagramFeeds)
                                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\r\n                                        <a style=\"cursor:pointer\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "db865ae5d96dc8215325559bc003b88a7273350b20397", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4177, "~/images/", 4177, 9, true);
#nullable restore
#line 85 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
AddHtmlAttributeValue("", 4186, item.Img, 4186, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                    </li>\n");
#nullable restore
#line 87 "C:\Users\Ali Aliyev\Desktop\Final-Project-Estore\Final-Project-Estore\Estore-back\Estore\Estore\Views\Shared\Components\Blog\Default.cshtml"
                                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                   
                                   
                                </ul>
                            </div>
                        </div>
                        <div class=""blog-right-item blog-subscribe"">
                            <h4>
                                Subscribe
                            </h4>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db865ae5d96dc8215325559bc003b88a7273350b22749", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <div class=""input-group mb-3"">
                                        <input type=""email"" name=""Email"" class=""form-control"" placeholder=""Enter email"" onfocus=""this.placeholder = ''"" onblur=""this.placeholder = 'Enter email'"">


                                    </div>
                                    <button onclick=""Popup()"" type=""submit"" class=""search-submit-btn btn w-100"">Submit</button>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <script>\r\n                    function Popup() {\r\n  alert(\"Thank you for subscribe!\");\r\n}\r\n                </script>\r\n               ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
