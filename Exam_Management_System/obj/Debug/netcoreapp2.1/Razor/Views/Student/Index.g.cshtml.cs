#pragma checksum "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e56e965ac9105d88415fc4e4ff8c4b8d3a1f379b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e56e965ac9105d88415fc4e4ff8c4b8d3a1f379b", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Exam_Management_System.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-major", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-major", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-major", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Student";

#line default
#line hidden
            BeginContext(104, 337, true);
            WriteLiteral(@"<style>
    .row #accordion .panel .panel-body li:hover {
        background-color: Highlight;
        color: white;
    }
</style>

<section class=""content-header bg-gray"" style=""padding-top:0px"">
    <div class=""row"">
        <div class=""col-sm-4"">
            <h1 style="""">
                Students
                <small>");
            EndContext();
            BeginContext(442, 16, false);
#line 18 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Student\Index.cshtml"
                  Write(ViewData["year"]);

#line default
#line hidden
            EndContext();
            BeginContext(458, 1522, true);
            WriteLiteral(@"</small>
            </h1>
        </div>
        <div class=""col-sm-8"">
            <div class=""row"" style=""padding-top:15px;padding-bottom:5px"">
                <div class=""col-md-6 col-md-offset-3"">
                    <input type=""text"" class=""form-control"" id=""search"" placeholder=""Search.........."" />
                </div>
            </div>
        </div>
    </div>

</section>
<!-- Main content -->
<section class=""content container-fluid"">

    <div class=""row"" style=""margin-top:10px"">
        <div class=""col-sm-3 col-md-2"">
            <div class=""panel-group"" id=""accordion"" role=""tablist"" aria-multiselectable=""true"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"" role=""tab"" id=""headingOne"">
                        <h3 class=""panel-title text-center"" style=""padding:5px"">
                            <a role=""button"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne""");
            WriteLiteral(@">
                                First Year
                            </a>
                        </h3>
                    </div>
                    <div id=""collapseOne"" class='panel-collapse collapse' role=""tabpanel"" aria-labelledby=""headingOne"">
                        <div class=""panel-body"">
                            <ul class=""list-unstyled text-center"" style=""font-size:18px"">
                                <li style=""border:1px solid grey;border-radius:5px;padding:3px"">");
            EndContext();
            BeginContext(1980, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0f1a98cf6df4309aa44ca6ebcddce22", async() => {
                BeginContext(2064, 4, true);
                WriteLiteral("CST ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["major"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2072, 995, true);
            WriteLiteral(@"</li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"" role=""tab"" id=""headingOne"">
                        <h3 class=""panel-title text-center"" style=""padding:5px"">
                            <a role=""button"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseTwo"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                Second Year
                            </a>
                        </h3>
                    </div>
                    <div id=""collapseTwo"" class=""panel-collapse collapse"" role=""tabpanel"" aria-labelledby=""headingOne"">
                        <div class=""panel-body"">
                            <ul class=""list-unstyled text-center"" style=""font-size:18px"">
                                <li style=""border:1px solid grey;border-radius:5px;padding:3px"">");
            EndContext();
            BeginContext(3067, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25d543bff69242778b73489da102399f", async() => {
                BeginContext(3151, 3, true);
                WriteLiteral("CS ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["major"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3158, 118, true);
            WriteLiteral("</li>\r\n                                <li style=\"border:1px solid grey;border-radius:5px;margin-top:5px;padding:3px\">");
            EndContext();
            BeginContext(3276, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ba6ee37baf440c983732e5bbf246f0e", async() => {
                BeginContext(3360, 2, true);
                WriteLiteral("CT");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["major"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3366, 4175, true);
            WriteLiteral(@"</li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"" role=""tab"" id=""headingOne"">
                        <h3 class=""panel-title text-center"" style=""padding:5px"">
                            <a role=""button"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseThree"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                Third Year
                            </a>
                        </h3>
                    </div>
                    <div id=""collapseThree"" class=""panel-collapse collapse"" role=""tabpanel"" aria-labelledby=""headingOne"">
                        <div class=""panel-body"">
                            <ul class=""list-unstyled text-center"" style=""font-size:18px"">
                                <li style=""border:1px solid grey;border-radius:5px;padding:3px""><a>CS </a></li>
         ");
            WriteLiteral(@"                       <li style=""border:1px solid grey;border-radius:5px;margin-top:5px;padding:3px""><a>CT</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"" role=""tab"" id=""headingOne"">
                        <h3 class=""panel-title text-center"" style=""padding:5px"">
                            <a role=""button"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseFour"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                Fourth Year
                            </a>
                        </h3>
                    </div>
                    <div id=""collapseFour"" class=""panel-collapse collapse"" role=""tabpanel"" aria-labelledby=""headingOne"">
                        <div class=""panel-body"">
                            <ul class=""list-unstyled text-center"" style=""font-size:18px"">
            ");
            WriteLiteral(@"                    <li style=""border:1px solid grey;border-radius:5px;padding:3px""><a href=""#"">CS</a></li>
                                <li style=""border:1px solid grey;border-radius:5px;margin-top:5px;padding:3px""><a href=""#"">CT</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"" role=""tab"" id=""headingOne"">
                        <h3 class=""panel-title text-center"" style=""padding:5px"">
                            <a role=""button"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseFive"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                Final Year
                            </a>
                        </h3>
                    </div>
                    <div id=""collapseFive"" class=""panel-collapse collapse"" role=""tabpanel"" aria-labelledby=""headingOne"">
                        <di");
            WriteLiteral(@"v class=""panel-body"">
                            <ul class=""list-unstyled text-center"" style=""font-size:18px"">
                                <li style=""border:1px solid grey;border-radius:5px;padding:3px""><a href=""#"">CS </a></li>
                                <li style=""border:1px solid grey;border-radius:5px;margin-top:5px;padding:3px""><a href=""#"">CT</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-sm-9 col-md-10"">
            <div class=""panel table-responsive"">
                <table class=""table table-hover text-center"">
                    <thead class=""bg-gray"">
                        <tr style=""font-size:16px"">
                            <th>Roll No</th>
                            <th>Name</th>
                            <th>Class</th>
                            <th>Year</th>
                            <th>Major</th>
                        ");
            WriteLiteral("</tr>\r\n                    </thead>\r\n                    <tbody id=\"myTable\">\r\n");
            EndContext();
#line 136 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Student\Index.cshtml"
                         foreach (var student in Model)
                        {

#line default
#line hidden
            BeginContext(7625, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(7696, 14, false);
#line 139 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Student\Index.cshtml"
                               Write(student.Rollno);

#line default
#line hidden
            EndContext();
            BeginContext(7710, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(7754, 12, false);
#line 140 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Student\Index.cshtml"
                               Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(7766, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(7810, 13, false);
#line 141 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Student\Index.cshtml"
                               Write(student.Class);

#line default
#line hidden
            EndContext();
            BeginContext(7823, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(7867, 12, false);
#line 142 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Student\Index.cshtml"
                               Write(student.Year);

#line default
#line hidden
            EndContext();
            BeginContext(7879, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(7923, 13, false);
#line 143 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Student\Index.cshtml"
                               Write(student.Major);

#line default
#line hidden
            EndContext();
            BeginContext(7936, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 145 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Student\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(8005, 118, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8140, 358, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Exam_Management_System.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
