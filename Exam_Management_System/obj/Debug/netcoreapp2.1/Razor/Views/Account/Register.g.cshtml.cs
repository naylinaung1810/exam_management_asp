#pragma checksum "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a53188af02af99ebc9216a38da9713699bf36e94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a53188af02af99ebc9216a38da9713699bf36e94", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630148b7f4f526813eb935eda4f23e42677916dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\LENOVO\source\repos\Exam_Management_System\Exam_Management_System\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(46, 1233, true);
            WriteLiteral(@"
<section class=""content-header bg-gray-active"" style=""padding-bottom:5px;margin-top:-10px"">
    <div class=""row"">
        <div class=""col-sm-6"">
            <h2 style=""font-size:25px"">
                <i class=""fa fa-sign-in text-primary""></i>
              Register
                
            </h2>
        </div>
        <div class=""col-sm-6"">
            <div class=""row"" style=""padding-top:15px;padding-bottom:5px"">
                <div class=""col-md-8 "">
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
<div id=""alert""></div>
<section class=""content container-fluid bg-info"">
    <div class=""row"">
        <div class=""col-md-6 col-md-offset-3"">
        ");
            WriteLiteral("    <div class=\"box\" style=\"\">\r\n                <div class=\"box-header\">\r\n                    <h3>Register</h3>\r\n                </div>\r\n            </div>\r\n            <div class=\"box-body\">\r\n                ");
            EndContext();
            BeginContext(1279, 1045, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "633410cb8f5b466fbca4b32271f33700", async() => {
                BeginContext(1285, 1032, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label>Username</label>
                        <input type=""text"" name=""User_name"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label>Email</label>
                        <input type=""email"" name=""Email"" class=""form-control"" />
                    </div>
                    <div class=""form-group"">
                        <label>Password</label>
                        <input type=""password"" name=""Password"" class=""form-control"" id=""password"" />
                    </div>
                    <div class=""form-group"">
                        <label>Confirm Password</label>
                        <input type=""password"" class=""form-control"" id=""con_pass"" />
                    </div>
                    <div class=""form-group"">
                        <button type=""submit"" class=""btn btn-success"">Sign up</button>
                    </div>
        ");
                WriteLiteral("        ");
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
            BeginContext(2324, 92, true);
            WriteLiteral("\r\n              \r\n            </div>\r\n          \r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2433, 958, true);
                WriteLiteral(@"
    <script>
        $(function () {
            $('form').submit(function () {
                if ($('#password').val() == $('#con_pass').val()) {
                    $.ajax({
                        url: ""/Account/Signup"",
                        type: ""POST"",
                        data: $('form').serialize(),
                        success: function (data) {
                            var str = ' <div class=""alert alert-success navbar-fixed-bottom text-center"" style=""padding:25px"" role=""alert"">' +
                                '<strong><i class=""fa fa-check-circle""></i> Successfully!</strong> Mark addition is successfully finished.' +
                                '</div>';
                        }
                    });
                    $('#alert').html(str);
                }
            });
             setTimeout(function () { $("".alert"").alert('close') }, 3000);
           
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
