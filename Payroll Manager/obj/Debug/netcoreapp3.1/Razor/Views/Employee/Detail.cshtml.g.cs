#pragma checksum "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73a89596787e28590587601e34a0a290180521fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Detail), @"mvc.1.0.view", @"/Views/Employee/Detail.cshtml")]
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
#line 1 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\_ViewImports.cshtml"
using Payroll_Manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\_ViewImports.cshtml"
using Payroll_Manager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73a89596787e28590587601e34a0a290180521fa", @"/Views/Employee/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c7f264d8223fcf11e6d2d6b3a53fc0d4a6d6d0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"col-md-12 grid-margin grid-margin-md-0\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <nav aria-label=\"breadcrumb\">\r\n                <ol class=\"breadcrumb\">\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73a89596787e28590587601e34a0a290180521fa4081", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73a89596787e28590587601e34a0a290180521fa5495", async() => {
                WriteLiteral("Employee List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Detail Employee</li>
                </ol>
            </nav><br /><br />
            <div class=""wrap d-flex justify-content-start justify-content-sm-center flex-wrap"">
                <img class=""rounded-circle shadow-lg"" style=""width:300px; height:350px""");
            BeginWriteAttribute("src", " src=\"", 1073, "\"", 1107, 1);
#nullable restore
#line 18 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 1079, Url.Content(Model.ImageUrl), 1079, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1108, "\"", 1114, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div class=\"wrap align-items-center ml-5\">\r\n                    <p class=\"font-weight-bold text-success\" style=\"font-size:20px\">");
#nullable restore
#line 20 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                                                               Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> Role: ");
#nullable restore
#line 21 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                                    Write(Model.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> Gender: ");
#nullable restore
#line 22 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                                      Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Date Of Birth: ");
#nullable restore
#line 23 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                                            Write(Model.DOB.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Employee Number: ");
#nullable restore
#line 24 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                                              Write(Model.EmployeeNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">NI Number: ");
#nullable restore
#line 25 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                                        Write(Model.NationalInsuranceNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\">Email: <a href=\"#\">");
#nullable restore
#line 26 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                                                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                    <p class=\"font-weight-normal\">Phone: <a");
            BeginWriteAttribute("href", " href=\"", 1881, "\"", 1904, 2);
            WriteAttributeValue("", 1888, "tel:", 1888, 4, true);
#nullable restore
#line 27 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 1892, Model.Phone, 1892, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                                                               Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n                    <br /><br />\r\n                    <p class=\"font-weight-bold\"> Pay & Deductions</p>       \r\n                    <hr style=\"background-color:crimson\" />\r\n                    <p class=\"font-weight-normal\"> Payment Method: ");
#nullable restore
#line 31 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                                              Write(Model.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> Student Loan: ");
#nullable restore
#line 32 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                                            Write(Model.StudentLoan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> Union Member: ");
#nullable restore
#line 33 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                                            Write(Model.UnionMember);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"><i class=\"fas fa-envelope\" style=\"margin-right:0.6em; color:cornflowerblue\"></i> <a");
            BeginWriteAttribute("href", " href=\"", 2505, "\"", 2584, 7);
            WriteAttributeValue("", 2512, "mailto:", 2512, 7, true);
#nullable restore
#line 34 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
WriteAttributeValue("", 2519, Model.Email, 2519, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2531, "?subject=Payslip&body=Attached", 2531, 30, true);
            WriteAttributeValue(" ", 2561, "within", 2562, 7, true);
            WriteAttributeValue(" ", 2568, "is", 2569, 3, true);
            WriteAttributeValue(" ", 2571, "your", 2572, 5, true);
            WriteAttributeValue(" ", 2576, "paylip.", 2577, 8, true);
            EndWriteAttribute();
            WriteLiteral(">Send Payslip</a></p>\r\n                    <br /><br />\r\n\r\n                    <p class=\"font-weight-bold\"> Address</p>\r\n                    <hr style=\"background-color:crimson\" />\r\n                    <p class=\"font-weight-normal\"> ");
#nullable restore
#line 39 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                              Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> ");
#nullable restore
#line 40 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                              Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"font-weight-normal\"> ");
#nullable restore
#line 41 "C:\Users\Tom\Documents\coding\visual studio\Payroll Manager\Payroll Manager\Views\Employee\Detail.cshtml"
                                              Write(Model.Postcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <br />\r\n                    <br />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
