#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "157ed4e0e5e49c5bf1d1bf6959aa5a2fa69be803"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Edit), @"mvc.1.0.view", @"/Views/Teacher/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157ed4e0e5e49c5bf1d1bf6959aa5a2fa69be803", @"/Views/Teacher/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b4f5f7ece706bf1df95f673afc4586bcd3aa2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolManagementSystem.Shared.TeacherViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section id=""page-title"" class=""padding-top-15 padding-bottom-15"">
    <div class=""row"">
        <div class=""col-sm-7"">
            <a href=""/Teacher/List""> Teache List </a>/ Create Teacher
        </div>
    </div>
</section>




<div class=""container-fluid container-fullw bg-white"">
    <div class=""row"">
");
#nullable restore
#line 23 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
         using (Html.BeginForm("Create", "Teacher", new { @class = "smart-wizard", role = "form" }))
        {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
   Write(Html.HiddenFor(x=>x.TeacherId));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <p class=\"text-small center text-danger\">");
#nullable restore
#line 27 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                                                Write(ViewBag.ValidationMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <div class=""col-md-6"">
                <fieldset>
                    <legend>
                        Personal Information
                    </legend>
                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        Firstname*
                                    </label>
                                    ");
#nullable restore
#line 40 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.TextBoxFor(m => m.Firstname, new { @class = "form-control", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        Middlename*
                                    </label>
                                    ");
#nullable restore
#line 49 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.TextBoxFor(m => m.Midname, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""control-label "">
                                        Surname *
                                    </label>
                                    ");
#nullable restore
#line 58 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.TextBoxFor(m => m.Surname, new { @class = "form-control", required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        Gender *
                                    </label>
                                    ");
#nullable restore
#line 66 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.DropDownListFor(model => model.Gender, new List<SelectListItem>()
                                      {
                                         new SelectListItem() { Text = "Female", Value = "Female" },
                                         new SelectListItem() { Text = "Male", Value = "Male"}
                                      }, "Select Gender", new { @class = "form-control", required = true  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        IsAfrican
                                    </label>
                                    ");
#nullable restore
#line 78 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.DropDownListFor(model => model.IsSouthAfrican, new List<SelectListItem>()
                                    {
                                       new SelectListItem() { Text = "Yes", Value = "1" },
                                       new SelectListItem() { Text = "No", Value = "0"}
                                    }, "Select.....", new { @class = "form-control" , required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        ID/Passport
                                    </label>
                                    ");
#nullable restore
#line 90 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.TextBoxFor(m => m.IdOrPassport, new { @class = "form-control", @readonly = "readonly", required = true  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        Date of Birth*
                                    </label>
                                    <input type=""date"" class=""form-control"" name=""DateOfBirth"" required />
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        CountryOfBirth*
                                    </label>
                                    ");
#nullable restore
#line 106 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.DropDownListFor(model => model.CountryOfBirth, new List<SelectListItem>()
                              {
                                 new SelectListItem() { Text = "South Africa", Value = "SouthAfrica" },
                                 new SelectListItem() { Text = "Nigeria", Value = "Nigeria"},
                                 new SelectListItem() { Text = "Ghana", Value = "Ghana" },
                                 new SelectListItem() { Text = "Egypt", Value = "Egypt."},
                                  new SelectListItem() { Text = "Other", Value = "Other"}
                              }, "Country of Birth", new { @class = "form-control", required = true  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        Title*
                                    </label>
                                    ");
#nullable restore
#line 121 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.DropDownListFor(model => model.Title, new List<SelectListItem>()
                                        {
                                           new SelectListItem() { Text = "Mr.", Value = "Mr." },
                                           new SelectListItem() { Text = "Mrs.", Value = "Mrs"},
                                           new SelectListItem() { Text = "Miss.", Value = "Miss" },
                                           new SelectListItem() { Text = "Prof.", Value = "Pro."},
                                            new SelectListItem() { Text = "Dr.", Value = "Dr."},
                                            new SelectListItem() { Text = "Other", Value = "Other"}
                                        }, "Select Title", new { @class = "form-control" , required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        Marital Status*
                                    </label>
                                    ");
#nullable restore
#line 137 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.DropDownListFor(model => model.MaritalStatus, new List<SelectListItem>()
                                    {
                                       new SelectListItem() { Text = "Single", Value = "Single" },
                                       new SelectListItem() { Text = "Married", Value = "Married"},
                                       new SelectListItem() { Text = "Widowed", Value = "Widowed" },
                                       new SelectListItem() { Text = "Separated", Value = "Separated"},
                                        new SelectListItem() { Text = "Divorced", Value = "Divorced"},
                                        new SelectListItem() { Text = "Other", Value = "Other"}
                                    }, "Select MaritalStatus", new { @class = "form-control", required = true  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>

                </fieldset>


            </div>
            <div class=""col-md-6"">
                <fieldset>
                    <legend>
                        Contact Information
                    </legend>
                    <div class=""form-group"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label>
                                        CellNr *
                                    </label>
                                    ");
#nullable restore
#line 167 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.TextBoxFor(m => m.CelPhoneNumber, new { @class = "form-control", type = "number", required = true  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        TelNr
                                    </label>
                                    ");
#nullable restore
#line 175 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.TextBoxFor(m => m.HomeTelNumber, new { @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""block"">
                                        Email Address
                                    </label>
                                    ");
#nullable restore
#line 183 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.TextBoxFor(m => m.PersonalEmailAddress, new { @class = "form-control", @readonly = "readonly", required = true  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        WorkTel
                                    </label>
                                    ");
#nullable restore
#line 191 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.TextBoxFor(m => m.WorkTelNumber, new { @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        Fax
                                    </label>
                                    ");
#nullable restore
#line 199 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.TextBoxFor(m => m.FaxNumber, new { @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label>
                                        Preferred Language
                                    </label>
                                    ");
#nullable restore
#line 208 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.DropDownListFor(model => model.PreferedLanguage, new List<SelectListItem>()
                     {
                        new SelectListItem() { Text = "English", Value = "English" },
                        new SelectListItem() { Text = "Swahili", Value = "Swahili"},
                        new SelectListItem() { Text = "Omoro", Value = "Omoro"},
                        new SelectListItem() { Text = "Zulu", Value = "Zulu"},
                        new SelectListItem() { Text = "Hausa", Value = "Hausa"},
                         new SelectListItem() { Text = "Other", Value = "Other"}
                     }, "Prefered Language", new { @class = "form-control" , required = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        Communication Method
                                    </label>
                                    ");
#nullable restore
#line 224 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
                               Write(Html.DropDownListFor(model => model.CommunicationMethod, new List<SelectListItem>()
                                  {
                                     new SelectListItem() { Text = "Email", Value = "Email" },
                                     new SelectListItem() { Text = "Phone", Value = "Phone"},
                                      new SelectListItem() { Text = "Call", Value = "Call"},
                                      new SelectListItem() { Text = "Other", Value = "Other"}
                                  }, "Communication Method", new { @class = "form-control", required = true  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </fieldset>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"form-group\">\r\n            <button id=\"submit\" class=\"btn btn-primary next-step btn-wide pull-right\">\r\n                Edit Teacher <i class=\"fa fa-arrow-circle-right\"></i>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 244 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Teacher\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolManagementSystem.Shared.TeacherViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
