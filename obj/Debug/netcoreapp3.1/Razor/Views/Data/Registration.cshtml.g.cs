#pragma checksum "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24ec7eff68d51fa18b1930098a0f025b168c95e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_Registration), @"mvc.1.0.view", @"/Views/Data/Registration.cshtml")]
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
#nullable restore
#line 1 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24ec7eff68d51fa18b1930098a0f025b168c95e8", @"/Views/Data/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Data_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Registration>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/Registration.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>  \r\n    .field-validation-error {  \r\n        color: red;  \r\n    }  \r\n  \r\n    .validation-summary-errors {  \r\n        font-weight: bold;  \r\n        color: red;  \r\n    }  \r\n</style> \r\n\r\n");
#nullable restore
#line 14 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
 using (Html.BeginForm("Registration", "Home", FormMethod.Post, new {id="ValidateUser();"}))  
{  

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
Write(Html.ValidationSummary(false));

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">  \r\n   <label for=\"First Name\" class=\"col-md-3 control-label\">First Name</label>  \r\n    <div class=\"col-md-9\">  \r\n      ");
#nullable restore
#line 20 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
 Write(Html.TextBoxFor(x => x.FirstName, "", new { @class = "form-control", placeholder = "FirstName" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n    ");
#nullable restore
#line 21 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
Write(Html.ValidationMessageFor(x => x.FirstName,"Please enter First Name", new { @class = "text-danger", style="display:none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n  </div>   \r\n</div>  \r\n<br />  \r\n<div class=\"form-group\">  \r\n   <label for=\"firstname\" class=\"col-md-3 control-label\">Last Name</label>  \r\n<div class=\"col-md-9\">  \r\n   ");
#nullable restore
#line 28 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
Write(Html.TextBoxFor(x => x.LastName, "", new { @class = "form-control", placeholder = "Last Name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n   ");
#nullable restore
#line 29 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
Write(Html.ValidationMessageFor(x => x.LastName,"Please enter Last Name", new { @class = "text-danger", style = "display:none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n</div>  \r\n</div>  \r\n<br />  \r\n<div class=\"form-group\">  \r\n   <label for=\"lastname\" class=\"col-md-3 control-label\">Email</label>  \r\n<div class=\"col-md-9\">  \r\n   ");
#nullable restore
#line 36 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
Write(Html.TextBoxFor(x => x.Email, "", new { @class = "form-control", placeholder = "Email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n   ");
#nullable restore
#line 37 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
Write(Html.ValidationMessageFor(x => x.Email,"Please enter Email", new { @class ="text-danger",style = "display:none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n   </div>  \r\n</div>  \r\n<br />  \r\n<div class=\"form-group\">  \r\n   <label for=\"password\" class=\"col-md-3 control-label\">Password</label>  \r\n<div class=\"col-md-9\">  \r\n   ");
#nullable restore
#line 44 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
Write(Html.PasswordFor(x => x.Password, new { @class = "form-control", placeholder = "Password", onblur = "PasswordStrength();" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n   ");
#nullable restore
#line 45 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
Write(Html.ValidationMessageFor(x => x.Password,"Please enter Password", new { @class = "text-danger", style ="display:none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n</div>  \r\n</div>  \r\n<br />  \r\n<div class=\"form-group\">  \r\n   <label for=\"contact\" class=\"col-md-3 control-label\">Contact</label>  \r\n<div class=\"col-md-9\">  \r\n   ");
#nullable restore
#line 52 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
Write(Html.TextBoxFor(x => x.Contact, new { @class = "form-control", placeholder = "Password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n   ");
#nullable restore
#line 53 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
Write(Html.ValidationMessageFor(x => x.Contact,"Please enter Contact", new { @class = "text-danger", style = "display:none" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n</div>  \r\n</div>  \r\n<div class=\"form-group\">  \r\n   <span id=\"spnMessage\" class=\"text-danger\">");
#nullable restore
#line 57 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
                                        Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>  
   <br />  
<!-- Button -->  
<div class=""col-md-offset-3 col-md-9"">  
   <button id=""btn-signup"" type=""button"" onclick= ""ValidateUser();"" class=""btn btn-info""><i class=""icon-hand-right""></i> Sign Up</button>  
   <span style=""margin-left:8px;""></span>  
</div>  
</div>  
");
#nullable restore
#line 65 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
}  

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24ec7eff68d51fa18b1930098a0f025b168c95e89267", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 68 "C:\Users\harsh jangid\Desktop\pract\WebApplication1\Views\Data\Registration.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Registration> Html { get; private set; }
    }
}
#pragma warning restore 1591
