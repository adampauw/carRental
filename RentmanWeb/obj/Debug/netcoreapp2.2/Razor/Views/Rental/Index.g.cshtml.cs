#pragma checksum "/Users/adampauw/RentmanWeb/RentmanWeb/Views/Rental/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8b2bc895679c9d5d3ca1d47a8dae0435f6f4fd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rental_Index), @"mvc.1.0.view", @"/Views/Rental/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rental/Index.cshtml", typeof(AspNetCore.Views_Rental_Index))]
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
#line 1 "/Users/adampauw/RentmanWeb/RentmanWeb/Views/_ViewImports.cshtml"
using RentmanWeb;

#line default
#line hidden
#line 2 "/Users/adampauw/RentmanWeb/RentmanWeb/Views/_ViewImports.cshtml"
using RentmanWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b2bc895679c9d5d3ca1d47a8dae0435f6f4fd2", @"/Views/Rental/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7443b881b81ce10573fbbc105865f172e9d910ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Rental_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentalViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/adampauw/RentmanWeb/RentmanWeb/Views/Rental/Index.cshtml"
  
    ViewData["Title"] = "Rental";

#line default
#line hidden
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(64, 205, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Rent a baby! no wait we rent cars</h1>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n");
            EndContext();
            BeginContext(270, 11, false);
#line 10 "/Users/adampauw/RentmanWeb/RentmanWeb/Views/Rental/Index.cshtml"
Write(Model.Begin);

#line default
#line hidden
            EndContext();
            BeginContext(281, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
