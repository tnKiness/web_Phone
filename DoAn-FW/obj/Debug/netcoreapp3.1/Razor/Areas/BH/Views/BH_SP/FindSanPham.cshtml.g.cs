#pragma checksum "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6d0d58a6fadccd9719ba9c60b2066b30094df7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_BH_Views_BH_SP_FindSanPham), @"mvc.1.0.view", @"/Areas/BH/Views/BH_SP/FindSanPham.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6d0d58a6fadccd9719ba9c60b2066b30094df7e", @"/Areas/BH/Views/BH_SP/FindSanPham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5921b7841ba6f9e9504d0d750cb3a120e74748a", @"/Areas/BH/Views/_ViewImports.cshtml")]
    public class Areas_BH_Views_BH_SP_FindSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.SanPham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""content-wrapper"" style=""min-height: 639px;"">
        <section class=""content-header"">
            <h1>
                <i class=""glyphicon glyphicon-phone""></i>Danh sách sản phẩm
            </h1>
        </section>
        <section class=""content"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""box"" id=""view"">
                        <div class=""box-header with-border"">
                            <div class=""box-body"">
                                <div class=""row"" style=""padding:0px; margin:0px; height: 1000px;"">
                                    <div class=""table-responsive"">
");
#nullable restore
#line 17 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
                                         if (Model.Any())
                                         { 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                         <table class=""table table-hover table-bordered"">
                                            <thead>
                                                <tr>
                                                    <th class=""text-center"" style=""width:70px"">Mã TTSP</th>
                                                    <th>Tên sản phẩm</th>
                                                    <th>Hình ảnh</th>
                                                    <th>Loại sản phẩm</th>
                                                    <th>Thương hiệu</th>
                                                    <th>Số lượng</th>
                                                    <th class=""text-center"" colspan=""2"">Thao tác</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 32 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\n                                                        <td class=\"text-center\">");
#nullable restore
#line 35 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
                                                                           Write(item.MATTSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                        <td style=\"font-size: 16px;\">");
#nullable restore
#line 36 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
                                                                                Write(item.TENSP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                        <td style=\"width:120px\">\n                                                            <img");
            BeginWriteAttribute("src", " src=\"", 2284, "\"", 2303, 1);
#nullable restore
#line 38 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
WriteAttributeValue("", 2290, item.HINHANH, 2290, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Điện thoại Iphone 13 ProMax\" class=\"img-responsive\">\n                                                        </td>\n                                                        <td>");
#nullable restore
#line 40 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
                                                       Write(item.MALOAISP);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                        <td>");
#nullable restore
#line 41 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
                                                       Write(item.MATH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                        <td>");
#nullable restore
#line 42 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
                                                       Write(item.SOLUONG);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                        <td class=\"text-center\">\n                                                            <a class=\"btn btn-success btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 2834, "\"", 2878, 2);
            WriteAttributeValue("", 2841, "/BH/BH_SP/ViewSanPham?Id=", 2841, 25, true);
#nullable restore
#line 44 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
WriteAttributeValue("", 2866, item.MATTSP, 2866, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">
                                                                <span class=""glyphicon glyphicon-edit""></span>Sửa
                                                            </a>
                                                        </td>
                                                        <td class=""text-center"">
                                                            <a class=""btn btn-danger btn-xs""");
            BeginWriteAttribute("href", " href=\"", 3309, "\"", 3355, 2);
            WriteAttributeValue("", 3316, "/BH/BH_SP/DeleteSanPham?Id=", 3316, 27, true);
#nullable restore
#line 49 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
WriteAttributeValue("", 3343, item.MATTSP, 3343, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" Sonclick=""return confirm('Xác nhận xóa sản phẩm này ?')"" role=""button"">
                                                                <span class=""glyphicon glyphicon-trash""></span>Xóa
                                                            </a>
                                                        </td>
                                                    </tr>
");
#nullable restore
#line 54 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </tbody>\n                                         </table>\n");
#nullable restore
#line 57 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <p>Không tìm thấy sản phẩm</p>\n");
#nullable restore
#line 61 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\BH\Views\BH_SP\FindSanPham.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </section>\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
