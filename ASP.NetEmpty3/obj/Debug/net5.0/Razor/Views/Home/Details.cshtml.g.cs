#pragma checksum "C:\Users\107061\Desktop\.NET\ASP.NetEmpty3\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd005b8b493693d7c292d66e6d41947e6a4b4a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd005b8b493693d7c292d66e6d41947e6a4b4a6d", @"/Views/Home/Details.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.NetEmpty3.ViewModel.HomeDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n<div class=\"card text-dark bg-info mb-3\" style=\"max-width: 30rem;\">\r\n    <div class=\"card-header\">Employee Details</div>\r\n    <div class=\"card-body\">\r\n        <h5> Age: ");
#nullable restore
#line 10 "C:\Users\107061\Desktop\.NET\ASP.NetEmpty3\Views\Home\Details.cshtml"
             Write(Model.Employee.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5> Id: ");
#nullable restore
#line 11 "C:\Users\107061\Desktop\.NET\ASP.NetEmpty3\Views\Home\Details.cshtml"
            Write(Model.Employee.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5> Name: ");
#nullable restore
#line 12 "C:\Users\107061\Desktop\.NET\ASP.NetEmpty3\Views\Home\Details.cshtml"
              Write(Model.Employee.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
    </div>
    <div class=""card-footer"">
        <button class=""btn btn-success""> VIEW</button>
        <button class=""btn btn-primary"">UPDATE </button>
        <button class=""btn btn-danger""> DELETE</button>
        <button class=""btn btn-dark""> DONE</button>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.NetEmpty3.ViewModel.HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591