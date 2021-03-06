#pragma checksum "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e89badb84af519dfff14d8260f69507bf8365303"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebManager.Pages.Shared.Components.Paging.Pages_Shared_Components_Paging_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/Paging/Default.cshtml")]
namespace WebManager.Pages.Shared.Components.Paging
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
#line 1 "D:\C#\Manager\webmanager\Pages\_ViewImports.cshtml"
using WebManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
using WebManager.Models.Paging;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e89badb84af519dfff14d8260f69507bf8365303", @"/Pages/Shared/Components/Paging/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"364d88f99cb708bb62d27142d0a956c36f99499a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_Paging_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
  
    int currentPage = Model.CurrentPages;
    int countPages = Model.CountPages;
    var generateUrl = Model.GenerateUrl;

    if (currentPage > countPages)
        currentPage = countPages;

    if (countPages <= 1) return;


    int? preview = null;
    int? next = null;

    if (currentPage > 1)
        preview = currentPage - 1;

    if (currentPage < countPages)
        next = currentPage + 1;

    // C??c trang hi???n th??? trong ??i???u h?????ng
    List<int> pagesRanges = new List<int>();


    int delta = 5;             // S??? trang m??? r???ng v??? m???i b??n trang hi???n t???i
    int remain = delta * 2;     // S??? trang hai b??n trang hi???n t???i

    pagesRanges.Add(currentPage);
    // C??c trang ph??t tri???n v??? hai b??n trang hi???n t???i
    for (int i = 1; i <= delta; i++)
    {
        if (currentPage + i <= countPages)
        {
            pagesRanges.Add(currentPage + i);
            remain--;
        }

        if (currentPage - i >= 1)
        {
            pagesRanges.Insert(0, currentPage - i);
            remain--;
        }

    }
    // X??? l?? th??m v??o c??c trang cho ????? remain
    //(x???y ra ??? ?????u m??t c???a kho???ng trang kh??ng ????? trang ch??n  v??o)
    if (remain > 0)
    {
        if (pagesRanges[0] == 1)
        {
            for (int i = 1; i <= remain; i++)
            {
                if (pagesRanges.Last() + 1 <= countPages)
                {
                    pagesRanges.Add(pagesRanges.Last() + 1);
                }
            }
        }
        else
        {
            for (int i = 1; i <= remain; i++)
            {
                if (pagesRanges.First() - 1 > 1)
                {
                    pagesRanges.Insert(0, pagesRanges.First() - 1);
                }
            }
        }
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<ul class=\"pagination\">\r\n    <!-- Previous page link -->\r\n");
#nullable restore
#line 87 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
     if (preview != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2234, "\"", 2262, 1);
#nullable restore
#line 90 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
WriteAttributeValue("", 2241, generateUrl(preview), 2241, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang tr?????c</a>\r\n        </li>\r\n");
#nullable restore
#line 92 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item disabled\">\r\n            <a class=\"page-link\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\">Trang tr?????c</a>\r\n        </li>\r\n");
#nullable restore
#line 98 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <!-- Numbered page links -->\r\n");
#nullable restore
#line 101 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
     foreach (var pageitem in pagesRanges)
    {
        if (pageitem != currentPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2685, "\"", 2714, 1);
#nullable restore
#line 106 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
WriteAttributeValue("", 2692, generateUrl(pageitem), 2692, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 107 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
               Write(pageitem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 110 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\" aria-current=\"page\">\r\n                <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 114 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
                                         Write(pageitem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n            </li>\r\n");
#nullable restore
#line 116 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <!-- Next page link -->\r\n");
#nullable restore
#line 121 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
     if (next != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\r\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3154, "\"", 3179, 1);
#nullable restore
#line 124 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
WriteAttributeValue("", 3161, generateUrl(next), 3161, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang sau</a>\r\n        </li>\r\n");
#nullable restore
#line 126 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item disabled\">\r\n            <a class=\"page-link\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\">Trang sau</a>\r\n        </li>\r\n");
#nullable restore
#line 132 "D:\C#\Manager\webmanager\Pages\Shared\Components\Paging\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
