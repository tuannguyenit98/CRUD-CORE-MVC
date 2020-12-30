#pragma checksum "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30b25fa99a8e2cd79c44ce5e7f5faeb95f187a1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_ListSchools), @"mvc.1.0.view", @"/Views/School/ListSchools.cshtml")]
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
#line 1 "E:\Web\SchoolManagementMVC\Views\_ViewImports.cshtml"
using SchoolManagementMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Web\SchoolManagementMVC\Views\_ViewImports.cshtml"
using SchoolManagementMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Web\SchoolManagementMVC\Views\_ViewImports.cshtml"
using SchoolManagementMVC.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30b25fa99a8e2cd79c44ce5e7f5faeb95f187a1d", @"/Views/School/ListSchools.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc1325f948e485e5b24e11a59df72a28ff12a14", @"/Views/_ViewImports.cshtml")]
    public class Views_School_ListSchools : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<School>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
  
    ViewData["Title"] = "ListSchools";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>All Schools are Shown Here</h2>\n\n");
#nullable restore
#line 11 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
Write(Html.ActionLink("Create new School", "CreateSchool", "School"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 13 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-hover\">\n        <thead>\n        <th>School Name</th>\n        <th>School Address</th>\n        <th>Founding Year</th>\n        <th>Number of Students</th>\n");
#nullable restore
#line 21 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
         if (SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th>Edit</th>\n            <th>Delete</th>\n            <th>Details</th>\n");
#nullable restore
#line 26 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </thead>\n        <tbody>\n");
#nullable restore
#line 31 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
             foreach (School school in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 34 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
                   Write(school.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 35 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
                   Write(school.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 36 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
                   Write(school.FoundingYear.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 37 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
                   Write(school.NumberOfStudents);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 38 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 40 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
                       Write(Html.ActionLink("Edit", "EditSchool", "School", new { @id = school.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 41 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
                       Write(Html.ActionLink("Delete", "DeleteSchool", "School", new { @id = school.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 42 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
                       Write(Html.ActionLink("Details", "SchoolDetails", "School", new { @id = school.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 43 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\n");
#nullable restore
#line 45 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 48 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center alert-info\">\n        <h1>There are no schools available.</h1>\n    </div>\n");
#nullable restore
#line 54 "E:\Web\SchoolManagementMVC\Views\School\ListSchools.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<School>> Html { get; private set; }
    }
}
#pragma warning restore 1591