#pragma checksum "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_KhachHang\XemKH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f85a0864335dabbacd739d46e00954abcd8c3e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_TT_Views_TT_KhachHang_XemKH), @"mvc.1.0.view", @"/Areas/TT/Views/TT_KhachHang/XemKH.cshtml")]
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
#line 1 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\TT\Views\_ViewImports.cshtml"
using Web_projectframeword_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\TT\Views\_ViewImports.cshtml"
using Web_projectframeword_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f85a0864335dabbacd739d46e00954abcd8c3e1", @"/Areas/TT/Views/TT_KhachHang/XemKH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5921b7841ba6f9e9504d0d750cb3a120e74748a", @"/Areas/TT/Views/_ViewImports.cshtml")]
    public class Areas_TT_Views_TT_KhachHang_XemKH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KhachHang>
    {
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
            WriteLiteral("<div class=\"content-wrapper\" style=\"min-height: 639px;\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f85a0864335dabbacd739d46e00954abcd8c3e13416", async() => {
                WriteLiteral(@"
        <section class=""content-header"">
            <h1><i class=""glyphicon glyphicon-user""></i> Thông tin chi tiết khách hàng</h1>
            <div class=""breadcrumb"">
                <a class=""btn btn-primary btn-sm"" href=""/TT/TT_KhachHang/Index"" role=""button"">
                    <span class=""glyphicon glyphicon-remove do_nos""></span> Thoát
                </a>
            </div>
        </section>
        <!-- Main content -->
        <section class=""content"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""box"" id=""view"">
                        <div class=""box-body"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""col-md-4"" style=""padding-left: 0px;"">
                                        <div class=""form-group"">
                                            <label>Mã khách hàng</label>
                                            <input type=""numbe");
                WriteLiteral("r\" readonly class=\"form-control\" style=\"width:100%\"");
                BeginWriteAttribute("value", " value=\"", 1159, "\"", 1178, 1);
#nullable restore
#line 23 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_KhachHang\XemKH.cshtml"
WriteAttributeValue("", 1167, Model.MaKH, 1167, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" min=""0"" step=""1"" max=""10000000"">
                                        </div>
                                    </div>
                                    <div class=""col-md-8"" style=""padding-right: 0px;"">
                                        <div class=""form-group"">
                                            <label>Tên khách hàng</label>
                                            <input type=""text"" readonly class=""form-control"" style=""width:100%"" placeholder=""Tên khách hàng""");
                BeginWriteAttribute("value", " value=\"", 1669, "\"", 1689, 1);
#nullable restore
#line 29 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_KhachHang\XemKH.cshtml"
WriteAttributeValue("", 1677, Model.TenKH, 1677, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""col-md-5"" style=""padding-left: 0px;"">
                                        <div class=""form-group"">
                                            <label>Số điện thoại</label>
                                            <input type=""text"" readonly class=""form-control"" style=""width:100%"" placeholder=""SĐT khách hàng""");
                BeginWriteAttribute("value", " value=\"", 2322, "\"", 2340, 1);
#nullable restore
#line 39 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_KhachHang\XemKH.cshtml"
WriteAttributeValue("", 2330, Model.SDT, 2330, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>
                                    <div class=""col-md-7"" style=""padding-right: 0px;"">
                                        <div class=""form-group"">
                                            <label>Email</label>
                                            <input type=""text"" readonly class=""form-control"" style=""width:100%"" placeholder=""Email khách hàng""");
                BeginWriteAttribute("value", " value=\"", 2792, "\"", 2812, 1);
#nullable restore
#line 45 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_KhachHang\XemKH.cshtml"
WriteAttributeValue("", 2800, Model.Email, 2800, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""col-md-4"" style=""padding-left: 0px;"">
                                        <div class=""form-group"">
                                            <label>Giới tính</label>
                                            <input type=""text"" readonly class=""form-control"" style=""width:100%"" placeholder=""Giới tính""");
                BeginWriteAttribute("value", " value=\"", 3436, "\"", 3459, 1);
#nullable restore
#line 55 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_KhachHang\XemKH.cshtml"
WriteAttributeValue("", 3444, Model.GioiTinh, 3444, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>
                                    <div class=""col-md-4"">
                                        <div class=""form-group"">
                                            <label>CMND</label>
                                            <input type=""text"" readonly class=""form-control"" style=""width:100%"" placeholder=""CMND khách hàng""");
                BeginWriteAttribute("value", " value=\"", 3881, "\"", 3900, 1);
#nullable restore
#line 61 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_KhachHang\XemKH.cshtml"
WriteAttributeValue("", 3889, Model.CMND, 3889, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>
                                    <div class=""col-md-4"" style=""padding-right: 0px;"">
                                        <div class=""form-group"">
                                            <label>Loại khách hàng</label>
                                            <input type=""text"" readonly class=""form-control"" style=""width:100%"" placeholder=""Loại khách hàng""");
                BeginWriteAttribute("value", " value=\"", 4361, "\"", 4382, 1);
#nullable restore
#line 67 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_KhachHang\XemKH.cshtml"
WriteAttributeValue("", 4369, Model.LoaiKH, 4369, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label>Địa chỉ</label>
                                <input type=""text"" readonly class=""form-control"" style=""width:100%"" placeholder=""Địa Chỉ khách hàng""");
                BeginWriteAttribute("value", " value=\"", 4789, "\"", 4810, 1);
#nullable restore
#line 74 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\TT\Views\TT_KhachHang\XemKH.cshtml"
WriteAttributeValue("", 4797, Model.DiaChi, 4797, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </section>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
