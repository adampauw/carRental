#pragma checksum "/Users/adampauw/Rentman/RentmanWeb/Views/Customer/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "581b9098599ca3690d1aefbb7527c8e83cfd1bfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Index.cshtml", typeof(AspNetCore.Views_Customer_Index))]
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
#line 1 "/Users/adampauw/Rentman/RentmanWeb/Views/_ViewImports.cshtml"
using RentmanWeb;

#line default
#line hidden
#line 2 "/Users/adampauw/Rentman/RentmanWeb/Views/_ViewImports.cshtml"
using RentmanWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581b9098599ca3690d1aefbb7527c8e83cfd1bfe", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7443b881b81ce10573fbbc105865f172e9d910ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rentman.CustomerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/adampauw/Rentman/RentmanWeb/Views/Customer/Index.cshtml"
  
    ViewData["Index"] = "List Customers";

#line default
#line hidden
            BeginContext(80, 255, true);
            WriteLiteral("\n<div class=\"text-center table-body\">\n\t<h3 class=\"table-header\">Customer List</h3>\n\t<table style=\"width:100%\">\n\t\t<tr class=\"titles\">\n\t\t\t<th>Id</th>\n\t\t\t<th>First Name</th> \n\t\t\t<th>Last Name</th>\n\t\t\t<th>Drivers License</th>\n\t\t\t<th>Phone Number</th>\n\t\t</tr>\n");
            EndContext();
#line 16 "/Users/adampauw/Rentman/RentmanWeb/Views/Customer/Index.cshtml"
         foreach (RentmanLib.Customer item in Model.CustomerList)
			{

#line default
#line hidden
            BeginContext(400, 18, true);
            WriteLiteral("\t\t\t\t<tr>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(419, 7, false);
#line 19 "/Users/adampauw/Rentman/RentmanWeb/Views/Customer/Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(426, 15, true);
            WriteLiteral("</td>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(442, 15, false);
#line 20 "/Users/adampauw/Rentman/RentmanWeb/Views/Customer/Index.cshtml"
                   Write(item.first_name);

#line default
#line hidden
            EndContext();
            BeginContext(457, 15, true);
            WriteLiteral("</td>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(473, 14, false);
#line 21 "/Users/adampauw/Rentman/RentmanWeb/Views/Customer/Index.cshtml"
                   Write(item.last_name);

#line default
#line hidden
            EndContext();
            BeginContext(487, 15, true);
            WriteLiteral("</td>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(503, 14, false);
#line 22 "/Users/adampauw/Rentman/RentmanWeb/Views/Customer/Index.cshtml"
                   Write(item.DL_Number);

#line default
#line hidden
            EndContext();
            BeginContext(517, 15, true);
            WriteLiteral("</td>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(533, 17, false);
#line 23 "/Users/adampauw/Rentman/RentmanWeb/Views/Customer/Index.cshtml"
                   Write(item.phone_number);

#line default
#line hidden
            EndContext();
            BeginContext(550, 16, true);
            WriteLiteral("</td>\n\t\t\t\t</tr>\n");
            EndContext();
#line 25 "/Users/adampauw/Rentman/RentmanWeb/Views/Customer/Index.cshtml"
			}

#line default
#line hidden
            BeginContext(571, 17, true);
            WriteLiteral("\t</table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rentman.CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
