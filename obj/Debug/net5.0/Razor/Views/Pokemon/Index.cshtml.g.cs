#pragma checksum "C:\Users\takes\source\repos\ApiTesting\Views\Pokemon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03f4a15c587cefe6968ca30b5644027538d9b6a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon_Index), @"mvc.1.0.view", @"/Views/Pokemon/Index.cshtml")]
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
#line 1 "C:\Users\takes\source\repos\ApiTesting\Views\_ViewImports.cshtml"
using ApiTesting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\takes\source\repos\ApiTesting\Views\_ViewImports.cshtml"
using ApiTesting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f4a15c587cefe6968ca30b5644027538d9b6a5", @"/Views/Pokemon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"149e95b92ac87989d215d22e7c61c51bcde77ec7", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokemon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApiTesting.Models.Pokemon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\takes\source\repos\ApiTesting\Views\Pokemon\Index.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n\r\n");
#nullable restore
#line 9 "C:\Users\takes\source\repos\ApiTesting\Views\Pokemon\Index.cshtml"
Write(ViewBag.Test);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<hr />\r\n\r\n");
#nullable restore
#line 13 "C:\Users\takes\source\repos\ApiTesting\Views\Pokemon\Index.cshtml"
Write(ViewBag.ApiResponse);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<hr />\r\n\r\n<table class=\"table table-sm table-striped table-bordered m-2\">\r\n    <thead>\r\n        <tr>\r\n            <th>URL</th>\r\n            <th>Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\takes\source\repos\ApiTesting\Views\Pokemon\Index.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\takes\source\repos\ApiTesting\Views\Pokemon\Index.cshtml"
               Write(p.url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\takes\source\repos\ApiTesting\Views\Pokemon\Index.cshtml"
               Write(p.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\takes\source\repos\ApiTesting\Views\Pokemon\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApiTesting.Models.Pokemon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
