#pragma checksum "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded6e19ff201dae1dd1f1dffec2206b82c6fc70f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BenhAns_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/BenhAns/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded6e19ff201dae1dd1f1dffec2206b82c6fc70f", @"/Areas/Admin/Views/BenhAns/Delete.cshtml")]
    public class Areas_Admin_Views_BenhAns_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppYte.Models.BenhNhan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
   ViewBag.Title = "Delete";
                Layout = "~/Areas/Admin/Views/Shared/_LayoutAd.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Bạn thực sự muoosb xóa?</h2>\n\n");
#nullable restore
#line 8 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-horizontal\">\n\n                    <hr />\n                    ");
#nullable restore
#line 15 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 16 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
               Write(Html.HiddenFor(model => model.Mabn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                    <div class=\"form-group\" readonly>\n                        ");
#nullable restore
#line 19 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                   Write(Html.LabelFor(model => model.Tenbn, "Họ tên", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 21 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.EditorFor(model => model.Tenbn, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 22 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Tenbn, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n\n\n                    <div class=\"form-group\"readonly>\n                        ");
#nullable restore
#line 29 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                   Write(Html.LabelFor(model => model.Sdt, "SDT", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 31 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.EditorFor(model => model.Sdt, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 32 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Sdt, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\"readonly>\n                        ");
#nullable restore
#line 37 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                   Write(Html.LabelFor(model => model.Email, "Email", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 39 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 40 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\"readonly>\n                        ");
#nullable restore
#line 45 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                   Write(Html.LabelFor(model => model.Diachi, "Địa chỉ", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 47 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.EditorFor(model => model.Diachi, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 48 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Diachi, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\"readonly>\n                        ");
#nullable restore
#line 53 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                   Write(Html.LabelFor(model => model.Ngaysinh, "Ngày sinh", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            <input class=\"form-control text-box single-line\" data-val=\"true\" data-val-date=\"The field Bắt đầu must be a date.\" id=\"ngaysinh\" name=\"ngaysinh\" type=\"date\"");
            BeginWriteAttribute("value", " value=\"", 2970, "\"", 2991, 1);
#nullable restore
#line 55 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
WriteAttributeValue("", 2978, ViewBag.ngay, 2978, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n                            <span class=\"field-validation-valid text-danger\" data-valmsg-for=\"ngaysinh\" data-valmsg-replace=\"true\"></span>\n                        </div>\n                        ");
#nullable restore
#line 58 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Ngaysinh, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n\n                    <div class=\"form-group\"readonly>\n                        ");
#nullable restore
#line 62 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                   Write(Html.LabelFor(model => model.Gioitinh, "Giới tính", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""col-md-10"">
                            <select class=""form-control"" id=""gioitinh"" name=""gioitinh"">

                                <option>Nam</option>
                                <option>Nữ</option>
                            </select>
                            ");
#nullable restore
#line 69 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Gioitinh, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                        </div>\n                    </div>\n\n\n                    <div class=\"form-group\"readonly>\n                        ");
#nullable restore
#line 76 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                   Write(Html.LabelFor(model => model.Tendn, "Tên đăng nhập", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 78 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.EditorFor(model => model.Tendn, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 79 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Tendn, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                    </div>\n\n                    <div class=\"form-group\"readonly>\n                        ");
#nullable restore
#line 84 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                   Write(Html.LabelFor(model => model.Mk, "Mật khẩu", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"col-md-10\">\n                            ");
#nullable restore
#line 86 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.EditorFor(model => model.Mk, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            ");
#nullable restore
#line 87 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Mk, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>



                    <div class=""form-group"">
                        <div class=""col-md-offset-2 col-md-10"">
                            <input type=""submit"" value=""Delete"" class=""btn btn-default"" />
                        </div>
                    </div>
                </div>");
#nullable restore
#line 98 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    ");
#nullable restore
#line 101 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppYte.Models.BenhNhan> Html { get; private set; }
    }
}
#pragma warning restore 1591
