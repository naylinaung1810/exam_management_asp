#pragma checksum "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Class\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26a3a4c2ca5c8b2c32b71bc24e60f3def5586a8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Class_Index), @"mvc.1.0.view", @"/Views/Class/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Class/Index.cshtml", typeof(AspNetCore.Views_Class_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26a3a4c2ca5c8b2c32b71bc24e60f3def5586a8a", @"/Views/Class/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Class_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Exam_Management_System.Models.Class>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Major", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditMajor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveMajor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Class\Index.cshtml"
  
    ViewData["Title"] = "Class";

#line default
#line hidden
            BeginContext(101, 990, true);
            WriteLiteral(@"<section class=""content-header bg-gray"" style=""padding-top:10px"">
    <div class=""row"">
        <div class=""col-sm-4"">
            <h2 style="""">
                Class
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
        <div class=""col-md-4"">
            <div class=""panel"">
                <div class=""panel-heading"">
                    <i class=""fa fa-plus-square fa-2x""></i><span style=""font-size:25px""> Add Class</span>
                </div>
                <div class=""panel-body"">
                    ");
            EndContext();
            BeginContext(1091, 789, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "953f71191abb4c3b998cde9f8100db0f", async() => {
                BeginContext(1097, 428, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label>Class Name</label>
                            <input type=""text"" class=""form-control"" name=""Name"" />
                        </div>
                        <div class=""form-group"">
                            <label>Year</label>
                            <select name=""Year_id"" class=""form-control"">
                                ");
                EndContext();
                BeginContext(1525, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e18ce2f6bfd4d3d90501ebd2bd0f7fb", async() => {
                    BeginContext(1533, 14, true);
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
                BeginContext(1556, 317, true);
                WriteLiteral(@"
                            </select>
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
            BeginContext(1880, 643, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-8"">
            <div class=""panel"">
                
                <div class=""panel-body table-responsive"">
                    <table class=""table table-hover"">
                        <thead class=""bg-gray"">
                            <tr>
                                <th>Id</th>
                                <th>Name</th>
                                <th>Year</th>
                                <th>Edit</th>
                            </tr>
                        </thead>
                        <tbody id=""myTable"">
");
            EndContext();
#line 64 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Class\Index.cshtml"
                             foreach (var c in Model)
                            {

#line default
#line hidden
            BeginContext(2609, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2680, 4, false);
#line 67 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Class\Index.cshtml"
                               Write(c.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2684, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2728, 6, false);
#line 68 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Class\Index.cshtml"
                               Write(c.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2734, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2778, 6, false);
#line 69 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Class\Index.cshtml"
                               Write(c.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2784, 81, true);
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2865, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8fa35bc6e104c1ab944188b7a2d6c03", async() => {
                BeginContext(2959, 26, true);
                WriteLiteral("<i class=\"fa fa-edit\"></i>");
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
#line 71 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Class\Index.cshtml"
                                                                                                               WriteLiteral(c.Id);

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
            BeginContext(2989, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3027, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faadbdbb2c044ff1a3c59651fdd2fcf7", async() => {
                BeginContext(3122, 27, true);
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Class\Index.cshtml"
                                                                                                                WriteLiteral(c.Id);

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
            BeginContext(3153, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 75 "C:\Users\Lenovo\Desktop\Exam_management\exam_management_asp\Exam_Management_System\Views\Class\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(3260, 148, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Exam_Management_System.Models.Class>> Html { get; private set; }
    }
}
#pragma warning restore 1591
