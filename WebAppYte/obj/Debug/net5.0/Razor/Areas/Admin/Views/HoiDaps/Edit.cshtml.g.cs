#pragma checksum "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "563ecb36c20a6d493b3a2a00a8b19b227a3cf486"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HoiDaps_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/HoiDaps/Edit.cshtml")]
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
#line 5 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
using WebAppYte.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"563ecb36c20a6d493b3a2a00a8b19b227a3cf486", @"/Areas/Admin/Views/HoiDaps/Edit.cshtml")]
    public class Areas_Admin_Views_HoiDaps_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppYte.Models.HoiDap>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
   ViewBag.Title = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAd.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 11 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
  
    var httpContext = HttpContextAccessor.HttpContext;
    var uJson = httpContext.Session.GetString("userAdmin");
    var u = !string.IsNullOrEmpty(uJson) ? JsonSerializer.Deserialize<NguoiDung>(uJson) : null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Chỉnh sửa</h2>\n\n");
#nullable restore
#line 19 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\n\n    <hr />\n    ");
#nullable restore
#line 26 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    ");
#nullable restore
#line 27 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
Write(Html.HiddenFor(model => model.Ma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 30 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
   Write(Html.LabelFor(model => model.Hoi, "Hỏi", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 32 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
       Write(Html.EditorFor(model => model.Hoi, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 33 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Hoi, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 38 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
   Write(Html.LabelFor(model => model.Dap, "Trả lời", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 40 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
       Write(Html.EditorFor(model => model.Dap, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 41 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Dap, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 46 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
   Write(Html.LabelFor(model => model.Mabn, "Người hỏi", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 48 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
       Write(Html.DropDownList("mabn", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 49 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Mabn, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 54 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
   Write(Html.LabelFor(model => model.Mand, "Người trả lời", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 56 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
       Write(Html.DropDownList("mand", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 57 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Mand, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 62 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
   Write(Html.LabelFor(model => model.Ngayhoi, "Ngày hỏi", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            <input class=\"form-control text-box single-line\" data-val=\"true\" data-val-date=\"The field Bắt đầu must be a date.\" id=\"ngayhoi\" name=\"ngayhoi\" type=\"date\"");
            BeginWriteAttribute("value", " value=\"", 2635, "\"", 2656, 1);
#nullable restore
#line 64 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
WriteAttributeValue("", 2643, ViewBag.ngay, 2643, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n            <span class=\"field-validation-valid text-danger\" data-valmsg-for=\"ngayhoi\" data-valmsg-replace=\"true\"></span>\n        </div>\n        ");
#nullable restore
#line 67 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Ngayhoi, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n\n    \n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            <input type=\"submit\" value=\"Lưu\" class=\"btn btn-default\" />\n        </div>\n    </div>\n</div>");
#nullable restore
#line 76 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    ");
#nullable restore
#line 79 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Edit.cshtml"
Write(Html.ActionLink("Quay lại", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppYte.Models.HoiDap> Html { get; private set; }
    }
}
#pragma warning restore 1591
