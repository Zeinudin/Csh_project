#pragma checksum "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82b5cff9ac1ba4eadd724a952baad518bd8df201"
// <auto-generated/>
#pragma warning disable 1591
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
#line 9 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\_Imports.razor"
using Csh_project.Blazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\Counter.razor"
                 input

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\Counter.razor"
                                       SetCounter

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __Blazor.Csh_project.Blazor.Pages.Counter.TypeInference.CreateInputNumber_0(__builder2, 14, 15, "form-control col-sm-2", 16, 
#nullable restore
#line 10 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\Counter.razor"
                              input.CounterValue

#line default
#line hidden
#nullable disable
                , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => input.CounterValue = __value, input.CounterValue)), 18, () => input.CounterValue);
                __builder2.AddMarkupContent(19, "\r\n    <input type=\"submit\" class=\"btn btn-outline-info mt-2 mb-2\" value=\"Set counter\">\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "class", "btn btn-primary");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Zeinudin\source\repos\Csh_project\Csh_project.Blazor\Pages\Counter.razor"
       
    private void SetCounter()

    {
        currentCount = input.CounterValue;
    }
    class Input
    {
        public int CounterValue { get; set; }
    }
    Input input;

    protected override void OnInitialized()
    {
        input = new Input();
    }
    private int currentCount = 0;
    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Csh_project.Blazor.Pages.Counter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
