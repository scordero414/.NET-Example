// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Proy1.Client.Pages
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
    public partial class FishesListComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor"
      
    public List<Fish> Fishes;
    private List<Fish> GetFishes(){
        return new List<Fish>(){
            new Fish(){
                FishSpecie = "Beta 1", 
                FishDescription = "Descripción del tipo de pez Beta 1",
                TypeOfWater = "Dulce",
                FishImage= "/Images/bet.jpg", 
                PublicationDate = new DateTime(2021, 09, 20)
            }, 
            new Fish(){
                FishSpecie = "Beta 2", 
                FishDescription = "Descripcióndel tipo de pez Beta 2",
                TypeOfWater = "Salada",
                FishImage= "/Images/beta2.jpg", 
                PublicationDate = new DateTime(2021, 08, 20)
            }, 
            new Fish(){
                FishSpecie = "Beta 3", 
                FishDescription = "Descripcióndel tipo de pez Beta 3",
                TypeOfWater = "Dulce",
                FishImage= "/Images/beta3.jpg", 
                PublicationDate = new DateTime(2021, 07, 20)
            }, 
            new Fish(){
                FishSpecie = "Beta 4",
                FishDescription = "Descripcióndel tipo de pez Beta 4",
                TypeOfWater = "Salada",
                FishImage= "/Images/beta4.jpeg", 
                PublicationDate = new DateTime(2021, 09, 20)
            }, 
            new Fish(){
                FishSpecie = "Beta 5", 
                FishDescription = "Descripcióndel tipo de pez Beta 5",
                TypeOfWater = "Dulce",
                FishImage= "/Images/beta5.jpeg", 
                PublicationDate = new DateTime(2021, 08, 20)
            }, 
            new Fish(){
                FishSpecie = "Beta 6", 
                FishDescription = "Descripcióndel tipo de pez Beta 6",
                TypeOfWater = "Salada",
                FishImage= "/Images/beta8.jpg", 
                PublicationDate = new DateTime(2021, 07, 20)
            } 
        }; 
    }

    protected override async Task OnInitializedAsync(){
        await Task.Delay(2000);
        Fishes = GetFishes();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
