#pragma checksum "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40834dcb45f10606be3794291a5d9668256873c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Activate), @"mvc.1.0.view", @"/Views/Auth/Activate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auth/Activate.cshtml", typeof(AspNetCore.Views_Auth_Activate))]
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
#line 1 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\_ViewImports.cshtml"
using FNMusic;

#line default
#line hidden
#line 2 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\_ViewImports.cshtml"
using FNMusic.Models;

#line default
#line hidden
#line 2 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40834dcb45f10606be3794291a5d9668256873c9", @"/Views/Auth/Activate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5459c0cf8603ab4dc6f79681afbdf1c2daee3acd", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Activate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserMgt.Models.Activate>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml"
  
    ViewData["Title"] = "Activate";
    Layout = "~/Views/Shared/_AuthLayout.cshtml";

    bool activated = Convert.ToBoolean(httpContextAccessor.HttpContext.Session.GetString("Activated"));

#line default
#line hidden
            BeginContext(321, 315, true);
            WriteLiteral(@"
<section class=""m-t-lg wrapper-md animated fadeInDown"">
    <div class=""container aside-xl bg-white"" style=""box-shadow:0px 10px 10px; border-radius:5px;"">
        <header class=""wrapper text-center"">
            <h2>Activate your account</h2>
            <h5>Input your email address</h5>
        </header>
");
            EndContext();
#line 18 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml"
          
            if (!activated)
            {

#line default
#line hidden
            BeginContext(692, 116, true);
            WriteLiteral("                <section class=\"form-horizontal\" style=\"padding: 0px 30px 20px 30px;\">\r\n                    <hr />\r\n");
            EndContext();
#line 23 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml"
                     using (Html.BeginForm("/activate/"+Model.Token+"", "Auth", FormMethod.Post, new { enctype = "multipart/form-data" }))
                    {
                        

#line default
#line hidden
            BeginContext(996, 70, false);
#line 25 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger small" }));

#line default
#line hidden
            EndContext();
            BeginContext(1068, 78, true);
            WriteLiteral("                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1147, 75, false);
#line 27 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1222, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1253, 113, false);
#line 28 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml"
                       Write(Html.TextBoxFor(x => x.Email, new { type = "email", @class = "form-control text-center", placeholder = "Email" }));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 215, true);
            WriteLiteral("\r\n                        </div>\r\n                        <button type=\"submit\" class=\"btn btn-warning btn-block\">\r\n                            <span>Activate your account</span>\r\n                        </button>\r\n");
            EndContext();
#line 33 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml"
                    }

#line default
#line hidden
            BeginContext(1604, 28, true);
            WriteLiteral("                </section>\r\n");
            EndContext();
#line 35 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1680, 71, true);
            WriteLiteral("                <div class=\"form-group\">\r\n                    <h4>Dear ");
            EndContext();
            BeginContext(1752, 11, false);
#line 39 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml"
                        Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1763, 200, true);
            WriteLiteral("</h4>\r\n                    <p class=\"text-center\">You have successfully activated your account</p>\r\n                    <a href=\"/discover\"><i class=\"fa fa-home\">Home</i></a>\r\n                </div>\r\n");
            EndContext();
#line 43 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Auth\Activate.cshtml"
                
            }
        

#line default
#line hidden
            BeginContext(2007, 28, true);
            WriteLiteral("\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor httpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserMgt.Models.Activate> Html { get; private set; }
    }
}
#pragma warning restore 1591
