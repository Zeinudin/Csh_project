#pragma checksum "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Components\DishDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c151b8d8f72e7d409ec52b16be6060f49bd3988"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Csh_project.Blazor.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\_Imports.razor"
using Csh_project.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\_Imports.razor"
using Csh_project.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Components\DishDetails.razor"
using Csh_project.Blazor.Data;

#line default
#line hidden
#nullable disable
    public partial class DishDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Components\DishDetails.razor"
       

    [Parameter]
    public DetailsViewModel Dish { get; set; }
    [Parameter]
    public EventCallback<DetailsViewModel> DishChanged { get; set; }
    string imageSrc
    {
        get
        {
            return $"https://localhost:44375/images/{Dish.Image}";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
