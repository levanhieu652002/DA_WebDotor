#pragma checksum "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afb10818d06f5d6ef9dc35ba319577527852449f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BenhAns_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/BenhAns/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb10818d06f5d6ef9dc35ba319577527852449f", @"/Areas/Admin/Views/BenhAns/Edit.cshtml")]
    public class Areas_Admin_Views_BenhAns_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppYte.Models.BenhAn>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate-vsdoc.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
   ViewBag.Title = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAd.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n");
#nullable restore
#line 8 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n\r\n    <hr />\r\n    ");
#nullable restore
#line 15 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <input type=\"hidden\" name=\"maba\"");
            BeginWriteAttribute("value", " value=\"", 358, "\"", 377, 1);
#nullable restore
#line 16 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
WriteAttributeValue("", 366, Model.Maba, 366, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 19 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
   Write(Html.LabelFor(model => model.Tieude, "Tiêu đề", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 21 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.TextBoxFor(model => model.Tieude, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Tieude, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 27 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
   Write(Html.LabelFor(model => model.Mabs, "Bác sĩ", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 29 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.DropDownListFor(model => model.Mabs, new SelectList(ViewData["bacsis"] as List<WebAppYte.Models.NguoiDung>, "mand", "hoten"), htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Mabs, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 33 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
      
        var listBN = ViewData["benhnhans"] as List<WebAppYte.Models.BenhNhan>;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 38 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
   Write(Html.LabelFor(model => model.Mabn, "Bệnh nhân", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 40 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.DropDownListFor(model => model.Mabn, new SelectList(ViewData["benhnhans"] as List<WebAppYte.Models.BenhNhan>, "mabn", "tenbn"), htmlAttributes: new { @class = "form-control", @onchange = "selectedValue(this)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 41 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Mabn, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label col-md-1\">Họ tên: </label>\r\n        <span id=\"hoten\">");
#nullable restore
#line 46 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
                    Write(Model.MabnNavigation.Tenbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label col-md-1\">Ngày sinh: </label>\r\n        <span id=\"ngaysinh\">");
#nullable restore
#line 50 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
                       Write(Model.MabnNavigation.Ngaysinh.Value.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label class=\"control-label col-md-1\">Địa chỉ: </label>\r\n        <span id=\"diachi\">");
#nullable restore
#line 54 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
                     Write(Model.MabnNavigation.Diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"form-group col-6\">\r\n            ");
#nullable restore
#line 58 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.Ngaykham, "Ngày khám", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n");
#nullable restore
#line 60 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
                  
                    var ngaykham = Model.Ngaykham.ToString("yyyy-MM-dd");
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 63 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => ngaykham, new { @class = "form-control", @type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 64 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Ngaykham, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group col-6\">\r\n            ");
#nullable restore
#line 69 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.Giokham, "Giờ khám", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n");
#nullable restore
#line 71 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
                  
                    var giokham = Model.Giokham.ToString("HH:mm:ss");
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 74 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => giokham, new { @class = "form-control", @type = "time" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 75 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Giokham, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"form-group col-4\">\r\n            ");
#nullable restore
#line 82 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.Mach, "Mạch", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 84 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Mach, htmlAttributes: new { @class = "form-control", @type = "number", @step = "0.01" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 85 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Mach, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group col-4\">\r\n            ");
#nullable restore
#line 90 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.Nhietdo, "Thân nhiệt", htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 92 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Nhietdo, new { @class = "form-control", @type = "number", @step = "0.01" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 93 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nhietdo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group col-4\">\r\n            ");
#nullable restore
#line 98 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.Nhiptho, "Nhiệp thở", htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 100 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Nhiptho, new { @class = "form-control", @type = "number", @step = "0.01" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 101 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nhiptho, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"form-group col-4\">\r\n            ");
#nullable restore
#line 108 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.Chieucao, "Cao (m)", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 110 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Chieucao, new { @class = "form-control", @id = "chieucao", @value = "0", @oninput = "onCalculateBMI()", @type = "number", @step = "0.01" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 111 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Chieucao, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group col-4\">\r\n            ");
#nullable restore
#line 115 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.Cannang, "Nặng", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 117 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Cannang, new { @class = "form-control", @id = "cannang", @value = "0", @oninput = "onCalculateBMI()", @type = "number", @step = "0.01" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 118 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Cannang, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group col-4\">\r\n            ");
#nullable restore
#line 123 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.Bmi, "BMI", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 125 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Bmi, new { @class = "form-control", @readonly = "true", @id = "bmi", @type = "number" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 126 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Bmi, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"row\">\r\n        <div class=\"form-group col-6\">\r\n            ");
#nullable restore
#line 134 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.Thiluctrai, "Mắt trái", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 136 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Thiluctrai, new { @class = "form-control", @min = 1, @max = 10 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 137 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Thiluctrai, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group col-6\">\r\n            ");
#nullable restore
#line 142 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.Thilucphai, "Mắt phải", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 144 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.Thilucphai, new { @class = "form-control", @min = 1, @max = 10 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 145 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Thilucphai, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"row\">\r\n        <div class=\"form-group col-6\">\r\n            ");
#nullable restore
#line 153 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.NhanapP, "Nhãn áp P", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 155 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.NhanapP, new { @class = "form-control", @value = 0 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 156 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.NhanapP, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group col-6\">\r\n            ");
#nullable restore
#line 161 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.LabelFor(model => model.NhanapT, "Nhãn áp T", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 163 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.TextBoxFor(model => model.NhanapT, new { @class = "form-control", @value = 0 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 164 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.NhanapT, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 170 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
   Write(Html.LabelFor(model => model.Chuandoan, "Chuẩn đoán lâm sàng", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 172 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.TextAreaFor(model => model.Chuandoan, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 173 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
       Write(Html.ValidationMessageFor(model => model.Chuandoan, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 179 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
   Write(Html.LabelFor(model => model.Ketqua, "Kết quả", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <textarea class = \"form-control\" name=\"ketqua\">");
#nullable restore
#line 181 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
                                                      Write(Model.Ketqua);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-outline-info\" />\r\n        </div>\r\n    </div>\r\n</div>");
#nullable restore
#line 190 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 193 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb10818d06f5d6ef9dc35ba319577527852449f26762", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb10818d06f5d6ef9dc35ba319577527852449f27862", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb10818d06f5d6ef9dc35ba319577527852449f28962", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb10818d06f5d6ef9dc35ba319577527852449f30062", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afb10818d06f5d6ef9dc35ba319577527852449f31162", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        function onCalculateBMI() {
            var height = $(""#chieucao"").val();
            var weight = $(""#cannang"").val();
            var bmi = weight / (height * height);
            $(""#bmi"").val(bmi.toFixed(2));
        }
        function selectedValue(ddlObject) {
            var id = ddlObject.value;
            var obj = ");
#nullable restore
#line 213 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\BenhAns\Edit.cshtml"
                 Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(ViewData["benhnhans"],
                           new Newtonsoft.Json.JsonSerializerSettings
                           {
                               ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                           })));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            var benhnhan = obj.find(x => x.mabn == id);
            $(""#hoten"").text(benhnhan.tenbn);
            $(""#ngaysinh"").text(new Date(benhnhan.ngaysinh).toLocaleDateString());
            $(""#diachi"").text(benhnhan.diachi);
        }
    </script>
");
            }
            );
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
