#pragma checksum "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\TinTuc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "014feafb9f8c16ccc362eb75c40dce55487ac8e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_TinTuc_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/TinTuc/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"014feafb9f8c16ccc362eb75c40dce55487ac8e5", @"/Areas/Admin/Views/TinTuc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5921b7841ba6f9e9504d0d750cb3a120e74748a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_TinTuc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.TinTuc>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""content-wrapper"" style=""min-height: 639px;"">
        <section class=""content-header"">
            <h1>
                <i class=""glyphicon glyphicon-book""></i>Danh sách bài viết
            </h1>
            <div class=""breadcrumb"">
                <div class=""searchbox"">
                    <input type=""text"" placeholder=""Search here"">
                    <a><i class=""fas fa-search-location""></i></a>
                </div>
                <a class=""btn btn-primary btn-sm"" href=""/Admin/TinTuc/ThemTinTuc"" role=""button"">
                    <span class=""glyphicon glyphicon-plus""></span>Thêm mới
                </a>
            </div>
        </section>
        <section class=""content"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""box"" id=""view"">
                        <div class=""box-header with-border"">
                            <div class=""box-body"">
                                <div class=""row"" style=""padding:0px; margin:0px;"">
 ");
            WriteLiteral(@"                                   <div class=""table-responsive"">
                                        <table class=""table table-hover table-bordered"">
                                            <thead>
                                                <tr>
                                                    <th class=""text-center"">ID</th>
                                                    <th class=""text-center"" style=""width:100px;"">Hình</th>
                                                    <th class=""text-center"">Tiêu đề bài viết</th>
                                                   
                                                    <th class=""text-center"">Trạng thái</th>
                                                    <th class=""text-center"" colspan=""2"">Thao tác</th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 38 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\TinTuc\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\n                                                        <td class=\"text-center\">");
#nullable restore
#line 41 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\TinTuc\Index.cshtml"
                                                                           Write(item.matintuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                        <td>\n                                                            <img");
            BeginWriteAttribute("src", " src=\"", 2448, "\"", 2467, 1);
#nullable restore
#line 43 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\TinTuc\Index.cshtml"
WriteAttributeValue("", 2454, item.hinhbia, 2454, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2468, "\"", 2474, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                                        </td>\n                                                        <td> ");
#nullable restore
#line 45 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\TinTuc\Index.cshtml"
                                                        Write(item.tieude);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                                                        \n");
#nullable restore
#line 47 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\TinTuc\Index.cshtml"
                                                         if(@item.trangthai == 1) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td class=\"text-center\">\n                                                                <a");
            BeginWriteAttribute("href", " href=\"", 2911, "\"", 2918, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                    <span class=""glyphicon glyphicon-ok-circle mauxanh18""></span>
                                                                </a>
                                                            </td>
");
#nullable restore
#line 53 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\TinTuc\Index.cshtml"
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td class=\"text-center\">\n                                                                <a");
            BeginWriteAttribute("href", " href=\"", 3514, "\"", 3521, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                    <span class=""glyphicon glyphicon-remove-circle maudo""></span>
                                                                </a>
                                                            </td>
");
#nullable restore
#line 61 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\TinTuc\Index.cshtml"
                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td class=\"text-center\">\n                                                            <a class=\"btn btn-success btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 4022, "\"", 4070, 2);
            WriteAttributeValue("", 4029, "/Admin/TinTuc/SuaTinTuc?id=", 4029, 27, true);
#nullable restore
#line 63 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\TinTuc\Index.cshtml"
WriteAttributeValue("", 4056, item.matintuc, 4056, 14, false);

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
            BeginWriteAttribute("href", " href=\"", 4501, "\"", 4545, 2);
            WriteAttributeValue("", 4508, "/Admin/TinTuc/Index?id=", 4508, 23, true);
#nullable restore
#line 68 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\TinTuc\Index.cshtml"
WriteAttributeValue("", 4531, item.matintuc, 4531, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận xóa bài này ?')"" role=""button"">
                                                                <span class=""glyphicon glyphicon-trash""></span>Xóa
                                                            </a>
                                                        </td>
                                                    </tr>
");
#nullable restore
#line 73 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\TinTuc\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.TinTuc>> Html { get; private set; }
    }
}
#pragma warning restore 1591
