#pragma checksum "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34e850b6e3eec4c3eb50cfd6309f126cd08c37d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subject_Index), @"mvc.1.0.view", @"/Views/Subject/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Subject/Index.cshtml", typeof(AspNetCore.Views_Subject_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34e850b6e3eec4c3eb50cfd6309f126cd08c37d0", @"/Views/Subject/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Subject_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Exam_Management_System.Models.Subject>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Subject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddSubject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditSubject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveSubject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\Index.cshtml"
  
    ViewData["Title"] = "Subject";

#line default
#line hidden
            BeginContext(105, 786, true);
            WriteLiteral(@"    <section class=""content-header bg-gray"" style=""padding-top:0px"">
        <div class=""row"">
            <div class=""col-sm-4"">
                <h2 style="""">
                    Subject
                    <small>Data</small>
                </h2>
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
    <div class=""row"">
        <div class=""col-md-4"">");
            EndContext();
            BeginContext(891, 150, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "502730a17b04498c8763229fc061edc1", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cde5e65005da4c7cb358635d91fe79f8", async() => {
>>>>>>> fbdfd7e4dfb6e8a842ae9b8b815c127f179d4b3d
                BeginContext(992, 45, true);
                WriteLiteral("<i class=\"fa fa-plus-square\"></i> Add Subject");
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
            BeginContext(1041, 907, true);
            WriteLiteral(@"</div>
        <div class=""col-md-8"">
            <!--div class=""row"">
                <div class=""col-xs-6 col-xs-offset-3"">
                    <input type=""text"" class=""form-control"" id=""search"" placeholder=""Search.........."" />
                </div>
            </div-->
        </div>
        
    </div>
    <div class=""row"" style=""padding:10px"">
        <div class=""panel"">
           
            <div class=""panel-body table-responsive"">
                <table class=""table table-hover"">
                    <thead class=""bg-gray"">
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Year</th>
                            <th>Major</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody id=""myTable"">
");
            EndContext();
#line 51 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\Index.cshtml"
                         foreach (var subjec in Model)
                        {

#line default
#line hidden
            BeginContext(2031, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2102, 9, false);
#line 54 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\Index.cshtml"
                               Write(subjec.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2111, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2155, 11, false);
#line 55 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\Index.cshtml"
                               Write(subjec.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2166, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2210, 11, false);
#line 56 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\Index.cshtml"
                               Write(subjec.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2221, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2265, 12, false);
#line 57 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\Index.cshtml"
                               Write(subjec.Major);

#line default
#line hidden
            EndContext();
            BeginContext(2277, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2358, 133, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dea0c130f644e3488aa3f091a550372", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fedfd6385154c159e9543a2893f039d", async() => {
>>>>>>> fbdfd7e4dfb6e8a842ae9b8b815c127f179d4b3d
                BeginContext(2461, 26, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\Index.cshtml"
                                                                                                                   WriteLiteral(subjec.Id);

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
            BeginContext(2491, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(2529, 135, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ef6f301cd914e068bf8ce1b1c68295e", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "615bb0a1ce004cf68419f3ea353607d6", async() => {
>>>>>>> fbdfd7e4dfb6e8a842ae9b8b815c127f179d4b3d
                BeginContext(2633, 27, true);
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\Index.cshtml"
                                                                                                                    WriteLiteral(subjec.Id);

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
            BeginContext(2664, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 63 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Subject\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2767, 118, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Exam_Management_System.Models.Subject>> Html { get; private set; }
    }
}
#pragma warning restore 1591
