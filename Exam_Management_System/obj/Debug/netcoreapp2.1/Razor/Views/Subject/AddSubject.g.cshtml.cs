#pragma checksum "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed73dd84f4f56b9ae59dcd3716d4aab32df53a86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subject_AddSubject), @"mvc.1.0.view", @"/Views/Subject/AddSubject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Subject/AddSubject.cshtml", typeof(AspNetCore.Views_Subject_AddSubject))]
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
#line 5 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
using Microsoft.AspNetCore.Session;

#line default
#line hidden
#line 6 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed73dd84f4f56b9ae59dcd3716d4aab32df53a86", @"/Views/Subject/AddSubject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Subject_AddSubject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Subject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success text-center btn-block hidden-sm hidden-lg hidden-md"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-left hidden-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostAddSubject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
  
    ViewData["Title"] = "AddSubject";

#line default
#line hidden
            BeginContext(119, 169, true);
            WriteLiteral("<section class=\"content-header bg-gray\" style=\"padding-top:10px\">\r\n    <h1 style=\"padding-top:10px;padding-bottom:20px\">\r\n        Subject\r\n        <small>Add</small> <b>");
            EndContext();
            BeginContext(289, 15, false);
#line 10 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
                         Write(ViewBag.session);

#line default
#line hidden
            EndContext();
            BeginContext(304, 29, true);
            WriteLiteral("</b>\r\n    </h1>\r\n</section>\r\n");
            EndContext();
#line 13 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
  
        var info = Context.Session.GetString("info");
        if (info!=null)
        {

#line default
#line hidden
            BeginContext(428, 299, true);
            WriteLiteral(@"        <div class=""alert alert-success alert-dismissible"" role=""alert"">
            <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
            <strong>Well done!</strong> You successfully add Subject.
        </div>
");
            EndContext();
#line 21 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
        }    

#line default
#line hidden
            BeginContext(742, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(750, 4, false);
#line 22 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
  Write(info);

#line default
#line hidden
            EndContext();
            BeginContext(754, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
            BeginContext(765, 7, true);
            WriteLiteral("    <b>");
            EndContext();
            BeginContext(773, 12, false);
#line 24 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
  Write(ViewBag.data);

#line default
#line hidden
            EndContext();
            BeginContext(785, 6, true);
            WriteLiteral("</b>\r\n");
            EndContext();
            BeginContext(794, 205, true);
            WriteLiteral("<!-- Main content -->\r\n<section class=\"content container-fluid\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-xs-12 hidden-sm hidden-lg hidden-md\">\r\n                ");
            EndContext();
            BeginContext(999, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "926089efe8bc489e8e078204f73937b7", async() => {
                BeginContext(1149, 47, true);
                WriteLiteral("<i class=\"fa fa-arrow-circle-left\"></i> Subject");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1200, 77, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            ");
            EndContext();
            BeginContext(1277, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2281ebdb13c4d90b118b69b2a436a4d", async() => {
                BeginContext(1368, 47, true);
                WriteLiteral("<i class=\"fa fa-arrow-circle-left\"></i> Subject");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1419, 418, true);
            WriteLiteral(@"
            <div class=""col-md-4 col-sm-6 col-sm-offset-1 col-md-offset-2"">
                <div class=""panel"">
                    <div class=""panel-heading"" style=""border-bottom:1px solid lightgrey"">
                        <i class=""fa fa-plus-square fa-2x""></i> <span style=""font-size:25px"">Add Subject</span>
                    </div>
                    <div class=""panel-body"">
                        ");
            EndContext();
            BeginContext(1837, 2025, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d67fd69e48b140c69f4af90d036ac3c7", async() => {
                BeginContext(1910, 233, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>Year</label>\r\n                                <select name=\"Year_id\" id=\"year\" class=\"form-control\">\r\n                                    ");
                EndContext();
                BeginContext(2143, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a24a05e5ebe4988b5a12255c94b7f11", async() => {
                    BeginContext(2151, 13, true);
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
                BeginContext(2173, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 47 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
                                      
                                        var year = ViewBag.year;
                                        foreach (var y in year)
                                        {

#line default
#line hidden
                BeginContext(2389, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(2433, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "014b653f7ac44bedb23c0dec2eff94ca", async() => {
                    BeginContext(2456, 6, false);
#line 51 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
                                                             Write(y.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 51 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
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
                BeginContext(2471, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 52 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
                                        }
                                    

#line default
#line hidden
                BeginContext(2555, 313, true);
                WriteLiteral(@"                                </select>
                            </div>
                            <div class=""form-group"">
                                <label>Major</label>
                                <select name=""Major_id"" id=""major"" class=""form-control"">
                                    ");
                EndContext();
                BeginContext(2868, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72b7b2434ceb40c886c08e444a457174", async() => {
                    BeginContext(2876, 13, true);
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
                BeginContext(2898, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 60 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
                                      
                                        var major = ViewBag.major;
                                        foreach (var m in major)
                                        {

#line default
#line hidden
                BeginContext(3117, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(3161, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27d3e913595f48b5baccd21d17340693", async() => {
                    BeginContext(3184, 6, false);
#line 64 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
                                                             Write(m.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 64 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
                                               WriteLiteral(m.Id);

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
                BeginContext(3199, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 65 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\AddSubject.cshtml"
                                        }
                                    

#line default
#line hidden
                BeginContext(3283, 572, true);
                WriteLiteral(@"                                </select>
                            </div>

                            <div class=""form-group"">
                                <label>Name</label>
                                <input type=""text"" class=""form-control"" name=""Name"" />
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3862, 114, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3993, 1004, true);
                WriteLiteral(@"
    <script>
        $(function () {
            console.log(""OK"")
            /*
            $.ajax({
                url: ""/subject/getYear"",
                type: ""GET"",
                success: function (data) {
                    console.log(data);
                    $.each(data, function (i, year) {
                        var str = ' <option value=""' + year.id + '"">' + year.name + '</option>';
                        //$('#year').append(str);
                    })
                }
            });
            $.ajax({
                url: ""/major/getMajor"",
                type: ""GET"",
                success: function (data) {
                    console.log(data);
                    $.each(data, function (i, major) {
                        var str = ' <option value=""' + major.id + '"">' + major.name + '</option>';
                       // $('#major').append(str);
                    })
                }
            });*/
        })
    </script>
");
                EndContext();
            }
            );
            BeginContext(5000, 2, true);
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
