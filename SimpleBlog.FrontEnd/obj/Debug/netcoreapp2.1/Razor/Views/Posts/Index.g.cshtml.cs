#pragma checksum "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a41eb2994e5498639824d1ecd193c681dfb6b31b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Index), @"mvc.1.0.view", @"/Views/Posts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/Index.cshtml", typeof(AspNetCore.Views_Posts_Index))]
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
#line 1 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\_ViewImports.cshtml"
using SimpleBlog.FrontEnd;

#line default
#line hidden
#line 2 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\_ViewImports.cshtml"
using SimpleBlog.FrontEnd.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a41eb2994e5498639824d1ecd193c681dfb6b31b", @"/Views/Posts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"333b4d5741233eb07802cc45b29e0288188afc3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleBlog.FrontEnd.ViewModels.PostsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Index.cshtml"
  
    ViewData["Title"] = "Our Simple Blog Posts";
    var bgRand = new Random(0);

#line default
#line hidden
            BeginContext(144, 22, true);
            WriteLiteral("\r\n<h1>Our Posts</h1>\r\n");
            EndContext();
#line 8 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Index.cshtml"
 if(Model.Posts != null && Model.Posts.Count() > 0) 
{
    foreach(var post in Model.Posts) 
    {

#line default
#line hidden
            BeginContext(269, 47, true);
            WriteLiteral("        <div class=\"row m1emb\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 316, "\"", 376, 1);
#line 13 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Index.cshtml"
WriteAttributeValue("", 323, Url.Action("Details", "Posts", new { id = post.Id }), 323, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(377, 67, true);
            WriteLiteral(">\r\n                <div class=\"col-md-4\">\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 444, "\"", 461, 1);
#line 15 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Index.cshtml"
WriteAttributeValue("", 450, post.Image, 450, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 462, "\"", 479, 1);
#line 15 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Index.cshtml"
WriteAttributeValue("", 468, post.Title, 468, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(480, 116, true);
            WriteLiteral(" class=\"img-responsive\" />\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <h3>");
            EndContext();
            BeginContext(597, 10, false);
#line 18 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Index.cshtml"
                   Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(607, 65, true);
            WriteLiteral("</h3>\r\n                </div>\r\n            </a>\r\n        </div>\r\n");
            EndContext();
#line 22 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Index.cshtml"
    }
} else {

#line default
#line hidden
            BeginContext(689, 137, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <p>There\'s nothing to see here.. :|</p>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 29 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleBlog.FrontEnd.ViewModels.PostsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
