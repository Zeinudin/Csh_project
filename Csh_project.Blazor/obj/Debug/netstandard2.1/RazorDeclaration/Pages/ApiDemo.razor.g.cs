#pragma checksum "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\ApiDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd1676461125e2d92136482f30aef90f119f1e98"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Csh_project.Blazor.Pages
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
#line 1 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\ApiDemo.razor"
using Csh_project.Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\ApiDemo.razor"
using Csh_project.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\ApiDemo.razor"
using Csh_project.Blazor.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\ApiDemo.razor"
using Csh_project.Blazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/apidemo")]
    public partial class ApiDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\ApiDemo.razor"
       
    [Parameter]
    public IEnumerable<ListViewModel> dishes { get; set; }

    string apiBaseAddress = "https://localhost:44382/Api/Dishes";
    protected override async Task OnInitializedAsync()
    {
        dishes =
        await
        client.GetFromJsonAsync<IEnumerable<ListViewModel>>(apiBaseAddress);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory clientFactory { get; set; }
    }
}
#pragma warning restore 1591