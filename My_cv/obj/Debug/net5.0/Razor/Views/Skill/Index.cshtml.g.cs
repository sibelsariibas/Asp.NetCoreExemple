#pragma checksum "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05df94412b09ed8fab77a273ffd1bca0c4611d7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "C:\Users\sibel.saribas\source\repos\My_cv\Views\_ViewImports.cshtml"
using My_cv;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sibel.saribas\source\repos\My_cv\Views\_ViewImports.cshtml"
using My_cv.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05df94412b09ed8fab77a273ffd1bca0c4611d7c", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14763ea3d9fd3c41535c8a51a31e405b5d4f39e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card-header border-0"">
    <h3 class=""mb-0"">Yetenekler</h3>
</div>
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Oran</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">

");
#nullable restore
#line 24 "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 28 "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml"
                   Write(item.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <td class=\"budget\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div class=\"d-flex align-items-center\">\r\n                            <span class=\"completion mr-2\">");
#nullable restore
#line 35 "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml"
                                                     Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n                            <div>\r\n                                <div class=\"progress\">\r\n                                    <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1453, "\"", 1480, 1);
#nullable restore
#line 38 "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1469, item.Value, 1469, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 1519, "\"", 1546, 3);
            WriteAttributeValue("", 1527, "width:", 1527, 6, true);
#nullable restore
#line 38 "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1533, item.Value, 1533, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1544, "%;", 1544, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </td>\r\n                    <td> <a");
            BeginWriteAttribute("href", " href=\"", 1718, "\"", 1757, 2);
            WriteAttributeValue("", 1725, "/Skill/DeleteSkill/", 1725, 19, true);
#nullable restore
#line 43 "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1744, item.SkillID, 1744, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-danger\">Sil</a></td>\r\n                    <td>  <a");
            BeginWriteAttribute("href", " href=\"", 1827, "\"", 1866, 2);
            WriteAttributeValue("", 1834, "/Skill/UpdateSkill/", 1834, 19, true);
#nullable restore
#line 44 "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1853, item.SkillID, 1853, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn-sm btn-info\">Güncelle</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\sibel.saribas\source\repos\My_cv\Views\Skill\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n\r\n<br />\r\n<a href=\"/Skill/AddSkill\" class=\"btn-sm btn-primary\">Yetenek Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
