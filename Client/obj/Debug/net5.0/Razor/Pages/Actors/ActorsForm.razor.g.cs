#pragma checksum "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ddc0ff979ae40ed2f1ea90fc19ef40c1b49201"
// <auto-generated/>
#pragma warning disable 1591
namespace Proy1.Client.Pages.Actors
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
#line 1 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
using Proy1.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    public partial class ActorsForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "jumbotron");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
                         Actor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
                                               OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.AddMarkupContent(10, "<h3>Crea un nuevo usuario.</h3>\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row mb-3");
                __builder2.AddMarkupContent(13, "<label for class=\"form-label\">Nombre:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "placeholder", "Nombre actor");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
                                                              Actor.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.Name = __value, Actor.Name))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Actor.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __Blazor.Proy1.Client.Pages.Actors.ActorsForm.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 10 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
                                          ()=>Actor.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "row mb-3");
                __builder2.AddMarkupContent(26, "<label for class=\"form-label\">Fecha de nacimiento:</label>\r\n                ");
                __Blazor.Proy1.Client.Pages.Actors.ActorsForm.TypeInference.CreateInputDate_1(__builder2, 27, 28, "form-control", 29, 
#nullable restore
#line 14 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
                                                              Actor.BirthDate

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.BirthDate = __value, Actor.BirthDate)), 31, () => Actor.BirthDate);
                __builder2.AddMarkupContent(32, "\r\n                ");
                __Blazor.Proy1.Client.Pages.Actors.ActorsForm.TypeInference.CreateValidationMessage_2(__builder2, 33, 34, 
#nullable restore
#line 15 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
                                          ()=>Actor.BirthDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "row mb-3");
                __builder2.AddMarkupContent(38, "<label for class=\"form-label\">Biografía:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(39);
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "aria-placeholder", "Ingresa la biografía del autor.");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
                                                                  Actor.Biography

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Actor.Biography = __value, Actor.Biography))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Actor.Biography));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                ");
                __Blazor.Proy1.Client.Pages.Actors.ActorsForm.TypeInference.CreateValidationMessage_3(__builder2, 46, 47, 
#nullable restore
#line 22 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
                                          ()=> Actor.Biography

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "row mb-3");
                __builder2.OpenComponent<Proy1.Client.Pages.Components.ImageComponent>(51);
                __builder2.AddAttribute(52, "Label", "Selecciona una foto:");
                __builder2.AddAttribute(53, "ImageSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 26 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
                                                                            ImageSelected

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(54, "ImageURL", 
#nullable restore
#line 26 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
                                                                                                      ImageURL

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "row");
                __builder2.OpenElement(58, "button");
                __builder2.AddAttribute(59, "type", "submit");
                __builder2.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
                                                 OnValidSubmit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "class", "btn btn-info btn-sm");
                __builder2.AddContent(62, "Registrar");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\ProyEnfasisProfesional\Proy1\Client\Pages\Actors\ActorsForm.razor"
       
    [Parameter] public Actor Actor { get; set; }
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    public string ImageURL;
    protected override void OnInitialized()
    {
        if (!string.IsNullOrWhiteSpace(Actor.Photo))
        {
            ImageURL = Actor.Photo;
            Actor.Photo = null;
        }
    }

    private void ImageSelected(string imageBase64)
    {
        Actor.Photo = imageBase64;
        ImageURL = null;
    }




#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Proy1.Client.Pages.Actors.ActorsForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
