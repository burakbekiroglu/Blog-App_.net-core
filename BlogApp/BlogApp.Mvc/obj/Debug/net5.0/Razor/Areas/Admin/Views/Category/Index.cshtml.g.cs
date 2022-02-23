#pragma checksum "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e883280e846847824842f94cc3aa41319eaa821"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 2 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
using BlogApp.Shared.Utilities.Results.ComplexTypes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e883280e846847824842f94cc3aa41319eaa821", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogApp.Entities.Dtos.CategoryListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/categoryIndex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("application/ecmascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Kategoriler Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Success)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""modalPlaceHolder"" aria-hidden=""true""></div>
    <div class=""card mb-4 mt-2"">
        <div class=""card-header"">
            <i class=""fas fa-table mr-1""></i>
            Kategoriler
        </div>
        <div class=""card-body"">
            <div class=""spinner-border"" role=""status"" style=""display:none;"">
                <span class=""sr-only"">Yükleniyor...</span>
            </div>
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""categoriesTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Adı</th>
                            <th>Açıklaması</th>
                            <th>Aktif Mi?</th>
                            <th>Silinmiş Mi?</th>
                            <th>Not</th>
                            <th>Oluşturulma Tarihi</th>
                            <th>Oluşturan Kullanıcı Adı</th>
                   ");
            WriteLiteral(@"         <th>Son Düzenlenme Tarihi</th>
                            <th>Son Düzenleyen Kullanıcı Adı</th>
                            <th>İşlemler</th>
                        </tr>
                    </thead>
                    <tfoot>
                        <tr>
                            <th>ID</th>
                            <th>Adı</th>
                            <th>Açıklaması</th>
                            <th>Aktif Mi?</th>
                            <th>Silinmiş Mi?</th>
                            <th>Not</th>
                            <th>Oluşturulma Tarihi</th>
                            <th>Oluşturan Kullanıcı Adı</th>
                            <th>Son Düzenlenme Tarihi</th>
                            <th>Son Düzenleyen Kullanıcı Adı</th>
                            <th>İşlemler</th>
                        </tr>
                    </tfoot>
                    <tbody>
");
#nullable restore
#line 52 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                         foreach (var category in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("name", " name=\"", 2309, "\"", 2328, 1);
#nullable restore
#line 54 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 2316, category.Id, 2316, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <td>");
#nullable restore
#line 55 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 56 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 59 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.IsDeleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 60 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.Note);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 61 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 62 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.CreatedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 63 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.ModifiedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 64 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                               Write(category.ModifiedByName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <button class=\"btn btn-primary btn-sm btn-block btn-update\" data-id=\"");
#nullable restore
#line 66 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                                                                    Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-edit\"></span> Düzenle</button>\r\n                                    <button class=\"btn btn-danger btn-sm btn-block btn-delete\" data-id=\"");
#nullable restore
#line 67 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                                                                                                   Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fas fa-minus-circle\"></span> Sil</button>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 77 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Error)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger mt-3\">\r\n        ");
#nullable restore
#line 81 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n        Dashboard sayfasına geri dönmek için lütfen ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e883280e846847824842f94cc3aa41319eaa82114066", async() => {
                WriteLiteral("tıklayınız.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 84 "C:\Users\Burak\Desktop\proje\Blog-App_.net-core\BlogApp\BlogApp.Mvc\Areas\Admin\Views\Category\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e883280e846847824842f94cc3aa41319eaa82116020", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogApp.Entities.Dtos.CategoryListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
