#pragma checksum "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f88d9455d67ccab2aa19f6b4dacecc49c51840e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompanySetup_Details), @"mvc.1.0.view", @"/Views/CompanySetup/Details.cshtml")]
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
#line 1 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\_ViewImports.cshtml"
using HRMSProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\_ViewImports.cshtml"
using HRMSProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f88d9455d67ccab2aa19f6b4dacecc49c51840e9", @"/Views/CompanySetup/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"268a04eeac5b7d34aa503f5264f40d6e5b1629ee", @"/Views/_ViewImports.cshtml")]
    public class Views_CompanySetup_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HRMSProject.Models.VmCompnaySetup>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n<h1>Details Compnay Setup</h1>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RegistrationNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayFor(model => model.RegistrationNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 60 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 63 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n</div>\r\n    ");
#nullable restore
#line 69 "C:\Users\User\Desktop\HRMSProject\HRMSProject\HRMSProject\HRMSProject\Views\CompanySetup\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f88d9455d67ccab2aa19f6b4dacecc49c51840e910457", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HRMSProject.Models.VmCompnaySetup> Html { get; private set; }
    }
}
#pragma warning restore 1591
