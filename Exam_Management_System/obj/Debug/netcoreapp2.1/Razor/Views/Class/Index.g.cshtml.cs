#pragma checksum "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e62d561d1ef072e3c50b79843c191a581bbd2d1d"
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
#line 1 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\_ViewImports.cshtml"
using Exam_Management_System;

#line default
#line hidden
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\_ViewImports.cshtml"
using Exam_Management_System.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e62d561d1ef072e3c50b79843c191a581bbd2d1d", @"/Views/Class/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Class_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Exam_Management_System.Models.Class>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Major", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveMajor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Class", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditClass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
  
    ViewData["Title"] = "Class";

#line default
#line hidden
            BeginContext(101, 990, true);
            WriteLiteral(@"<section class=""content-header bg-gray"" style=""padding-top:10px"">
    <div class=""row"">
        <div class=""col-sm-4"">
            <h2 style="""">
                Class
                <small>Info</small>
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
            BeginContext(1091, 1234, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61b9a894db694fa9b0fa7421bfbb2f96", async() => {
                BeginContext(1097, 438, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label>Class Name</label>
                            <input type=""text"" class=""form-control"" name=""Name"" />
                        </div>
                        <div class=""form-group"">
                            <label>Year</label>
                            <select name=""Year_id"" id=""year"" class=""form-control"">
                                ");
                EndContext();
                BeginContext(1535, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e362e14e4cf1443da54f9e4ebe69627d", async() => {
                    BeginContext(1543, 14, true);
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
                BeginContext(1566, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 41 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                  
                                    var year = ViewBag.year;
                                    foreach (var y in year)
                                    {                                      

#line default
#line hidden
                BeginContext(1804, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(1848, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "291eaf35db4f4e88996c72c23df1e0d9", async() => {
                    BeginContext(1871, 6, false);
#line 45 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                                             Write(y.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 45 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
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
                BeginContext(1886, 41, true);
                WriteLiteral("                                       \r\n");
                EndContext();
#line 46 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"

                                    }
                                

#line default
#line hidden
                BeginContext(2003, 315, true);
                WriteLiteral(@"                            </select>
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
            BeginContext(2325, 643, true);
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
#line 72 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                             foreach (var c in Model)
                            {

#line default
#line hidden
            BeginContext(3054, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(3133, 4, false);
#line 75 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                   Write(c.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3137, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3185, 6, false);
#line 76 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                   Write(c.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3191, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3239, 6, false);
#line 77 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                   Write(c.Year);

#line default
#line hidden
            EndContext();
            BeginContext(3245, 150, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#");
            EndContext();
            BeginContext(3396, 4, false);
#line 79 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                                                                                Write(c.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3400, 74, true);
            WriteLiteral("\"><i class=\"fa fa-edit\"></i></a>\r\n                                        ");
            EndContext();
            BeginContext(3474, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d8d44e232b14f3badc68c072ab1b5d9", async() => {
                BeginContext(3569, 27, true);
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
#line 80 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
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
            BeginContext(3600, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
            BeginContext(3686, 83, true);
            WriteLiteral("                                <div class=\"modal fade\" tabindex=\"-1\" role=\"dialog\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3769, "\"", 3779, 1);
#line 84 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
WriteAttributeValue("", 3774, c.Id, 3774, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3780, 194, true);
            WriteLiteral(">\r\n                                    <div class=\"modal-dialog\" role=\"document\">\r\n                                        <div class=\"modal-content\">\r\n                                          ");
            EndContext();
            BeginContext(3974, 3004, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0b389b4f6ea48aeb11121892caecf34", async() => {
                BeginContext(4040, 579, true);
                WriteLiteral(@"
                                            <div class=""modal-header"">
                                                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                                                <h4 class=""modal-title""><i class=""fa fa-edit""></i> Edit</h4>
                                            </div>
                                            <div class=""modal-body"">
                                                <input type=""hidden"" class=""form-control"" name=""Id""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4619, "\"", 4632, 1);
#line 93 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
WriteAttributeValue("", 4627, c.Id, 4627, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4633, 261, true);
                WriteLiteral(@" />
                                                <div class=""form-group"">
                                                    <label>Class Name</label>
                                                    <input type=""text"" class=""form-control"" name=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4894, "\"", 4909, 1);
#line 96 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
WriteAttributeValue("", 4902, c.Name, 4902, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4910, 372, true);
                WriteLiteral(@" />
                                                </div>
                                                <div class=""form-group"">
                                                    <label>Year</label>
                                                    <select name=""Year_id"" id=""year"" class=""form-control"">
                                                        ");
                EndContext();
                BeginContext(5282, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7133f7a40884767bce71c1164ea9591", async() => {
                    BeginContext(5290, 14, true);
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
                BeginContext(5313, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 102 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                                          
                                                            var year1 = ViewBag.year;
                                                            foreach (var y in year1)
                                                            {
                                                                if (y.Id == c.Year_id)
                                                                {

#line default
#line hidden
                BeginContext(5766, 68, true);
                WriteLiteral("                                                                    ");
                EndContext();
                BeginContext(5834, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc7e69f290ec45f0acaf0f61ca184fd0", async() => {
                    BeginContext(5866, 6, false);
#line 108 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                                                                              Write(y.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 108 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                                                       WriteLiteral(y.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5881, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 109 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                                                }
                                                                else
                                                                {

#line default
#line hidden
                BeginContext(6087, 68, true);
                WriteLiteral("                                                                    ");
                EndContext();
                BeginContext(6155, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b375472eea8c466e910aa99931053074", async() => {
                    BeginContext(6178, 6, false);
#line 112 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                                                                     Write(y.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 112 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
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
                BeginContext(6193, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 113 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                                                                }

                                                            }
                                                        

#line default
#line hidden
                BeginContext(6386, 585, true);
                WriteLiteral(@"                                                    </select>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6978, 197, true);
            WriteLiteral("\r\n                                        </div><!-- /.modal-content -->\r\n                                    </div><!-- /.modal-dialog -->\r\n                                </div><!-- /.modal -->\r\n");
            EndContext();
#line 128 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Class\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(7206, 148, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7371, 942, true);
                WriteLiteral(@" 
<script>
    $(function () {
<<<<<<< HEAD
        console.log(""OK"")
        /*
=======
        //console.log(""OK"")
         $(""#search"").on(""keyup"", function () {
                var value = $(this).val().toLowerCase();
                $(""#myTable tr"").filter(function () {
                    $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
                });
            });
        ///////////////////////////////////////////////
>>>>>>> fbdfd7e4dfb6e8a842ae9b8b815c127f179d4b3d
        $.ajax({
            url: ""/class/getYear"",
            type: ""GET"",
            success: function (data) {
                console.log(data);
                $.each(data, function (i, year) {
                    var str = ' <option value=""' + year.id + '"">' + year.name + '</option>';
                    $('#year').append(str);
                })
            }
        })
        */
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Exam_Management_System.Models.Class>> Html { get; private set; }
    }
}
#pragma warning restore 1591
