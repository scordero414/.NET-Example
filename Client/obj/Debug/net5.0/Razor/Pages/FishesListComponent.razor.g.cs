#pragma checksum "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e35634dba9008b42d6c6329cb9e7c29760078e25"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
#nullable restore
#line 2 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor"
     if (Fishes == null){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<label><small class=\"text-muted\">Cargando...</small></label>\r\n        <img src=\"/Images/loading.gif\" class=\"rounded mx-auto dblock\" height=\"50px\" width=\"50px\">");
#nullable restore
#line 5 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<h6>Peces Beta</h6>");
#nullable restore
#line 9 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor"
         foreach (var fish in Fishes)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "list-group mb-3");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-3");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 14 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor"
                                   fish.FishImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "class", "imgthumbnail");
            __builder.AddAttribute(13, "alt");
            __builder.AddAttribute(14, "width", "200px");
            __builder.AddAttribute(15, "height", "200px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-md-9");
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "class", "text-center");
            __builder.AddMarkupContent(21, "\r\n                        Especie de pez: ");
            __builder.OpenElement(22, "small");
            __builder.AddAttribute(23, "class", "textmuted");
            __builder.AddContent(24, 
#nullable restore
#line 18 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor"
                                                                  fish.FishSpecie

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "blockquote");
            __builder.AddAttribute(27, "class", "blockquote text-center");
            __builder.AddMarkupContent(28, "\r\n                            Descripción:\r\n                            ");
            __builder.OpenElement(29, "small");
            __builder.AddAttribute(30, "class", "textmuted");
            __builder.AddContent(31, 
#nullable restore
#line 22 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor"
                                                      fish.FishDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            <br>\r\n                            Tipo de agua en la que habita:\r\n                            ");
            __builder.OpenElement(33, "small");
            __builder.AddAttribute(34, "class", "textmuted");
            __builder.AddContent(35, 
#nullable restore
#line 25 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor"
                                                      fish.TypeOfWater

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "footer");
            __builder.AddAttribute(38, "class", "blockquote-footer");
            __builder.OpenElement(39, "cite");
            __builder.AddContent(40, 
#nullable restore
#line 27 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor"
                                   fish.PublicationDate.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\FishesListComponent.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
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
