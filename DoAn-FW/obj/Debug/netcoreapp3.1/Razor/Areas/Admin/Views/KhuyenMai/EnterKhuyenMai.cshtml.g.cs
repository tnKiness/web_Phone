#pragma checksum "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\KhuyenMai\EnterKhuyenMai.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "379d3c1d126e68184067abe8b15eee8654dce2fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_KhuyenMai_EnterKhuyenMai), @"mvc.1.0.view", @"/Areas/Admin/Views/KhuyenMai/EnterKhuyenMai.cshtml")]
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
#line 1 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\Admin\Views\KhuyenMai\EnterKhuyenMai.cshtml"
using Web_projectframeword_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"379d3c1d126e68184067abe8b15eee8654dce2fe", @"/Areas/Admin/Views/KhuyenMai/EnterKhuyenMai.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5921b7841ba6f9e9504d0d750cb3a120e74748a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_KhuyenMai_EnterKhuyenMai : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KhuyenMai>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/KhuyenMai/InsertKhuyenMai"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    <div class=\"content-wrapper\" style=\"min-height: 639px;\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "379d3c1d126e68184067abe8b15eee8654dce2fe4290", async() => {
                WriteLiteral(@"
            <section class=""content-header"">
                <h1><i class=""glyphicon glyphicon-leaf""></i> Thêm khuyến mãi mới</h1>
                <div class=""breadcrumb"">
                    <a class=""btn btn-primary btn-sm"" href=""/Admin/KhuyenMai/InsertKhuyenMai"">
                        Insert
                        <button type=""submit"" style=""width: 50px; height: 25px; background-color: darkcyan; border-radius: 10px; color: white; border-color: white; "">
                            <i class=""glyphicon glyphicon-floppy-save""></i>
                        </button>
                    </a>
                    <a class=""btn btn-primary btn-sm"" href=""/Admin/KhuyenMai/LietKeSanPham"" role=""button"">
                        <span class=""glyphicon glyphicon-remove do_nos""></span> Thoát
                    </a>
                </div>
            </section>
            <!-- Main content -->
            <section class=""content"">
                <div class=""row"">
                    <div class=""col-md-12"">
         ");
                WriteLiteral(@"               <div class=""box"" id=""view"">
                            <div class=""box-body"">
                                <div class=""col-md-12"">
                                    <div class=""col-md-6"" style=""padding-left: 0px;"">
                                        <div class=""form-group"">
                                            <label for=""maKM"">Mã khuyến mãi</label>
                                            <input type=""number"" class=""form-control"" name=""MaKM"" min=""0"" step=""1"" max=""100"" style=""width:100%"">
                                        </div>
                                    </div>
                                    <div class=""col-md-6"" style=""padding-right: 0px;"">
                                        <div class=""form-group"">
                                            <label for=""soPTKM"">Số % khuyến mãi</label>
                                            <input type=""number"" class=""form-control"" name=""SoPTKM"" min=""0"" style=""width:100%"">
                                    ");
                WriteLiteral(@"    </div>
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""col-md-6"" style=""padding-left: 0px;"">
                                        <div class=""form-group"">
                                            <label for=""tuNgay"">Ngày bắt đầu</label>
                                            <input type=""date"" class=""form-control"" name=""TuNgay"" style=""width:100%"">
                                        </div>
                                    </div>
                                    <div class=""col-md-6"" style=""padding-right: 0px;"">
                                        <div class=""form-group"">
                                            <label for=""denNgay"">Ngày kết thúc</label>
                                            <input type=""date"" class=""form-control"" name=""DenNgay"" style=""width:100%"">
                                        </div>
                          ");
                WriteLiteral(@"          </div>
                                </div>
                                <div class=""col-md-12"">
                                    <div class=""col-md-6"" style=""padding-left: 0px;"">
                                        <div class=""form-group"">
                                            <label for=""ttienToiThieu"">Số tiền tối thiểu</label>
                                            <input type=""number"" class=""form-control"" name=""TTienToiThieu"" min=""0"" step=""5000"" style=""width:100%"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <label>Sản phẩm được giảm giá</label><br>
                                    <input type=""checkbox"" name=""AllSP"">
                                    <label for=""ALLSP"" style=""font-weight:400;"">Tất cả sản phẩm</label>
                                    <select name=""SPGG"" class=""form-group"" st");
                WriteLiteral("yle=\"width:100%\"");
                BeginWriteAttribute("multiple", " multiple=\"", 4305, "\"", 4316, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "379d3c1d126e68184067abe8b15eee8654dce2fe9153", async() => {
                    WriteLiteral("Iphone 13 Pro Max");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "379d3c1d126e68184067abe8b15eee8654dce2fe10216", async() => {
                    WriteLiteral("Iphone 12 Pro Max");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    </select>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </section>\n        ");
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
            WriteLiteral("\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KhuyenMai> Html { get; private set; }
    }
}
#pragma warning restore 1591
