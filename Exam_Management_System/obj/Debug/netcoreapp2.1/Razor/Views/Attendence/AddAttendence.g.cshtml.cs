#pragma checksum "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Attendence\AddAttendence.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75e1b51b303050d48ae622005597a38228e5d5ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendence_AddAttendence), @"mvc.1.0.view", @"/Views/Attendence/AddAttendence.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Attendence/AddAttendence.cshtml", typeof(AspNetCore.Views_Attendence_AddAttendence))]
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
#line 1 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\_ViewImports.cshtml"
using Exam_Management_System;

#line default
#line hidden
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\_ViewImports.cshtml"
using Exam_Management_System.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75e1b51b303050d48ae622005597a38228e5d5ec", @"/Views/Attendence/AddAttendence.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendence_AddAttendence : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Attendence\AddAttendence.cshtml"
  
    ViewData["Title"] = "AddAttendance";

#line default
#line hidden
            BeginContext(51, 1155, true);
            WriteLiteral(@"
<section class=""content-header bg-gray-active"" style=""padding-top:5px"">
    <div class=""row"">
        <div class=""col-sm-4"">
            <h2 style=""font-size:30px"">
                <i class=""fa fa-pie-chart text-purple""></i>
                Attendance
                <small>Add</small>
            </h2>
</div>
        <!--
        <div class=""col-sm-8"">
            <div class=""row"" style=""padding-top:15px;padding-bottom:5px"">
                <div class=""col-md-6 col-md-offset-3"">
                    <input type=""text"" class=""form-control"" id=""search"" placeholder=""Search.........."" />
                </div>
            </div>
        </div>
            -->
    </div>
</section>
<!-- Main content -->
<div id=""alert""></div>
<section class=""content container-fluid bg-info"">
    <div class=""row"">
        <div class=""col-md-6 col-md-offset-2"">
            <div class=""box box-info "" style=""box-shadow:gainsboro 5px 5px"">
                <div class=""box-header"" style=""font-size:25px""><i cla");
            WriteLiteral("ss=\"fa fa-plus-square\"></i> Add Attendance</div>\r\n                <div class=\"box-body\" style=\"padding:20px\">\r\n                    ");
            EndContext();
            BeginContext(1206, 2633, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3634bbaf768d4e3bb2bcf9bc511f338b", async() => {
                BeginContext(1223, 202, true);
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label>Year</label>\r\n                            <select id=\"year\" class=\"form-control\">\r\n                                ");
                EndContext();
                BeginContext(1425, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c197c0e893e447bb6cdfa16094a0c39", async() => {
                    BeginContext(1433, 14, true);
                    WriteLiteral("----Select----");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1456, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 39 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Attendence\AddAttendence.cshtml"
                                   
                                    var year = ViewBag.year;
                                    foreach(var y in year)
                                    {

#line default
#line hidden
                BeginContext(1656, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(1696, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f51c1ca5f152435abdf98e9dba8be802", async() => {
                    BeginContext(1719, 6, false);
#line 43 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Attendence\AddAttendence.cshtml"
                                                         Write(y.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 43 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Attendence\AddAttendence.cshtml"
                                           WriteLiteral(y.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1734, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Attendence\AddAttendence.cshtml"
                                    }
                                

#line default
#line hidden
                BeginContext(1810, 350, true);
                WriteLiteral(@"                            </select>
                        </div>
                        <div class=""form-group"">
                            <label>Roll No</label>
                            <input list=""rollno"" class=""form-control"" name=""Rollno"" id=""roll"">
                           
                            <datalist id=""rollno"">
");
                EndContext();
#line 53 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Attendence\AddAttendence.cshtml"
                                  
                                    var roll = ViewBag.rollno;
                                    foreach (var r in roll)
                                    {

#line default
#line hidden
                BeginContext(2360, 40, true);
                WriteLiteral("                                        ");
                EndContext();
                BeginContext(2400, 33, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6eeac73d87a46d7bbd2837905a7a640", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 57 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Attendence\AddAttendence.cshtml"
                                           WriteLiteral(r.Roll);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2433, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 58 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Attendence\AddAttendence.cshtml"
                                    }
                                

#line default
#line hidden
                BeginContext(2509, 288, true);
                WriteLiteral(@"                            </datalist>
                        </div>
                        <div class=""form-group"">
                            <label>Month</label>
                            <select id=""month"" name=""Month"" class=""form-control"">
                                ");
                EndContext();
                BeginContext(2797, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ce4493f32904b64ad559be95e7fce7a", async() => {
                    BeginContext(2805, 14, true);
                    WriteLiteral("----Select----");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2828, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2862, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e6b5bb10b084cb0bf969fa8faa693c3", async() => {
                    BeginContext(2870, 8, true);
                    WriteLiteral("December");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2887, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2921, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26fd8aa96d3d4300973cd4ab47efaa86", async() => {
                    BeginContext(2929, 7, true);
                    WriteLiteral("January");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2945, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2979, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07071661608145099bec77bb44284e2e", async() => {
                    BeginContext(2987, 8, true);
                    WriteLiteral("February");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3004, 828, true);
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""form-group"">
                            <label>Total (Monthly)</label>
                            <input type=""number"" min=""0"" max=""120"" class=""form-control"" name=""total"" />
                        </div>
                        <div class=""form-group"">
                            <label>Current (Monthly)</label>
                            <input type=""number"" min=""0"" max=""120"" class=""form-control"" name=""current"" id=""current"" />
                        </div>
                        <div class=""form-group text-center"">
                            <button type=""submit"" class=""btn btn-primary"">Save <i class=""fa fa-arrow-circle-right""></i></button>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3839, 86, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3942, 933, true);
                WriteLiteral(@" 
<script>
    $(function () {
        $(""form"").submit(function (e) {
            e.preventDefault();
            $.ajax({
                url: ""/Attendence/PostAddAttendence"",
                type: ""POST"",
                data: $('form').serialize(),
                success: function (data) {
                    // console.log(data);
                    var str = ' <div class=""alert alert-success navbar-fixed-bottom text-center"" style=""padding:25px"" role=""alert"">' +
                        '<strong><i class=""fa fa-check-circle""></i> Successfully!</strong> Mark addition is successfully finished.' +
                        '</div>';
                    $('#alert').html(str);
                    $('#roll').val(null);
                    $('#current').val(null);
                }
            });
             setTimeout(function () { $("".alert"").alert('close') }, 3000);
        });
    });
</script>
");
                EndContext();
            }
            );
            BeginContext(4878, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
