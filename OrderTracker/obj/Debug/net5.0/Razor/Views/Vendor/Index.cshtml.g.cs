#pragma checksum "C:\Users\coltt\OneDrive\Desktop\Ordertracker.Solution\OrderTracker\Views\Vendor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80681a461f57ab14e13e40c549802fcf5e93dc28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendor_Index), @"mvc.1.0.view", @"/Views/Vendor/Index.cshtml")]
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
#line 1 "C:\Users\coltt\OneDrive\Desktop\Ordertracker.Solution\OrderTracker\Views\Vendor\Index.cshtml"
using OrderTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80681a461f57ab14e13e40c549802fcf5e93dc28", @"/Views/Vendor/Index.cshtml")]
    public class Views_Vendor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Vendors</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\coltt\OneDrive\Desktop\Ordertracker.Solution\OrderTracker\Views\Vendor\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h2>No vendors in the warehouse</h2>\r\n  <h3><a href=\"/vendors/new\">Add your shift!</a></h3>\r\n");
#nullable restore
#line 9 "C:\Users\coltt\OneDrive\Desktop\Ordertracker.Solution\OrderTracker\Views\Vendor\Index.cshtml"
} 
else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\coltt\OneDrive\Desktop\Ordertracker.Solution\OrderTracker\Views\Vendor\Index.cshtml"
 foreach (Vendor vendor in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3><a");
            BeginWriteAttribute("href", " href=\'", 231, "\'", 257, 2);
            WriteAttributeValue("", 238, "/vendors/", 238, 9, true);
#nullable restore
#line 13 "C:\Users\coltt\OneDrive\Desktop\Ordertracker.Solution\OrderTracker\Views\Vendor\Index.cshtml"
WriteAttributeValue("", 247, vendor.Id, 247, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 13 "C:\Users\coltt\OneDrive\Desktop\Ordertracker.Solution\OrderTracker\Views\Vendor\Index.cshtml"
                               Write(vendor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n");
#nullable restore
#line 14 "C:\Users\coltt\OneDrive\Desktop\Ordertracker.Solution\OrderTracker\Views\Vendor\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p><a href=\'/\'>Home</a></p>");
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
