#pragma checksum "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a86642fe82455bdca22248e4d4809771e4e1fea"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a86642fe82455bdca22248e4d4809771e4e1fea", @"/Views/Examtitle/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Examtitle_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Exam_Management_System.Models.Examtitle>>
    {
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
            BeginContext(109, 591, true);
            WriteLiteral(@"<section class=""content-header bg-gray"" style=""padding-top:10px"">
    <h1 style=""padding-top:10px;padding-bottom:20px"">
        Exam Title
        <small>Data</small>
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
            BeginContext(700, 480, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f70f1eadbda417387d026df8fc54c25", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58aaddb4b2c342f1a6c33e70d0e3a89b", async() => {
>>>>>>> fbdfd7e4dfb6e8a842ae9b8b815c127f179d4b3d
                BeginContext(706, 467, true);
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
            BeginContext(1180, 926, true);
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
#line 52 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
                             foreach (var exam in Model)
                            {

#line default
#line hidden
            BeginContext(2195, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2274, 7, false);
#line 55 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                   Write(exam.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2281, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2329, 9, false);
#line 56 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
                                   Write(exam.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2338, 177, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        Edit\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 61 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Examtitle\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2546, 148, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2711, 358, true);
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
