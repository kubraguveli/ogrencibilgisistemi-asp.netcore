#pragma checksum "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8681d6cda7e7a5d599fcb77a07968c5b3023893"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
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
#line 1 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
using StajUygulama2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8681d6cda7e7a5d599fcb77a07968c5b3023893", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f4e4b9013aeeb2cfbe50ad7ee31e2652cd15f3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StajUygulama2.Models.OgrenciBilgi>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("filter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #204E5F;color: white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(85, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(127, 228, true);
            WriteLiteral("<div class=\"container\">\r\n    <br />\r\n    <h3 class=\" text-white p-3\" style=\"background-color: #204E5F;\">Öğrenci Bilgi Sistemi</h3>\r\n\r\n    <div class=\"card m-2\">\r\n        <div class=\"card-body\" style=\"width:500px;\">\r\n            ");
            EndContext();
            BeginContext(355, 702, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc15668436a14cbda9a5392abd425352", async() => {
                BeginContext(386, 133, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <input name=\"ogrencino\" class=\"form-control\" placeholder=\"Ogrenci No\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 519, "\"", 545, 1);
#line 15 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
WriteAttributeValue("", 527, ViewBag.OgrenciNo, 527, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(546, 148, true);
                WriteLiteral(" />\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <input name=\"ad\" class=\"form-control\" placeholder=\"Adı\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 694, "\"", 713, 1);
#line 19 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
WriteAttributeValue("", 702, ViewBag.Ad, 702, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(714, 154, true);
                WriteLiteral(" />\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <input name=\"soyad\" class=\"form-control\" placeholder=\"Soyadı\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 868, "\"", 890, 1);
#line 23 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
WriteAttributeValue("", 876, ViewBag.Soyad, 876, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(891, 159, true);
                WriteLiteral(" />\r\n                </div>\r\n                <button class=\"btn\" style=\"background-color: #204E5F; color:white;\"><strong>Filter</strong></button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1057, 447, true);
            WriteLiteral(@"
        </div>
    </div>

    <table class=""table table-bordered table-striped"" m-5>
        <thead>
            <tr>
                <th>Kodu</th>
                <th>Ad</th>
                <th>Soyad</th>
                <th>Öğrenci Numarası</th>
                <th>E-posta</th>
                <th>Telefon</th>
                <th>Adres</th>
                <th></th>

            </tr>
        </thead>

        <tbody>
");
            EndContext();
#line 46 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
             foreach (var item in Model)
            {
                if (item.SilinmeTarihi == null)
                {

#line default
#line hidden
            BeginContext(1629, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1684, 7, false);
#line 51 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1691, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1727, 7, false);
#line 52 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
                       Write(item.Ad);

#line default
#line hidden
            EndContext();
            BeginContext(1734, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1770, 10, false);
#line 53 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
                       Write(item.Soyad);

#line default
#line hidden
            EndContext();
            BeginContext(1780, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1816, 31, false);
#line 54 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
                       Write(item.OgrenciOkulBilgi.OgrenciNo);

#line default
#line hidden
            EndContext();
            BeginContext(1847, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1883, 29, false);
#line 55 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
                       Write(item.OgrenciAdresBilgi.Eposta);

#line default
#line hidden
            EndContext();
            BeginContext(1912, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1948, 31, false);
#line 56 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
                       Write(item.OgrenciAdresBilgi.Telefon1);

#line default
#line hidden
            EndContext();
            BeginContext(1979, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2015, 29, false);
#line 57 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
                       Write(item.OgrenciAdresBilgi.Adres1);

#line default
#line hidden
            EndContext();
            BeginContext(2044, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2109, 384, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43d45b14d14a4377a604b9427bd2bfc9", async() => {
                BeginContext(2149, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2183, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "854c4f84f0534791bd63ac4146614f9b", async() => {
                    BeginContext(2261, 6, true);
                    WriteLiteral("Update");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 60 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
                                                         WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2271, 64, true);
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2335, "\"", 2351, 1);
#line 61 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
WriteAttributeValue("", 2343, item.Id, 2343, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2352, 134, true);
                WriteLiteral(" />\r\n                                <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2493, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 66 "C:\Users\kubraguveli\source\repos\StajUygulama2\StajUygulama2\Views\Home\List.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2587, 36, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            EndContext();
            BeginContext(2623, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0bf727c564c48d8b9d87f1beebd3eb0", async() => {
                BeginContext(2706, 43, true);
                WriteLiteral("\r\n        <strong>Yeni Kayıt</strong>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2753, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StajUygulama2.Models.OgrenciBilgi>> Html { get; private set; }
    }
}
#pragma warning restore 1591
