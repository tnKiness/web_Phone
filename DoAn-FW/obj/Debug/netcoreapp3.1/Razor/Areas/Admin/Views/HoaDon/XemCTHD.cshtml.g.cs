#pragma checksum "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e60436e1ff20215b4bbfcbadafd61eb7194f2683"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HoaDon_XemCTHD), @"mvc.1.0.view", @"/Areas/Admin/Views/HoaDon/XemCTHD.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e60436e1ff20215b4bbfcbadafd61eb7194f2683", @"/Areas/Admin/Views/HoaDon/XemCTHD.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5921b7841ba6f9e9504d0d750cb3a120e74748a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_HoaDon_XemCTHD : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web_projectframeword_admin.Models.CTHD>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("InsertCTHD"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Click_CTHD", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $('#tbl_cthd tr').click(function (e) {
                var masp = $(this).closest('.onRow').find('td:nth-child(1)').text();
                var sl = $(this).closest('.onRow').find('td:nth-child(3)').text();
                $('#spSL').val(masp);
                $('#slIP').val(sl);
            });
        });
    </script>
");
            }
            );
            WriteLiteral("<div class=\"content-wrapper\" style=\"min-height: 639px;\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e60436e1ff20215b4bbfcbadafd61eb7194f26835049", async() => {
                WriteLiteral(@"
        <section class=""content-header"">
            <h1><i class=""glyphicon glyphicon-ok-sign""></i>Chi tiết hóa đơn</h1>
            <div class=""breadcrumb"">
                <a class=""btn btn-primary btn-sm"" href=""/Admin/HoaDon/Index"" role=""button"">
                    <span class=""glyphicon glyphicon-floppy-save""></span>Lưu
                </a>
            </div>
        </section>
        <section class=""content"">
");
#nullable restore
#line 25 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
              
                if (Convert.ToString(ViewData["thongbao"]) == "Vui lòng chọn sản phẩm và số lượng" || Convert.ToString(ViewData["thongbao"]) == "Thêm thất bại")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"row\">\n                        <div class=\"alert alert-error\">\n                            ");
#nullable restore
#line 30 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                       Write(ViewData["thongbao"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\n                        </div>\n                    </div>\n");
#nullable restore
#line 34 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                }
                if (Convert.ToString(ViewData["thongbao"]) == "Thêm thành công")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"row\">\n                        <div class=\"alert alert-success\">\n                            ");
#nullable restore
#line 39 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                       Write(ViewData["thongbao"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\n                        </div>\n                    </div>\n");
#nullable restore
#line 43 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
              
                if (Convert.ToString(ViewData["trangthai"]) == "Xóa không thành công")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"row\">\n                        <div class=\"alert alert-error\">\n                            ");
