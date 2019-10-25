#pragma checksum "/Users/adampauw/Rentman/RentmanWeb/Views/Car/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecf571a2441b2825374cf05579c913821db1cab2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Index), @"mvc.1.0.view", @"/Views/Car/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Car/Index.cshtml", typeof(AspNetCore.Views_Car_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecf571a2441b2825374cf05579c913821db1cab2", @"/Views/Car/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7443b881b81ce10573fbbc105865f172e9d910ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rentman.CarViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Car", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/adampauw/Rentman/RentmanWeb/Views/Car/Index.cshtml"
  
    ViewData["Index"] = "List Cars";

#line default
#line hidden
            BeginContext(70, 79, true);
            WriteLiteral("\n<div class=\"text-center table-body\">\n\t<h3 class=\"table-header\">Car List</h3>\n\t");
            EndContext();
            BeginContext(149, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecf571a2441b2825374cf05579c913821db1cab23883", async() => {
                BeginContext(193, 10, true);
                WriteLiteral("Create Car");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(207, 165, true);
            WriteLiteral("\n\t<table style=\"width:100%\">\n\t\t<tr class=\"titles\">\n\t\t\t<th>Id</th>\n\t\t\t<th>Make</th> \n\t\t\t<th>Model</th>\n\t\t\t<th>Colour</th>\n\t\t\t<th>Year</th>\n\t\t\t<th>Milage</th>\n\t\t</tr>\n");
            EndContext();
#line 18 "/Users/adampauw/Rentman/RentmanWeb/Views/Car/Index.cshtml"
         foreach (RentmanLib.Car item in Model.CarList)
			{

#line default
#line hidden
            BeginContext(427, 18, true);
            WriteLiteral("\t\t\t\t<tr>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(446, 7, false);
#line 21 "/Users/adampauw/Rentman/RentmanWeb/Views/Car/Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(453, 15, true);
            WriteLiteral("</td>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(469, 9, false);
#line 22 "/Users/adampauw/Rentman/RentmanWeb/Views/Car/Index.cshtml"
                   Write(item.Make);

#line default
#line hidden
            EndContext();
            BeginContext(478, 16, true);
            WriteLiteral("</td> \n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(495, 10, false);
#line 23 "/Users/adampauw/Rentman/RentmanWeb/Views/Car/Index.cshtml"
                   Write(item.Model);

#line default
#line hidden
            EndContext();
            BeginContext(505, 15, true);
            WriteLiteral("</td>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(521, 11, false);
#line 24 "/Users/adampauw/Rentman/RentmanWeb/Views/Car/Index.cshtml"
                   Write(item.Colour);

#line default
#line hidden
            EndContext();
            BeginContext(532, 15, true);
            WriteLiteral("</td>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(548, 9, false);
#line 25 "/Users/adampauw/Rentman/RentmanWeb/Views/Car/Index.cshtml"
                   Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(557, 15, true);
            WriteLiteral("</td>\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(573, 11, false);
#line 26 "/Users/adampauw/Rentman/RentmanWeb/Views/Car/Index.cshtml"
                   Write(item.Milage);

#line default
#line hidden
            EndContext();
            BeginContext(584, 16, true);
            WriteLiteral("</td>\n\t\t\t\t</tr>\n");
            EndContext();
#line 28 "/Users/adampauw/Rentman/RentmanWeb/Views/Car/Index.cshtml"
			}

#line default
#line hidden
            BeginContext(605, 17, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rentman.CarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
