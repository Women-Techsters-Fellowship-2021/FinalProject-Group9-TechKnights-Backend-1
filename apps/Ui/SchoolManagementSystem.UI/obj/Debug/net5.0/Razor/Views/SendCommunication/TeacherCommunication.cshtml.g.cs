#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62c9114d257f5aa83d8ab2924a8fc297ff1ec56d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SendCommunication_TeacherCommunication), @"mvc.1.0.view", @"/Views/SendCommunication/TeacherCommunication.cshtml")]
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
#line 1 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\_ViewImports.cshtml"
using SchoolManagementSystem.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\_ViewImports.cshtml"
using SchoolManagementSystem.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62c9114d257f5aa83d8ab2924a8fc297ff1ec56d", @"/Views/SendCommunication/TeacherCommunication.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b4f5f7ece706bf1df95f673afc4586bcd3aa2d", @"/Views/_ViewImports.cshtml")]
    public class Views_SendCommunication_TeacherCommunication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SchoolManagementSystem.Shared.TeacherViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""page-title"" class=""padding-top-15 padding-bottom-15"">
    <div class=""row"">
        <div class=""col-sm-7"">
            <a href=""/SendCommunication/Index""> Index </a>/ Teacher Communication
        </div>
    </div>
</section>

<div class=""container-fluid container-fullw bg-white"">
    <p class=""text-small center text-danger"">");
#nullable restore
#line 17 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                                        Write(ViewBag.ValidateErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    <div class=""row"">
        <div class=""col-md-12"">
            <h5 class=""over-title margin-bottom-15"">Teachers <span class=""text-bold"">List</span></h5>
            <p>
                List of all teacher.
            </p>
            <table class=""table table-striped table-bordered table-hover table-full-width"" id=""sample_1"">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>FullNames</th>
                        <th>
                            ID/Passport
                        </th>
                        <th>
                            CommunicationMethod
                        </th>
                        <th class=""hidden-xs"">Phone</th>
                        <th class=""hidden-xs"">EmailAddress</th>
                        <th class=""hidden-xs"">
                            CreatedBy
                        </th>                       
                        <th>
                        </th>
          ");
            WriteLiteral("          </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 45 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 48 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                           Write(item.TeacherId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 49 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                           Write(item.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 49 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                                            Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                            <td>");
#nullable restore
#line 50 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                           Write(item.IdOrPassport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 51 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                           Write(item.CommunicationMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"hidden-xs\">");
#nullable restore
#line 52 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                                             Write(item.CelPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"hidden-xs\">");
#nullable restore
#line 53 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                                             Write(item.PersonalEmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"hidden-xs\">");
#nullable restore
#line 54 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                                             Write(item.CreatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                           \r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                           Write(Html.ActionLink("SendToTeacher", "SendToTeacher", new { id = item.TeacherId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 59 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\SendCommunication\TeacherCommunication.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SchoolManagementSystem.Shared.TeacherViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591