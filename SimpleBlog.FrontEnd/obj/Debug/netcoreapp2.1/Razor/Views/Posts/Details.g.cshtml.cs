#pragma checksum "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3671d00a8cdc1cc2280136291a3cad9757b159bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/Details.cshtml", typeof(AspNetCore.Views_Posts_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3671d00a8cdc1cc2280136291a3cad9757b159bb", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"333b4d5741233eb07802cc45b29e0288188afc3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimpleBlog.FrontEnd.ViewModels.PostDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
  
    ViewData["Title"] = $"{Model.Post.Title} - Simple Blog";
    var bgRand = new Random(0);

#line default
#line hidden
            BeginContext(162, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
 if(Model.Post != null) 
{

#line default
#line hidden
            BeginContext(193, 8, true);
            WriteLiteral("    <h1>");
            EndContext();
            BeginContext(202, 16, false);
#line 9 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
   Write(Model.Post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(218, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
            BeginContext(231, 81, true);
            WriteLiteral("    <div class=\"row mb-1\">\r\n        <div class=\"col-md-12\">\r\n            <h2><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 312, "\"", 414, 4);
            WriteAttributeValue("", 318, "https://via.placeholder.com/1920x600/", 318, 37, true);
#line 13 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
WriteAttributeValue("", 355, bgRand.Next(100000, 1000000), 355, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 384, "/ffffff?text=", 384, 13, true);
#line 13 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
WriteAttributeValue("", 397, Model.Post.Title, 397, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 415, "\"", 438, 1);
#line 13 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
WriteAttributeValue("", 421, Model.Post.Title, 421, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(439, 61, true);
            WriteLiteral(" class=\"img-responsive\" /></h2>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(502, 68, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(571, 15, false);
#line 19 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
       Write(Model.Post.Body);

#line default
#line hidden
            EndContext();
            BeginContext(586, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(622, 68, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
            EndContext();
            BeginContext(691, 15, false);
#line 25 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
       Write(Model.Post.Body);

#line default
#line hidden
            EndContext();
            BeginContext(706, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(738, 26, true);
            WriteLiteral("<h2>What people say</h2>\r\n");
            EndContext();
#line 30 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
    foreach(var comment in Model.Comments) 
    {

#line default
#line hidden
            BeginContext(816, 83, true);
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-1\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 899, "\"", 920, 1);
#line 34 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
WriteAttributeValue("", 905, comment.Avatar, 905, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 921, "\"", 940, 1);
#line 34 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
WriteAttributeValue("", 927, comment.Name, 927, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(941, 120, true);
            WriteLiteral(" class=\"img-responsive\" />                \r\n            </div>\r\n            <div class=\"col-md-5\">\r\n                <h3>");
            EndContext();
            BeginContext(1062, 12, false);
#line 37 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
               Write(comment.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1074, 26, true);
            WriteLiteral("</h3>\r\n                <p>");
            EndContext();
            BeginContext(1101, 12, false);
#line 38 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
              Write(comment.Body);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 42, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 41 "C:\Projects\Recruitment\Improve-Blog-Challenge\SimpleBlog.FrontEnd\Views\Posts\Details.cshtml"
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimpleBlog.FrontEnd.ViewModels.PostDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
