#pragma checksum "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "740f7ea5f26a1abc430920222329422a5d8cd713"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Delete), @"mvc.1.0.view", @"/Views/Clients/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"740f7ea5f26a1abc430920222329422a5d8cd713", @"/Views/Clients/Delete.cshtml")]
    #nullable restore
    public class Views_Clients_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n<h2>Are you sure you want to delete this client?</h2>\n\n\n");
#nullable restore
#line 11 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 11 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Delete.cshtml"
                                      Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\n");
#nullable restore
#line 15 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Delete.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Delete.cshtml"
Write(Html.ActionLink("Back ", "Index"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
