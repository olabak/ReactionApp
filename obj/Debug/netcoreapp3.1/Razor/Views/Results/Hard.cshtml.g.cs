#pragma checksum "C:\Users\Ola\Downloads\ReactionTestApp-main\Views\Results\Hard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47b39a76f92c858aeaa381a539d8f551831734ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Results_Hard), @"mvc.1.0.view", @"/Views/Results/Hard.cshtml")]
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
#line 1 "C:\Users\Ola\Downloads\ReactionTestApp-main\Views\_ViewImports.cshtml"
using ReactionTimeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ola\Downloads\ReactionTestApp-main\Views\_ViewImports.cshtml"
using ReactionTimeApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47b39a76f92c858aeaa381a539d8f551831734ba", @"/Views/Results/Hard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b6d516f41215a621a28bd2ba0da767fa5ba0ff8", @"/Views/_ViewImports.cshtml")]
    public class Views_Results_Hard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReactionTimeApp.Models.ReactionTest>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ola\Downloads\ReactionTestApp-main\Views\Results\Hard.cshtml"
  
    ViewData["Title"] = "Hard";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Position\r\n            </th>\r\n            <th>\r\n                Time [s]\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Ola\Downloads\ReactionTestApp-main\Views\Results\Hard.cshtml"
          
            var a = 1;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\Ola\Downloads\ReactionTestApp-main\Views\Results\Hard.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\Ola\Downloads\ReactionTestApp-main\Views\Results\Hard.cshtml"
               Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Ola\Downloads\ReactionTestApp-main\Views\Results\Hard.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReactionTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Ola\Downloads\ReactionTestApp-main\Views\Results\Hard.cshtml"
            a++;

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReactionTimeApp.Models.ReactionTest>> Html { get; private set; }
    }
}
#pragma warning restore 1591