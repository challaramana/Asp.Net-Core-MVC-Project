#pragma checksum "C:\Users\ravgoud\Pictures\MyProjects\NeoSoft_Tarun_Bommadevara.Web\Views\Employee\ViewRecords.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "714dbe78e4cc3b021ea0c5af84b431b5807b1c8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ViewRecords), @"mvc.1.0.view", @"/Views/Employee/ViewRecords.cshtml")]
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
#line 1 "C:\Users\ravgoud\Pictures\MyProjects\NeoSoft_Tarun_Bommadevara.Web\Views\_ViewImports.cshtml"
using NeoSoft_Tarun_Bommadevara.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ravgoud\Pictures\MyProjects\NeoSoft_Tarun_Bommadevara.Web\Views\_ViewImports.cshtml"
using NeoSoft_Tarun_Bommadevara.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"714dbe78e4cc3b021ea0c5af84b431b5807b1c8d", @"/Views/Employee/ViewRecords.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f05981c58ebf589a2ba96a0953d7f1c7bf0cb2f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ViewRecords : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NeoSoft_Tarun_Bommadevara.Web.ViewModels.EmployeeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\ravgoud\Pictures\MyProjects\NeoSoft_Tarun_Bommadevara.Web\Views\Employee\ViewRecords.cshtml"
  
    ViewData["Title"] = "View Records";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mb-2\"><small>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "714dbe78e4cc3b021ea0c5af84b431b5807b1c8d3797", async() => {
                WriteLiteral("Add/Update Employee");
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
            WriteLiteral("</small></div>\r\n");
#nullable restore
#line 6 "C:\Users\ravgoud\Pictures\MyProjects\NeoSoft_Tarun_Bommadevara.Web\Views\Employee\ViewRecords.cshtml"
  
    if (Model.Employees.Count() != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""overflow-auto"" >
            <table id=""snv-main-table"" class=""table table-bordered table-responsive-sm"" style=""overflow-x:hidden"">
                <thead>
                    <tr class=""table-secondary"">
                        <th scope=""col"">
                            Email
                        </th>
                        <th scope=""col"">
                            Country
                        </th>
                        <th scope=""col"">
                            State
                        </th>
                        <th scope=""col"">
                            City
                        </th>
                        <th scope=""col"">
                            Pan No
                        </th>
                        <th scope=""col"">
                            Passport No
                        </th>
                        <th scope=""col"">
                            Gender
                        </th>
                        <th sc");
            WriteLiteral(@"ope=""col"">
                            Isactive
                        </th>
                        <th scope=""col"">
                            Profile Image
                        </th>
                        <th scope=""col"">
                            Action
                        </th>
                    </tr>
                </thead>
");
#nullable restore
#line 45 "C:\Users\ravgoud\Pictures\MyProjects\NeoSoft_Tarun_Bommadevara.Web\Views\Employee\ViewRecords.cshtml"
              Write(await Html.PartialAsync("Partial/_userTablePartial", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n");
#nullable restore
#line 48 "C:\Users\ravgoud\Pictures\MyProjects\NeoSoft_Tarun_Bommadevara.Web\Views\Employee\ViewRecords.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"no-records-display\">\r\n            No users available.\r\n        </div>\r\n");
#nullable restore
#line 54 "C:\Users\ravgoud\Pictures\MyProjects\NeoSoft_Tarun_Bommadevara.Web\Views\Employee\ViewRecords.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NeoSoft_Tarun_Bommadevara.Web.ViewModels.EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
