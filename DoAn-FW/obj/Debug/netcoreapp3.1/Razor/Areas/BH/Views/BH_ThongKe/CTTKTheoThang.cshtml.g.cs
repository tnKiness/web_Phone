#pragma checksum "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_ThongKe\CTTKTheoThang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03694f393595ceecc822eb0b04639ffff955f49b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BH_Views_BH_ThongKe_CTTKTheoThang), @"mvc.1.0.view", @"/Areas/BH/Views/BH_ThongKe/CTTKTheoThang.cshtml")]
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
#line 1 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\_ViewImports.cshtml"
using Web_projectframeword_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\_ViewImports.cshtml"
using Web_projectframeword_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03694f393595ceecc822eb0b04639ffff955f49b", @"/Areas/BH/Views/BH_ThongKe/CTTKTheoThang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5921b7841ba6f9e9504d0d750cb3a120e74748a", @"/Areas/BH/Views/_ViewImports.cshtml")]
    public class Areas_BH_Views_BH_ThongKe_CTTKTheoThang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.HoaDon>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"content-wrapper\" style=\"min-height: 639px;\">\n        <section class=\"content-header\">\n            <h1>\n                <i class=\"glyphicon glyphicon-ok-sign\"></i>Danh sách hóa đơn tháng ");
#nullable restore
#line 6 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_ThongKe\CTTKTheoThang.cshtml"
                                                                              Write(ViewBag.Thang);

#line default
#line hidden
#nullable disable
            WriteLiteral(" năm ");
#nullable restore
#line 6 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_ThongKe\CTTKTheoThang.cshtml"
                                                                                                 Write(ViewBag.Nam);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h1>
            <div class=""breadcrumb"">
                <div class=""searchbox"">
                    <input type=""text"" placeholder=""Search here"">
                    <a><i class=""fas fa-search-location""></i></a>
                </div>
            </div>
        </section>
        <section class=""content"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""box"" id=""view"">
                        <div class=""box-header with-border"">
                            <div class=""box-body"">
                                <div class=""row"" style=""padding:0px; margin:0px;"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-hover table-bordered"">
                                            <thead>
                                                <tr>
                                                    <th class=""text-center"">Mã PN</th>
                                        ");
            WriteLiteral(@"            <th>Nhà cung cấp</th>
                                                    <th>Tổng tiền</th>
                                                    <th>Ngày lập PN</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 33 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_ThongKe\CTTKTheoThang.cshtml"
                                              if (Model.Count() > 0)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_ThongKe\CTTKTheoThang.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\n                                                        <td class=\"text-center\">");
#nullable restore
#line 38 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_ThongKe\CTTKTheoThang.cshtml"
                                                                           Write(item.MaHD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                        <td>");
#nullable restore
#line 39 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_ThongKe\CTTKTheoThang.cshtml"
                                                       Write(item.TenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                        <td>");
#nullable restore
#line 40 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_ThongKe\CTTKTheoThang.cshtml"
                                                       Write(string.Format("{0:0,0}", @item.TongTienTT));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\n                                                        <td>");
#nullable restore
#line 41 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_ThongKe\CTTKTheoThang.cshtml"
                                                       Write(item.NgayLapHD.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    </tr>\n");
#nullable restore
#line 43 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_ThongKe\CTTKTheoThang.cshtml"

                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_ThongKe\CTTKTheoThang.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-md-12 text-center"">
                                            <ul class=""pagination"">
                                            </ul>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.HoaDon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
