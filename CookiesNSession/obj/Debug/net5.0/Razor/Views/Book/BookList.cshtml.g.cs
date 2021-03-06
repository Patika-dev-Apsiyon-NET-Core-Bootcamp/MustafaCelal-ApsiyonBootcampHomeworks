#pragma checksum "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "565a1c1f9dbbd4325db659367173f657a2bd4310"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_BookList), @"mvc.1.0.view", @"/Views/Book/BookList.cshtml")]
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
#line 1 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\_ViewImports.cshtml"
using CookiesNSession;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\_ViewImports.cshtml"
using CookiesNSession.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"565a1c1f9dbbd4325db659367173f657a2bd4310", @"/Views/Book/BookList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0422efddbc101b568d368cda88892de5b3e861e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_BookList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CookiesNSession.Models.BookModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddFavorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Favorilere Ekle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"
  
    ViewData["Title"] = "BookList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.EmptyList))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<label>");
#nullable restore
#line 9 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"
   Write(ViewBag.EmptyList);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label> ");
#nullable restore
#line 9 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"
                                   }
else
{


#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.FavoriKitap))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<label>");
#nullable restore
#line 14 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"
   Write(ViewBag.FavoriKitap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>");
#nullable restore
#line 14 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>BookList</h1>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Kitap Ad??</th>\r\n            <th>Yazar??</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 27 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"
         foreach (BookModel kitap in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"
               Write(kitap.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"
               Write(kitap.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "565a1c1f9dbbd4325db659367173f657a2bd43106693", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
#nullable restore
#line 41 "E:\repos\Bootcamp_Calismalarim\CookiesNSession\Views\Book\BookList.cshtml"


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CookiesNSession.Models.BookModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
