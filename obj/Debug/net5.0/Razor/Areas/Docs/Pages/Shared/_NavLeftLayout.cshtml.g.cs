#pragma checksum "D:\C#\Manager\webmanager\Areas\Docs\Pages\Shared\_NavLeftLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49d8a98a425cb95d4ab181cf1dbb17f8b3d3d2cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebManager.Areas.Docs.Pages.Shared.Areas_Docs_Pages_Shared__NavLeftLayout), @"mvc.1.0.view", @"/Areas/Docs/Pages/Shared/_NavLeftLayout.cshtml")]
namespace WebManager.Areas.Docs.Pages.Shared
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
#line 1 "D:\C#\Manager\webmanager\Areas\Docs\Pages\_ViewImports.cshtml"
using WebManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\C#\Manager\webmanager\Areas\Docs\Pages\Shared\_NavLeftLayout.cshtml"
using WebManager.Pages.Shared.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49d8a98a425cb95d4ab181cf1dbb17f8b3d3d2cd", @"/Areas/Docs/Pages/Shared/_NavLeftLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"781b4d2c6daa9c293bc69da388c7e51e388d5104", @"/Areas/Docs/Pages/_ViewImports.cshtml")]
    public class Areas_Docs_Pages_Shared__NavLeftLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#\Manager\webmanager\Areas\Docs\Pages\Shared\_NavLeftLayout.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        <div class=\"container mt-2\">\r\n            ");
#nullable restore
#line 9 "D:\C#\Manager\webmanager\Areas\Docs\Pages\Shared\_NavLeftLayout.cshtml"
       Write(await Component.InvokeAsync("NavbarLeft"));

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        </div>\r\n    </div>\r\n    <div class=\"col-sm-9\">\r\n        <div class=\"container mt-3\">\r\n            ");
#nullable restore
#line 14 "D:\C#\Manager\webmanager\Areas\Docs\Pages\Shared\_NavLeftLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 19 "D:\C#\Manager\webmanager\Areas\Docs\Pages\Shared\_NavLeftLayout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
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
