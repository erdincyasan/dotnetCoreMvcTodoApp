#pragma checksum "C:\Users\erdinc\source\repos\Udemy.TodoApp\Udemy.TodoApp.UI\Views\Home\NotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3fa5d5b5b62085541c9b43e4a750e8d5bec1ff3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NotFound), @"mvc.1.0.view", @"/Views/Home/NotFound.cshtml")]
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
#line 2 "C:\Users\erdinc\source\repos\Udemy.TodoApp\Udemy.TodoApp.UI\Views\_ViewImports.cshtml"
using Udemy.TodoApp.Dtos.WorkDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3fa5d5b5b62085541c9b43e4a750e8d5bec1ff3", @"/Views/Home/NotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bdaabb754a148b4d14045a9d3093e5715231345", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\erdinc\source\repos\Udemy.TodoApp\Udemy.TodoApp.UI\Views\Home\NotFound.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-12 d-flex justify-content-center\">\r\n    <div>\r\n        <h2>\r\n            Aradığınız şey bulunamadı!\r\n        </h2>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
