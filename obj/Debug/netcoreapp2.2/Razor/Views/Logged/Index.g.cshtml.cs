#pragma checksum "C:\Users\Alessio\Desktop\EFLogin\Views\Logged\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09d1cab50dc53dbd4332905bd3693a58ba8b5bad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logged_Index), @"mvc.1.0.view", @"/Views/Logged/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Logged/Index.cshtml", typeof(AspNetCore.Views_Logged_Index))]
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
#line 1 "C:\Users\Alessio\Desktop\EFLogin\Views\_ViewImports.cshtml"
using EFLogin;

#line default
#line hidden
#line 2 "C:\Users\Alessio\Desktop\EFLogin\Views\_ViewImports.cshtml"
using EFLogin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d1cab50dc53dbd4332905bd3693a58ba8b5bad", @"/Views/Logged/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccd313a6fe700153d7e7ebb6ec0473aac31a7cac", @"/Views/_ViewImports.cshtml")]
    public class Views_Logged_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1365, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand-md navbar-dark"" style=""background-color: tomato"">
    <div>
        <a href="""" class=""navbar-brand""> User Management App </a>
    </div>

    <ul class=""navbar-nav"">
        <li><a href="""" class=""nav-link"">Users</a></li>
    </ul>
</nav>
<br>
<div class=""row"">
    <div class=""container"">
        <h3 class=""text-center"">List of Users</h3>
        <hr>
        <div class=""container text-left"">
            <a href=""#"" class=""btn btn-success"">Add New User</a>
        </div>
        <br>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Name</th>
                    <th>Email</th>
                    <th>Country</th>
                </tr>
            </thead>
            <tbody>
                /*per ogni utente presente nel database mostrare i suoi dati
                <tr>
                    <td>//ID</td>
                    <td>//Nome</td>
                ");
            WriteLiteral(@"    <td>//Email</td>
                    <td>//Nazione</td>
                    <td><a href=""/*Link aggiornamento utente*/"">updateUser</a></td>
                    <td><a href=""/*Link cancellare utente*/"">deleteUser</a></td>
                </tr>
                */
            </tbody>
        </table>
    </div>
</div>

</html>");
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
