#pragma checksum "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b248ccffcb96dbd10bef014c4ddb7468a78263"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChuyenGiaBacSi_ChuyenGiaBacSi), @"mvc.1.0.view", @"/Views/ChuyenGiaBacSi/ChuyenGiaBacSi.cshtml")]
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
#line 2 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
using WebAppYte.DAO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
using WebAppYte.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b248ccffcb96dbd10bef014c4ddb7468a78263", @"/Views/ChuyenGiaBacSi/ChuyenGiaBacSi.cshtml")]
    public class Views_ChuyenGiaBacSi_ChuyenGiaBacSi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList<TTNguoiDung>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/images/banner-chuyen-gia-bac-si-desk.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("position:absolute; width:100%; height:auto; display:block !important; top:210px; left:-0px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("loading", new global::Microsoft.AspNetCore.Html.HtmlString("lazy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 14 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
  
    ViewBag.Title = "ChuyenGiaBacSi";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var httpContext = HttpContextAccessor.HttpContext;
    var uJson = httpContext.Session.GetString("userBS");
    var u = !string.IsNullOrEmpty(uJson) ? JsonSerializer.Deserialize<TTNguoiDung>(uJson) : null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style type=""text/css"">
    /*    td {
        text-align: center
    }*/

    th {
        text-align: center
    }

    .tenBV {
        color: orangered;
        font-size: x-large
    }
</style>



<div id=""nivoslider"" class=""slides nivoSlider"">

    <div class=""nivo-directionNav""><a class=""nivo-prevNav"">Prev</a><a class=""nivo-nextNav"">Next</a></div>
    <div class=""nivo-slice"" name=""0"" style=""left: 0px; width: 100%; height: 515px; opacity: 1; overflow: hidden;"">
        <div class=""col-sm-12"" style=""position:absolute; width:100%; height:auto; display:block !important; top:180px; left:200px;"">
            <nav aria-label=""breadcrumbs"" class=""rank-math-breadcrumb""><p><a href=""/Home/Index"">TRANG CHỦ</a><span class=""separator""> &gt; </span><span class=""last"">CHUYÊN GIA - BÁC SĨ</span></p></nav>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26b248ccffcb96dbd10bef014c4ddb7468a782636654", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

</div>


<div class=""text-center mt_15"" style=""margin-top: 150px;"">
    <div class=""box_search"" style=""top:30px;"">
        <form method=""post"" action = ""/ChuyenGiaBacSi/Search"">
            <input type=""text"" placeholder=""Tìm bác sĩ"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1799, "\"", 1819, 1);
#nullable restore
#line 55 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 1807, ViewBag.txt, 1807, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""id"" style=""top:30px;"">
            <button type=""submit"" for=""email"" class=""glyphicon glyphicon-search cl_head"" rel=""tooltip"" title=""search""></button>
        </form>
    </div>
</div>

<div class=""text-center"">
    <h1 class=""div_head text-center cl_head text-uppercase font_hel sz_24 mb_25 pb_15"" style=""top:15px;"">Chuyên gia - bác sĩ</h1>
</div>
<div class=""filter_chuyengia mb_30"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 text-center pb_15 mb_15"">

                <button class=""click_location btn bg_xam cl_33 text-uppercase active"" data-gtm-vis-recent-on-screen-2545377_121=""78"" data-gtm-vis-first-on-screen-2545377_121=""78"" data-gtm-vis-total-visible-time-2545377_121=""100"" data-gtm-vis-has-fired-2545377_121=""1"" data-gtm-vis-recent-on-screen-2545377_155=""82"" data-gtm-vis-first-on-screen-2545377_155=""82"" data-gtm-vis-total-visible-time-2545377_155=""100"" data-gtm-vis-has-fired-2545377_155=""1""><a");
            BeginWriteAttribute("href", " href=\"", 2780, "\"", 2834, 1);
