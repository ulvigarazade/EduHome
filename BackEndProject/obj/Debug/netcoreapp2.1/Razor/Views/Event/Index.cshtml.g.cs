#pragma checksum "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c307498db912e67dc8495493b7f6398ce2a1ee83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Index), @"mvc.1.0.view", @"/Views/Event/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Event/Index.cshtml", typeof(AspNetCore.Views_Event_Index))]
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
#line 1 "D:\Code Academy\EduHome-master\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.ViewModels;

#line default
#line hidden
#line 2 "D:\Code Academy\EduHome-master\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.Models;

#line default
#line hidden
#line 3 "D:\Code Academy\EduHome-master\BackEndProject\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c307498db912e67dc8495493b7f6398ce2a1ee83", @"/Views/Event/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6a7137cbfc21f64254730f2e3df1d47d27077f", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 102, true);
            WriteLiteral("\n<!-- Banner Area Start -->\n<div class=\"banner-area-wrapper\">\n    <div class=\"banner-area text-center\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 117, "\"", 194, 5);
            WriteAttributeValue("", 125, "background-image:", 125, 17, true);
            WriteAttributeValue(" ", 142, "url(/img/banner/", 143, 17, true);
#line 5 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
WriteAttributeValue("", 159, Model.Background.Image, 159, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 182, ")", 182, 1, true);
            WriteAttributeValue(" ", 183, "!important", 184, 11, true);
            EndWriteAttribute();
            BeginContext(195, 625, true);
            WriteLiteral(@">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>events</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Blog Start -->
<div class=""blog-area event-area three text-center pt-150 pb-90"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""row"">
");
            EndContext();
#line 26 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                     foreach (Event _event in Model.Event)
                    {


#line default
#line hidden
            BeginContext(902, 293, true);
            WriteLiteral(@"                        <div class=""col-md-6 col-sm-6 col-xs-12"">
                            <div class=""single-event mb-60"">
                                <div class=""event-img"">
                                    <a href=""event-details.html"">
                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1195, "\"", 1224, 2);
            WriteAttributeValue("", 1201, "img/event/", 1201, 10, true);
#line 33 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
WriteAttributeValue("", 1211, _event.Image, 1211, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1225, 345, true);
            WriteLiteral(@" alt=""event"">
                                        <div class=""course-hover"">
                                            <i class=""fa fa-link""></i>
                                        </div>
                                    </a>
                                    <div class=""event-date"">
                                        <h3>");
            EndContext();
            BeginContext(1571, 60, false);
#line 39 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                                       Write(_event.Date.ToString("dd MMM", CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(1631, 227, true);
            WriteLiteral("</h3>\n                                    </div>\n                                </div>\n                                <div class=\"event-content text-left\">\n                                    <h4><a href=\"event-details.html\">");
            EndContext();
            BeginContext(1859, 13, false);
#line 43 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                                                                Write(_event.Header);

#line default
#line hidden
            EndContext();
            BeginContext(1872, 114, true);
            WriteLiteral("</a></h4>\n                                    <ul>\n                                        <li><span>time:</span> ");
            EndContext();
            BeginContext(1987, 15, false);
#line 45 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                                                          Write(_event.Interval);

#line default
#line hidden
            EndContext();
            BeginContext(2002, 69, true);
            WriteLiteral("</li>\n                                        <li><span>venue</span> ");
            EndContext();
            BeginContext(2072, 15, false);
#line 46 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                                                          Write(_event.Location);

#line default
#line hidden
            EndContext();
            BeginContext(2087, 368, true);
            WriteLiteral(@"</li>
                                    </ul>
                                    <div class=""event-content-right"">
                                        <a class=""default-btn"" href=""event-details.html"">join now</a>
                                    </div>
                                </div>
                            </div>
                        </div>
");
            EndContext();
#line 54 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2477, 313, true);
            WriteLiteral(@"                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""blog-sidebar right text-left"">
                    <div class=""single-blog-widget mb-50"">
                        <h3>search</h3>
                        <div class=""blog-search"">
                            ");
            EndContext();
            BeginContext(2790, 334, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6484a11031bb47e5aa32ceb0c20ada39", async() => {
                BeginContext(2819, 298, true);
                WriteLiteral(@"
                                <input type=""search"" placeholder=""Search..."" name=""search"" />
                                <button type=""submit"">
                                    <span><i class=""fa fa-search""></i></span>
                                </button>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3124, 187, true);
            WriteLiteral("\n                        </div>\n                    </div>\n                    <div class=\"single-blog-widget mb-50\">\n                        <h3>Events</h3>\n                        <ul>\n");
            EndContext();
#line 73 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                             foreach (Event eventName in Model.Event)
                            {

#line default
#line hidden
            BeginContext(3411, 39, true);
            WriteLiteral("                                <li><a>");
            EndContext();
            BeginContext(3451, 26, false);
#line 75 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                                  Write(eventName.Header.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(3477, 11, true);
            WriteLiteral(" </a></li>\n");
            EndContext();
#line 76 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3518, 517, true);
            WriteLiteral(@"                        </ul>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <div class=""single-blog-banner"">
                            <a href=""blog-details.html"" id=""blog""><img src=""img/blog/blog-img.jpg"" alt=""blog""></a>
                            <h2>best<br> eductaion<br> theme</h2>
                        </div>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <h3>latest blogs</h3>
");
            EndContext();
#line 87 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                         foreach (Blog blog in Model.Blogs)
                        {


#line default
#line hidden
            BeginContext(4122, 364, true);
            WriteLiteral(@"                                <div class=""row"">
                                    <div class=""single-post mb-30"">
                                        <div class=""single-post-img"">
                                            <a href=""blog-details.html"" style=""width:33% !important; margin-top:5px!important"">
                                                ");
            EndContext();
            BeginContext(4486, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f560558d5d494223b048267128893a05", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4496, "~/img/blog/", 4496, 11, true);
#line 94 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
AddHtmlAttributeValue("", 4507, blog.Image, 4507, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4531, 454, true);
            WriteLiteral(@"
                                                <div class=""blog-hover"">
                                                    <i class=""fa fa-link""></i>
                                                </div>
                                            </a>
                                        </div>
                                        <div class=""single-post-content"">
                                            <h4><a href=""blog-details.html"">");
            EndContext();
            BeginContext(4986, 11, false);
#line 101 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                                                                       Write(blog.Header);

#line default
#line hidden
            EndContext();
            BeginContext(4997, 60, true);
            WriteLiteral("</a></h4>\n                                            <p>By ");
            EndContext();
            BeginContext(5058, 14, false);
#line 102 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                                             Write(blog.Publisher);

#line default
#line hidden
            EndContext();
            BeginContext(5072, 5, true);
            WriteLiteral("  /  ");
            EndContext();
            BeginContext(5078, 64, false);
#line 102 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                                                                 Write(blog.Date.ToString("MMM dd, yyyy", CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(5142, 134, true);
            WriteLiteral("</p>\n                                        </div>\n                                    </div>\n                                </div>\n");
            EndContext();
#line 106 "D:\Code Academy\EduHome-master\BackEndProject\Views\Event\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5302, 812, true);
            WriteLiteral(@"                    </div>
                    <div class=""single-blog-widget"">
                        <h3>tags</h3>
                        <div class=""single-tag"">
                            <a href=""blog-details.html"" class=""mr-10 mb-10"">course</a>
                            <a href=""blog-details.html"" class=""mr-10 mb-10"">education</a>
                            <a href=""blog-details.html"" class=""mb-10"">teachers</a>
                            <a href=""blog-details.html"" class=""mr-10"">learning</a>
                            <a href=""blog-details.html"" class=""mr-10"">university</a>
                            <a href=""blog-details.html"">events</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Blog End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
