#pragma checksum "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f381e62ef079b91019ed791411c1df2b568890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Breed_Index), @"mvc.1.0.view", @"/Views/Breed/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f381e62ef079b91019ed791411c1df2b568890", @"/Views/Breed/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4793fe2852eb262ad6bfbdc086f04c745b569dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Breed_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Index.cshtml"
   var breed = (List<BreedModel>)ViewData["Breeds"]; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 59, "\"", 67, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"background-color: darkturquoise\">\n    ");
#nullable restore
#line 3 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Index.cshtml"
Write(await Html.PartialAsync("_NavPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n<div class=\"container ml-5 pl-5\">\n    <div class=\"row\">\n");
#nullable restore
#line 7 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Index.cshtml"
         foreach (var b in breed)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card bg-light box-shadow mr-5 mt-2\" style=\"width: 18rem;\">\n    <div class=\"card-body\">\n        <img class=\"card-img-top \"");
            BeginWriteAttribute("src", " src=\"", 394, "\"", 408, 1);
#nullable restore
#line 11 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Index.cshtml"
WriteAttributeValue("", 400, b.image, 400, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\n        <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Index.cshtml"
                          Write(b.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <p class=\"card-text\"> ");
#nullable restore
#line 13 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Index.cshtml"
                         Write(b.overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <a");
            BeginWriteAttribute("href", " href=\"", 532, "\"", 559, 2);
            WriteAttributeValue("", 539, "/Breed/Details/", 539, 15, true);
#nullable restore
#line 14 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Index.cshtml"
WriteAttributeValue("", 554, b.id, 554, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-info\">More Info</button></a>\n    </div>\n</div>");
#nullable restore
#line 16 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.Net\Projects\Project04_Auth_CRUD_ASP.NET\KittyCat\KittyCat\Views\Breed\Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
