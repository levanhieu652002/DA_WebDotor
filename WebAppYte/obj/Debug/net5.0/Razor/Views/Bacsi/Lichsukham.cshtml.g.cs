#pragma checksum "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebdb5081bdfe73fb84c2919156b9faaa9810c218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bacsi_Lichsukham), @"mvc.1.0.view", @"/Views/Bacsi/Lichsukham.cshtml")]
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
#line 2 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
using WebAppYte.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebdb5081bdfe73fb84c2919156b9faaa9810c218", @"/Views/Bacsi/Lichsukham.cshtml")]
    public class Views_Bacsi_Lichsukham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<WebAppYte.DAO.LichKham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 11 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var httpContext = HttpContextAccessor.HttpContext;
    var uJson = httpContext.Session.GetString("user");
    var u = !string.IsNullOrEmpty(uJson) ? JsonSerializer.Deserialize<BenhNhan>(uJson) : null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style type=""text/css"">
    .body {
        background: #fafafa url(https://jackrugile.com/images/misc/noise-diagonal.png);
        color: #444;
        font: 100%/30px 'Helvetica Neue', helvetica, arial, sans-serif;
        text-shadow: 0 1px 0 #fff;
    }

    strong {
        font-weight: bold;
    }

    em {
        font-style: italic;
    }

    table {
        background: #f5f5f5;
        border-collapse: separate;
        box-shadow: inset 0 1px 0 #fff;
        font-size: 12px;
        line-height: 24px;
        margin: 30px auto;
        text-align: left;
        width: 100%;
    }

    th {
        background: url(https://jackrugile.com/images/misc/noise-diagonal.png), linear-gradient(#777, #444);
        border-left: 1px solid #555;
        border-right: 1px solid #777;
        border-top: 1px solid #555;
        border-bottom: 1px solid #333;
        box-shadow: inset 0 1px 0 #999;
        color: #fff;
        font-weight: bold;
        padding: 10px 15px;
  ");
            WriteLiteral(@"      position: relative;
        text-shadow: 0 1px 0 #000;
    }

        th:after {
            background: linear-gradient(rgba(255,255,255,0), rgba(255,255,255,.08));
            content: '';
            display: block;
            height: 25%;
            left: 0;
            margin: 1px 0 0 0;
            position: absolute;
            top: 25%;
            width: 100%;
        }

        th:first-child {
            border-left: 1px solid #777;
            box-shadow: inset 1px 1px 0 #999;
        }

        th:last-child {
            box-shadow: inset -1px 1px 0 #999;
        }

    td {
        border-right: 1px solid #fff;
        border-left: 1px solid #e8e8e8;
        border-top: 1px solid #fff;
        border-bottom: 1px solid #e8e8e8;
        padding: 10px 15px;
        position: relative;
        transition: all 300ms;
    }

        td:first-child {
            box-shadow: inset 1px 0 0 #fff;
        }

        td:last-child {
            border-right");
            WriteLiteral(@": 1px solid #e8e8e8;
            box-shadow: inset -1px 0 0 #fff;
        }

    tr {
        background: url(https://jackrugile.com/images/misc/noise-diagonal.png);
    }

        tr:nth-child(odd) td {
            background: #f1f1f1 url(https://jackrugile.com/images/misc/noise-diagonal.png);
        }

        tr:last-of-type td {
            box-shadow: inset 0 -1px 0 #fff;
        }

            tr:last-of-type td:first-child {
                box-shadow: inset 1px -1px 0 #fff;
            }

            tr:last-of-type td:last-child {
                box-shadow: inset -1px -1px 0 #fff;
            }

    tbody:hover td {
        color: transparent;
        text-shadow: 0 0 3px #aaa;
    }

    tbody:hover tr:hover td {
        color: #444;
        text-shadow: 0 1px 0 #fff;
    }
</style>

<div id=""nivoslider"" class=""slides nivoSlider"">

    <div class=""nivo-directionNav""><a class=""nivo-prevNav"">Prev</a><a class=""nivo-nextNav"">Next</a></div>
    <div class=""nivo-sli");
            WriteLiteral(@"ce"" name=""0"" style=""left: 0px; width: 1530px; height: 160px; opacity: 1; overflow: hidden;"">
        <div class=""col-sm-12"" style=""position:absolute; width:1519px; height:auto; display:block !important; top:180px; left:200px;"">
            <nav aria-label=""breadcrumbs"" class=""rank-math-breadcrumb""><p><a href=""/Home/Index"">TRANG CHỦ</a><span class=""separator""> &gt; </span><span class=""last"">LỊCH SỬ KHÁM</span></p></nav>
        </div>

    </div>
</div>


<div class=""body"">



    <table>
        <thead>
            <tr>
                <th></th>
                <th>Bác Sĩ</th>
                <th>Hình Thức</th>
                <th>Ngày Đặt</th>
                <th>Ca Khám</th>
                <th>Ngày Khám</th>
                <th>Mô tả</th>
                <th>Ghi chú bác sĩ</th>
                <th>Trạng Thái</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 162 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
              
                int count = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><strong>");
#nullable restore
#line 168 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                            Write(++count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                    <td><strong>");
#nullable restore
#line 169 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                           Write(item.hoten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                    <td>");
#nullable restore
#line 170 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                   Write(item.hinhthuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 171 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                   Write(item.ngaydat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 172 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                   Write(item.ca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 173 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                    Write(item.ngaykham != null ? item.ngaykham : "Chưa khám");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 174 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                   Write(item.mota);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 175 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                    Write(item.donthuoc != null ? item.donthuoc.Trim() : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 177 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                         if (@item.trangthai == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5 style=\"color:blueviolet\"> Đang chờ xác nhận. </h5>\r\n");
#nullable restore
#line 180 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                        }
                        else if (@item.trangthai == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5 style=\"color:orange\"> Đã xác nhận lịch </h5>\r\n");
#nullable restore
#line 184 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h5 style=\"color:green\"> Đã tư vấn xong. </h5>\r\n");
#nullable restore
#line 188 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 191 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n\r\n<br />\r\nTrang ");
#nullable restore
#line 199 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
  Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 199 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
                                                                Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 201 "D:\DA\WebAppYte\WebAppYte\Views\Bacsi\Lichsukham.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Lichsukham",  new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<WebAppYte.DAO.LichKham>> Html { get; private set; }
    }
}
#pragma warning restore 1591