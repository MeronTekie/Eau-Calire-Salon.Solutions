#pragma checksum "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Stylists/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acdfb889fe3b54f89816b05c42c1473a35fb7867"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Index), @"mvc.1.0.view", @"/Views/Stylists/Index.cshtml")]
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
#line 5 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Stylists/Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acdfb889fe3b54f89816b05c42c1473a35fb7867", @"/Views/Stylists/Index.cshtml")]
    #nullable restore
    public class Views_Stylists_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Stylists/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n  <h1>Stylists at Mullets R Us Salon:</h1>\n\n");
#nullable restore
#line 9 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Stylists/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No Stylists have been added yet!</h3>\n");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Stylists/Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<ul>\n");
#nullable restore
#line 15 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Stylists/Index.cshtml"
   foreach(Stylist stylist in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 17 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Stylists/Index.cshtml"
   Write(Html.ActionLink($"{stylist.Name}", "Details", new { id = stylist.StylistId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 18 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Stylists/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n<p>");
#nullable restore
#line 21 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Stylists/Index.cshtml"
Write(Html.ActionLink("Add new stylist", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 22 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Stylists/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
