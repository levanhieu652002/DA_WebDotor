#pragma checksum "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "889fbcf7ec2318d84781341ba432c807af6cdc0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bacsi_Details), @"mvc.1.0.view", @"/Views/Bacsi/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"889fbcf7ec2318d84781341ba432c807af6cdc0c", @"/Views/Bacsi/Details.cshtml")]
    public class Views_Bacsi_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppYte.Models.NguoiDung>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgavt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("170"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("170"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
   ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""nivoslider"" class=""slides nivoSlider"">

    <div class=""nivo-directionNav""><a class=""nivo-prevNav"">Prev</a><a class=""nivo-nextNav"">Next</a></div>
    <div class=""nivo-slice"" name=""0"" style=""left: 0px; width: 1530px; height: 160px; opacity: 1; overflow: hidden;"">
        <div class=""col-sm-12"" style=""position:absolute; width:1519px; height:auto; display:block !important; top:180px; left:200px;"">
            <nav aria-label=""breadcrumbs"" class=""rank-math-breadcrumb""><p><a href=""/Home/Index"">TRANG CHỦ</a><span class=""separator""> &gt; </span><span class=""last"">HỒ SƠ CÁ NHÂN</span></p></nav>
        </div>

    </div>
</div>
<div class=""text-center"">
    <h1 class=""div_head text-center cl_head text-uppercase font_hel sz_24 mb_15  pb_15"">
        HỒ SƠ CÁ NHÂN
    </h1>
</div>


<div");
            BeginWriteAttribute("class", " class=\"", 911, "\"", 919, 0);
            EndWriteAttribute();
            WriteLiteral(">\n    <div class=\"col-md-6\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "889fbcf7ec2318d84781341ba432c807af6cdc0c4851", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 982, "~/images/images/", 982, 16, true);
#nullable restore
#line 25 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
AddHtmlAttributeValue("", 998, Model.Anh, 998, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        &nbsp;\n        <div class=\"divInfo\">\n            Họ tên : <b> ");
#nullable restore
#line 28 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
                    Write(Html.DisplayFor(model => model.Hoten));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n            <br />\n            Giới tính :  ");
#nullable restore
#line 30 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
                    Write(Html.DisplayFor(model => model.Gioitinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            <br />\n            Ngày sinh :  ");
#nullable restore
#line 33 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
                    Write(Model.Ngaysinh.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            <br />\n            <button class=\"btn-warning\">\n                ");
#nullable restore
#line 37 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
           Write(Html.ActionLink("Cập nhật", "Edit", new { id = Model.Mand }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </button>\n            <button class=\"btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1527, "\"", 1559, 3);
            WriteAttributeValue("", 1537, "phongKham(", 1537, 10, true);
#nullable restore
#line 39 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
WriteAttributeValue("", 1547, Model.Mand, 1547, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1558, ")", 1558, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                Phòng khám
            </button>
            <script>
                function phongKham(id) {
                    window.location.href = '/Bacsi/DiaChiKham?bsId=' + id;
                }


            </script>
        </div>
        <br />
        <br />
        <br />
    </div>
   
    <div class=""col-md-6"">
        <div class=""divInfo"">
            <br />
            Chức vụ :  ");
#nullable restore
#line 58 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
                  Write(Html.DisplayFor(model => model.Chucvu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n\n            Học hàm :  ");
#nullable restore
#line 61 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
                  Write(Html.DisplayFor(model => model.Hocham));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            Học vị :  ");
#nullable restore
#line 63 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
                 Write(Html.DisplayFor(model => model.Hocvi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            <span class=\"material-icons\">wifi_calling</span> &nbsp; Số điện thoại :  ");
#nullable restore
#line 65 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
                                                                                Write(Html.DisplayFor(model => model.Sdt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            <span class=\"material-icons\">\n                email\n            </span> &nbsp; Email :  ");
#nullable restore
#line 69 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            <span class=\"material-icons\">\n                home\n            </span> &nbsp;\n            Địa chỉ : ");
#nullable restore
#line 74 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
                 Write(Html.DisplayFor(model => model.Diachi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n            <br />\n            Tài khoản: ");
#nullable restore
#line 77 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
                  Write(Html.DisplayFor(model => model.Tendn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            Mật khẩu : ");
#nullable restore
#line 79 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Details.cshtml"
                  Write(Html.DisplayFor(model => model.Mk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n\n        </div>\n\n    </div>\n\n</div>\n<br />\n<br />\n<br />\n<br />\n\n<center>\n\n  \n</center>\n<br />\n<br />\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppYte.Models.NguoiDung> Html { get; private set; }
    }
}
#pragma warning restore 1591