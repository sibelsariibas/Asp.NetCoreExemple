#pragma checksum "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\TestimonialList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "576319646d91fb57c70be804444ecc7987cec7ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TestimonialList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
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
#line 1 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\TestimonialList\Default.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"576319646d91fb57c70be804444ecc7987cec7ce", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14763ea3d9fd3c41535c8a51a31e405b5d4f39e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TestimonialList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"section px-3 px-lg-4 pt-5\" id=\"testimonial\">\r\n    <div class=\"container-narrow\">\r\n        <div class=\"text-center mb-5\">\r\n            <h2 class=\"marker marker-center\">Referanslarım</h2>\r\n        </div>\r\n");
#nullable restore
#line 9 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\TestimonialList\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-md-6 mb-5"" data-aos=""fade-right"" data-aos-delay=""100"">
                <div class=""d-flex justify-content-end align-items-end"">
                    <div class=""text-end me-2"">
                        <div class=""fw-bolder"">");
#nullable restore
#line 15 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\TestimonialList\Default.cshtml"
                                          Write(item.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"text-small\">");
#nullable restore
#line 16 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\TestimonialList\Default.cshtml"
                                           Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Shared\Components\TestimonialList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; }
    }
}
#pragma warning restore 1591
