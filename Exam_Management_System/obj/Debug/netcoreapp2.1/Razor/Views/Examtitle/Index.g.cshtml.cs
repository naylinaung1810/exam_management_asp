#pragma checksum "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5338f3c23ccd0ab4e860f156d15c51853fbec0f"
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
#line 1 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\_ViewImports.cshtml"
using Exam_Management_System;

#line default
#line hidden
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\_ViewImports.cshtml"
using Exam_Management_System.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5338f3c23ccd0ab4e860f156d15c51853fbec0f", @"/Views/Examtitle/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Examtitle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Exam_Management_System.Models.Examtitle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Examtitle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddExamTitle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditExamtitle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
  
    ViewData["Title"] = "Exam Title";

#line default
#line hidden
            BeginContext(109, 698, true);
            WriteLiteral(@"<section class=""content-header bg-gray-active"" style=""padding-top:10px;"">
    <h1 style=""padding-top:10px;padding-bottom:20px"">
        Exam Title
        <small>Information</small>
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid bg-info"" style=""height:650px"">
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""box box-success"" style=""box-shadow:gainsboro 5px 5px"">
                <div class=""box-header"">
                    <i class=""fa fa-plus-square fa-2x""></i><span style=""font-size:25px""> Add Exam Title</span>
                </div>
                <div class=""box-body"" style=""padding:20px"">
                    ");
            EndContext();
            BeginContext(807, 547, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f265323ce5ee4590bb97fab75e3fd592", async() => {
                BeginContext(880, 467, true);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1354, 1215, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-8"">
            <div class=""box box-info"">
                <div class=""box-header"">
                    <div class=""row"">
                        <div class=""col-xs-6 col-xs-offset-3"">
                            <div class=""input-group"">
                                <span class=""input-group-addon bg-gray""><i class=""fa fa-search""></i></span>
                                <input type=""text"" class=""form-control"" id=""search"" placeholder=""Search.........."" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""box-body table-responsive"">
                  
                        <table class=""table table-bordered text-center table-hover"">
                            <thead class=""bg-gray"">
                                <tr>
                                    <th>Id</th>
                                    <th");
            WriteLiteral(">Title</th>\r\n                                    <th>Edit</th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody id=\"myTable\">\r\n");
            EndContext();
#line 56 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                 foreach (var exam in Model)
                                {

#line default
#line hidden
            BeginContext(2666, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(2753, 7, false);
#line 59 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                       Write(exam.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2760, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2812, 9, false);
#line 60 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                       Write(exam.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2821, 158, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <a class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#");
            EndContext();
            BeginContext(2980, 7, false);
#line 62 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                                                                                    Write(exam.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2987, 115, true);
            WriteLiteral("\"><i class=\"fa fa-edit\"></i></a>\r\n                                            <a class=\"btn btn-danger\" id=\"delete\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 3102, "\"", 3117, 1);
#line 63 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
WriteAttributeValue("", 3109, exam.Id, 3109, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3118, 211, true);
            WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                                        </td>\r\n                                    </tr>\r\n                                    <div class=\"modal fade\" tabindex=\"-1\" role=\"dialog\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3329, "\"", 3342, 1);
#line 66 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
WriteAttributeValue("", 3334, exam.Id, 3334, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3343, 208, true);
            WriteLiteral(">\r\n                                        <div class=\"modal-dialog\" role=\"document\">\r\n                                            <div class=\"modal-content\">\r\n                                                ");
            EndContext();
            BeginContext(3551, 1614, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0b7a4db70c243adada50a986d4eb214", async() => {
                BeginContext(3625, 629, true);
                WriteLiteral(@"
                                                    <div class=""modal-header"">
                                                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                                                        <h4 class=""modal-title""><i class=""fa fa-edit""></i> Edit</h4>
                                                    </div>
                                                    <div class=""modal-body"">

                                                        <input type=""hidden"" class=""form-control"" name=""Id""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4254, "\"", 4270, 1);
#line 76 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
WriteAttributeValue("", 4262, exam.Id, 4262, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4271, 285, true);
                WriteLiteral(@" />
                                                        <div class=""form-group"">
                                                            <label>Class Name</label>
                                                            <input type=""text"" class=""form-control"" name=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4556, "\"", 4574, 1);
#line 79 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
WriteAttributeValue("", 4564, exam.Name, 4564, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4575, 583, true);
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5165, 209, true);
            WriteLiteral("\r\n                                            </div><!-- /.modal-content -->\r\n                                        </div><!-- /.modal-dialog -->\r\n                                    </div><!-- /.modal -->\r\n");
            EndContext();
#line 91 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(5409, 184, true);
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                        \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5610, 1059, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $(""#search"").on(""keyup"", function () {
                var value = $(this).val().toLowerCase();
                $(""#myTable tr"").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            });

            $('body').delegate('table #myTable tr td #delete', 'click', function (e) {
                    console.log('OK')
                      if(confirm(""Are you sure you want to delete this?"")){
                          $.ajax({
                              url: ""/Examtitle/RemoveExamtitle/"" + e.target.name,
                              type: ""GET"",
                              success: function (data) {
                                 location.reload(true);
                              }
                          });
                        }
                        else{
                          console.log('Cancle');
                        }
           ");
                WriteLiteral("  });\r\n        });\r\n    </script>\r\n");
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
