#pragma checksum "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccf5afb830d746c63eb30428691fd108a318855b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Details), @"mvc.1.0.view", @"/Views/Clients/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccf5afb830d746c63eb30428691fd108a318855b", @"/Views/Clients/Details.cshtml")]
    #nullable restore
    public class Views_Clients_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n<h2>Client\'s Detail</h2>\n\n\n<h3>");
#nullable restore
#line 11 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 11 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>\n<h3>");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Wax));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 12 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Details.cshtml"
                                         Write(Html.DisplayFor(model => model.Wax));

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3></h3>\n<h3>");
#nullable restore
#line 13 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Massage));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 13 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Details.cshtml"
                                             Write(Html.DisplayFor(model => model.Massage));

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>\n<p>");
#nullable restore
#line 14 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Details.cshtml"
Write(Html.ActionLink("Edit A Client", "Edit", new { id = Model.ClientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 15 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Details.cshtml"
Write(Html.ActionLink("Delete A Client", "Delete", new { id = Model.ClientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 16 "/Users/ramenimo/Desktop/Epicodous/C-sharp/Projects/week-three/EauClaireSalon.Solutions/HairSalon/Views/Clients/Details.cshtml"
Write(Html.ActionLink("Back", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