#nullable restore
#line 69 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 2787, Url.Action("ChuyenGiaBacSi", "ChuyenGiaBacSi"), 2787, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Toàn hệ thống</a></button>\n                <button class=\"  click_location btn bg_xam cl_33 text-uppercase \" data-gtm-vis-has-fired-2545377_121=\"1\" data-gtm-vis-has-fired-2545377_155=\"1\"> <a");
            BeginWriteAttribute("href", " href=\"", 3026, "\"", 3072, 1);
#nullable restore
#line 70 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 3033, Url.Action("DaNang", "ChuyenGiaBacSi"), 3033, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đà Nẵng</a></button>\n                <button class=\"  click_location btn bg_xam cl_33 text-uppercase \" data-gtm-vis-has-fired-2545377_121=\"1\" data-gtm-vis-has-fired-2545377_155=\"1\"><a");
            BeginWriteAttribute("href", " href=\"", 3259, "\"", 3305, 1);
#nullable restore
#line 71 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 3266, Url.Action("SaiGon", "ChuyenGiaBacSi"), 3266, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sài Gòn</a></button>\n                <button class=\"  click_location btn bg_xam cl_33 text-uppercase \" data-gtm-vis-has-fired-2545377_121=\"1\" data-gtm-vis-has-fired-2545377_155=\"1\"><a");
            BeginWriteAttribute("href", " href=\"", 3492, "\"", 3537, 1);
