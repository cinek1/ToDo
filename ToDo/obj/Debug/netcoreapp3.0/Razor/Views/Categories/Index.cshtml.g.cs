#pragma checksum "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50dedb4ca5e31d238b3c357d2360310f1920bbc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Index), @"mvc.1.0.view", @"/Views/Categories/Index.cshtml")]
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
#line 1 "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\_ViewImports.cshtml"
using ToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\_ViewImports.cshtml"
using ToDo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50dedb4ca5e31d238b3c357d2360310f1920bbc9", @"/Views/Categories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24dbfa247bf4efcab4de47a8cd07946aafc5d6b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToDoMVC.Model.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\Categories\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Categories</h1>\r\n<p> ");
#nullable restore
#line 8 "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\Categories\Index.cshtml"
Write(Html.ActionLink("Create New Category", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n<table class=\"table\">\r\n\r\n    <thead>\r\n        ");
#nullable restore
#line 14 "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\Categories\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </thead>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\Categories\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\Categories\Index.cshtml"
           Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\Categories\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\Categories\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\Categories\Index.cshtml"
           Write(Html.ActionLink("Works", "Index", "Works", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\nnnnn\source\repos\ToDo\ToDo\Views\Categories\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToDoMVC.Model.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
