#pragma checksum "/Users/paulopires/Code/paycertify/plugin/csharp-example/Pages/ThankYou.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb0a3ef81a9a3c7da50430eba20dfb95421a654c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(csharp_example.Pages.Pages_ThankYou), @"mvc.1.0.razor-page", @"/Pages/ThankYou.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ThankYou.cshtml", typeof(csharp_example.Pages.Pages_ThankYou), null)]
namespace csharp_example.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/paulopires/Code/paycertify/plugin/csharp-example/Pages/_ViewImports.cshtml"
using csharp_example;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb0a3ef81a9a3c7da50430eba20dfb95421a654c", @"/Pages/ThankYou.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aff67a4022cb91e0899f23714bff4a08c7e17edf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ThankYou : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/Users/paulopires/Code/paycertify/plugin/csharp-example/Pages/ThankYou.cshtml"
  
    ViewData["Title"] = "Thank You";

#line default
#line hidden
            BeginContext(74, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(79, 17, false);
#line 6 "/Users/paulopires/Code/paycertify/plugin/csharp-example/Pages/ThankYou.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(96, 15, true);
            WriteLiteral("</h1>\r\n\r\n<code>");
            EndContext();
            BeginContext(112, 47, false);
#line 8 "/Users/paulopires/Code/paycertify/plugin/csharp-example/Pages/ThankYou.cshtml"
 Write(Html.DisplayFor(model => model.TransactionData));

#line default
#line hidden
            EndContext();
            BeginContext(159, 9, true);
            WriteLiteral("</code>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThankYouModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ThankYouModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ThankYouModel>)PageContext?.ViewData;
        public ThankYouModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591