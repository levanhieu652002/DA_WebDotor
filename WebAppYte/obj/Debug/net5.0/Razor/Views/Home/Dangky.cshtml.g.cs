#pragma checksum "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0236bd84d945bf5420ad18608a078b84e0fa47c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dangky), @"mvc.1.0.view", @"/Views/Home/Dangky.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0236bd84d945bf5420ad18608a078b84e0fa47c", @"/Views/Home/Dangky.cshtml")]
    public class Views_Home_Dangky : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppYte.Models.BenhNhan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
   ViewBag.Title = "Dangky";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-md-12"">

    <div id=""nivoslider"" class=""slides nivoSlider"">

        <div class=""nivo-directionNav""><a class=""nivo-prevNav"">Prev</a><a class=""nivo-nextNav"">Next</a></div>
        <div class=""nivo-slice"" name=""0"" style=""left: 0px; width: 1530px; height: 160px; opacity: 1; overflow: hidden;"">
            <div class=""col-sm-12"" style=""position:absolute; width:1519px; height:auto; display:block !important; top:130px; left:0px;"">
                <nav aria-label=""breadcrumbs"" class=""rank-math-breadcrumb""><p><a href=""/Home/Index"">TRANG CHỦ</a><span class=""separator""> &gt; </span><span class=""last"">ĐĂNG KÝ</span></p></nav>
            </div>

        </div>
    </div>
    <hr />

");
#nullable restore
#line 22 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""form-horizontal"">
                <div class=""text-center"">
                    <h1 class=""div_head text-center cl_head text-uppercase font_hel sz_24 mb_15  pb_15"">
                        Đăng ký
                    </h1>
                    <h3 style=""color:red;"">");
#nullable restore
#line 31 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                                      Write(ViewBag.loi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                </div>\n                <center>\n                    <div");
            BeginWriteAttribute("class", " class=\"", 1264, "\"", 1272, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                        ");
#nullable restore
#line 35 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <div class=\"form-group\">\n\n                            ");
#nullable restore
#line 38 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                       Write(Html.LabelFor(model => model.Tenbn, "Họ tên", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
#nullable restore
#line 40 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.EditorFor(model => model.Tenbn, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 41 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Tenbn, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 45 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                       Write(Html.LabelFor(model => model.Sdt, "Số điện thoại", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
#nullable restore
#line 47 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.EditorFor(model => model.Sdt, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 48 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Sdt, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 53 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                       Write(Html.LabelFor(model => model.Email, "Email", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
#nullable restore
#line 55 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 56 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n\n\n\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 63 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                       Write(Html.LabelFor(model => model.Diachi, "Địa chỉ", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
#nullable restore
#line 65 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.EditorFor(model => model.Diachi, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 66 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Diachi, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 70 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                       Write(Html.LabelFor(model => model.Ngaysinh, "Ngày sinh", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <div class=""col-md-10"">
                                <input class=""form-control text-box single-line"" data-val=""true"" data-val-date=""The field Bắt đầu must be a date."" id=""ngaysinh"" name=""ngaysinh"" type=""date"" data-date="""" data-date-format=""DD/MMMM/YYYY"" />
                                <span class=""field-validation-valid text-danger"" data-valmsg-for=""ngaysinh"" data-valmsg-replace=""true""></span>
                            </div>
                        </div>


                        <div class=""form-group"">
                            ");
#nullable restore
#line 79 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
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
#line 86 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Gioitinh, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 90 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                       Write(Html.LabelFor(model => model.Tendn, "Tên đăng nhập", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
#nullable restore
#line 92 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.EditorFor(model => model.Tendn, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 93 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Tendn, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 97 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                       Write(Html.LabelFor(model => model.Mk, "Mật khẩu", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
#nullable restore
#line 99 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.EditorFor(model => model.Mk, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 100 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Mk, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>

                        <div class=""form-group"">
                            <div class=""col-md-offset-2 col-md-10"">
                                <input type=""submit"" value=""Đăng ký"" class=""btn btn-danger"" />
                            </div>
                        </div>
                    </div>
                </center>
            </div>
");
#nullable restore
#line 112 "D:\DA\WebAppYte\WebAppYte\Views\Home\Dangky.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n");
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