#pragma checksum "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Categories\EditCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a64e688defddc703b5ca9c570ab2c3289e42f36"
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
#line 2 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Categories\EditCategory.razor"
using Proy1.Client.Pages.Forms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Categories/edit/{Id:int}")]
    public partial class EditCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "jumbotron");
            __builder.OpenComponent<Proy1.Client.Pages.Forms.CategoryForm>(4);
            __builder.AddAttribute(5, "Category", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Proy1.Shared.Entity.Category>(
#nullable restore
#line 5 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Categories\EditCategory.razor"
                                Category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Categories\EditCategory.razor"
                                                         Edit

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
#line 8 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Categories\EditCategory.razor"
       
    [Parameter] public int Id { get; set; }

    public Category Category = new Category();

    protected override void OnInitialized()
    {
        Category = new Category()
        {
            Id = Id,
            Name = "Comedia"
        };
    }
    void Edit()
    {
        Console.WriteLine($"Actualizando el nombre de la categoría {Category.Name}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
