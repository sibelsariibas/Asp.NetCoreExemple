#pragma checksum "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be638d9f2c3e7d47f4ca6c8b9d9f4035fafd05d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be638d9f2c3e7d47f4ca6c8b9d9f4035fafd05d6", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14763ea3d9fd3c41535c8a51a31e405b5d4f39e1", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contact>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml"
 using (Html.BeginForm("Index", "Contact", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-10 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">İletişim Bilgileri</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be638d9f2c3e7d47f4ca6c8b9d9f4035fafd05d64542", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 15 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml"
               Write(Html.HiddenFor(x => x.ContactID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        <label>Başlık</label>\r\n                        ");
#nullable restore
#line 18 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Title, new {  @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <text style=\"color:gray\">");
#nullable restore
#line 19 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml"
                                            Write(Html.ValidationMessage("Title"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</text>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Mail Adresi</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Mail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <text style=\"color:gray\">");
#nullable restore
#line 24 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml"
                                            Write(Html.ValidationMessage("Mail"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</text>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Telefon</label>\r\n                        ");
#nullable restore
#line 28 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml"
                   Write(Html.TextBoxFor(x => x.Phone , new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        <text style=\"color:gray\">");
#nullable restore
#line 29 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml"
                                            Write(Html.ValidationMessage("Phone"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</text>\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-outline-info\">Kaydet</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\sibel.saribas\source\Asp.NetCoreEx\Asp.NetCoreEx\My_cv\Views\Contact\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591
