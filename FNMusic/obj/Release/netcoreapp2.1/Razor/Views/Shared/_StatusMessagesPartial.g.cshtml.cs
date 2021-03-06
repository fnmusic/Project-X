#pragma checksum "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Shared\_StatusMessagesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b378e502921e846fb69cc96d626f6cb10693ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__StatusMessagesPartial), @"mvc.1.0.view", @"/Views/Shared/_StatusMessagesPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_StatusMessagesPartial.cshtml", typeof(AspNetCore.Views_Shared__StatusMessagesPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b378e502921e846fb69cc96d626f6cb10693ba", @"/Views/Shared/_StatusMessagesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5459c0cf8603ab4dc6f79681afbdf1c2daee3acd", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__StatusMessagesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Shared\_StatusMessagesPartial.cshtml"
  
    var type = (string)TempData["_alert.Type"];
    var title = (string)TempData["_alert.title"];
    var body = (string)TempData["_alert.body"];

    var alertStyle = "alert-primary";


    if (type == "success")
    {
        alertStyle = "alert-success";
    }
    else if (type == "info")
    {
        alertStyle = "alert-info";
    }
    else if (type == "warning")
    {
        alertStyle = "alert-warning";
    }
    else if (type == "danger")
    {
        alertStyle = "alert-danger";
    }

#line default
#line hidden
            BeginContext(654, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Shared\_StatusMessagesPartial.cshtml"
 if (!string.IsNullOrEmpty(type))
{


#line default
#line hidden
            BeginContext(696, 27, true);
            WriteLiteral("    <div id=\"statusMessage\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 723, "\"", 774, 4);
            WriteAttributeValue("", 731, "navbar-fixed-top", 731, 16, true);
            WriteAttributeValue(" ", 747, "fadeInDown", 748, 11, true);
            WriteAttributeValue(" ", 758, "btn", 759, 4, true);
#line 33 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Shared\_StatusMessagesPartial.cshtml"
WriteAttributeValue(" ", 762, alertStyle, 763, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(775, 66, true);
            WriteLiteral(" >\r\n        <div class=\"container\">\r\n            <span class=\"h4\">");
            EndContext();
            BeginContext(842, 5, false);
#line 35 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Shared\_StatusMessagesPartial.cshtml"
                        Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(847, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(856, 4, false);
#line 35 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Shared\_StatusMessagesPartial.cshtml"
                                      Write(body);

#line default
#line hidden
            EndContext();
            BeginContext(860, 357, true);
            WriteLiteral(@"
            <a class=""close"" onclick=""hideMessage()"">
                <span>&times;</span>
            </a>
            <script type=""text/javascript"">
                function hideMessage() {
                    document.getElementById('statusMessage').classList.add('hidden');
                }
            </script>
        </div>
    </div>
");
            EndContext();
#line 46 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\Shared\_StatusMessagesPartial.cshtml"
}

#line default
#line hidden
            BeginContext(1220, 2, true);
            WriteLiteral("\r\n");
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
