#pragma checksum "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\VentasPorProducto.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42aea251c0bc88946b6e502313b5457c4f794ebc"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Tabs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using BlazorApp1.Tabs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\VentasPorProducto.razor"
using static BlazorApp1.Shared.MainLayout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\VentasPorProducto.razor"
using static BlazorApp1.Tabs.TabMain;

#line default
#line hidden
#nullable disable
    public partial class VentasPorProducto : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "VentasPorProducto ");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\VentasPorProducto.razor"
                       Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 6 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\VentasPorProducto.razor"
 if (sFather.cuentas == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p>\r\n        coño\r\n    </p>");
#nullable restore
#line 11 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\VentasPorProducto.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.BlazorApp1.Tabs.VentasPorProducto.TypeInference.CreateSfGrid_0(__builder, 4, 5, 
#nullable restore
#line 14 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\VentasPorProducto.razor"
                         sFather.cuentas

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 14 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\VentasPorProducto.razor"
                                                       true

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 16 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\VentasPorProducto.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\VentasPorProducto.razor"
       

    [Parameter]
    public string Text { get; set; }

    [CascadingParameter]
    protected Pshared sFather { get; set; }



#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorApp1.Tabs.VentasPorProducto
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