#nullable restore
#line 50 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                       Write(ViewData["trangthai"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\n                        </div>\n                    </div>\n");
#nullable restore
#line 54 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                }
                if (Convert.ToString(ViewData["trangthai"]) == "Xóa thành công")
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"row\">\n                        <div class=\"alert alert-success\">\n                            ");
#nullable restore
#line 59 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                       Write(ViewData["trangthai"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">×</button>\n                        </div>\n                    </div>\n");
#nullable restore
#line 63 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                }
            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""row"">
                <div class=""col-md-12"">
                    <span style=""font-size: 16px; font-weight: 700;"">Chi tiết hóa đơn</span>
                    <div class=""box"" id=""view"">
                        <div class=""box-body"">
                            <div class=""col-md-12"" style=""border-right:ridge"">
                                <div class=""form-group"">
                                    <div class=""col-md-6"">
                                        <label>Sản phẩm</label>
                                        <select class=""form-group"" style=""width:100%"" onchange=""return LoadMASP(this)"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e60436e1ff20215b4bbfcbadafd61eb7194f268310591", async() => {
                    WriteLiteral("[----Xem danh sách sản phẩm----]");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 76 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                                             foreach (var item in ViewBag.DSSP)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e60436e1ff20215b4bbfcbadafd61eb7194f268312222", async() => {
#nullable restore
#line 78 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                                                                        Write(item.MATTSP);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" - ");
#nullable restore
#line 78 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                                                                                       Write(item.TENSP);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                                                   WriteLiteral(item.MATTSP);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 79 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </select>
                                    </div>
                                    <div class=""col-md-5"">
                                        <div class=""col-md-6"">
                                            <label>Mã sản phẩm</label>
                                            <input type=""hidden"" class=""form-control"" name=""MaHD"" min=""0"" step=""1"" style=""width: 100%; margin-bottom: 10px;""");
                BeginWriteAttribute("value", " value=\"", 4353, "\"", 4378, 1);
#nullable restore
#line 85 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
WriteAttributeValue("", 4361, ViewData["mahd"], 4361, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            <input type=""number"" class=""form-control"" id=""spSL"" name=""MaSP"" min=""0"" step=""1"" style=""width: 100%; margin-bottom: 10px;"" value=""0"">
                                        </div>
                                        <div class=""col-md-6"">
                                            <label>Số lượng</label>
                                            <input type=""number"" class=""form-control"" id=""slIP"" name=""SoLuong"" min=""0"" step=""1"" style=""width:100%; margin-bottom: 10px;"" value=""0"">
                                        </div>

                                    </div>
                                    <div class=""col-md-1"" style=""padding-right: 0px; padding-top: 25px;"">
                                        <button class=""btn btn-primary btn-sm"">
                                            <span class=""glyphicon glyphicon-plus""></span>Thêm
                                        </button>
                                    </div>

                    ");
                WriteLiteral(@"            </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""row"" style=""padding:0px; margin:0px;"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-hover table-bordered"" id=""tbl_cthd"">
                                            <thead>
                                                <tr>
                                                    <th class=""text-center"">Mã SP</th>
                                                    <th>Tên sản phẩm</th>
                                                    <th class=""text-center"">Số lượng</th>
                                                    <th class=""text-center"">Thành tiền</th>
                                                    <th class=""text-center"">Thao tác</th>
                                                </tr>
                                            </thead>
                    ");
                WriteLiteral("                        <tbody>\n");
#nullable restore
#line 116 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <tr class=\"onRow\">\n                                                        <td class=\"text-center\">");
#nullable restore
#line 119 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                                                                           Write(item.MaSP);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                        <td>");
#nullable restore
#line 120 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                                                       Write(item.TenSP);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                        <td class=\"text-center\">");
#nullable restore
#line 121 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                                                                           Write(item.SoLuong);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                        <td class=\"text-center\">");
#nullable restore
#line 122 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                                                                           Write(item.ThanhTien);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                                                        <td class=\"text-center\">\n                                                            <a class=\"btn btn-danger btn-xs\"");
                BeginWriteAttribute("href", " href=\"", 7203, "\"", 7266, 4);
                WriteAttributeValue("", 7210, "/Admin/HoaDon/DeleteCTHD?MAHD=", 7210, 30, true);
#nullable restore
#line 124 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
WriteAttributeValue("", 7240, item.MaHD, 7240, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7250, "&MASP=", 7250, 6, true);
#nullable restore
#line 124 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
WriteAttributeValue("", 7256, item.MaSP, 7256, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" onclick=""return confirm('Xác nhận xóa ?')"" role=""button"">
                                                                <span class=""glyphicon glyphicon-trash""></span>Xóa
                                                            </a>
                                                        </td>
                                                    </tr>
");
#nullable restore
#line 129 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\HoaDon\XemCTHD.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    ");
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
            WriteLiteral("\n</div>\n<script type=\"text/javascript\">\n    function LoadMASP(obj) {\n        var masp = obj.value;\n        document.getElementById(\"spSL\").value = masp;\n    }\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web_projectframeword_admin.Models.CTHD>> Html { get; private set; }
    }
}
#pragma warning restore 1591
