#pragma checksum "E:\Code C# Tasklar\eNno\eNno\Areas\Manage\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4e75a459ff8c18307cc4021e113818beadddec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Team_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Team/Index.cshtml")]
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
#line 2 "E:\Code C# Tasklar\eNno\eNno\Areas\Manage\Views\_ViewImports.cshtml"
using eNno.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Code C# Tasklar\eNno\eNno\Areas\Manage\Views\_ViewImports.cshtml"
using eNno.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4e75a459ff8c18307cc4021e113818beadddec", @"/Areas/Manage/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d347e58b0870ba5fefedefafcae3cc4210594d78", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Team>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Code C# Tasklar\eNno\eNno\Areas\Manage\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""d-flex justify-content-sm-around"">
    <h1>Index</h1>
    <a href=""#""><i class=""fas fa-plus-square btn btn-primary""></i></a>
</div>



<table class=""table"">

    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">FullName</th>
            <th scope=""col"">Position</th>
            <th scope=""col"">Desc</th>
            <th scope=""col"">Image</th>
            <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "E:\Code C# Tasklar\eNno\eNno\Areas\Manage\Views\Team\Index.cshtml"
         foreach (var item in Model)
        {
            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 31 "E:\Code C# Tasklar\eNno\eNno\Areas\Manage\Views\Team\Index.cshtml"
                           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 32 "E:\Code C# Tasklar\eNno\eNno\Areas\Manage\Views\Team\Index.cshtml"
               Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "E:\Code C# Tasklar\eNno\eNno\Areas\Manage\Views\Team\Index.cshtml"
               Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "E:\Code C# Tasklar\eNno\eNno\Areas\Manage\Views\Team\Index.cshtml"
               Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "E:\Code C# Tasklar\eNno\eNno\Areas\Manage\Views\Team\Index.cshtml"
               Write(item.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a href=\"#\"><i class=\"fas fa-edit btn btn-warning\"></i></a>\r\n                    <a href=\"#\"><i class=\"fas fa-trash-alt btn btn-danger\"></i></a>\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "E:\Code C# Tasklar\eNno\eNno\Areas\Manage\Views\Team\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Team>> Html { get; private set; }
    }
}
#pragma warning restore 1591
