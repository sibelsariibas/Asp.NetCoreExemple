#pragma checksum "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "098da4bc1e1180ef5ffc11df1697b2cbf613abf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#line 1 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\_ViewImports.cshtml"
using My_cv;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\_ViewImports.cshtml"
using My_cv.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Services\Index.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"098da4bc1e1180ef5ffc11df1697b2cbf613abf3", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14763ea3d9fd3c41535c8a51a31e405b5d4f39e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Services\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .overflow-description p {
        margin: 0 0 10px;
    }
</style>
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Mesleki Kazanım</h3>
</div>
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""budget"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">

");
#nullable restore
#line 29 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Services\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"budget\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Services\Index.cshtml"
                   Write(item.ServiceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"budget\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Services\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 1164, "\"", 1209, 2);
            WriteAttributeValue("", 1171, "/Service/DeleteService/", 1171, 23, true);
#nullable restore
#line 38 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Services\Index.cshtml"
WriteAttributeValue("", 1194, item.ServiceID, 1194, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-danger\">Sil</a></td>\r\n                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 1278, "\"", 1323, 2);
            WriteAttributeValue("", 1285, "/Service/UpdateService/", 1285, 23, true);
#nullable restore
#line 39 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Services\Index.cshtml"
WriteAttributeValue("", 1308, item.ServiceID, 1308, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-info\">Güncelle</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 41 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Services\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n<br />\r\n<a href=\"/Service/AddService\" class=\"btn-sm btn-primary\">Mesleki Kazanım Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591