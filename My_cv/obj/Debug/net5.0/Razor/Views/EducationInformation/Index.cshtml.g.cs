#pragma checksum "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\EducationInformation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6d794adcec9fc3940b15073312d41ede1239c41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EducationInformation_Index), @"mvc.1.0.view", @"/Views/EducationInformation/Index.cshtml")]
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
#line 1 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\EducationInformation\Index.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6d794adcec9fc3940b15073312d41ede1239c41", @"/Views/EducationInformation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14763ea3d9fd3c41535c8a51a31e405b5d4f39e1", @"/Views/_ViewImports.cshtml")]
    public class Views_EducationInformation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EducationInformation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\EducationInformation\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card-header border-0"">
    <h3 class=""mb-0"">Eğitim</h3>
</div>
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""budget"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Öğrenim Kurumu</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Branş Bilgisi</th>
                <th scope=""col"" class=""sort"" data-sort=""date"">Mezuniyer Tarihi</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">

");
#nullable restore
#line 27 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\EducationInformation\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td class=\"budget\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\EducationInformation\Index.cshtml"
               Write(item.EducationInformationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"budget\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\EducationInformation\Index.cshtml"
               Write(item.SchoolName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"budget\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\EducationInformation\Index.cshtml"
               Write(item.Branch);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"budget\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\EducationInformation\Index.cshtml"
               Write(item.GraduationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1445, "\"", 1529, 2);
            WriteAttributeValue("", 1452, "/EducationInformation/DeleteEducationInformation/", 1452, 49, true);
#nullable restore
#line 42 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\EducationInformation\Index.cshtml"
WriteAttributeValue("", 1501, item.EducationInformationID, 1501, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-danger\">Sil</a></td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1594, "\"", 1678, 2);
            WriteAttributeValue("", 1601, "/EducationInformation/UpdateEducationInformation/", 1601, 49, true);
#nullable restore
#line 43 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\EducationInformation\Index.cshtml"
WriteAttributeValue("", 1650, item.EducationInformationID, 1650, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-info\">Güncelle</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\EducationInformation\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n<br />\r\n<a href=\"/EducationInformation/AddEducationInformation\" class=\"btn-sm btn-primary\">Eğitim Bilgisi Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EducationInformation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
