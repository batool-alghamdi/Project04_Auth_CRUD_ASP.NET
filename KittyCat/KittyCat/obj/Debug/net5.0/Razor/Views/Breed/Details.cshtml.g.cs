#pragma checksum "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae0d6a39f45c5e9f89f0f0b208fc720d1c3995a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Breed_Details), @"mvc.1.0.view", @"/Views/Breed/Details.cshtml")]
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
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\_ViewImports.cshtml"
using KittyCat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\_ViewImports.cshtml"
using KittyCat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae0d6a39f45c5e9f89f0f0b208fc720d1c3995a5", @"/Views/Breed/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4793fe2852eb262ad6bfbdc086f04c745b569dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Breed_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Details.cshtml"
   var b = (BreedModel)ViewData["breed"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 48, "\"", 56, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: darkturquoise\">\n    ");
#nullable restore
#line 3 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Details.cshtml"
Write(await Html.PartialAsync("_NavPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div class=\"col-sm-6\">\n    <div class=\"card\" style=\"width:40em\">\n        <div class=\"card-body\">\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 284, "\"", 298, 1);
#nullable restore
#line 8 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Details.cshtml"
WriteAttributeValue("", 290, b.image, 290, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\n            <h5 class=\"card-title\">");
#nullable restore
#line 9 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Details.cshtml"
                              Write(b.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n            <h5 class=\"font-weight-bold\">overview:</h5>\n            <p class=\"card-text\"> ");
#nullable restore
#line 11 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Details.cshtml"
                             Write(b.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <h5 class=\"font-weight-bold\">personality:</h5>\n            <p class=\"card-text align-content-center\">  ");
#nullable restore
#line 13 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Details.cshtml"
                                                   Write(b.personality);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <h5 class=\"font-weight-bold\">grooming:</h5>\n            <p class=\"card-text\">  ");
#nullable restore
#line 15 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Details.cshtml"
                              Write(b.grooming);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591