#pragma checksum "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2f3199f7d2737571fe250788d3260bff148b127fdefaf3f5c15602efb0b56b72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2f3199f7d2737571fe250788d3260bff148b127fdefaf3f5c15602efb0b56b72", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b082b762a216bfff973b964f5a8b688262dc980e97b9ec47c5e410a5f2c61a8a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<style>
    .product-container {
        display: flex;
        border: 1px solid darkslateblue;
        padding: 10px;
        margin-bottom: 10px;
        border-radius: 5px;
        box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        background-color: #f9f9f9;
    }

    .product-image {
        flex: 0 0 150px;  
        margin-right: 15px;
    }

        .product-image img {
            width: 100%; 
            height: 100%; 
            background-repeat:no-repeat;
            height: auto;
            border-radius: 5px;
        }

    .product-info {
        flex: 1;
    }

        .product-info h4 {
            margin: 5px 0;
        }

    .product-actions {
        margin-top: 10px;
    }

        .product-actions a {
            text-decoration: none;
            color: #007bff;
            margin-right: 10px;
        }

            .product-actions a:hover {
                text-decoration: underline;
            }
</style>

<section>
");
#nullable restore
#line 51 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
     foreach (var i in Model.Products)
    {
        var newPrice = @i.Price - (@i.Price * @i.Discount / 100);
        

#line default
#line hidden
#nullable disable

            WriteLiteral("<section class=\"product-container\">\r\n            <div class=\"product-image\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1257, "\"", 1275, 1);
            WriteAttributeValue("", 1263, 
#nullable restore
#line 56 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                           i.ImagePath

#line default
#line hidden
#nullable disable
            , 1263, 12, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1276, "\"", 1298, 3);
            WriteAttributeValue("", 1282, "Image", 1282, 5, true);
            WriteAttributeValue(" ", 1287, "of", 1288, 3, true);
            WriteAttributeValue(" ", 1290, 
#nullable restore
#line 56 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                                       i.Name

#line default
#line hidden
#nullable disable
            , 1291, 7, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"product-info\">\r\n                <h4>Name: ");
            Write(
#nullable restore
#line 59 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                           i.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n                <h4>Description: ");
            Write(
#nullable restore
#line 60 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                  i.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</h4>\r\n\t\t\t\t<h4>Price: ");
            Write(
#nullable restore
#line 61 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                newPrice.ToString("0.00")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("$</h4>\r\n                <h4>Discount: ");
            Write(
#nullable restore
#line 62 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                               i.Discount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("% <span style=\"text-decoration:line-through;color:red\"> ");
            Write(
#nullable restore
#line 62 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                                                                                  i.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("$ </span></h4>\r\n                <div class=\"product-actions\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f3199f7d2737571fe250788d3260bff148b127fdefaf3f5c15602efb0b56b728350", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 64 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                      i.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f3199f7d2737571fe250788d3260bff148b127fdefaf3f5c15602efb0b56b7210776", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#nullable restore
#line 65 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
                                      i.Id

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
#nullable restore
#line 69 "C:\Users\user\source\repos\WebApplication4\WebApplication4\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
