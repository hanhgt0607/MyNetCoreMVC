#pragma checksum "C:\Users\Hanh\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ed0b85bd6d19a99fceda7e078493211eb8ac53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Create.cshtml", typeof(AspNetCore.Views_Product_Create))]
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
#line 1 "C:\Users\Hanh\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\_ViewImports.cshtml"
using MyNetCoreMVC;

#line default
#line hidden
#line 2 "C:\Users\Hanh\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\_ViewImports.cshtml"
using MyNetCoreMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ed0b85bd6d19a99fceda7e078493211eb8ac53", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e8349a69a9b9dbbc33631bafc0217674c3299b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Hanh\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(44, 31, true);
            WriteLiteral("\r\n<h2>Hello Create</h2>\r\n\r\n<h3>");
            EndContext();
            BeginContext(76, 16, false);
#line 8 "C:\Users\Hanh\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\Create.cshtml"
Write(ViewData["name"]);

#line default
#line hidden
            EndContext();
            BeginContext(92, 11, true);
            WriteLiteral("</h3>\r\n<h3>");
            EndContext();
            BeginContext(104, 17, false);
#line 9 "C:\Users\Hanh\source\repos\MyNetCoreMVC\MyNetCoreMVC\Views\Product\Create.cshtml"
Write(ViewData["price"]);

#line default
#line hidden
            EndContext();
            BeginContext(121, 5, true);
            WriteLiteral("</h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
