#pragma checksum "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\SkillList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755e8438f3adceb69b1bad900ce62751ee6f7b09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillList/Default.cshtml")]
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
#line 1 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\SkillList\Default.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"755e8438f3adceb69b1bad900ce62751ee6f7b09", @"/Views/Shared/Components/SkillList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14763ea3d9fd3c41535c8a51a31e405b5d4f39e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SkillList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""section px-3 px-lg-4 pt-5"" id=""skills"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Teknik Bilgi</h2>
        </div>
        <div class=""text-center"">
            <p class=""mx-auto mb-3"" style=""max-width:600px"">Aşağıda bildiğim programlama dilleri ve teknolojiler üzerine bir bar listesi bulunmaktadır.</p>
        </div>
        <div class=""bg-light p-3"">
");
#nullable restore
#line 13 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\SkillList\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-md-7\">\r\n                            <div class=\"py-1\">\r\n                                <div class=\"d-flex text-small fw-bolder\"><span class=\"me-auto\">");
#nullable restore
#line 18 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 18 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                                                  Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></div>\r\n                                <div class=\"progress my-1\">\r\n                                    <div class=\"progress-bar bg-primary\" role=\"progressbar\" data-aos=\"zoom-in-right\" data-aos-delay=\"300\" data-aos-anchor=\".skills-section\"");
            BeginWriteAttribute("style", " style=\"", 1075, "\"", 1102, 3);
            WriteAttributeValue("", 1083, "width:", 1083, 6, true);
#nullable restore
#line 20 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue(" ", 1089, item.Value, 1090, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1101, "%", 1101, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1103, "\"", 1130, 1);
#nullable restore
#line 20 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue("", 1119, item.Value, 1119, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                                </div>\r\n                            </div>\r\n                        </div>           \r\n                    </div>\r\n");
#nullable restore
#line 25 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\SkillList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n    </div>\r\n</div>");
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
