#pragma checksum "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2e946c37250776ffd57dc669c6e55890f145923"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_EditSchool), @"mvc.1.0.view", @"/Views/School/EditSchool.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e946c37250776ffd57dc669c6e55890f145923", @"/Views/School/EditSchool.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc1325f948e485e5b24e11a59df72a28ff12a14", @"/Views/_ViewImports.cshtml")]
    public class Views_School_EditSchool : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<School>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
  
    ViewData["Title"] = "EditSchool";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Edit School</h2>\n\n");
#nullable restore
#line 7 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
 using (Html.BeginForm("SchoolEdited", "School", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
Write(Html.HiddenFor(n=>n.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 12 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
   Write(Html.LabelFor(n => n.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 13 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
   Write(Html.TextBoxFor(n => n.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 14 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
   Write(Html.ValidationMessageFor(n=>n.Name,"", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 18 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
   Write(Html.LabelFor(n => n.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 19 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
   Write(Html.TextBoxFor(e => e.Address, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 20 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
   Write(Html.ValidationMessageFor(n => n.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 24 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
   Write(Html.LabelFor(n => n.FoundingYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 25 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
   Write(Html.TextBoxFor(a => a.FoundingYear,"{0:yyyy-MM-dd}", new { @class = "form-control", @type="date", @value = Model.FoundingYear.ToString("yyyy-MM-dd") }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <div class=\"form-group\">\n        ");
#nullable restore
#line 29 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
   Write(Html.LabelFor(n => n.NumberOfStudents));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 30 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"
   Write(Html.TextBoxFor(a => a.NumberOfStudents, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-default\">Save Changes</button>\n");
#nullable restore
#line 35 "E:\Web\SchoolManagementMVC\Views\School\EditSchool.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<School> Html { get; private set; }
    }
}
#pragma warning restore 1591
