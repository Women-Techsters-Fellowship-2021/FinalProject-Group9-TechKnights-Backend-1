#pragma checksum "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baf432697f0dad33aecd51b0ede4be3933d3cc01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parent_Details), @"mvc.1.0.view", @"/Views/Parent/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baf432697f0dad33aecd51b0ede4be3933d3cc01", @"/Views/Parent/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b4f5f7ece706bf1df95f673afc4586bcd3aa2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Parent_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolManagementSystem.Shared.StudentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/GetTheAddress.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section id=""page-title"" class=""padding-top-15 padding-bottom-15"">
    <div class=""row"">
        <div class=""col-sm-7"">
            <a href=""/Student/List""> Student List </a>/ Create Student
        </div>
    </div>
</section>


<div class=""container-fluid container-fullw bg-white"">
    <div class=""row"">
");
#nullable restore
#line 21 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
         using (Html.BeginForm("Create", "Student", new { @class = "smart-wizard", role = "form" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""row"">
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
#line 36 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
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
#line 45 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.TextBoxFor(m => m.Midname, new { @class = "form-control", required = true }));

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
#line 54 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
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
#line 62 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.DropDownListFor(model => model.Gender, new List<SelectListItem>()
                                          {
                                             new SelectListItem() { Text = "Female", Value = "Female" },
                                             new SelectListItem() { Text = "Male", Value = "Male"}
                                          }, "Select Gender", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label>
                                            IsSouthAfrican
                                        </label>
                                        ");
#nullable restore
#line 76 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.DropDownListFor(model => model.IsSouthAfrican, new List<SelectListItem>()
                                        {
                                           new SelectListItem() { Text = "Yes", Value = "1" },
                                           new SelectListItem() { Text = "No", Value = "0"}
                                        }, "Select.....", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">
                                            ID/Passport
                                        </label>
                                        ");
#nullable restore
#line 90 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.TextBoxFor(m => m.IdOrPassport, new { @class = "form-control" }));

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
                                        ");
#nullable restore
#line 98 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.TextBoxFor(m => m.DateOfBirth, new { @class = "form-control datepicker" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label>
                                            CountryOfBirth*
                                        </label>
                                        <select id=""CountryOfBirthId"" name=""CountryOfBirthId"" class=""form-control""></select>
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label>
                                            Title*
                                        </label>
                                        ");
#nullable restore
#line 114 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.DropDownListFor(model => model.Title, new List<SelectListItem>()
                                            {
                                               new SelectListItem() { Text = "Mr.", Value = "Mr." },
                                               new SelectListItem() { Text = "Mrs.", Value = "Mrs"},
                                               new SelectListItem() { Text = "Miss.", Value = "Miss" },
                                               new SelectListItem() { Text = "Prof.", Value = "Pro."},
                                                new SelectListItem() { Text = "Dr.", Value = "Dr."},
                                                new SelectListItem() { Text = "Other", Value = "Other"}
                                            }, "Select Title", new { @class = "form-control" }));

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
#line 130 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.DropDownListFor(model => model.MaritalStatus, new List<SelectListItem>()
                                        {
                                           new SelectListItem() { Text = "Single", Value = "Single" },
                                           new SelectListItem() { Text = "Married", Value = "Married"},
                                           new SelectListItem() { Text = "Widowed", Value = "Widowed" },
                                           new SelectListItem() { Text = "Separated", Value = "Separated"},
                                            new SelectListItem() { Text = "Divorced", Value = "Divorced"},
                                            new SelectListItem() { Text = "Other", Value = "Other"}
                                        }, "Select MaritalStatus", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>

                    </fieldset>

                    <fieldset>
                        <legend>
                            Physical Information
                        </legend>
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <label>
                                        Address Line 1*
                                    </label>
                                    <input id=""autocomplete"" name=""PhysicalAddress"" onFocus=""geolocate()"" placeholder=""Enter your address"" type=""text"" class=""form-control"" />
                                </div>
                            </div>

                            <div class=""col-md-3"">
                                <div class=""form-group"">
                ");
            WriteLiteral(@"                    <label>
                                        Country
                                    </label>
                                    <input id=""country"" name=""PhysicalCountry"" disabled class=""form-control"" readonly />
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        Province
                                    </label>
                                    <input class=""form-control"" name=""PhysicalProvince"" id=""administrative_area_level_1"" readonly />
                                </div>
                            </div>

                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label>
                                        City
                ");
            WriteLiteral(@"                    </label>
                                    <input class=""form-control"" name=""PhysicalCity"" id=""locality"" readonly />
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        Street Number
                                    </label>
                                    <input id=""street_number"" name=""PhysicalAddressLine2"" class=""form-control"" readonly />
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        Street Name
                                    </label>
                                    <input id=""route""");
            WriteLiteral(@" name=""PhysicalAddressLine3"" class=""form-control"" readonly />
                                </div>
                            </div>

                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        OtherAddress
                                    </label>
                                    ");
#nullable restore
#line 207 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.PhysicalOther, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        Postal Code*
                                    </label>
                                    <input id=""postal_code"" name=""PhysicalPostalCode"" class=""form-control"" readonly />
");
            WriteLiteral(@"                                </div>
                            </div>
                        </div><br />
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
#line 240 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.TextBoxFor(m => m.CelPhoneNumber, new { @class = "form-control", type = "number" }));

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
#line 248 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
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
#line 257 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.TextBoxFor(m => m.PersonalEmailAddress, new { @class = "form-control" }));

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
#line 265 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
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
#line 273 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.TextBoxFor(m => m.FaxNumber, new { @class = "form-control", type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""form-group"">
                                        <label>
                                            Preferred Language
                                        </label>
                                        ");
#nullable restore
#line 282 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.TextBoxFor(m => m.StudentNumber, new { @class = "form-control" }));

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
#line 290 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                                   Write(Html.DropDownListFor(model => model.CommunicationMethod, new List<SelectListItem>()
                                      {
                                         new SelectListItem() { Text = "Email", Value = "Email" },
                                         new SelectListItem() { Text = "Phone", Value = "Phone"},
                                          new SelectListItem() { Text = "Call", Value = "Call"},
                                          new SelectListItem() { Text = "Other", Value = "Other"}
                                      }, "Communication Method", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </fieldset>
                    <fieldset>
                        <legend>
                            Postal Information
                        </legend>
                        <div class=""row"">
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        IsPostalSameAsPhysical
                                    </label>
                                    ");
#nullable restore
#line 312 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                               Write(Html.DropDownListFor(model => model.IsPostalSameAsPhysical, new List<SelectListItem>()
                                        {
                                           new SelectListItem() { Text = "Yes", Value = "True" },
                                           new SelectListItem() { Text = "No", Value = "False"}
                                        }, "Select.....", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-md-9"">
                                <div class=""form-group"">
                                    <label>
                                        Address Line 1*
                                    </label>
                                    ");
#nullable restore
#line 326 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.PostalAddress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>

                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        Country
                                    </label>
                                    ");
#nullable restore
#line 335 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.PostalCountry, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        Province
                                    </label>
                                    ");
#nullable restore
#line 343 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.PostalProvince, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>

                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        City
                                    </label>
                                    ");
#nullable restore
#line 352 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.PostalCity, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label>
                                        Region
                                    </label>
                                    ");
#nullable restore
#line 360 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.PostalRegion, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        Street Number
                                    </label>
                                    ");
#nullable restore
#line 368 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.PostalAddressLine2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        Street Name
                                    </label>
                                    ");
#nullable restore
#line 376 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.PostalAddressLine3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>

                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        OtherAddress
                                    </label>
                                    ");
#nullable restore
#line 385 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.PostalAddress, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-md-3"">
                                <div class=""form-group"">
                                    <label class=""control-label"">
                                        Postal Code*
                                    </label>
                                    ");
#nullable restore
#line 393 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
                               Write(Html.TextBoxFor(m => m.PostalPostalCode, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div><br />\r\n                    </fieldset>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""form-group"">
                <button id=""submit"" class=""btn btn-primary next-step btn-wide pull-right"">
                    Save & Continuing <i class=""fa fa-arrow-circle-right""></i>
                </button>
            </div>
");
#nullable restore
#line 407 "C:\2021\Repos\Project\apps\Ui\SchoolManagementSystem.UI\Views\Parent\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<script src=\"https://maps.googleapis.com/maps/api/js?key=AIzaSyAyGTCuQbgKFn9O16P6BE-A-gaGSiMTEtI&libraries=places&callback=initAutocomplete\" async defer></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baf432697f0dad33aecd51b0ede4be3933d3cc0133272", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolManagementSystem.Shared.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
