#pragma checksum "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f25685df0dcc7dd3e361666a1aaff431bcab6336"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_EditStudent), @"mvc.1.0.view", @"/Views/Student/EditStudent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/EditStudent.cshtml", typeof(AspNetCore.Views_Student_EditStudent))]
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
#line 1 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\_ViewImports.cshtml"
using Exam_Management_System;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\_ViewImports.cshtml"
using Exam_Management_System.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f25685df0dcc7dd3e361666a1aaff431bcab6336", @"/Views/Student/EditStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_EditStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "m", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "f", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostEditStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
  
    ViewData["Title"] = "EditStudent";

#line default
#line hidden
            BeginContext(49, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
  
    var student = ViewBag.student;

#line default
#line hidden
            BeginContext(96, 247, true);
            WriteLiteral("\r\n<section class=\"content-header\" style=\"padding-top:0px\">\r\n</section>\r\n<!-- Main content -->\r\n<section class=\"content container-fluid\">\r\n    <div class=\"row\">\r\n        <h2><i class=\"fa fa-edit\"></i> Edit Student</h2>\r\n    </div>\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(343, 9067, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c652b1c95b4f708157345ab863f398", async() => {
                BeginContext(483, 804, true);
                WriteLiteral(@"       

        <div class=""container-fluid  table-responsive"" style=""margin-top:30px;"">
            <table class=""table table-bordered"" style=""border:1px solid black"">
                <tr>

                    <th style=""border:hidden""></th>
                    <th style=""border:hidden""></th>
                    <th style=""font-size:large"">Student</th>
                    <th style=""font-size:large"">Father</th>
                    <th style=""font-size:large"">Mother</th>
                </tr>
                <tr style=""border:1px solid;"">
                    <th style=""font-size:large"">1</th>
                    <th style=""font-size:large"">Name</th>

                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""Name"" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1287, "\"", 1308, 1);
#line 35 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 1295, student.Name, 1295, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1309, 144, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\"><input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"father_name\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1453, "\"", 1481, 1);
#line 36 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 1461, student.Father_name, 1461, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1482, 144, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\"><input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"mother_name\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1626, "\"", 1654, 1);
#line 37 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 1634, student.Mother_name, 1634, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1655, 376, true);
                WriteLiteral(@"/></td>
                </tr>
                <tr style=""border:1px solid;"">
                    <th style=""font-size:large"">2</th>
                    <th style=""font-size:large"">Gender</th>

                    <td style=""font-size:large"" colspan=""3"">
                        <select name=""sex"" class=""form-control"" style=""width:100px;"">
                            ");
                EndContext();
                BeginContext(2031, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81822420e1694252978789695e5de5c6", async() => {
                    BeginContext(2058, 4, true);
                    WriteLiteral("Male");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2071, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2101, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f084252b2684c2489452dbef55b945c", async() => {
                    BeginContext(2128, 6, true);
                    WriteLiteral("Female");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2143, 404, true);
                WriteLiteral(@"
                          



                        </select>
                    </td>

                </tr>

                <tr>
                    <th style=""font-size:large"">3</th>
                    <th style=""font-size:large"">Nationality</th>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""nationality"" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2547, "\"", 2575, 1);
#line 59 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 2555, student.Nationality, 2555, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2576, 177, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\">\r\n                        <input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"Father_nationality\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2753, "\"", 2788, 1);
#line 61 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 2761, student.Father_nationality, 2761, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2789, 173, true);
                WriteLiteral("/>\r\n                    </td>\r\n                    <td style=\"font-size:large\"><input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"Mother_nationality\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2962, "\"", 2997, 1);
#line 63 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 2970, student.Mother_nationality, 2970, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2998, 307, true);
                WriteLiteral(@"/></td>
                </tr>
                <tr>
                    <th style=""font-size:large"">4</th>
                    <th style=""font-size:large"">Religion</th>

                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""religion"" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3305, "\"", 3330, 1);
#line 69 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 3313, student.Religion, 3313, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3331, 148, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\"><input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"Father_religion\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3479, "\"", 3511, 1);
#line 70 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 3487, student.Father_religion, 3487, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3512, 148, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\"><input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"Mother_religion\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3660, "\"", 3692, 1);
#line 71 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 3668, student.Mother_religion, 3668, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3693, 299, true);
                WriteLiteral(@"/></td>
                </tr>
                <tr>
                    <th style=""font-size:large"">5</th>
                    <th style=""font-size:large"">City</th>

                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""city"" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3992, "\"", 4013, 1);
#line 77 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 4000, student.City, 4000, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4014, 144, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\"><input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"Father_city\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4158, "\"", 4186, 1);
#line 78 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 4166, student.Father_city, 4166, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4187, 144, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\"><input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"Mother_city\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4331, "\"", 4359, 1);
#line 79 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 4339, student.Mother_city, 4339, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4360, 307, true);
                WriteLiteral(@"/></td>
                </tr>

                <tr>
                    <th style=""font-size:large"">6</th>
                    <th style=""font-size:large"">Phone Number</th>
                    <td style=""font-size:large""><input type=""tel"" class=""form-control"" style=""border:none"" name=""phone"" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4667, "\"", 4689, 1);
#line 85 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 4675, student.Phone, 4675, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4690, 144, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\"><input type=\"tel\" class=\"form-control\" style=\"border:none\" name=\"father_phone\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4834, "\"", 4863, 1);
#line 86 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 4842, student.Father_phone, 4842, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4864, 144, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\"><input type=\"tel\" class=\"form-control\" style=\"border:none\" name=\"mother_phone\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5008, "\"", 5037, 1);
#line 87 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 5016, student.Mother_phone, 5016, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5038, 430, true);
                WriteLiteral(@"/></td>

                </tr>
                <tr>
                    <th style=""font-size:large"">7</th>
                    <th style=""font-size:large"">Job</th>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" required /></td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""father_job"" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5468, "\"", 5495, 1);
#line 94 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 5476, student.Father_job, 5476, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5496, 143, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\"><input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"mother_job\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5639, "\"", 5666, 1);
#line 95 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 5647, student.Mother_job, 5647, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5667, 299, true);
                WriteLiteral(@"/></td>

                </tr>

                <tr>
                    <th style=""font-size:large"">8</th>
                    <th style=""font-size:large"">NRC</th>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""Nrc"" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5966, "\"", 5986, 1);
#line 102 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 5974, student.Nrc, 5974, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5987, 143, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\"><input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"father_nrc\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6130, "\"", 6157, 1);
#line 103 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 6138, student.Father_nrc, 6138, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6158, 143, true);
                WriteLiteral("/></td>\r\n                    <td style=\"font-size:large\"><input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"mother_nrc\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6301, "\"", 6328, 1);
#line 104 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 6309, student.Mother_nrc, 6309, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6329, 873, true);
                WriteLiteral(@"/></td>

                </tr>

            </table>
        </div>


        <div class=""container-fluid  table-responsive"" style=""margin-top:30px;margin-right:5px"">
            <table class=""table table-bordered"">
                <tr style=""border:1px solid;"">
                    <th style=""font-size:large"">9</th>
                    <th style=""font-size:large"" colspan=""2"">Birth Date Of Student</th>

                    <td style=""font-size:large"">
                        <div class=""form-group"">

                            <div class=""input-group date"">
                                <div class=""input-group-addon"">
                                    <i class=""fa fa-calendar""></i>
                                </div>
                                <input type=""text"" name=""DOB"" class=""form-control pull-right"" id=""datepicker"" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7202, "\"", 7222, 1);
#line 125 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 7210, student.DOB, 7210, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7223, 552, true);
                WriteLiteral(@">
                            </div>
                            <!-- /.input group -->
                        </div>
                    </td>
                </tr>

                <tr>
                    <th style=""font-size:large"" rowspan=""3"">10</th>
                    <th style=""font-size:large"" rowspan=""3"">Passed Matriculation Exam:</th>
                    <th style=""font-size:large"">Roll No:</th>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""reg_no"" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7775, "\"", 7798, 1);
#line 136 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 7783, student.Reg_no, 7783, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7799, 249, true);
                WriteLiteral("/></td>\r\n                </tr>\r\n                <tr>\r\n\r\n                    <th style=\"font-size:large\">Year</th>\r\n\r\n                    <td style=\"font-size:large\"><input type=\"text\" class=\"form-control\" style=\"border:none\" name=\"reg_date\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 8048, "\"", 8073, 1);
#line 142 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 8056, student.Reg_date, 8056, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8074, 249, true);
                WriteLiteral("/></td>\r\n\r\n                </tr>\r\n                <tr>\r\n\r\n                    <th style=\"font-size:large\">Mark</th>\r\n\r\n                    <td style=\"font-size:large\"><input type=\"number\" class=\"form-control\" style=\"border:none\" name=\"Mark\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 8323, "\"", 8344, 1);
#line 149 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 8331, student.Mark, 8331, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(8345, 312, true);
                WriteLiteral(@"/></td>

                </tr>
                <tr>
                    <th style=""font-size:large"">11</th>
                    <th style=""font-size:large"" colspan=""2"">Address</th>

                    <td style=""font-size:large""><textarea class=""form-control"" style=""border:none"" name=""address"" required>");
                EndContext();
                BeginContext(8658, 15, false);
#line 156 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
                                                                                                                      Write(student.Address);

#line default
#line hidden
                EndContext();
                BeginContext(8673, 334, true);
                WriteLiteral(@"</textarea></td>

                </tr>

                <tr>
                    <th style=""font-size:large"">12</th>
                    <th style=""font-size:large"" colspan=""2"">Email Adderss</th>
                    <td style=""font-size:large""><input type=""email"" class=""form-control"" style=""border:none"" name=""email"" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 9007, "\"", 9029, 1);
#line 163 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\EditStudent.cshtml"
WriteAttributeValue("", 9015, student.Email, 9015, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(9030, 373, true);
                WriteLiteral(@"/></td>


                </tr>

            </table>
        </div>


        <center style=""margin-bottom:30px;""> <input type=""submit"" value=""Edit"" style=""margin-top:280px;font-weight:bolder;font-size:18px;background-color:cadetblue;color:black;width:100px;height:50px;margin-right:100px;margin-top:50px;border-radius:10px"" class=""form-control""></center>

    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9410, 14, true);
            WriteLiteral("\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9441, 206, true);
                WriteLiteral("\r\n    <script>\r\n    $(function () {\r\n         $(\'#datepicker\').datepicker({\r\n                autoclose: true\r\n         });\r\n        ///////////////////////////////////////\r\n       \r\n    });\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
