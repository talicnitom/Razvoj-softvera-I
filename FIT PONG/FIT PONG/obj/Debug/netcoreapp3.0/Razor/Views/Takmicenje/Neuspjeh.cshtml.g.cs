#pragma checksum "C:\Users\talicni\Desktop\SEMINARSKI_RAD_RS_1\webapp\FIT PONG\FIT PONG\Views\Takmicenje\Neuspjeh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3438d81326b70ae717b49bfb49e24a012ee6acec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Takmicenje_Neuspjeh), @"mvc.1.0.view", @"/Views/Takmicenje/Neuspjeh.cshtml")]
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
#line 1 "C:\Users\talicni\Desktop\SEMINARSKI_RAD_RS_1\webapp\FIT PONG\FIT PONG\Views\_ViewImports.cshtml"
using FIT_PONG;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\talicni\Desktop\SEMINARSKI_RAD_RS_1\webapp\FIT PONG\FIT PONG\Views\_ViewImports.cshtml"
using FIT_PONG.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3438d81326b70ae717b49bfb49e24a012ee6acec", @"/Views/Takmicenje/Neuspjeh.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"438b6b2e6f34317388d1a6ef6e05391772603c6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Takmicenje_Neuspjeh : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\talicni\Desktop\SEMINARSKI_RAD_RS_1\webapp\FIT PONG\FIT PONG\Views\Takmicenje\Neuspjeh.cshtml"
  
    ViewData["Title"] = "Neuspjeh";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\talicni\Desktop\SEMINARSKI_RAD_RS_1\webapp\FIT PONG\FIT PONG\Views\Takmicenje\Neuspjeh.cshtml"
  
    if (Model != null && Model.Count > 0)
    {
        int brojac = 1;
        foreach (string i in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 class=\"text-danger\">");
#nullable restore
#line 11 "C:\Users\talicni\Desktop\SEMINARSKI_RAD_RS_1\webapp\FIT PONG\FIT PONG\Views\Takmicenje\Neuspjeh.cshtml"
                                Write(brojac++);

#line default
#line hidden
#nullable disable
            WriteLiteral(". ");
#nullable restore
#line 11 "C:\Users\talicni\Desktop\SEMINARSKI_RAD_RS_1\webapp\FIT PONG\FIT PONG\Views\Takmicenje\Neuspjeh.cshtml"
                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 12 "C:\Users\talicni\Desktop\SEMINARSKI_RAD_RS_1\webapp\FIT PONG\FIT PONG\Views\Takmicenje\Neuspjeh.cshtml"

        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Nesto je krenulo po zlu</h1>\r\n");
#nullable restore
#line 18 "C:\Users\talicni\Desktop\SEMINARSKI_RAD_RS_1\webapp\FIT PONG\FIT PONG\Views\Takmicenje\Neuspjeh.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
