#pragma checksum "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Assignment\AddAssignment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dea2e3a3ae9b287439edfb92d7025f70fc803e10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Assignment_AddAssignment), @"mvc.1.0.view", @"/Views/Assignment/AddAssignment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Assignment/AddAssignment.cshtml", typeof(AspNetCore.Views_Assignment_AddAssignment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea2e3a3ae9b287439edfb92d7025f70fc803e10", @"/Views/Assignment/AddAssignment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Assignment_AddAssignment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Assignment\AddAssignment.cshtml"
  
    ViewData["Title"] = "AddAssignment";

#line default
#line hidden
            BeginContext(51, 1489, true);
            WriteLiteral(@"

<section class=""content-header bg-gray-active"" style=""padding-top:10px"">
    <h1 style=""padding-top:10px;padding-bottom:20px"">
        <i class=""fa fa-paperclip text-blue""></i>
        Assignment
        <small> > Mark</small><small style=""font-size:16px""> > Add</small>
    </h1>
</section>
<!-- Main content -->
<span id=""alert""></span>
<section class=""content container-fluid bg-info"" style=""height:650px"">
    <div class=""container"">
        <!--
        <div class=""row"">
            <div class=""col-xs-12 hidden-sm hidden-lg hidden-md"">
                <a asp-controller=""Subject"" asp-action=""Index"" class=""btn btn-success text-center btn-block hidden-sm hidden-lg hidden-md"" style=""margin-bottom:10px""><i class=""fa fa-arrow-circle-left""></i> Mark</a>
            </div>
        </div>-->
        <div class=""row"">
           <!-- <a asp-controller=""Exam"" asp-action=""Index"" class=""btn btn-success pull-left hidden-xs""><i class=""fa fa-arrow-circle-left""></i> Exam Info</a>-->
            <div cl");
            WriteLiteral(@"ass=""col-md-6 col-sm-6 col-sm-offset-1 col-md-offset-2"">

                <div class=""box box-success"" style=""box-shadow:gainsboro 5px 5px"">
                    <div class=""box-header"" style=""border-bottom:1px solid lightgrey"">
                        <i class=""fa fa-plus-square fa-2x""></i> <span style=""font-size:25px"">Add Assignment</span>
                    </div>
                    <div class=""box-body"" style=""padding:20px"">
                        ");
            EndContext();
            BeginContext(1540, 2046, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e97afb299e9c43e8b9120d086b5d268a", async() => {
                BeginContext(1546, 233, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>Year</label>\r\n                                <select name=\"Year_id\" id=\"year\" class=\"form-control\">\r\n                                    ");
                EndContext();
                BeginContext(1779, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2bf561747184796b0f13244f25bbfa6", async() => {
                    BeginContext(1787, 13, true);
                    WriteLiteral("----Select---");
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
                BeginContext(1809, 309, true);
                WriteLiteral(@"

                                </select>
                            </div>
                            <div class=""form-group"">
                                <label>Major</label>
                                <select name="""" id=""major"" class=""form-control"">
                                    ");
                EndContext();
                BeginContext(2118, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ea2cedb31984946a8533a0686ef5a6c", async() => {
                    BeginContext(2136, 3, true);
                    WriteLiteral("CST");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2148, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2186, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b6302c264f84806ab61d8481f850769", async() => {
                    BeginContext(2204, 2, true);
                    WriteLiteral("CS");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2215, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2253, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "514437e151134c4cafff71dd98ea149b", async() => {
                    BeginContext(2271, 2, true);
                    WriteLiteral("CT");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2282, 662, true);
                WriteLiteral(@"

                                </select>
                            </div>
                            <div class=""form-group"">
                                <label>Roll No</label>
                                <input list=""rollno"" class=""form-control"" name=""Rollno"">

                                <datalist id=""rollno"">
                                </datalist>
                            </div>
                            <div class=""form-group"">
                                <label>Subject</label>
                                <select name=""Subject_id"" id=""subject"" class=""form-control"">
                                    ");
                EndContext();
                BeginContext(2944, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1e59bc39fdd4d85a434f01c86302d1a", async() => {
                    BeginContext(2952, 13, true);
                    WriteLiteral("----Select---");
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
                BeginContext(2974, 605, true);
                WriteLiteral(@"

                                </select>
                            </div>
                            <div class=""form-group"">
                                <label>Mark</label>
                                <input type=""number"" min=""0"" max=""20"" class=""form-control"" id=""mark"" name=""Mark"" />
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3586, 114, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3717, 3428, true);
                WriteLiteral(@"
    <script>
        $(function () {


            ////////////////////////////////////////
            $('#year').change(function () {
                console.log($('#year').val());

                $.ajax({
                    url: ""/Result/GetRollNo/"" + $('#year').val(),
                    type: ""GET"",
                    success: function (data) {
                        //console.log(data);
                        $(""#rollno"").html(null);
                        $.each(data, function (i, rollno) {
                            var str = ' <option value=""' + rollno.roll + '""></option>';
                            $('#rollno').append(str);
                        });
                    }
                });
                $.ajax({
                    url: ""/Result/GetSubject/"" + $('#year').val() + ""?major="" + $('#major').val(),
                    type: ""GET"",
                    success: function (data) {
                        //console.log(data);
                        $(""");
                WriteLiteral(@"#subject"").html(null);
                        $.each(data, function (i, subject) {
                            var str = ' <option value=""' + subject.id + '"">' + subject.name + '</option>';
                            $('#subject').append(str);
                        });
                    }
                });


            });
            $('#major').change(function () {
                $.ajax({
                    url: ""/Result/GetSubject/"" + $('#year').val() + ""?major="" + $('#major').val(),
                    type: ""GET"",
                    success: function (data) {
                        //console.log(data);
                        $(""#subject"").html(null);
                        $.each(data, function (i, subject) {
                            var str = ' <option value=""' + subject.id + '"">' + subject.name + '</option>';
                            $('#subject').append(str);
                        });
                    }
                });
            })

            ");
                WriteLiteral(@"$.ajax({
                url: ""/Result/getYear"",
                type: ""GET"",
                success: function (data) {
                    //console.log(data);
                    $.each(data, function (i, year) {
                        var str = ' <option value=""' + year.id + '"">' + year.name + '</option>';
                        $('#year').append(str);
                    })
                }
            });
            ////////////////////////////////////////////

            $('form').submit(function (e) {
                e.preventDefault();
                $.ajax({
                    url: ""/Assignment/PostAddAssignment"",
                    type: ""POST"",
                    data: $('form').serialize(),
                    success: function (data) {
                        var str = ' <div class=""alert alert-success navbar-fixed-bottom text-center"" style=""padding:25px"" role=""alert"">' +
                            '<strong><i class=""fa fa-check-circle""></i> Successfully!</strong> ");
                WriteLiteral(@"Assignment addition is successfully finished.' +
                            '</div>';
                        $('#alert').html(str);
                        $('#mark').val(null);

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
            BeginContext(7148, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
