#pragma checksum "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "128ab7512622260790922939d6d59998b122a996"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_KhachHang_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/KhachHang/Index.cshtml")]
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
#line 1 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\_ViewImports.cshtml"
using Web_projectframeword_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\_ViewImports.cshtml"
using Web_projectframeword_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"128ab7512622260790922939d6d59998b122a996", @"/Areas/Admin/Views/KhachHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13ac08b6395ba83e3e81f8ac123db1ca5d7d26c3", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_KhachHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.KhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/KhachHang/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
   int pages = Convert.ToInt32(ViewData["pages"]); int p = Convert.ToInt32(ViewData["page"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content-wrapper\" style=\"min-height: 639px;\">\r\n    <section class=\"content-header\">\r\n        <h1>\r\n            <i class=\"glyphicon glyphicon-user\"></i>Danh sách khách hàng\r\n        </h1>\r\n        <div class=\"breadcrumb\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "128ab7512622260790922939d6d59998b122a9964988", async() => {
                WriteLiteral(@"
                <input type=""text"" placeholder=""Search here"" name=""ID"">
                <button type=""submit"" style=""width: 50px; height: 25px; background-color: darkcyan; border-radius: 10px; color: white; border-color: white; "">
                    <i class=""fas fa-search-location""></i>
                </button>
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
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n    <section class=\"content\">\r\n");
#nullable restore
#line 18 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
          
            if (Convert.ToString(ViewData["trangthai"]) == "Xóa không thành công")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"alert alert-error\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                   Write(ViewData["trangthai"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 27 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
            }
            if (Convert.ToString(ViewData["trangthai"]) == "Xóa thành công")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"alert alert-success\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                   Write(ViewData["trangthai"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 36 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
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
                                                <th class=""text-center"">Mã KH</th>
                                                <th>Tên khách hàng</th>
                                                <th class=""text-center"">SĐT</th>
                                                <th>Địa chỉ</th>
                                                <th>Loại khách</th>
                                                <th class=""text-center"" colspan=""2"">Thao tác</th>
       ");
            WriteLiteral("                                     </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 57 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                                              
                                                int a = Convert.ToInt32(ViewData["ThongBao"]);
                                                if (a == 1)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr><td class=\"text-center\" colspan=\"7\">Không tìm thấy khách hàng nào!</td></tr>\r\n");
#nullable restore
#line 62 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                                                }
                                                else
                                                {
                                                    foreach (var item in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                            <td class=\"text-center\">");
#nullable restore
#line 68 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                                                                               Write(item.MaKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 69 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                                                           Write(item.TenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td class=\"text-center\">");
#nullable restore
#line 70 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                                                                               Write(item.SDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 71 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                                                           Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 72 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                                                           Write(item.LoaiKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td class=\"text-center\">\r\n                                                                <a class=\"btn btn-info btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 4268, "\"", 4311, 2);
            WriteAttributeValue("", 4275, "/Admin/KhachHang/XemKH?ID=", 4275, 26, true);
#nullable restore
#line 74 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 4301, item.MaKH, 4301, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">
                                                                    <span class=""glyphicon glyphicon-eye-open""></span>Xem
                                                                </a>
                                                            </td>
                                                            <td class=""text-center"">
");
#nullable restore
#line 79 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                                                                  var t = (Model.Count() == 1) ? (p - 1) : p;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <a class=\"btn btn-danger btn-xs\"");
            BeginWriteAttribute("href", " href=\"", 4883, "\"", 4933, 4);
            WriteAttributeValue("", 4890, "/Admin/KhachHang/Xoa?ID=", 4890, 24, true);
#nullable restore
#line 80 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 4914, item.MaKH, 4914, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4924, "&&page=", 4924, 7, true);
#nullable restore
#line 80 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 4931, t, 4931, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onclick=""return confirm('Xác nhận xóa khách hàng này ?')"" role=""button"">
                                                                    <span class=""glyphicon glyphicon-trash""></span>Xóa
                                                                </a>
                                                            </td>
                                                        </tr>
");
#nullable restore
#line 85 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                                                    }
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "128ab7512622260790922939d6d59998b122a99616824", async() => {
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Go to\" /> page <input type=\"number\"");
                BeginWriteAttribute("max", " max=\"", 6065, "\"", 6077, 1);
#nullable restore
#line 102 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 6071, pages, 6071, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" min=\"1\" name=\"page\"");
                BeginWriteAttribute("value", " value=\"", 6098, "\"", 6108, 1);
#nullable restore
#line 102 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 6106, p, 6106, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> of ");
#nullable restore
#line 102 "C:\Users\Admin1\Downloads\web_Phone_ver0.0.2\web_Phone\DoAn-FW\Areas\Admin\Views\KhachHang\Index.cshtml"
                                                                                                                                     Write(pages);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.KhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
