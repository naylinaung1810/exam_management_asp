#pragma checksum "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Year\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "365b181fa9dc1236bd027307b0ee6a1faecbe169"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Year_Index), @"mvc.1.0.view", @"/Views/Year/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Year/Index.cshtml", typeof(AspNetCore.Views_Year_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"365b181fa9dc1236bd027307b0ee6a1faecbe169", @"/Views/Year/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Year_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Exam_Management_System.Models.Year>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Year", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddYear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditYear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Year\Index.cshtml"
  
    ViewData["Title"] = "Year";

#line default
#line hidden
            BeginContext(99, 1291, true);
            WriteLiteral(@"<section class=""content-header bg-gray-active"" style=""padding-top:10px;margin-top:-10px"">
    <div class=""row"">
        <div class=""col-sm-4"">
            <h2 style="""">
                Year
                <small>Information</small>
            </h2>
        </div>
        <div class=""col-sm-8"">
            <div class=""row"" style=""padding-top:15px;padding-bottom:5px"">
                <div class=""col-md-6 col-md-offset-3"">
                    <div class=""input-group"">
                        <span class=""input-group-addon bg-gray""><i class=""fa fa-search""></i></span>
                        <input type=""text"" class=""form-control"" id=""search"" placeholder=""Search.........."" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Main content -->
<section class=""content container-fluid bg-info"" style=""height:650px"">
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""box box-success"" style=""box-shadow:gainsbo");
            WriteLiteral(@"ro 5px 5px"">
                <div class=""box-header"">
                    <i class=""fa fa-plus-square fa-2x""></i><span style=""font-size:25px""> Add Year</span>
                </div>
                <div class=""box-body"" style=""padding:20px"">
                    ");
            EndContext();
            BeginContext(1390, 531, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a30c4dfce3c44ecbb78af9d0f25cfe4", async() => {
                BeginContext(1453, 461, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label>Year</label>
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
            BeginContext(1921, 612, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""col-md-8"">
            <div class=""box box-info"">

                <div class=""box-body table-responsive"">
                    <table class=""table text-center table-bordered table-hover"">
                        <thead class=""bg-gray"">
                            <tr>
                                <th>Id</th>
                                <th>Year</th>
                                <th>Edit</th>
                            </tr>
                        </thead>
                        <tbody id=""myTable"">
");
            EndContext();
#line 60 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Year\Index.cshtml"
                             foreach (var year in Model)
                            {

#line default
#line hidden
            BeginContext(2622, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2701, 7, false);
#line 63 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Year\Index.cshtml"
                                   Write(year.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2708, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2756, 9, false);
#line 64 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Year\Index.cshtml"
                                   Write(year.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2765, 150, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#");
            EndContext();
            BeginContext(2916, 7, false);
#line 66 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Year\Index.cshtml"
                                                                                                Write(year.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2923, 111, true);
            WriteLiteral("\"><i class=\"fa fa-edit\"></i></a>\r\n                                        <a class=\"btn btn-danger\" id=\"delete\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 3034, "\"", 3049, 1);
#line 67 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Year\Index.cshtml"
WriteAttributeValue("", 3041, year.Id, 3041, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3050, 199, true);
            WriteLiteral("><i class=\"fa fa-trash\"></i></a>\r\n                                    </td>\r\n                                </tr>\r\n                                <div class=\"modal fade\" tabindex=\"-1\" role=\"dialog\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3249, "\"", 3262, 1);
#line 70 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Year\Index.cshtml"
WriteAttributeValue("", 3254, year.Id, 3254, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3263, 196, true);
            WriteLiteral(">\r\n                                    <div class=\"modal-dialog\" role=\"document\">\r\n                                        <div class=\"modal-content\">\r\n                                            ");
            EndContext();
            BeginContext(3459, 1589, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "009ed623782b4a81981a20ecac4aa00c", async() => {
                BeginContext(3523, 603, true);
                WriteLiteral(@"
                                                <div class=""modal-header"">
                                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                                                    <h4 class=""modal-title""><i class=""fa fa-edit""></i> Edit</h4>
                                                </div>
                                                <div class=""modal-body"">
                                                    <input type=""hidden"" class=""form-control"" name=""Id""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4126, "\"", 4142, 1);
#line 79 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Year\Index.cshtml"
WriteAttributeValue("", 4134, year.Id, 4134, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4143, 273, true);
                WriteLiteral(@" />
                                                    <div class=""form-group"">
                                                        <label>Class Name</label>
                                                        <input type=""text"" class=""form-control"" name=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4416, "\"", 4434, 1);
#line 82 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Year\Index.cshtml"
WriteAttributeValue("", 4424, year.Name, 4424, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4435, 606, true);
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
            BeginContext(5048, 197, true);
            WriteLiteral("\r\n                                        </div><!-- /.modal-content -->\r\n                                    </div><!-- /.modal-dialog -->\r\n                                </div><!-- /.modal -->\r\n");
            EndContext();
#line 94 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Year\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(5276, 150, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5443, 1053, true);
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
                              url: ""/Year/RemoveYear/"" + e.target.name,
                              type: ""GET"",
                              success: function (data) {
                                 location.reload(true);
                              }
                          });
                        }
                        else{
                          console.log('Cancle');
                        }
                });");
                WriteLiteral("\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Exam_Management_System.Models.Year>> Html { get; private set; }
    }
}
#pragma warning restore 1591
