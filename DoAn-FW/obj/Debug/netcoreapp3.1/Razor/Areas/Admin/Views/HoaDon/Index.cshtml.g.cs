#pragma checksum "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02ffb819467b93597fa5862c0b815be279a7fdbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HoaDon_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HoaDon/Index.cshtml")]
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
#line 1 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\_ViewImports.cshtml"
using Web_projectframeword_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\_ViewImports.cshtml"
using Web_projectframeword_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ffb819467b93597fa5862c0b815be279a7fdbf", @"/Areas/Admin/Views/HoaDon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5921b7841ba6f9e9504d0d750cb3a120e74748a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HoaDon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.HoaDonViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/HoaDon/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Hoadon/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
   int pages = Convert.ToInt32(ViewData["pages"]); int p = Convert.ToInt32(ViewData["page"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content-wrapper\" style=\"min-height: 639px;\">\n    <section class=\"content-header\">\n        <h1>\n            <i class=\"glyphicon glyphicon-ok-sign\"></i>Danh sách hóa đơn\n        </h1>\n        <div class=\"breadcrumb\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ffb819467b93597fa5862c0b815be279a7fdbf5281", async() => {
                WriteLiteral(@"
                <input type=""text"" placeholder=""Search here"" name=""SearchString"">
                <button type=""submit"" style=""width: 50px; height: 25px; background-color: darkcyan; border-radius: 10px; color: white; border-color: white; ""><i class=""fas fa-search-location""></i></button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <a class=\"btn btn-primary btn-sm\" href=\"/Admin/HoaDon/ThemHD\" role=\"button\">\n                <span class=\"glyphicon glyphicon-plus\"></span>Thêm mới\n            </a>\n        </div>\n    </section>\n    <section class=\"content\">\n");
#nullable restore
#line 19 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
         if (Convert.ToString(ViewData["tb"]) == "Thêm hóa đơn thành công")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\n                <div class=\"alert alert-success\">\n                    ");
#nullable restore
#line 23 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
               Write(ViewData["tb"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\n                </div>\n            </div>\n");
#nullable restore
#line 27 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
          
            if (Convert.ToString(ViewData["trangthai"]) == "Xóa không thành công")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\n                    <div class=\"alert alert-error\">\n                        ");
#nullable restore
#line 33 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                   Write(ViewData["trangthai"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\n                    </div>\n                </div>\n");
#nullable restore
#line 37 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
            }
            if (Convert.ToString(ViewData["trangthai"]) == "Xóa thành công")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\n                    <div class=\"alert alert-success\">\n                        ");
#nullable restore
#line 42 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                   Write(ViewData["trangthai"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\n                    </div>\n                </div>\n");
#nullable restore
#line 46 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""box"" id=""view"">
                    <div class=""box-header with-border"">
                        <div class=""box-body"">
                            <div class=""row"" style=""padding:0px; margin:0px;"">
                                <div class=""table-responsive"">
                                    <table class=""table table-hover table-bordered"">
                                        <thead>
                                            <tr>
                                                <th class=""text-center"">Mã HĐ</th>
                                                <th>Khách hàng</th>
                                                <th>Tổng tiền</th>
                                                <th>Ngày lập HD</th>
                                                <th>Tình trạng</th>
                                                <th class=""text-center"">Duyệt</th>
                                                <th>");
            WriteLiteral(@"Địa chỉ</th>
                                                <th class=""text-center"" colspan=""3"">Thao tác</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 69 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                              
                                                int a = Convert.ToInt32(ViewData["ThongBao"]);
                                                if (a == 1)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr><td class=\"text-center\" colspan=\"9\">Không tìm thấy hóa đơn nào!</td></tr>\n");
#nullable restore
#line 74 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                }
                                                else
                                                    foreach (var hd in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\n                                                            <td class=\"text-center\">");
#nullable restore
#line 79 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                               Write(hd.MaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                            <td>");
#nullable restore
#line 80 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                           Write(hd.TenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                            <td>");
#nullable restore
#line 81 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                           Write(hd.TongTienTT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                            <td>");
#nullable restore
#line 82 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                           Write(hd.NgayLapHD.Date.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                            <td>\n");
#nullable restore
#line 84 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                  
                                                                    if (hd.TinhTrangTT == 0)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <span>Chưa thanh toán</span>\n");
#nullable restore
#line 88 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                    }
                                                                    else
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <span>Đã thanh toán</span>\n");
#nullable restore
#line 92 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                    }
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            </td>\n                                                            <td style=\"text-align: center;\">\n");
#nullable restore
#line 96 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                  
                                                                    if (hd.TinhTrangHD == 0)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <a class=\"btn btn-default btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 5874, "\"", 5918, 2);
            WriteAttributeValue("", 5881, "/Admin/GiaoHang/DuyetHD?MAHD=", 5881, 29, true);
