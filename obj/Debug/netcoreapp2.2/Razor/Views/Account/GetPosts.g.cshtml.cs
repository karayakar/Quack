#pragma checksum "/shared/projects/Quack/Views/Account/GetPosts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eeb017c1b2065be4ba8b45a881fa578a8044b64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_GetPosts), @"mvc.1.0.view", @"/Views/Account/GetPosts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/GetPosts.cshtml", typeof(AspNetCore.Views_Account_GetPosts))]
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
#line 1 "/shared/projects/Quack/Views/_ViewImports.cshtml"
using Quack;

#line default
#line hidden
#line 2 "/shared/projects/Quack/Views/_ViewImports.cshtml"
using Quack.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eeb017c1b2065be4ba8b45a881fa578a8044b64", @"/Views/Account/GetPosts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb824938960c7f5392dd4fc37ccacb9ca47e5af", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_GetPosts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 249, true);
            WriteLiteral("<button onclick=\"loadmore()\">LOAD</button>\n<script>\n  function loadmore(){\n\n  $.ajax({\n    type: \'POST\',\n    url: \'/Account/GetPosts1\',\n    data: {\"skip\": 1},\n    dataType: \'html\',\n  success: function(data) {\n\n  alert(data);\n  }\n  });\n  }\n</script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
