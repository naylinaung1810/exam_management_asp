#pragma checksum "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Examtitle\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "547aed09bcb0f4caf84dd2e5806479e496b64aa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Examtitle_Index), @"mvc.1.0.view", @"/Views/Examtitle/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Examtitle/Index.cshtml", typeof(AspNetCore.Views_Examtitle_Index))]
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
#line 1 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\_ViewImports.cshtml"
using Exam_Management_System;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\_ViewImports.cshtml"
using Exam_Management_System.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"547aed09bcb0f4caf84dd2e5806479e496b64aa4", @"/Views/Examtitle/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Examtitle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Exam_Management_System.Models.Examtitle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Examtitle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveExamtitle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditExamtitle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddExamTitle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Examtitle\Index.cshtml"
  
    ViewData["Title"] = "Exam Title";

#line default
#line hidden
            BeginContext(109, 598, true);
            WriteLiteral(@"<section class=""content-header bg-gray"" style=""padding-top:10px"">
    <h1 style=""padding-top:10px;padding-bottom:20px"">
        Exam Title
        <small>Information</small>
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""panel"">
                <div class=""panel-heading"">
                    <i class=""fa fa-plus-square fa-2x""></i><span style=""font-size:25px""> Add Exam Title</span>
                </div>
                <div class=""panel-body"">
                    ");
            EndContext();
            BeginContext(707, 480, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "841c02de98be4e9eb4a541e56d5ec267", async() => {
                BeginContext(713, 467, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label>Exam Title</label>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1187, 553, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-8"">
            <div class=""panel"">
                <div class=""panel-heading"">
                    <div class=""row"">
                        <div class=""col-xs-6 col-xs-offset-3"">
                            <input type=""text"" class=""form-control"" id=""search"" placeholder=""Search.........."" />
                        </div>
                    </div>
                </div>
                <div class=""panel-body table-responsive"">
                    ");
            EndContext();
            BeginContext(1740, 3499, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97b11f2b902f4d8d98d6868d4c248c1a", async() => {
                BeginContext(1813, 431, true);
                WriteLiteral(@"
                        <table class=""table table-hover"">
                            <thead class=""bg-gray"">
                                <tr>
                                    <th>Id</th>
                                    <th>Title</th>
                                    <th>Edit</th>
                                </tr>
                            </thead>
                            <tbody id=""myTable"">
");
                EndContext();
#line 53 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                 foreach (var exam in Model)
                                {

#line default
#line hidden
                BeginContext(2341, 86, true);
                WriteLiteral("                                    <tr>\r\n                                        <td>");
                EndContext();
                BeginContext(2428, 7, false);
#line 56 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                       Write(exam.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2435, 51, true);
                WriteLiteral("</td>\r\n                                        <td>");
                EndContext();
                BeginContext(2487, 9, false);
#line 57 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                       Write(exam.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2496, 158, true);
                WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#");
                EndContext();
                BeginContext(2655, 7, false);
#line 59 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                                                                                    Write(exam.Id);

#line default
#line hidden
                EndContext();
                BeginContext(2662, 78, true);
                WriteLiteral("\"><i class=\"fa fa-edit\"></i></a>\r\n                                            ");
                EndContext();
                BeginContext(2740, 137, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "517adf96dd3b44b6a8b188a25a259dc0", async() => {
                    BeginContext(2846, 27, true);
                    WriteLiteral("<i class=\"fa fa-trash\"></i>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                                                                                                                WriteLiteral(exam.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2877, 179, true);
                WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n                                    <div class=\"modal fade\" tabindex=\"-1\" role=\"dialog\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3056, "\"", 3069, 1);
#line 63 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Examtitle\Index.cshtml"
WriteAttributeValue("", 3061, exam.Id, 3061, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3070, 208, true);
                WriteLiteral(">\r\n                                        <div class=\"modal-dialog\" role=\"document\">\r\n                                            <div class=\"modal-content\">\r\n                                                ");
                EndContext();
                BeginContext(3278, 1612, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c9c457747d944c8ab110efd9b42a708", async() => {
                    BeginContext(3352, 627, true);
                    WriteLiteral(@"
                                                    <div class=""modal-header"">
                                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                                                        <h4 class=""modal-title""><i class=""fa fa-edit""></i> Edit</h4>
                                                    </div>
                                                    <div class=""modal-body"">
                                                        <input type=""hidden"" class=""form-control"" name=""Id""");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 3979, "\"", 3995, 1);
#line 72 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Examtitle\Index.cshtml"
WriteAttributeValue("", 3987, exam.Id, 3987, 8, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3996, 285, true);
                    WriteLiteral(@" />
                                                        <div class=""form-group"">
                                                            <label>Class Name</label>
                                                            <input type=""text"" class=""form-control"" name=""Name""");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 4281, "\"", 4299, 1);
#line 75 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Examtitle\Index.cshtml"
WriteAttributeValue("", 4289, exam.Name, 4289, 10, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(4300, 583, true);
                    WriteLiteral(@" />
                                                        </div>

                                                    </div>
                                                    <div class=""modal-footer"">
                                                        <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                                                        <button type=""submit"" class=""btn btn-primary"">Save changes</button>
                                                    </div>
                                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4890, 209, true);
                WriteLiteral("\r\n                                            </div><!-- /.modal-content -->\r\n                                        </div><!-- /.modal-dialog -->\r\n                                    </div><!-- /.modal -->\r\n");
                EndContext();
#line 87 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(5134, 98, true);
                WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5239, 86, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5342, 358, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $(""#search"").on(""keyup"", function () {
                var value = $(this).val().toLowerCase();
                $(""#myTable tr"").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Exam_Management_System.Models.Examtitle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
