#pragma checksum "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\AddNewStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7292f0dc9f0319ccc60b1534d0a7a8b79361de1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_AddNewStudent), @"mvc.1.0.view", @"/Views/Student/AddNewStudent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/AddNewStudent.cshtml", typeof(AspNetCore.Views_Student_AddNewStudent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7292f0dc9f0319ccc60b1534d0a7a8b79361de1", @"/Views/Student/AddNewStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_AddNewStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/school.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:40px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "m", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "f", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostNewStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Lenovo\Desktop\exam_management_asp\Exam_Management_System\Views\Student\AddNewStudent.cshtml"
  
    ViewData["Title"] = "AddNewStudent";

#line default
#line hidden
            BeginContext(51, 148, true);
            WriteLiteral("\r\n<section class=\"content-header\" style=\"padding-top:0px\">\r\n    \r\n</section>\r\n<!-- Main content -->\r\n<section class=\"content container-fluid\">\r\n    ");
            EndContext();
            BeginContext(199, 10224, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a819b02d5c5a4105885df5a5e9a39852", async() => {
                BeginContext(338, 310, true);
                WriteLiteral(@"

        <center>
            <h2>University of Computer Studies(Thaton)</h2>
            <h2>2018-2019 Academic Year</h2>
            <h2><b>Admission Form</b></h2>
        </center>

        <div class=""row"">
            <div class=""col-md-4 text-center"" style=""margin-left:0px;"">
                ");
                EndContext();
                BeginContext(648, 121, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "caebe04dbf6c41c9842e3761a2a156f1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(769, 2944, true);
                WriteLiteral(@"<br /><br />
                <input type=""file"" style=""margin-left:10px"" name=""Photo"" required/>
            </div>
            <div class=""col-md-8 container "" style=""margin-top:0px;"">

                <div style=""margin-top:30px"" class="" table-responsive"">
                    <table class=""table table-bordered col-md-8"" style=""border:1px solid black"">
                        <tr>
                            <th class=""col-xs-4"" style=""font-size:large"">Academic Year</th>
                            <td class=""col-xs-4"" style=""font-size:large"">
                               <select class=""form-control"" name=""academic_id"" id=""academic"" required>

                               </select>
                            </td>
                        </tr>
                        <tr>
                            <th class=""col-xs-4"" style=""font-size:large"">University NRC Number</th>
                            <td class=""col-xs-4"" style=""font-size:large""><input type=""text"" class=""form-control"" style");
                WriteLiteral(@"=""border:none"" /> </td>
                        </tr>
                        <tr>
                            <th class=""col-xs-4"" style=""font-size:large"">University Entrance Year</th>
                            <td class=""col-xs-4"" style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" /> </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
       
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
             ");
                WriteLiteral(@"       <th style=""font-size:large"">1</th>
                    <th style=""font-size:large"">Name</th>

                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""Name"" required/></td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""father_name"" required/></td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""mother_name"" required/></td>
                </tr>
                <tr style=""border:1px solid;"">
                    <th style=""font-size:large"">2</th>
                    <th style=""font-size:large"">Gender</th>

                    <td style=""font-size:large"" colspan=""3"">
                        <select name=""sex"" class=""form-control"" style=""width:100px;"">
                            ");
                EndContext();
                BeginContext(3713, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccdad1f0eb3847baa2a7bf7a42736337", async() => {
                    BeginContext(3731, 4, true);
                    WriteLiteral("Male");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3744, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3774, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f403cb2743194fc590b42de0e30d0ee2", async() => {
                    BeginContext(3792, 6, true);
                    WriteLiteral("Female");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3807, 6609, true);
                WriteLiteral(@"
                        </select>
                    </td>

                </tr>

                <tr>
                    <th style=""font-size:large"">3</th>
                    <th style=""font-size:large"">Nationality</th>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""nationality"" required/></td>
                    <td style=""font-size:large"">
                        <input type=""text"" class=""form-control"" style=""border:none"" name=""Father_nationality"" required/>
                    </td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""Mother_nationality"" required/></td>
                </tr>
                <tr>
                    <th style=""font-size:large"">4</th>
                    <th style=""font-size:large"">Religion</th>

                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""religion"" requi");
                WriteLiteral(@"red/></td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""Father_religion"" required/></td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""Mother_religion"" required/></td>
                </tr>
                <tr>
                    <th style=""font-size:large"">5</th>
                    <th style=""font-size:large"">City</th>

                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""city"" required/></td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""Father_city"" required/></td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""Mother_city"" required/></td>
                </tr>

                <tr>
                    <th style=""font-size:large"">6</th>
                    <th st");
                WriteLiteral(@"yle=""font-size:large"">Phone Number</th>
                    <td style=""font-size:large""><input type=""tel"" class=""form-control"" style=""border:none"" name=""phone"" required/></td>
                    <td style=""font-size:large""><input type=""tel"" class=""form-control"" style=""border:none"" name=""father_phone"" required/></td>
                    <td style=""font-size:large""><input type=""tel"" class=""form-control"" style=""border:none"" name=""mother_phone"" required /></td>

                </tr>
                <tr>
                    <th style=""font-size:large"">7</th>
                    <th style=""font-size:large"">Job</th>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" required/></td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""father_job"" required/></td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""mother_job"" re");
                WriteLiteral(@"quired/></td>

                </tr>

                <tr>
                    <th style=""font-size:large"">8</th>
                    <th style=""font-size:large"">NRC</th>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""Nrc"" required/></td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""father_nrc"" required/></td>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""mother_nrc"" required/></td>

                </tr>

            </table>
        </div>


        <div class=""container-fluid  table-responsive"" style=""margin-top:30px;margin-right:5px"">
            <table class=""table table-bordered"">
                <tr style=""border:1px solid;"">
                    <th style=""font-size:large"">9</th>
                    <th style=""font-size:large"" colspan=""2"">Birth Date Of Student</th>

             ");
                WriteLiteral(@"       <td style=""font-size:large"">
                        <div class=""form-group"">

                            <div class=""input-group date"">
                                <div class=""input-group-addon"">
                                    <i class=""fa fa-calendar""></i>
                                </div>
                                <input type=""text"" name=""DOB"" class=""form-control pull-right"" id=""datepicker"" required>
                            </div>
                            <!-- /.input group -->
                        </div>
                    </td>
                </tr>

                <tr>
                    <th style=""font-size:large"" rowspan=""3"">10</th>
                    <th style=""font-size:large"" rowspan=""3"">Passed Matriculation Exam:</th>
                    <th style=""font-size:large"">Roll No:</th>
                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""reg_no"" required/></td>
                </tr>
");
                WriteLiteral(@"                <tr>

                    <th style=""font-size:large"">Year</th>

                    <td style=""font-size:large""><input type=""text"" class=""form-control"" style=""border:none"" name=""reg_date"" required/></td>

                </tr>
                <tr>

                    <th style=""font-size:large"">Mark</th>

                    <td style=""font-size:large""><input type=""number"" class=""form-control"" style=""border:none"" name=""Mark"" required/></td>

                </tr>
                <tr>
                    <th style=""font-size:large"">11</th>
                    <th style=""font-size:large"" colspan=""2"">Address</th>

                    <td style=""font-size:large""><textarea class=""form-control"" style=""border:none"" name=""address"" required></textarea></td>

                </tr>

                <tr>
                    <th style=""font-size:large"">12</th>
                    <th style=""font-size:large"" colspan=""2"">Email Adderss</th>
                    <td style=""font-size:l");
                WriteLiteral(@"arge""><input type=""email"" class=""form-control"" style=""border:none"" name=""email"" required/></td>


                </tr>



            </table>
        </div>


        <center style=""margin-bottom:30px;""> <input type=""submit"" value=""Save"" style=""margin-top:280px;font-weight:bolder;font-size:18px;background-color:cadetblue;color:black;width:100px;height:50px;margin-right:100px;margin-top:50px;border-radius:10px"" class=""form-control""></center>

    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10423, 14, true);
            WriteLiteral("\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(10454, 558, true);
                WriteLiteral(@" 
<script>
    $(function () {
         $('#datepicker').datepicker({
                autoclose: true
         });
        ///////////////////////////////////////
        $.ajax({
            url: ""/Student/GetAcademic"",
            type: ""GET"",
            success: function (data) {
                $.each(data, function (i, item) {
                    var str = '<option value=""' + item.id + '"">' + item.name + '</option>';
                    $('#academic').append(str);
                });
            }
        });
    });
</script>
");
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
