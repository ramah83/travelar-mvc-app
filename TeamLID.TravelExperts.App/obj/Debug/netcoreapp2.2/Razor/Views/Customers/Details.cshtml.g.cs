#pragma checksum "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e56bf0a89b820f13ad21567360d09250976ad5557f3163e117cf0be424673de6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Details.cshtml", typeof(AspNetCore.Views_Customers_Details))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\_ViewImports.cshtml"
using TeamLID.TravelExperts.App

    ;
#line 2 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\_ViewImports.cshtml"
using TeamLID.TravelExperts.App.Models

    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e56bf0a89b820f13ad21567360d09250976ad5557f3163e117cf0be424673de6", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"859621e46de238147a7e9afcc15d5e4fe4095e8eb2ae00fefac9fe517b1a3928", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#line 1 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
       TeamLID.TravelExperts.Repository.Domain.Customers

#line default
#line hidden
    >
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden

            BeginContext(103, 132, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Customers</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(236, 49, false);
            Write(
#line 14 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.CustFirstName)

#line default
#line hidden
            );
            EndContext();
            BeginContext(285, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(349, 45, false);
            Write(
#line 17 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.CustFirstName)

#line default
#line hidden
            );
            EndContext();
            BeginContext(394, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(457, 48, false);
            Write(
#line 20 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.CustLastName)

#line default
#line hidden
            );
            EndContext();
            BeginContext(505, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(569, 44, false);
            Write(
#line 23 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.CustLastName)

#line default
#line hidden
            );
            EndContext();
            BeginContext(613, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(676, 47, false);
            Write(
#line 26 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.CustAddress)

#line default
#line hidden
            );
            EndContext();
            BeginContext(723, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(787, 43, false);
            Write(
#line 29 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.CustAddress)

#line default
#line hidden
            );
            EndContext();
            BeginContext(830, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(893, 44, false);
            Write(
#line 32 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.CustCity)

#line default
#line hidden
            );
            EndContext();
            BeginContext(937, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1001, 40, false);
            Write(
#line 35 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.CustCity)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1041, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1104, 44, false);
            Write(
#line 38 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.CustProv)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1148, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1212, 40, false);
            Write(
#line 41 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.CustProv)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1252, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1315, 46, false);
            Write(
#line 44 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.CustPostal)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1361, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1425, 42, false);
            Write(
#line 47 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.CustPostal)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1467, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1530, 47, false);
            Write(
#line 50 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.CustCountry)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1577, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1641, 43, false);
            Write(
#line 53 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.CustCountry)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1684, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1747, 49, false);
            Write(
#line 56 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.CustHomePhone)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1796, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1860, 45, false);
            Write(
#line 59 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.CustHomePhone)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1905, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1968, 48, false);
            Write(
#line 62 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.CustBusPhone)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2016, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2080, 44, false);
            Write(
#line 65 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.CustBusPhone)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2124, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2187, 45, false);
            Write(
#line 68 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.CustEmail)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2232, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2296, 41, false);
            Write(
#line 71 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.CustEmail)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2337, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2400, 44, false);
            Write(
#line 74 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.Username)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2444, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2508, 40, false);
            Write(
#line 77 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.Username)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2548, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2611, 44, false);
            Write(
#line 80 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.Password)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2655, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2719, 40, false);
            Write(
#line 83 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.Password)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2759, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2822, 41, false);
            Write(
#line 86 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayNameFor(model => model.Agent)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2863, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2927, 45, false);
            Write(
#line 89 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
             Html.DisplayFor(model => model.Agent.AgentId)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2972, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3019, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e56bf0a89b820f13ad21567360d09250976ad5557f3163e117cf0be424673de616490", async() => {
                BeginContext(3073, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 94 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Details.cshtml"
                                        Model.CustomerId

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3081, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3089, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e56bf0a89b820f13ad21567360d09250976ad5557f3163e117cf0be424673de618884", async() => {
                BeginContext(3111, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(3127, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamLID.TravelExperts.Repository.Domain.Customers> Html { get; private set; }
    }
}
#pragma warning restore 1591
