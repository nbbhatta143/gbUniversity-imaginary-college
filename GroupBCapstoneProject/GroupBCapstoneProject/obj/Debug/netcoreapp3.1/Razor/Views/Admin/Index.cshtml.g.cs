#pragma checksum "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "230f48ae103f2aa68ea7769f90ce7f028c53b740"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\_ViewImports.cshtml"
using GroupBCapstoneProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\_ViewImports.cshtml"
using GroupBCapstoneProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
using GroupBCapstoneProject.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"230f48ae103f2aa68ea7769f90ce7f028c53b740", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50fe17463a6e178e695157ba9184f8ef4f726319", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataIndex_vm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    <h3>Admin Controls</h3>\r\n");
#nullable restore
#line 7 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
     using (Html.BeginForm("Index", "Admin", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <input type=""submit"" value=""Add Course"" class=""btn btn-primary"" name=""btnSubmit"" />
        <input type=""submit"" value=""General Journal"" class=""btn btn-primary"" name=""btnSubmit"" />
        <input type=""submit"" value=""Accounts Receivable"" class=""btn btn-primary"" name=""btnSubmit"" />
        <input type=""submit"" value=""Accounts Payable"" class=""btn btn-primary"" name=""btnSubmit"" />
        <input type=""submit"" value=""Create Account"" class=""btn btn-primary"" name=""btnSubmit"" />
");
#nullable restore
#line 14 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <p>

    </p>
    <hr />
    <div id=""Show Students"">
        <h4>Student</h4>
        <div class=""col-md-12"">
            <div class=""row"" style=""font-weight: bold"">
                <div class=""col-md-2"">Name</div>
                <div class=""col-md-3"">Major</div>
                <div class=""col-md-1"">Balance</div>
                <div class=""col-md-4"">Email Address</div>
                <div class=""col-md-2"">Phone Number</div>
            </div>

            <div class=""row"">
");
#nullable restore
#line 31 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                 foreach (Student student in ViewBag.listOfStudents)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-2\">");
#nullable restore
#line 33 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(String.Join(" ", student.FirstName, student.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-3\">");
#nullable restore
#line 34 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(student.Major);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-1\">");
#nullable restore
#line 35 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(student.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-4\">");
#nullable restore
#line 36 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(student.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-2\">");
#nullable restore
#line 37 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(student.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 38 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <p>\r\n\r\n    </p>\r\n    <hr />\r\n");
            WriteLiteral(@"    <div id=""Show Faculty"">
        <h4>Faculty</h4>
        <div class=""col-md-12"">
            <div class=""row"" style=""font-weight: bold"">
                <div class=""col-md-1"">Faculty ID</div>
                <div class=""col-md-2"">Name</div>
                <div class=""col-md-3"">Department</div>
                <div class=""col-md-4"">Email Address</div>
                <div class=""col-md-2"">Phone Number</div>
            </div>

            <div class=""row"">
");
#nullable restore
#line 60 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                 foreach (Faculty faculty in ViewBag.listOfFaculty)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-1\">");
#nullable restore
#line 62 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(faculty.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-2\">");
#nullable restore
#line 63 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(String.Join(" ", faculty.FirstName, faculty.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-3\">");
#nullable restore
#line 64 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(faculty.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-4\">");
#nullable restore
#line 65 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(faculty.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-2\">");
#nullable restore
#line 66 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(faculty.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 67 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <p>\r\n\r\n    </p>\r\n    <hr />\r\n");
            WriteLiteral(@"    <div id=""Show Courses"">
        <h4>Courses</h4>
        <div class=""col-md-12"">
            <div class=""row"" style=""font-weight: bold"">
                <div class=""col-md-1"">Course Number</div>
                <div class=""col-md-1"">Section Number</div>
                <div class=""col-md-1"">Capacity</div>
                <div class=""col-md-1"">Enrollment</div>
                <div class=""col-md-1"">FacultyID</div>
                <div class=""col-md-2"">Start Time</div>
                <div class=""col-md-2"">End Time</div>
                <div class=""col-md-2"">Building Name</div>
                <div class=""col-md-1"">Building Number</div>
            </div>

            <div class=""row"">
");
#nullable restore
#line 93 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                 foreach (Course course in ViewBag.listOfCourses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-1\">");
#nullable restore
#line 95 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(course.CourseNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-1\">");
#nullable restore
#line 96 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(course.SectionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-1\">");
#nullable restore
#line 97 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(course.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-1\">");
#nullable restore
#line 98 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(course.Enrollment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-1\">");
#nullable restore
#line 99 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(course.FacultyID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-2\">");
#nullable restore
#line 100 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(course.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-2\">");
#nullable restore
#line 101 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(course.EndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-2\">");
#nullable restore
#line 102 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(course.BuildingName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"col-md-1\">");
#nullable restore
#line 103 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
                                     Write(course.BuildingNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 104 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 109 "C:\Users\naray\OneDrive\Desktop\AllFile\Capstone\GroupBCapstoneProject\GroupBCapstoneProject\Views\Admin\Index.cshtml"
    {

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataIndex_vm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
