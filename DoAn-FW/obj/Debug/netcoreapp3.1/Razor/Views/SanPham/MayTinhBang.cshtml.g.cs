#pragma checksum "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb5d2d579f0b3b1555580025a7472e5e70b0fffc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_MayTinhBang), @"mvc.1.0.view", @"/Views/SanPham/MayTinhBang.cshtml")]
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
#line 1 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\_ViewImports.cshtml"
using DoAn_FW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\_ViewImports.cshtml"
using DoAn_FW.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb5d2d579f0b3b1555580025a7472e5e70b0fffc", @"/Views/SanPham/MayTinhBang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3faed0a872865f7b5063ed88e6ca22051c9f0aa3", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_MayTinhBang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/SanPham/MayTinhBang"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
  
    ViewData["Title"] = "Máy tính bảng";
    List<object> Model = ViewData["list"] as List<object>;
    KhachHang kh = ViewBag.KH;
    Pager pager = new Pager();


    int pageNo = 0;
    if (ViewBag.Pager != null)
    {
        pager = ViewBag.Pager;
        pageNo = pager.CurrentPage;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""mainmenu-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""navbar-header"">
                <button type=""button""
                        class=""navbar-toggle""
                        data-toggle=""collapse""
                        data-target="".navbar-collapse"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
            </div>
            <div class=""navbar-collapse collapse"">
                <ul class=""nav navbar-nav"">
                    <li><a href=""/Home/Index"">Trang chủ</a></li>
                    <li><a href=""/SanPham/DTDD"">Điện thoại</a></li>
                    <li class=""active"">
                        <a href=""/SanPham/MayTinhBang"">Máy tính bảng</a>
                    </li>
                    <li><a href=""/TinTuc/DanhSachTinTuc"">Tin t");
            WriteLiteral(@"ức</a></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- End mainmenu area -->

<div class=""product-big-title-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""product-bit-title text-center"">
                    <h2>Danh sách sản phẩm</h2>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""single-product-area"">
    <div class=""zigzag-bottom""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-3"">
                <h2>Tìm kiếm</h2>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb5d2d579f0b3b1555580025a7472e5e70b0fffc6191", async() => {
                WriteLiteral(@"
                    <input type=""search"" name=""search"" class=""form-control"" placeholder=""Search"" style=""float:left; width:80%"" />
                    <button type=""button"" class=""btn btn-primary"" style=""float: left; width: 20%"">
                        <i class=""fas fa-search""></i>
                    </button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-3\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb5d2d579f0b3b1555580025a7472e5e70b0fffc7986", async() => {
                WriteLiteral(@"

                <div class=""left-sidebar"">
                    <h2>Danh mục</h2>
                    <div class=""panel-group category-products""
                         id=""accordian"">
                        <!--category-productsr-->
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse""
                                       data-parent=""#accordian""
                                       href=""#LoaiSP"">
                                        <span class=""badge pull-right"">
                                            <i class=""fa fa-plus""></i>
                                        </span>
                                        Loại sản phẩm
                                    </a>
                                </h4>
                            </div>
                            <div id=""LoaiSP""
          ");
                WriteLiteral(@"                       class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                        <ul style=""list-style:none"">
                                        <li><input type=""checkbox"" name=""MaLoaiSP"" value=""1"">Điện thoại</li>
                                        <li><input type=""checkbox"" name=""MaLoaiSP"" value=""2"">Máy tính bảng</li>
                                        </ul>
                                </div>
                            </div>
                        </div>
                        <!--
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse""
                                       data-parent=""#accordian""
                                       href=""#ram"">
                                        <span class=""badge pull-right"">
   ");
                WriteLiteral(@"                                         <i class=""fa fa-plus""></i>
                                        </span>
                                        Ram
                                    </a>
                                </h4>
                            </div>
                            <div id=""ram""
                                 class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <ul>

                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse""
                                       data-parent=""#accordian""
                                       href=""#bonhotrong"">
                   ");
                WriteLiteral(@"                     <span class=""badge pull-right"">
                                            <i class=""fa fa-plus""></i>
                                        </span>
                                        Bộ nhớ trong
                                    </a>
                                </h4>
                            </div>
                            <div id=""bonhotrong""
                                 class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <ul>

                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse""
                                       data-parent=""#accordian""
      ");
                WriteLiteral(@"                                 href=""#manhinh"">
                                        <span class=""badge pull-right"">
                                            <i class=""fa fa-plus""></i>
                                        </span>
                                        Màn hình
                                    </a>
                                </h4>
                            </div>
                            <div id=""manhinh""
                                 class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <ul>

                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""panel panel-default"">
                            <div class=""panel-heading"">
                                <h4 class=""panel-title"">
                                    <a data-toggle=""collapse""
        ");
                WriteLiteral(@"                               data-parent=""#accordian""
                                       href=""#hang"">
                                        <span class=""badge pull-right"">
                                            <i class=""fa fa-plus""></i>
                                        </span>
                                        Hãng
                                    </a>
                                </h4>
                            </div>
                            <div id=""hang""
                                 class=""panel-collapse collapse"">
                                <div class=""panel-body"">
                                    <ul>

                                    </ul>
                                </div>
                            </div>
                        </div>
                        -->
                    </div>

                        <button type=""submit"" onchange=""this.form.submit()"">Lọc sản phẩm</button>

                </div>

      ");
                WriteLiteral("          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"col-sm-9 padding-right\">\r\n");
#nullable restore
#line 203 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-3 col-sm-6"" style=""float: left; width: 250px; height: 400px; padding: 10px; margin-top: 20px; margin-bottom: 20px;"">
                        <div class=""single-shop-product"">
                            <div class=""product-upper"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 9154, "\"", 9230, 1);
#nullable restore
#line 208 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
WriteAttributeValue("", 9160, item.GetType().GetProperty("HinhAnh").GetValue(item, null).ToString(), 9160, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 9231, "\"", 9237, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </div>\r\n                            <h2>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 9347, "\"", 9507, 4);
            WriteAttributeValue("", 9354, "/SanPham/ChiTietSP?t=", 9354, 21, true);
#nullable restore
#line 211 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
WriteAttributeValue("", 9375, item.GetType().GetProperty("MaTTSP").GetValue(item, null).ToString(), 9375, 69, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 9444, "&l=", 9444, 3, true);
#nullable restore
#line 211 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
WriteAttributeValue("", 9447, item.GetType().GetProperty("MaLoaiSP").GetValue(item, null), 9447, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 212 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                               Write(item.GetType().GetProperty("TenSP").GetValue(item, null).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </h2>\r\n                            <h4>\r\n                                ");
#nullable restore
#line 216 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                           Write(item.GetType().GetProperty("MauSac").GetValue(item, null).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("-\r\n                                ");
#nullable restore
#line 217 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                           Write(item.GetType().GetProperty("Ram").GetValue(item, null).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("GB-\r\n                                ");
#nullable restore
#line 218 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                           Write(item.GetType().GetProperty("BoNhoTrong").GetValue(item, null).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("GB\r\n                            </h4>\r\n                            <div class=\"product-carousel-price\">\r\n");
#nullable restore
#line 221 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                                 if (int.Parse(item.GetType().GetProperty("GiaKM").GetValue(item, null).ToString()) > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <del>");
#nullable restore
#line 223 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                                    Write(string.Format("{0:0,0 đ}", item.GetType().GetProperty("Gia").GetValue(item, null)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n                                    <br />\r\n                                    <ins>");
#nullable restore
#line 225 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                                    Write(string.Format("{0:0,0 đ}", item.GetType().GetProperty("GiaKM").GetValue(item, null)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</ins>\r\n");
#nullable restore
#line 226 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <del style=\"height: 74px; width: 150px\"></del>\r\n                                    <ins>");
#nullable restore
#line 230 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                                    Write(string.Format("{0:0,0 đ}", item.GetType().GetProperty("Gia").GetValue(item, null)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</ins>\r\n");
#nullable restore
#line 231 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>

                            <div class=""product-option-shop"">
                                <a class=""add_to_cart_button""
                                   data-quantity=""1""
                                   data-product_sku=""""
                                   data-product_id=""70""
                                   rel=""nofollow""");
            BeginWriteAttribute("href", "\r\n                                   href=\"", 11347, "\"", 11532, 4);
            WriteAttributeValue("", 11390, "/SanPham/ChiTietSP?t=", 11390, 21, true);
#nullable restore
#line 240 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
WriteAttributeValue("", 11411, item.GetType().GetProperty("MaTTSP").GetValue(item, null), 11411, 58, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 11469, "&l=", 11469, 3, true);
#nullable restore
#line 240 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
WriteAttributeValue("", 11472, item.GetType().GetProperty("MaLoaiSP").GetValue(item, null), 11472, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    Xem chi tiết\r\n                                </a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 246 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <div class=\"product-pagination text-center\">\r\n                    <nav>\r\n");
#nullable restore
#line 254 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                         if (pager.TotalPages > 0)

                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <ul class=\"pagination\">\r\n                                <!-- Link đến Trang trước -->\r\n                                <li>\r\n                                    <a href=\"javascript:void(0);\"");
            BeginWriteAttribute("onclick", " onclick=\"", 12230, "\"", 12278, 3);
            WriteAttributeValue("", 12240, "navigatePage(", 12240, 13, true);
#nullable restore
#line 260 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
WriteAttributeValue("", 12253, pager.CurrentPage - 1, 12253, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 12277, ")", 12277, 1, true);
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                        <span aria-hidden=\"true\">&laquo;</span>\r\n                                    </a>\r\n                                </li>\r\n\r\n                                <!-- Liệt kê các trang -->\r\n");
#nullable restore
#line 266 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                                 for (var pge = pager.StartPage; pge <= pager.EndPage; pge++)

                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li");
            BeginWriteAttribute("class", " class=\"", 12699, "\"", 12760, 2);
            WriteAttributeValue("", 12707, "page-item", 12707, 9, true);
#nullable restore
#line 269 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
WriteAttributeValue(" ", 12716, pge == pager.CurrentPage ? "active" : "", 12717, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <a class=\"page-link\" href=\"javascript:void(0);\"");
            BeginWriteAttribute("onclick", " onclick=\"", 12851, "\"", 12879, 3);
            WriteAttributeValue("", 12861, "navigatePage(", 12861, 13, true);
#nullable restore
#line 270 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
WriteAttributeValue("", 12874, pge, 12874, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 12878, ")", 12878, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 270 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                                                                                                                Write(pge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 272 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <!-- Link đến Trang sau -->\r\n                                <li>\r\n                                    <a href=\"javascript:void(0);\"");
            BeginWriteAttribute("onclick", " onclick=\"", 13135, "\"", 13183, 3);
            WriteAttributeValue("", 13145, "navigatePage(", 13145, 13, true);
#nullable restore
#line 276 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
WriteAttributeValue("", 13158, pager.CurrentPage + 1, 13158, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 13182, ")", 13182, 1, true);
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                                        <span aria-hidden=\"true\">&raquo;</span>\r\n                                    </a>\r\n                                </li>\r\n                            </ul>\r\n");
#nullable restore
#line 281 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Views\SanPham\MayTinhBang.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </nav>
                </div>
            </div>
        </div>


    </div>
</div>

<script>
    function navigatePage(pageNumber) {
        // Lấy URL hiện tại của trang
        var currentUrl = window.location.href;

        // Xóa bất kỳ tham số pg nào hiện có trong URL để tránh trùng lặp
        var cleanUrl = currentUrl.replace(/([?&]pg=\d+)/, '');

        // Thêm tham số pg mới vào URL
        var newUrl = cleanUrl + (cleanUrl.includes('?') ? '&' : '?') + 'pg=' + pageNumber;

        // Điều hướng đến URL mới
        window.location.href = newUrl;
    }
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
