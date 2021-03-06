#pragma checksum "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0717337562924d2c55b51206b1b41e94e4ecb817"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Profile.cshtml", typeof(AspNetCore.Views_User_Profile))]
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
#line 3 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 4 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
using BaseLib.Models;

#line default
#line hidden
#line 5 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
using UserMgt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0717337562924d2c55b51206b1b41e94e4ecb817", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5459c0cf8603ab4dc6f79681afbdf1c2daee3acd", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserMgt.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
  
    Layout = "~/Views/Shared/_PlayerLayout.cshtml";
    
    ViewData["Title"] = ""+Model.FirstName ?? ""+" "+Model.LastName ?? ""+" (@"+Model.Username+")";

    string[] months = new string[]
    {
        "January",
        "Febuary",
        "March",
        "April",
        "May",
        "June",
        "July",
        "August",
        "September",
        "October",
        "November",
        "December"
    };

    long profileUserId = Model.Id;
    long loggedInUserId = Convert.ToInt64(httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == "Id").Value);

    


#line default
#line hidden
            BeginContext(778, 1330, true);
            WriteLiteral(@"
<section>
    <section class=""vbox"">
        <section class=""scrollable"">
            <section class=""wrapper hidden-xs"" style=""height:300px; background-image:url(/images/electric_feeling-1280x800.jpg); background-size:cover"">
                <a href=""#"" class=""img-circle"" style=""position:absolute; top:200px; left:5px; border-style:solid; border-color:white;"">
                    <img src=""images/a4.png"" class=""img-circle"" height=""180"" style=""border-color:white;"">
                </a>
            </section>
            <section class=""wrapper hidden-mobile-xs"" style=""height:100px;  background-image:url(/images/electric_feeling-1280x800.jpg); background-size:cover"">
                <a href=""#"" class=""img-circle"" style=""position:absolute; top:100px; left:5px; border-style:solid; border-color:white;"">
                    <img src=""images/a4.png"" class=""img-circle"" height=""100"" style=""border-color:white;"">
                </a>
            </section>
            <section class=""hbox stretch"" >
    ");
            WriteLiteral(@"            <aside class=""aside-lg bg-light lter b-r"">
                    <section class=""vbox"">
                        <section class=""scrollable"">
                            <div class=""wrapper"">
                                <div style=""padding-top:20px;"">
                                    ");
            EndContext();
            BeginContext(2109, 39, false);
#line 54 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                               Write(await Html.PartialAsync("_IsFanLayout"));

#line default
#line hidden
            EndContext();
            BeginContext(2148, 186, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"m-b m-t\" style=\"padding-top:60px;\">\r\n                                    <div class=\"h3 text-black\">");
            EndContext();
            BeginContext(2335, 15, false);
#line 57 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                          Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2350, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2352, 14, false);
#line 57 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                                           Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2366, 102, true);
            WriteLiteral("</div>\r\n                                    <div class=\"h5\">\r\n                                        ");
            EndContext();
            BeginContext(2469, 1, true);
            WriteLiteral("@");
            EndContext();
            BeginContext(2471, 14, false);
#line 59 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                     Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(2485, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 61 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                         if (loggedInUserId != Model.Id)
                                        {
                                            //Result<User> isFollowerResult = await userController.IsFollower(loggedInUserId, Model.Id);
                                            //User followerUser = isFollowerResult.Data;
                                            

#line default
#line hidden
#line 70 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                               
                                        }

#line default
#line hidden
            BeginContext(3266, 133, true);
            WriteLiteral("                                    </div>\r\n                                    <div class=\"h5 text-black\" style=\"padding-top:15px;\">");
            EndContext();
            BeginContext(3400, 15, false);
#line 73 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                                                    Write(Model.Biography);

#line default
#line hidden
            EndContext();
            BeginContext(3415, 88, true);
            WriteLiteral("</div>\r\n                                    <div class=\"h5\" style=\"padding-top:10px;\">\r\n");
            EndContext();
#line 75 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                         if (!string.IsNullOrEmpty(Model.Location))
                                        {

#line default
#line hidden
            BeginContext(3631, 204, true);
            WriteLiteral("                                            <a class=\"text-muted\">\r\n                                                <i class=\"fa fa-map-marker\"></i>\r\n                                                <span>");
            EndContext();
            BeginContext(3836, 14, false);
#line 79 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                 Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(3850, 59, true);
            WriteLiteral("</span>\r\n                                            </a>\r\n");
            EndContext();
#line 81 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3952, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 83 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                         if (!string.IsNullOrEmpty(Model.Website))
                                        {

#line default
#line hidden
            BeginContext(4081, 46, true);
            WriteLiteral("                                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4127, "\"", 4148, 1);
#line 85 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
WriteAttributeValue("", 4134, Model.Website, 4134, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4149, 146, true);
            WriteLiteral(" class=\"link\">\r\n                                                <i class=\"fa fa-link\"></i>\r\n                                                <span>");
            EndContext();
            BeginContext(4296, 13, false);
#line 87 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                 Write(Model.Website);

#line default
#line hidden
            EndContext();
            BeginContext(4309, 59, true);
            WriteLiteral("</span>\r\n                                            </a>\r\n");
            EndContext();
#line 89 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4411, 316, true);
            WriteLiteral(@"                                    </div>

                                    <div class=""h5"" style=""padding-top:10px"">
                                        <a class=""text-muted"">
                                            <i class=""fa fa-bell""></i>
                                            <span>Born ");
            EndContext();
            BeginContext(4728, 35, false);
#line 95 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                  Write(months[Model.DateOfBirth.Month - 1]);

#line default
#line hidden
            EndContext();
            BeginContext(4763, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4765, 21, false);
#line 95 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                                                       Write(Model.DateOfBirth.Day);

#line default
#line hidden
            EndContext();
            BeginContext(4786, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(4789, 22, false);
#line 95 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                                                                               Write(Model.DateOfBirth.Year);

#line default
#line hidden
            EndContext();
            BeginContext(4811, 252, true);
            WriteLiteral("</span>\r\n                                        </a>\r\n                                        <a class=\"text-muted\">\r\n                                            <i class=\"fa fa-calendar\"></i>\r\n                                            <span>Joined ");
            EndContext();
            BeginContext(5064, 35, false);
#line 99 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                    Write(months[Model.DateCreated.Month - 1]);

#line default
#line hidden
            EndContext();
            BeginContext(5099, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(5101, 22, false);
#line 99 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                                                         Write(Model.DateCreated.Year);

#line default
#line hidden
            EndContext();
            BeginContext(5123, 325, true);
            WriteLiteral(@"</span>
                                        </a>
                                    </div>
                                </div>

                                <div class=""h5"">
                                    <a style=""padding-right:10px;"">
                                        <span class=""text-black"">");
            EndContext();
            BeginContext(5449, 15, false);
#line 106 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                            Write(Model.Following);

#line default
#line hidden
            EndContext();
            BeginContext(5464, 248, true);
            WriteLiteral("</span>\r\n                                        <span>Following</span>\r\n                                    </a>\r\n                                    <a style=\"padding-left:10px;\">\r\n                                        <span class=\"text-black\">");
            EndContext();
            BeginContext(5713, 15, false);
#line 110 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
                                                            Write(Model.Followers);

#line default
#line hidden
            EndContext();
            BeginContext(5728, 449, true);
            WriteLiteral(@"</span>
                                        <span>Followers</span>
                                    </a>
                                </div>
                               
                                <div>
                                    <div class=""line""></div> <small class=""text-uc text-xs text-muted"">connections</small>
                                    <p class=""m-t-sm"">
                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6177, "\"", 6205, 1);
#line 118 "C:\Users\Stephen\Documents\Visual Studio 2017\Projects\Project-X\FNMusic\Views\User\Profile.cshtml"
WriteAttributeValue("", 6184, Model.TwitterProfile, 6184, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6206, 8549, true);
            WriteLiteral(@" class=""btn btn-rounded btn-twitter btn-icon""><i class=""fa fa-twitter""></i></a>
                                        <a href="""" class=""btn btn-rounded btn-facebook btn-icon""><i class=""fa fa-facebook""></i></a>
                                        <a href=""#"" class=""btn btn-rounded btn-icon""><i class=""fa fa-envelope""></i></a>
                                    </p>
                                </div>
                            </div>
                        </section>
                    </section>
                </aside>
                <aside class=""bg-white"">
                    <section class=""vbox"">
                        <header class=""header bg-light lt"">
                            <ul class=""nav nav-tabs nav-white"">
                                <li class=""active""><a href=""#activity"" data-toggle=""tab"">Activity</a></li>
                                <li class=""""><a href=""#events"" data-toggle=""tab"">Events</a></li>
                                <li class=""""><a href=""#inte");
            WriteLiteral(@"raction"" data-toggle=""tab"">Interaction</a></li>
                            </ul>
                        </header>
                        <section class=""scrollable"">
                            <div class=""tab-content"">
                                <div class=""tab-pane active"" id=""activity"">
                                    <ul class=""list-group no-radius m-b-none m-t-n-xxs list-group-lg no-border"">
                                        <li class=""list-group-item"">
                                            <a href=""#"" class=""thumb-sm pull-left m-r-sm""> <img src=""images/a0.png"" class=""img-circle""> </a>
                                            <a href=""#"" class=""clear"">
                                                <small class=""pull-right"">3 minuts ago</small> <strong class=""block"">Drew Wllon</strong>                                                            <small>Wellcome and play this web application template ... </small>
                                            </a>
      ");
            WriteLiteral(@"                                  </li>
                                        <li class=""list-group-item"">
                                            <a href=""#"" class=""thumb-sm pull-left m-r-sm""> <img src=""images/a1.png"" class=""img-circle""> </a>
                                            <a href=""#"" class=""clear"">
                                                <small class=""pull-right"">1 hour ago</small> <strong class=""block"">Jonathan George</strong>                                                            <small>Morbi nec nunc condimentum...</small>
                                            </a>
                                        </li>
                                        <li class=""list-group-item"">
                                            <a href=""#"" class=""thumb-sm pull-left m-r-sm""> <img src=""images/a2.png"" class=""img-circle""> </a>
                                            <a href=""#"" class=""clear"">
                                                <small class=""pull-right""");
            WriteLiteral(@">2 hours ago</small> <strong class=""block"">Josh Long</strong>                                                            <small>Vestibulum ullamcorper sodales nisi nec...</small>
                                            </a>
                                        </li>
                                        <li class=""list-group-item"">
                                            <a href=""#"" class=""thumb-sm pull-left m-r-sm""> <img src=""images/a3.png"" class=""img-circle""> </a>
                                            <a href=""#"" class=""clear"">
                                                <small class=""pull-right"">1 day ago</small> <strong class=""block"">Jack Dorsty</strong>                                                            <small>Morbi nec nunc condimentum...</small>
                                            </a>
                                        </li>
                                        <li class=""list-group-item"">
                                            <a href=""#"" ");
            WriteLiteral(@"class=""thumb-sm pull-left m-r-sm""> <img src=""images/a4.png"" class=""img-circle""> </a>
                                            <a href=""#"" class=""clear"">
                                                <small class=""pull-right"">3 days ago</small> <strong class=""block"">Morgen Kntooh</strong>                                                            <small>Mobile first web app for startup...</small>
                                            </a>
                                        </li>
                                        <li class=""list-group-item"">
                                            <a href=""#"" class=""thumb-sm pull-left m-r-sm""> <img src=""images/a5.png"" class=""img-circle""> </a>
                                            <a href=""#"" class=""clear"">
                                                <small class=""pull-right"">Jun 21</small> <strong class=""block"">Yoha Omish</strong>                                                            <small>Morbi nec nunc condimentum...</small>
");
            WriteLiteral(@"                                            </a>
                                        </li>
                                        <li class=""list-group-item"">
                                            <a href=""#"" class=""thumb-sm pull-left m-r-sm""> <img src=""images/a6.png"" class=""img-circle""> </a>
                                            <a href=""#"" class=""clear"">
                                                <small class=""pull-right"">May 10</small> <strong class=""block"">Gole Lido</strong>                                                            <small>Vestibulum ullamcorper sodales nisi nec...</small>
                                            </a>
                                        </li>
                                        <li class=""list-group-item"">
                                            <a href=""#"" class=""thumb-sm pull-left m-r-sm""> <img src=""images/a7.png"" class=""img-circle""> </a>
                                            <a href=""#"" class=""clear"">
              ");
            WriteLiteral(@"                                  <small class=""pull-right"">Jan 2</small> <strong class=""block"">Jonthan Snow</strong>                                                            <small>Morbi nec nunc condimentum...</small>
                                            </a>
                                        </li>
                                        <li class=""list-group-item"" href=""#email-content"" data-toggle=""class:show"">
                                            <a href=""#"" class=""thumb-sm pull-left m-r-sm""> <img src=""images/a8.png"" class=""img-circle""> </a>
                                            <a href=""#"" class=""clear"">
                                                <small class=""pull-right"">3 minuts ago</small> <strong class=""block"">Drew Wllon</strong>                                                            <small>Vestibulum ullamcorper sodales nisi nec sodales nisi nec sodales nisi nec...</small>
                                            </a>
                                  ");
            WriteLiteral(@"      </li>
                                        <li class=""list-group-item"">
                                            <a href=""#"" class=""thumb-sm pull-left m-r-sm""> <img src=""images/a9.png"" class=""img-circle""> </a>
                                            <a href=""#"" class=""clear"">
                                                <small class=""pull-right"">1 hour ago</small> <strong class=""block"">Jonathan George</strong>                                                            <small>Morbi nec nunc condimentum...</small>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                                <div class=""tab-pane"" id=""events"">
                                    <div class=""text-center wrapper""> <i class=""fa fa-spinner fa fa-spin fa fa-large""></i> </div>
                                </div>
                                <div class=""tab-pane"" id=""inter");
            WriteLiteral(@"action"">
                                    <div class=""text-center wrapper""> <i class=""fa fa-spinner fa fa-spin fa fa-large""></i> </div>
                                </div>
                            </div>
                        </section>
                    </section>
                </aside>
                <aside class=""col-lg-3 b-l"">
");
            EndContext();
            BeginContext(15961, 220, true);
            WriteLiteral("                </aside>\r\n            </section>\r\n        </section>\r\n    </section>\r\n    <a href=\"#\" class=\"hide nav-off-screen-block\" data-toggle=\"class:nav-off-screen,open\" data-target=\"#nav,html\"></a>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserMgt.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
