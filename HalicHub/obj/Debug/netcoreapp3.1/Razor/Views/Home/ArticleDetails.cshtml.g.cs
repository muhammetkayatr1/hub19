#pragma checksum "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c111deab230c455c0c2aea1c2ef3727068142d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ArticleDetails), @"mvc.1.0.view", @"/Views/Home/ArticleDetails.cshtml")]
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
#line 1 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using Halic.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\_ViewImports.cshtml"
using HalicHub.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c111deab230c455c0c2aea1c2ef3727068142d7", @"/Views/Home/ArticleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1d447f06f600cad35a08585f36a3d6ae0aa3e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ArticleDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArticleDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("author_img rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AuthorDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ArticleDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
Write(await Html.PartialAsync("_Header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"blog_area p_120 single-post-area\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-lg-8\">\n                <div class=\"main_blog_details\">\n                    <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 293, "\"", 325, 2);
            WriteAttributeValue("", 299, "/img/", 299, 5, true);
#nullable restore
#line 8 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
WriteAttributeValue("", 304, Model.Articles.Image, 304, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 326, "\"", 332, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <a href=\"#\"><h4>");
#nullable restore
#line 9 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                               Write(Model.Articles.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></a>\n                    <div class=\"user_details\">\n                        <div class=\"float-right\">\n                            <div class=\"media\">\n                                <div class=\"media-body\">\n");
#nullable restore
#line 14 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                                     foreach (var item in Model.Authors)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5>");
#nullable restore
#line 16 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                       Write(item.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>");
#nullable restore
#line 16 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 17 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                                  Write(Model.Articles.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                </div>\n                                <div class=\"d-flex\">\n                                    <img src=\"img/blog2/user-img.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 992, "\"", 998, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                    <p>");
#nullable restore
#line 25 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                  Write(Html.Raw(Model.Articles.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </div>\n            </div>\n            <div class=\"col-lg-4\">\n                <div class=\"blog_right_sidebar\">\n");
#nullable restore
#line 30 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                     foreach (var item in Model.Authors)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <aside class=\"single_sidebar_widget author_widget\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c111deab230c455c0c2aea1c2ef3727068142d710949", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1515, "~/img/", 1515, 6, true);
#nullable restore
#line 33 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
AddHtmlAttributeValue("", 1521, item.Image, 1521, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c111deab230c455c0c2aea1c2ef3727068142d712620", async() => {
#nullable restore
#line 34 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                                                                                            Write(item.NameSurname);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-author", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                                                                          WriteLiteral(item.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["author"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-author", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["author"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\n            <p>");
#nullable restore
#line 35 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <div class=""social_icon"">
                <a href=""#""><i class=""fa fa-facebook""></i></a>
                <a href=""#""><i class=""fa fa-twitter""></i></a>
                <a href=""#""><i class=""fa fa-github""></i></a>
                <a href=""#""><i class=""fa fa-behance""></i></a>
            </div>
            <div class=""br""></div>
        </aside>");
#nullable restore
#line 43 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <aside class=\"single_sidebar_widget popular_post_widget\">\n                    <h3 class=\"widget_title\">İlgili Yazılar</h3>\n\n");
#nullable restore
#line 47 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                     foreach (var articles in (List<Article>)ViewBag.tası)
                    {
                        if (articles.Url != Model.Articles.Url)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"media post_item\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2458, "\"", 2484, 2);
            WriteAttributeValue("", 2464, "/img/", 2464, 5, true);
#nullable restore
#line 52 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
WriteAttributeValue("", 2469, articles.Image, 2469, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"post\">\n                    <div class=\"media-body\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c111deab230c455c0c2aea1c2ef3727068142d717301", async() => {
                WriteLiteral("<h3>");
#nullable restore
#line 54 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                                                                                                          Write(articles.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-url", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                                                                                WriteLiteral(articles.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-url", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <p>");
#nullable restore
#line 55 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                      Write(articles.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    </div>\n                </div>");
#nullable restore
#line 57 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
                      }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"br\"></div>\n                </aside>\n                    <aside class=\"single_sidebar_widget\">\n                        <h4 class=\"widget_title\">E-Bülten Aboneliği</h4>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c111deab230c455c0c2aea1c2ef3727068142d720878", async() => {
                WriteLiteral("\n                            <div class=\"form-group\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c111deab230c455c0c2aea1c2ef3727068142d721223", async() => {
                    WriteLiteral(@"
                                    <input class=""form-control"" style=""width: 100%; margin-bottom: 20px; border-radius: 0px;"" type=""text"" placeholder=""Email"">
                                    <button style=""background: #140C40; color: white; padding: 10px 5px 10px 5px; width: 100%;"" type=""button"">Gönder</button>
                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                            </div>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </aside>
                    <aside class=""single_sidebar_widget post_category_widget"">
                        <h4 class=""widget_title"">Kategoriler</h4>
                        <ul class=""list cat-list"">
                        <li style=""display: block;"">
                            <a href=""#"" class=""d-flex justify-content-between"">
                                <p>Teknoloji</p>
                                <p>37</p>
                            </a>
                        </li>} 
                        </ul>
                        <div class=""br""></div>
                    </aside>
                </div>
            </div>

        </div>
    </div>
</section>
");
#nullable restore
#line 90 "C:\Users\muhammetkaya\Desktop\Hub Versions\sn-main\HalicHub\Views\Home\ArticleDetails.cshtml"
Write(await Html.PartialAsync("_Footer"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArticleDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591