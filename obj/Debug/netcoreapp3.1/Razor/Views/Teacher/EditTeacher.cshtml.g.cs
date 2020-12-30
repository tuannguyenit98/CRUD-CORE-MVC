#pragma checksum "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92ba401ae8dedac0f891bfc2897c4e5b12435a73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_EditTeacher), @"mvc.1.0.view", @"/Views/Teacher/EditTeacher.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92ba401ae8dedac0f891bfc2897c4e5b12435a73", @"/Views/Teacher/EditTeacher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc1325f948e485e5b24e11a59df72a28ff12a14", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_EditTeacher : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
  
    ViewData["Title"] = "EditTeacher";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Edit Teacher</h2>\n\n");
#nullable restore
#line 7 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
 using (Html.BeginForm("TeacherEdited", "Teacher", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
Write(Html.HiddenFor(n => n.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 12 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.LabelFor(n => n.SchoolId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 13 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.DropDownListFor(n => n.SchoolId, new SelectList(ViewBag.Schools,"Id","Name"), "Select a School.", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 14 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.ValidationMessageFor(n => n.SchoolId, "", new {@class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 17 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.LabelFor(n => n.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 18 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.TextBoxFor(n => n.FullName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 19 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.ValidationMessageFor(n => n.FullName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 23 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.LabelFor(n => n.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 24 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.TextBoxFor(e => e.Age, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 25 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.ValidationMessageFor(n => n.Age, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 29 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.LabelFor(n => n.YearsOfExperience));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 30 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.TextBoxFor(a => a.YearsOfExperience, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 31 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.ValidationMessageFor(n => n.YearsOfExperience, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 35 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.LabelFor(n => n.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 36 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.TextBoxFor(a => a.PhoneNumber, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 37 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.ValidationMessageFor(n => n.PhoneNumber, "", new { @class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 41 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.LabelFor(n => n.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 42 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
   Write(Html.TextBoxFor(a => a.Subject, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-default\">Save All Changes</button>\n");
#nullable restore
#line 47 "E:\Web\SchoolManagementMVC\Views\Teacher\EditTeacher.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591