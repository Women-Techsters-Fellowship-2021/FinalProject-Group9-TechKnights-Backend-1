#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\ParentAdmin\Views\Parent\ParentMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8a406d6cfd0741cb5da00dd54e9f9a9b0d2994b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ParentAdmin_Views_Parent_ParentMessage), @"mvc.1.0.view", @"/Areas/ParentAdmin/Views/Parent/ParentMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8a406d6cfd0741cb5da00dd54e9f9a9b0d2994b", @"/Areas/ParentAdmin/Views/Parent/ParentMessage.cshtml")]
    public class Areas_ParentAdmin_Views_Parent_ParentMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SchoolManagementSystem.Shared.EmailAuditDataViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\ParentAdmin\Views\Parent\ParentMessage.cshtml"
  
    ViewData["Title"] = "MyMessage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""page-title"" class=""padding-top-15 padding-bottom-15"">
    <div class=""row"">
        <div class=""col-sm-7"">
            <a href=""/ParentAdmin/Parent/Index""> Index </a>/ Parent Message
        </div>
    </div>
</section>



<div class=""container-fluid container-fullw bg-white"">
    <p class=""text-small center text-danger"">");
#nullable restore
#line 18 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\ParentAdmin\Views\Parent\ParentMessage.cshtml"
                                        Write(ViewBag.ValidateErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    <div class=""row"">
        <div class=""col-md-12"">
            <h5 class=""over-title margin-bottom-15"">Student <span class=""text-bold"">Mail</span></h5>
            <p>
                My communication emails list
            </p>
            <table class=""table table-striped table-bordered table-hover table-full-width"" id=""sample_1"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>To</th>
                        <th>
                            Dear
                        </th>
                        <th>
                            Subject
                        </th>
                        <th class=""hidden-xs"">body</th>
                        <th class=""hidden-xs"">
                            from
                        </th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 43 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\ParentAdmin\Views\Parent\ParentMessage.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 46 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\ParentAdmin\Views\Parent\ParentMessage.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\ParentAdmin\Views\Parent\ParentMessage.cshtml"
                       Write(item.Mailto);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>");
#nullable restore
#line 48 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\ParentAdmin\Views\Parent\ParentMessage.cshtml"
                       Write(item.DearName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\ParentAdmin\Views\Parent\ParentMessage.cshtml"
                       Write(item.EmailSubject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"hidden-xs\">");
#nullable restore
#line 50 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\ParentAdmin\Views\Parent\ParentMessage.cshtml"
                                         Write(item.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"hidden-xs\">");
#nullable restore
#line 51 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\ParentAdmin\Views\Parent\ParentMessage.cshtml"
                                         Write(item.MailFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 53 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Areas\ParentAdmin\Views\Parent\ParentMessage.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n-");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SchoolManagementSystem.Shared.EmailAuditDataViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
