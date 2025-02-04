#pragma checksum "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "495ba30d8ded0a286309fcffb972fc0ceb6d8cfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BenhAns_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/BenhAns/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"495ba30d8ded0a286309fcffb972fc0ceb6d8cfe", @"/Areas/Admin/Views/BenhAns/Details.cshtml")]
    public class Areas_Admin_Views_BenhAns_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppYte.Models.BenhAn>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
   ViewBag.Title = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAd.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n");
#nullable restore
#line 7 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n\r\n        <hr />\r\n        ");
#nullable restore
#line 14 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 18 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
       Write(Html.LabelFor(model => model.Tieude, "Tiêu đề", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 20 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.TextBoxFor(model => model.Tieude, new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.ValidationMessageFor(model => model.Tieude, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 26 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
       Write(Html.LabelFor(model => model.Mabs, "Bác sĩ", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 28 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.DropDownListFor(model => model.Mabs, new SelectList(ViewData["bacsis"] as List<WebAppYte.Models.NguoiDung>, "mand", "hoten"), htmlAttributes: new { @class = "form-control", @readonly = "true", @disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 29 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.ValidationMessageFor(model => model.Mabs, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 32 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
          
            var listBN = ViewData["benhnhans"] as List<WebAppYte.Models.BenhNhan>;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 37 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
       Write(Html.LabelFor(model => model.Mabn, "Bệnh nhân", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 39 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.DropDownListFor(model => model.Mabn, new SelectList(ViewData["benhnhans"] as List<WebAppYte.Models.BenhNhan>, "mabn", "tenbn"), htmlAttributes: new { @class = "form-control", @readonly = "true", @disabled="true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 40 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.ValidationMessageFor(model => model.Mabn, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-1\">Họ tên: </label>\r\n            <span id=\"hoten\">");
#nullable restore
#line 45 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
                        Write(listBN[0].Tenbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-1\">Ngày sinh: </label>\r\n            <span id=\"ngaysinh\">");
#nullable restore
#line 49 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
                           Write(listBN[0].Ngaysinh.Value.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label col-md-1\">Địa chỉ: </label>\r\n            <span id=\"diachi\">");
#nullable restore
#line 53 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
                         Write(listBN[0].Diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-6\">\r\n                ");
#nullable restore
#line 57 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.Ngaykham, "Ngày khám", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n");
#nullable restore
#line 59 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
                      
                        var ngaykham = Model.Ngaykham.ToString("yyyy-MM-dd");
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 62 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => ngaykham, new { @class = "form-control", @type = "date", @readonly="true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 63 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Ngaykham, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group col-6\">\r\n                ");
#nullable restore
#line 68 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.Giokham, "Giờ khám", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n");
#nullable restore
#line 70 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
                      
                        var giokham = Model.Giokham.ToString("HH:mm:ss");
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 73 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => giokham, new { @class = "form-control", @type = "time", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 74 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Giokham, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-4\">\r\n                ");
#nullable restore
#line 81 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.Mach, "Mạch", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 83 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => model.Mach, htmlAttributes: new { @class = "form-control", @type = "number", @step = "0.01", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 84 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Mach, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group col-4\">\r\n                ");
#nullable restore
#line 89 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.Nhietdo, "Thân nhiệt", htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 91 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => model.Nhietdo, new { @class = "form-control", @type = "number", @step = "0.01", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 92 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Nhietdo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group col-4\">\r\n                ");
#nullable restore
#line 97 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.Nhiptho, "Nhiệp thở", htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 99 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => model.Nhiptho, new { @class = "form-control", @type = "number", @step = "0.01", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 100 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Nhiptho, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-4\">\r\n                ");
#nullable restore
#line 107 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.Chieucao, "Cao (m)", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 109 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => model.Chieucao, new { @class = "form-control", @id = "chieucao", @readonly = "true", @type = "number", @step = "0.01" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 110 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Chieucao, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group col-4\">\r\n                ");
#nullable restore
#line 114 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.Cannang, "Nặng", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 116 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => model.Cannang, new { @class = "form-control", @id = "cannang", @readonly = "true", @type = "number", @step = "0.01" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 117 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Cannang, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group col-4\">\r\n                ");
#nullable restore
#line 122 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.Bmi, "BMI", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 124 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => model.Bmi, new { @class = "form-control", @readonly = "true", @id = "bmi", @type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 125 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Bmi, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-6\">\r\n                ");
#nullable restore
#line 133 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.Thiluctrai, "Mắt trái", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 135 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => model.Thiluctrai, new { @class = "form-control", @min = 1, @max = 10, @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 136 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Thiluctrai, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group col-6\">\r\n                ");
#nullable restore
#line 141 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.Thilucphai, "Mắt phải", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 143 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => model.Thilucphai, new { @class = "form-control", @min = 1, @max = 10, @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 144 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Thilucphai, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-6\">\r\n                ");
#nullable restore
#line 152 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.NhanapP, "Nhãn áp P", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 154 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => model.NhanapP, new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 155 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.NhanapP, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group col-6\">\r\n                ");
#nullable restore
#line 160 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.LabelFor(model => model.NhanapT, "Nhãn áp T", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
#nullable restore
#line 162 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.TextBoxFor(model => model.NhanapT, new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 163 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.NhanapT, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 169 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
       Write(Html.LabelFor(model => model.Chuandoan, "Chuẩn đoán lâm sàng", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 171 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.TextAreaFor(model => model.Chuandoan, new { @class = "form-control", @readonly = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 172 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
           Write(Html.ValidationMessageFor(model => model.Chuandoan, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 176 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
       Write(Html.LabelFor(model => model.Ketqua, "Kết quả", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                <textarea class = \"form-control\" readonly name=\"ketqua\">");
#nullable restore
#line 178 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
                                                                   Write(Model.Ketqua);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n            </div>\r\n        </div>\r\n    </div>");
#nullable restore
#line 181 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
#nullable restore
#line 183 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Maba }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 184 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppYte.Models.BenhAn> Html { get; private set; }
    }
}
#pragma warning restore 1591
