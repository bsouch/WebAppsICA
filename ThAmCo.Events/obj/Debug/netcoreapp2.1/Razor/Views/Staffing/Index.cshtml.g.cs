#pragma checksum "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Staffing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b65de77ab05fe7fad83f3c56ddddd34d8990eddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffing_Index), @"mvc.1.0.view", @"/Views/Staffing/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Staffing/Index.cshtml", typeof(AspNetCore.Views_Staffing_Index))]
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
#line 1 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\_ViewImports.cshtml"
using ThAmCo.Events;

#line default
#line hidden
#line 2 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\_ViewImports.cshtml"
using ThAmCo.Events.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b65de77ab05fe7fad83f3c56ddddd34d8990eddc", @"/Views/Staffing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"003e11b98f4e83258e7425222a5fc2043b9ee1d9", @"/Views/_ViewImports.cshtml")]
    public class Views_Staffing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ThAmCo.Events.Data.Staffing>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Staffing\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(121, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4315bf1f71f4797ae4205c5b909c54d", async() => {
                BeginContext(144, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(158, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(251, 41, false);
#line 16 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Staffing\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Event));

#line default
#line hidden
            EndContext();
            BeginContext(292, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(348, 41, false);
#line 19 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Staffing\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Staff));

#line default
#line hidden
            EndContext();
            BeginContext(389, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Staffing\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(507, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(556, 46, false);
#line 28 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Staffing\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Event.Title));

#line default
#line hidden
            EndContext();
            BeginContext(602, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(658, 51, false);
#line 31 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Staffing\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Staff.StaffEmail));

#line default
#line hidden
            EndContext();
            BeginContext(709, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(765, 77, false);
#line 34 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Staffing\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item.StaffID, id1 = item.EventID }));

#line default
#line hidden
            EndContext();
            BeginContext(842, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(863, 64, false);
#line 35 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Staffing\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id=item.StaffID  }));

#line default
#line hidden
            EndContext();
            BeginContext(927, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(948, 86, false);
#line 36 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Staffing\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new {  id=item.StaffID, eventId = item.EventID  }));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "C:\Users\Souchys\Desktop\Uni\Year 2\Web Apps and Services\WebAppsICA\ThAmCo.Events\Views\Staffing\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1073, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ThAmCo.Events.Data.Staffing>> Html { get; private set; }
    }
}
#pragma warning restore 1591