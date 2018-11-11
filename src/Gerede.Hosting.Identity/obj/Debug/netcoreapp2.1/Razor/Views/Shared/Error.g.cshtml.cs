#pragma checksum "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/Shared/Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bbf8b54ce515f34efe823bf3fb658bf34f88a67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/_ViewImports.cshtml"
using IdentityServer4.Quickstart.UI;

#line default
#line hidden
#line 1 "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/Shared/Error.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bbf8b54ce515f34efe823bf3fb658bf34f88a67", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4c1f8a331756813dc62d0a9e9a6b6778f02506", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(91, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/Shared/Error.cshtml"
  
    var error = Model?.Error?.Error;
    var errorDescription = host.IsDevelopment() ? Model?.Error?.ErrorDescription : null;
    var request_id = Model?.Error?.RequestId;

#line default
#line hidden
            BeginContext(269, 232, true);
            WriteLiteral("\n<div class=\"error-page\">\n    <div class=\"page-header\">\n        <h1>Error</h1>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-sm-6\">\n            <div class=\"alert alert-danger\">\n                Sorry, there was an error\n\n");
            EndContext();
#line 21 "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/Shared/Error.cshtml"
                 if (error != null)
                {

#line default
#line hidden
            BeginContext(555, 88, true);
            WriteLiteral("                    <strong>\n                        <em>\n                            : ");
            EndContext();
            BeginContext(644, 5, false);
#line 25 "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/Shared/Error.cshtml"
                         Write(error);

#line default
#line hidden
            EndContext();
            BeginContext(649, 61, true);
            WriteLiteral("\n                        </em>\n                    </strong>\n");
            EndContext();
#line 28 "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/Shared/Error.cshtml"

                    if (errorDescription != null)
                    {

#line default
#line hidden
            BeginContext(783, 29, true);
            WriteLiteral("                        <div>");
            EndContext();
            BeginContext(813, 16, false);
#line 31 "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/Shared/Error.cshtml"
                        Write(errorDescription);

#line default
#line hidden
            EndContext();
            BeginContext(829, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 32 "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/Shared/Error.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(876, 20, true);
            WriteLiteral("            </div>\n\n");
            EndContext();
#line 36 "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/Shared/Error.cshtml"
             if (request_id != null)
            {

#line default
#line hidden
            BeginContext(947, 52, true);
            WriteLiteral("                <div class=\"request-id\">Request Id: ");
            EndContext();
            BeginContext(1000, 10, false);
#line 38 "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/Shared/Error.cshtml"
                                               Write(request_id);

#line default
#line hidden
            EndContext();
            BeginContext(1010, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 39 "/Users/burakbasar/Documents/GitHub/Gerede/src/Gerede.Hosting.Identity/Views/Shared/Error.cshtml"
            }

#line default
#line hidden
            BeginContext(1031, 33, true);
            WriteLiteral("        </div>\n    </div>\n</div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHostingEnvironment host { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
