#pragma checksum "/Users/Guest/Desktop/CarDealership.Solution/CarDealership/Views/Cars/CreateForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deee4681f63cc022d47b999c9cb8ce200aa5df47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_CreateForm), @"mvc.1.0.view", @"/Views/Cars/CreateForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cars/CreateForm.cshtml", typeof(AspNetCore.Views_Cars_CreateForm))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deee4681f63cc022d47b999c9cb8ce200aa5df47", @"/Views/Cars/CreateForm.cshtml")]
    public class Views_Cars_CreateForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 458, true);
            WriteLiteral(@"<form action=""/cars"" method=""post"">
  <label for=""makeModel"">Add car's model </label>
  <input id=""makeModel"" name=""makemodel"" type=""text"">
  <label for=""price"">Add car's price </label>
  <input id=""price"" name=""price"" type=""text"">
  <label for=""miles"">Add car's miles </label>
  <input id=""miles"" name=""miles"" type=""text"">
  <label for=""info"">Add car's info </label>
  <input id=""info"" name=""info"" type=""text"">
  <button type=""submit""> Add </button>
</form>");
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