#pragma checksum "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fdecd2aeb6fc3847f3beac72585c7f34ce2021b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 1 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Blog\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fdecd2aeb6fc3847f3beac72585c7f34ce2021b", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Blog\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-6 card\">\r\n        <a href=\"single.html\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 264, "\"", 285, 1);
#nullable restore
#line 13 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 270, item.BlogImage, 270, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 317, "\"", 323, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </a>\r\n        <div class=\"card-body\">\r\n            <ul class=\"blog-icons my-4\">\r\n                <li>\r\n                    <a href=\"#\">\r\n                        <i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 19 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Blog\Index.cshtml"
                                                        Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </a>
                </li>
                <li class=""mx-2"">
                    <a href=""#"">
                        <i class=""far fa-comment""></i> 21
                    </a>
                </li>
                <li>
                    <a href=""#"">
                        <i class=""fas fa-eye""></i> ");
#nullable restore
#line 29 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Blog\Index.cshtml"
                                              Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </li>\r\n\r\n            </ul>\r\n            <h5 class=\"card-title \">\r\n                <a href=\"single.html\">");
#nullable restore
#line 35 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Blog\Index.cshtml"
                                 Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </h5>\r\n            <p class=\"card-text mb-3\">");
#nullable restore
#line 37 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Blog\Index.cshtml"
                                 Write(item.BlogContent.Substring(0, item.BlogContent.Substring(0, 130).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral(") ...</p>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1286, "\"", 1324, 3);
            WriteAttributeValue("", 1293, "/Blog/BlogReadAll/", 1293, 18, true);
#nullable restore
#line 38 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1311, item.BlogID, 1311, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1323, "", 1324, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 41 "C:\Users\RTC9911\Documents\GitHub\BlogProject-Asp.Net-Core\CoreDemo\Views\Blog\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