#nullable restore
#line 72 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 3499, Url.Action("HaNoi", "ChuyenGiaBacSi"), 3499, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Hà Nội</a></button>
                <script>
                    jQuery(document).ready(function () {
                        jQuery(""label[data-location=\'35\']"").trigger('click');
                        jQuery("".click_location"").click(function () {
                            jQuery('body').addClass('load');
                            var location = jQuery(this).data('location');
                            jQuery('#filter_diadiem').val(location);
                            jQuery('#filter_form').submit();
                            jQuery("".click_location"").removeClass('active');
                            jQuery(this).addClass('active');
                        });
                    });</script>
            </div>
          
            <div class=""col-md-10 col-md-offset-1 col-md-12 col-xs-12"" style=""margin-left:29%;"">
                <div class=""row"">
                  
");
#nullable restore
#line 90 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                     using (Html.BeginForm("ActionPostData", "ChuyenGiaBacSi", FormMethod.Post))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-sm-3 col-xs-4 mb_10 filter_item\">\n\n                            <select id=\"filter\" name=\"filter\" onchange=\"this.form.submit()\">\n                                <option");
            BeginWriteAttribute("value", " value=\"", 4763, "\"", 4771, 0);
            EndWriteAttribute();
            WriteLiteral(">CHUYÊN KHOA</option>\n");
#nullable restore
#line 96 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                 foreach (var item in ViewBag.segmentList)
                                {

                                    if (item == ViewBag.filter)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option");
            BeginWriteAttribute("value", " value=\"", 5053, "\"", 5066, 1);
#nullable restore
#line 101 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 5061, item, 5061, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 101 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                                                  Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 102 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option");
            BeginWriteAttribute("value", " value=\"", 5256, "\"", 5269, 1);
#nullable restore
#line 105 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 5264, item, 5264, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 105 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                                         Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 106 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </select>\n\n                        </div>\n");
            WriteLiteral("                        <div class=\"col-sm-3 col-xs-4 mb_10 filter_item\">\n                            <select id=\"tencv\" name=\"tencv\" onchange=\"this.form.submit()\">\n                                <option");
            BeginWriteAttribute("value", " value=\"", 5636, "\"", 5644, 0);
            EndWriteAttribute();
            WriteLiteral(">CHỨC VỤ</option>\n");
#nullable restore
#line 118 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                 foreach (var item in ViewBag.chucvu)
                                {

                                    if (item.Text == ViewBag.choose)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option");
            BeginWriteAttribute("value", " value=\"", 5922, "\"", 5941, 1);
#nullable restore
#line 123 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 5930, item.Value, 5930, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 123 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                                                        Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 124 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <option");
            BeginWriteAttribute("value", " value=\"", 6136, "\"", 6155, 1);
#nullable restore
#line 127 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 6144, item.Value, 6144, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 127 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                                               Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\n");
#nullable restore
#line 128 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                    }

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </select>\n                        </div>\n");
#nullable restore
#line 134 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n<div class=\" \">\n    <div class=\"container\">\n        <div class=\"row\">\n\n");
#nullable restore
#line 146 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-xs-12  col-sm-12 item_post  mb_15 \">\n                    <div class=\"row\">\n                        <div class=\"col-xs-6 col-sm-4 col-md-3 mb_15\">\n                            <a class=\"thumb_cgia\"");
            BeginWriteAttribute("href", " href=\"", 6772, "\"", 6845, 1);
#nullable restore
#line 151 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 6779, Url.Action("DatLichHen", "ChuyenGiaBacSi", new { id = item.mand}), 6779, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26b248ccffcb96dbd10bef014c4ddb7468a7826319555", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6929, "~/images/images/", 6929, 16, true);
#nullable restore
#line 152 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
AddHtmlAttributeValue("", 6945, item.anh, 6945, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            </a>\n                        </div>\n                        <div class=\"col-xs-6 col-sm-8 col-md-9 \">\n                            <div class=\"info_chuyengia\">\n                                <a");
            BeginWriteAttribute("title", " title=\"", 7178, "\"", 7197, 1);
#nullable restore
#line 157 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 7186, item.hoten, 7186, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                    <h2 class=\"mt_0 mb_10 sz_18 cl_33\" style=\"font-weight: bold;\">");
#nullable restore
#line 158 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                                                                             Write(item.hoten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                                </a>\n                                <div class=\"font_helI s\" style=\" font-style: italic;\">\n                                    <div class=\"sss\">");
#nullable restore
#line 161 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                                Write(item.chucvu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><div>Trung tâm Đa khoa HK ");
#nullable restore
#line 161 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                                                                            Write(item.tenchinhanh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                </div>\n                                <div class=\"mt_10 hidden-xs\">");
#nullable restore
#line 163 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                                        Write(item.gioithieu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                                <div class=\"text-right mt_10 hidden-xs\">\n                                    <button");
            BeginWriteAttribute("class", " class=\"", 7798, "\"", 7806, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"border: none;\">\n                                        <a class=\"cl_white bg_brand btn text-uppercase\"");
            BeginWriteAttribute("href", " href=\"", 7918, "\"", 7991, 1);
#nullable restore
#line 166 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
WriteAttributeValue("", 7925, Url.Action("DatLichHen", "ChuyenGiaBacSi", new { id = item.mand}), 7925, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">CHI TIẾT</a>
                                    </button>

                                    
                                </div>
                                <div class=""clear""></div>
                            </div>
                        </div>
                       
                    </div>
                </div>
");
#nullable restore
#line 177 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n\n    <div class=\"pagination-bar\">\n        <div class=\"row\">\n            <div class=\"col-md-4 col-sm-4 col-xs-12\">\n                <div class=\"text\"> Trang ");
#nullable restore
#line 184 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                     Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" của ");
#nullable restore
#line 184 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                                                                                                     Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            </div>\n\n            <div class=\"col-md-8 col-sm-8 col-xs-12\">\n                <div class=\"pagination\">\n                    <ul class=\"page-list\" style=\"list-style:none;\">\n                        <li>");
#nullable restore
#line 190 "D:\DA\WebAppYte\WebAppYte\Views\ChuyenGiaBacSi\ChuyenGiaBacSi.cshtml"
                       Write(Html.PagedListPager(Model, page => Url.Action("ChuyenGiaBacSi", new { page, pageSize = 5 })));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n\n                    </ul>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList<TTNguoiDung>> Html { get; private set; }
    }
}
#pragma warning restore 1591