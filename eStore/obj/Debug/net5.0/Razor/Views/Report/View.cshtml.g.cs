#pragma checksum "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f1308bb191109b257d1a4b3006bff91f3989cae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_View), @"mvc.1.0.view", @"/Views/Report/View.cshtml")]
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
#line 1 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\_ViewImports.cshtml"
using eStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\_ViewImports.cshtml"
using eStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f1308bb191109b257d1a4b3006bff91f3989cae", @"/Views/Report/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a7cd37460f953b9787e736e6c4fe42df2fc1ad", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Report_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BussinessObject.Models.Order>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Report", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
  
    ViewData["Title"] = "View";
    if (ViewBag.Role == "admin")
    {
        Layout = "~/Views/Shared/_Layout.cshtml";
    }
    else
    {
        Layout = "~/Views/Shared/LayoutUser.cshtml";
    }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Report</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f1308bb191109b257d1a4b3006bff91f3989cae4847", async() => {
                WriteLiteral("\r\n    <div>\r\n        <input type=\"date\" name=\"start\" pattern=\'dd/MM/yyyy\'");
                BeginWriteAttribute("value", "  value=\"", 391, "\"", 418, 1);
#nullable restore
#line 19 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
WriteAttributeValue("", 400, ViewData["start"], 400, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <div>\r\n        <input type=\"date\" name=\"end\" pattern=\'dd/MM/yyyy\'");
                BeginWriteAttribute("value", " value=\"", 504, "\"", 528, 1);
#nullable restore
#line 22 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
WriteAttributeValue("", 512, ViewData["end"], 512, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    </div>\r\n    <div>\r\n        <input type=\"submit\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
 if(Model != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
           Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
           Write(Html.DisplayNameFor(model => model.RequiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
           Write(Html.DisplayNameFor(model => model.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
           Write(Html.DisplayNameFor(model => model.Freight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Email Member\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
               Write(Html.DisplayFor(modelItem => item.RequiredDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
               Write(Html.DisplayFor(modelItem => item.ShippedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
               Write(Html.DisplayFor(modelItem => item.Freight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
               Write(Html.DisplayFor(modelItem => item.Member.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f1308bb191109b257d1a4b3006bff91f3989cae11232", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
                                                                      WriteLiteral(item.OrderId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
                                                                                                    WriteLiteral(ViewData["end"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["end"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-end", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["end"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 70 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
                                                                                                                                       WriteLiteral(ViewData["start"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["start"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-start", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["start"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 73 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 76 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>Total: ");
#nullable restore
#line 79 "C:\Users\ntrun\Desktop\Ass3Solution_SE151323\Ass03Solution_SE151323\eStore\Views\Report\View.cshtml"
          Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BussinessObject.Models.Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
