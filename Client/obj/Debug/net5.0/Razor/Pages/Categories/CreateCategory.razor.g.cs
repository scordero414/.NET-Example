#pragma checksum "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Categories\CreateCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a12fa2bf14ac6d17f97f86bfb6e59534adb10c01"
// <auto-generated/>
#pragma warning disable 1591
namespace Proy1.Client.Pages.Categories
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using Proy1.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using Proy1.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using Proy1.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\ProyEnfasisProfesional\Proy1\Client\_Imports.razor"
using Proy1.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Categories\CreateCategory.razor"
using Proy1.Client.Pages.Forms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Categories/create")]
    public partial class CreateCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "jumbotron");
            __builder.OpenComponent<Proy1.Client.Pages.Forms.FormCategory>(4);
            __builder.AddAttribute(5, "Category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Proy1.Shared.Entity.Category>(
#nullable restore
#line 5 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Categories\CreateCategory.razor"
                                Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Categories\CreateCategory.razor"
                                                         Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Categories\CreateCategory.razor"
       
    public Category Category = new Category();
    void Create(){
        Console.WriteLine(Category.Name);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
