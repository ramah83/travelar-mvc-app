#pragma checksum "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e45d57faf896a71e0938fe25ccd32c371139d8e1fa5eab132a8df4415f2be54e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Profile), @"mvc.1.0.view", @"/Views/Customers/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Profile.cshtml", typeof(AspNetCore.Views_Customers_Profile))]
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
#line 1 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
 using Microsoft.AspNetCore.Http

    ;
#line 2 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
 using TeamLID.TravelExperts.Repository.Domain

    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e45d57faf896a71e0938fe25ccd32c371139d8e1fa5eab132a8df4415f2be54e", @"/Views/Customers/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"859621e46de238147a7e9afcc15d5e4fe4095e8eb2ae00fefac9fe517b1a3928", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#line 9 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
       TeamLID.TravelExperts.Repository.Domain.Customers

#line default
#line hidden
    >
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/profiles.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
  
    /*
     * Author: DongMing, Ibraheem
     * Purpose: A profile page allows logged in users to view/change their info.
     */

#line default
#line hidden

            BeginContext(281, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden

            BeginContext(326, 622, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""jumbotron jumbotron-fluid jumbotron-profile"">
        <div class=""container"">
            <h1 class=""display-4 register-greetings h1-responsive"">Your Account</h1>
            <hr class=""my-4"">
            <p class=""lead register-heading"">Profile</p>
        </div>
    </div>
</div>

<main>
    <div class=""container"">

        <div class=""register-main"">

            <div class=""row"">

                <div class=""col-md-4"">

                    <div class=""profile-box"">
                        <div class=""card package"">
                            ");
            EndContext();
            BeginContext(948, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e45d57faf896a71e0938fe25ccd32c371139d8e1fa5eab132a8df4415f2be54e7135", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1016, 202, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"register-box\">\r\n                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1218, "\"", 1226, 0);
            EndWriteAttribute();
            BeginContext(1227, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(1258, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45d57faf896a71e0938fe25ccd32c371139d8e1fa5eab132a8df4415f2be54e8958", async() => {
                BeginContext(1317, 64, true);
                WriteLiteral("<button class=\"btn btn-outline-primary\">Back to history</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1385, 63, true);
            WriteLiteral("\r\n                           \r\n                                ");
            EndContext();
            BeginContext(1448, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45d57faf896a71e0938fe25ccd32c371139d8e1fa5eab132a8df4415f2be54e10686", async() => {
                BeginContext(1529, 61, true);
                WriteLiteral("<button class=\"btn btn-outline-warning\">Edit Profile</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 45 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
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
            BeginContext(1594, 231, true);
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <br />\r\n                        <dl class=\"row mx-auto\">\r\n                            <dt class=\"col-sm-4\">\r\n                                ");
            EndContext();
            BeginContext(1826, 49, false);
            Write(
#line 51 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayNameFor(model => model.CustFirstName)

#line default
#line hidden
            );
            EndContext();
            BeginContext(1875, 120, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-8\">\r\n                                ");
            EndContext();
            BeginContext(1996, 45, false);
            Write(
#line 54 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayFor(model => model.CustFirstName)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2041, 120, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-4\">\r\n                                ");
            EndContext();
            BeginContext(2162, 48, false);
            Write(
#line 57 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayNameFor(model => model.CustLastName)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2210, 120, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-8\">\r\n                                ");
            EndContext();
            BeginContext(2331, 44, false);
            Write(
#line 60 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayFor(model => model.CustLastName)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2375, 120, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-4\">\r\n                                ");
            EndContext();
            BeginContext(2496, 47, false);
            Write(
#line 63 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayNameFor(model => model.CustAddress)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2543, 120, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-8\">\r\n                                ");
            EndContext();
            BeginContext(2664, 43, false);
            Write(
#line 66 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayFor(model => model.CustAddress)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2707, 120, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-4\">\r\n                                ");
            EndContext();
            BeginContext(2828, 44, false);
            Write(
#line 69 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayNameFor(model => model.CustCity)

#line default
#line hidden
            );
            EndContext();
            BeginContext(2872, 120, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-8\">\r\n                                ");
            EndContext();
            BeginContext(2993, 40, false);
            Write(
#line 72 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayFor(model => model.CustCity)

#line default
#line hidden
            );
            EndContext();
            BeginContext(3033, 120, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-4\">\r\n                                ");
            EndContext();
            BeginContext(3154, 44, false);
            Write(
#line 75 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayNameFor(model => model.CustProv)

#line default
#line hidden
            );
            EndContext();
            BeginContext(3198, 120, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-8\">\r\n                                ");
            EndContext();
            BeginContext(3319, 40, false);
            Write(
#line 78 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayFor(model => model.CustProv)

#line default
#line hidden
            );
            EndContext();
            BeginContext(3359, 120, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-4\">\r\n                                ");
            EndContext();
            BeginContext(3480, 46, false);
            Write(
#line 81 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayNameFor(model => model.CustPostal)

#line default
#line hidden
            );
            EndContext();
            BeginContext(3526, 120, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-8\">\r\n                                ");
            EndContext();
            BeginContext(3647, 42, false);
            Write(
#line 84 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayFor(model => model.CustPostal)

#line default
#line hidden
            );
            EndContext();
            BeginContext(3689, 120, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-4\">\r\n                                ");
            EndContext();
            BeginContext(3810, 47, false);
            Write(
#line 87 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayNameFor(model => model.CustCountry)

#line default
#line hidden
            );
            EndContext();
            BeginContext(3857, 120, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-8\">\r\n                                ");
            EndContext();
            BeginContext(3978, 43, false);
            Write(
#line 90 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayFor(model => model.CustCountry)

#line default
#line hidden
            );
            EndContext();
            BeginContext(4021, 120, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-4\">\r\n                                ");
            EndContext();
            BeginContext(4142, 49, false);
            Write(
#line 93 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayNameFor(model => model.CustHomePhone)

#line default
#line hidden
            );
            EndContext();
            BeginContext(4191, 120, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-8\">\r\n                                ");
            EndContext();
            BeginContext(4312, 45, false);
            Write(
#line 96 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayFor(model => model.CustHomePhone)

#line default
#line hidden
            );
            EndContext();
            BeginContext(4357, 120, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-4\">\r\n                                ");
            EndContext();
            BeginContext(4478, 48, false);
            Write(
#line 99 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayNameFor(model => model.CustBusPhone)

#line default
#line hidden
            );
            EndContext();
            BeginContext(4526, 120, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-8\">\r\n                                ");
            EndContext();
            BeginContext(4647, 44, false);
            Write(
#line 102 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayFor(model => model.CustBusPhone)

#line default
#line hidden
            );
            EndContext();
            BeginContext(4691, 120, true);
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-sm-4\">\r\n                                ");
            EndContext();
            BeginContext(4812, 45, false);
            Write(
#line 105 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayNameFor(model => model.CustEmail)

#line default
#line hidden
            );
            EndContext();
            BeginContext(4857, 120, true);
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-sm-8\">\r\n                                ");
            EndContext();
            BeginContext(4978, 41, false);
            Write(
#line 108 "D:\Travel MVC PROJECT\TeamLID.TravelExperts.App\Views\Customers\Profile.cshtml"
                                 Html.DisplayFor(model => model.CustEmail)

#line default
#line hidden
            );
            EndContext();
            BeginContext(5019, 185, true);
            WriteLiteral("\r\n                            </dd>\r\n                        </dl>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
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