#nullable restore
#line 99 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 5910, hd.MaHD, 5910, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận đơn hàng và chuẩn bị giao hàng ?')"" role=""button"">
                                                                            <i class=""fa fa-check-square""></i> Duyệt đơn
                                                                        </a>
                                                                        <a class=""btn btn-default btn-xs""");
            BeginWriteAttribute("href", " href=\"", 6308, "\"", 6356, 4);
            WriteAttributeValue("", 6315, "/Admin/HoaDon/HuyHD?MAHD=", 6315, 25, true);
#nullable restore
#line 102 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 6340, hd.MaHD, 6340, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6348, "&page=", 6348, 6, true);
#nullable restore
#line 102 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 6354, p, 6354, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận hủy đơn hàng ?')"" role=""button"">
                                                                            <i class=""fa fa-window-close""></i> Hủy
                                                                        </a>
");
#nullable restore
#line 105 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                    }
                                                                    else if (hd.TinhTrangHD == -1)
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <span>Đã hủy</span>\n");
#nullable restore
#line 109 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                    }
                                                                    else
                                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                        <span>Đã duyệt</span>\n");
#nullable restore
#line 113 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                    }
                                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            </td>\n                                                            <td>");
#nullable restore
#line 116 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                           Write(hd.DiaChiGH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                            <td class=\"text-center\">\n                                                                <a class=\"btn btn-info btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 7718, "\"", 7756, 2);
            WriteAttributeValue("", 7725, "/Admin/HoaDon/XemHD?ID=", 7725, 23, true);
#nullable restore
#line 118 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 7748, hd.MaHD, 7748, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">
                                                                    <span class=""glyphicon glyphicon-eye-open""></span>Xem
                                                                </a>
                                                            </td>
                                                            <td class=""text-center"">
                                                                <a class=""btn btn-info btn-xs""");
            BeginWriteAttribute("href", " href=\"", 8209, "\"", 8249, 2);
            WriteAttributeValue("", 8216, "/Admin/HoaDon/XemCTHD?ID=", 8216, 25, true);
#nullable restore
#line 123 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 8241, hd.MaHD, 8241, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">
                                                                    <span class=""glyphicon glyphicon-eye-open""></span>CTHD
                                                                </a>
                                                            </td>
                                                            <td class=""text-center"">
");
#nullable restore
#line 128 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                  var t = (Model.Count() == 1) ? (p - 1) : p;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <a class=\"btn btn-danger btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 8816, "\"", 8865, 4);
            WriteAttributeValue("", 8823, "/Admin/HoaDon/Delete?MAHD=", 8823, 26, true);
#nullable restore
#line 129 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 8849, hd.MaHD, 8849, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8857, "&page=", 8857, 6, true);
#nullable restore
#line 129 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 8863, t, 8863, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận xóa hóa đơn này ?')"" role=""button"">
                                                                    <span class=""glyphicon glyphicon-trash""></span>Xóa
                                                                </a>
                                                            </td>
                                                        </tr>
");
#nullable restore
#line 134 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                    }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12 text-center"">
                <div class=""pull-right pagination"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02ffb819467b93597fa5862c0b815be279a7fdbf24345", async() => {
                WriteLiteral("\n                        <input type=\"submit\" value=\"Go to\" /> page <input type=\"number\"");
                BeginWriteAttribute("max", " max=\"", 9919, "\"", 9931, 1);
#nullable restore
#line 150 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 9925, pages, 9925, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" name=\"page\"");
                BeginWriteAttribute("value", " value=\"", 9952, "\"", 9962, 1);
#nullable restore
#line 150 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
WriteAttributeValue("", 9960, p, 9960, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> of ");
#nullable restore
#line 150 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\Index.cshtml"
                                                                                                                                     Write(pages);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n    </section>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.HoaDonViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591