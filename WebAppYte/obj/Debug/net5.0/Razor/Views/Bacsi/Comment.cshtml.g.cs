#pragma checksum "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Comment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e039a3c79071b783de403b8f2b706ab213426f81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bacsi_Comment), @"mvc.1.0.view", @"/Views/Bacsi/Comment.cshtml")]
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
#line 2 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Comment.cshtml"
using WebAppYte.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e039a3c79071b783de403b8f2b706ab213426f81", @"/Views/Bacsi/Comment.cshtml")]
    public class Views_Bacsi_Comment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DanhGia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3> Đánh giá </h3>\n\n<hr />\n\n<div");
            BeginWriteAttribute("class", " class=\"", 79, "\"", 87, 0);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 8 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Comment.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <i>Người gửi : <b>");
#nullable restore
#line 10 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Comment.cshtml"
                     Write(item.MabnNavigation.Tenbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> &nbsp; <i class=\"fas fa-clock\"></i>&nbsp;");
#nullable restore
#line 10 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Comment.cshtml"
                                                                                             Write(item.Ngay.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\n");
            WriteLiteral("                <h5 class=\"text-primary\">  ");
#nullable restore
#line 12 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Comment.cshtml"
                                      Write(Html.Raw(item.Noidung));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n");
            WriteLiteral("                                <hr />");
#nullable restore
#line 14 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Comment.cshtml"
                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n\n</div>\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DanhGia>> Html { get; private set; }
    }
}
#pragma warning restore 1591