#pragma checksum "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\GH_ThongKe\DSKH.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "580bafa5347ade24d06b54de9cfcb032a9008ee8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_GH_Views_GH_ThongKe_DSKH), @"mvc.1.0.view", @"/Areas/GH/Views/GH_ThongKe/DSKH.cshtml")]
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
#line 1 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\_ViewImports.cshtml"
using Web_projectframeword_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\_ViewImports.cshtml"
using Web_projectframeword_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"580bafa5347ade24d06b54de9cfcb032a9008ee8", @"/Areas/GH/Views/GH_ThongKe/DSKH.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5921b7841ba6f9e9504d0d750cb3a120e74748a", @"/Areas/GH/Views/_ViewImports.cshtml")]
    public class Areas_GH_Views_GH_ThongKe_DSKH : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<object>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/GH/GH_ThongKe/DSKH"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\GH_ThongKe\DSKH.cshtml"
   int stt = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"" style=""min-height: 639px;"">
    <section class=""content"">
        <!-- Small boxes (Stat box) -->
        <div class=""row"">
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-aqua"">
                    <div class=""inner"">
                        <h3>1</h3>
                        <p>Khách hàng</p>
                        <div class=""icon"">
                            <i class=""ion ion-cash""></i>
                        </div>
                    </div>
                    <a href=""/GH/GH_ThongKe/DSKH"" class=""small-box-footer"">Các khách hàng mua nhiều nhất</a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-green"">
                    <div class=""inner"">
                        <h3>2</h3>
                        <p>Sản phẩm</p>
                    </div>
                    <");
            WriteLiteral(@"div class=""icon"">
                        <i class=""ion ion-stats-bars""></i>
                    </div>
                    <a href=""/GH/GH_ThongKe/DSSP"" class=""small-box-footer"">Những sản phẩm bán chạy nhất</a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-yellow"">
                    <div class=""inner"">
                        <h3>3</h3>
                        <p>Nhân viên</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-person""></i>
                    </div>
                    <a");
            BeginWriteAttribute("href", " href=\"", 1758, "\"", 1765, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""small-box-footer"" style=""height:26px""></a>
                </div>
            </div>
            <!-- ./col -->
            <div class=""col-lg-3 col-xs-6"">
                <!-- small box -->
                <div class=""small-box bg-red"">
                    <div class=""inner"">
                        <h3>4</h3>
                        <p>Nhà cung cấp</p>
                    </div>
                    <div class=""icon"">
                        <i class=""ion ion-pie-graph""></i>
                    </div>
                    <a href=""/GH/GH_ThongKe/ChiPhi"" class=""small-box-footer"">Thống kê mua hàng & chi phí</a>
                </div>
            </div>
            <!-- ./col -->
        </div>
        <!-- /.row -->
    </section>
    <!-- /.Data -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""box"" id=""view"">
                    <div class=""box-header with-border"">
                        <div class=""box-body"">
                 ");
            WriteLiteral(@"           <div class=""row"" style=""padding:0px; margin:0px;"">
                                <div class=""table-responsive"">
                                    <div class=""box-header with-border"">
                                        <h3 class=""fa fa-chart-bar""> Top 3 khách hàng</h3>
                                        <div class=""bread_crumb"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "580bafa5347ade24d06b54de9cfcb032a9008ee87621", async() => {
                WriteLiteral("\n                                                <label for=\"chooseyear\">Chọn năm thống kê: </label>\n                                                <input type=\"number\" id=\"chooseyear\" name=\"y\" min=\"2021\"");
                BeginWriteAttribute("value", " value=\"", 3443, "\"", 3463, 1);
#nullable restore
#line 80 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\GH_ThongKe\DSKH.cshtml"
WriteAttributeValue("", 3451, ViewBag.Nam, 3451, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n                                                <input class=\"btn-success\" type=\"submit\" value=\"Xem thống kê\">\n                                            ");
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
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <table class=""table table-hover table-bordered"">
                                        <thead>
                                            <tr>
                                                <th class=""text-center"">STT</th>
                                                <th>Mã KH</th>
                                                <th>Tên Khách hàng</th>
                                                <th>Tổng tiền</th>
                                            </tr>
                                        </thead>
                                        <tbody>

");
#nullable restore
#line 96 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\GH_ThongKe\DSKH.cshtml"
                                             if (Model.Count() > 0)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\GH_ThongKe\DSKH.cshtml"
                                                 foreach (var item in Model)
                                                {
                                                     stt += 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\n                                                        <td class=\"text-center\">");
#nullable restore
#line 102 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\GH_ThongKe\DSKH.cshtml"
                                                                           Write(stt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                        <td>");
#nullable restore
#line 103 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\GH_ThongKe\DSKH.cshtml"
                                                       Write(item.GetType().GetProperty("MaKH").GetValue(item, null).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                        <td>");
#nullable restore
#line 104 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\GH_ThongKe\DSKH.cshtml"
                                                       Write(item.GetType().GetProperty("TenKH").GetValue(item, null).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                        <td>");
#nullable restore
#line 105 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\GH_ThongKe\DSKH.cshtml"
                                                       Write(string.Format("{0:0,0}", @item.GetType().GetProperty("TongTien").GetValue(item, null)));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</td>\n                                                    </tr>\n");
#nullable restore
#line 107 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\GH_ThongKe\DSKH.cshtml"

                                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Web_Project\PhoneStore-main\Soure\DoAn-FW\DoAn-FW\Areas\GH\Views\GH_ThongKe\DSKH.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<object>> Html { get; private set; }
    }
}
#pragma warning restore 1591
