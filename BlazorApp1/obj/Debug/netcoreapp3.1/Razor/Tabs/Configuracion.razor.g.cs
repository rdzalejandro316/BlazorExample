#pragma checksum "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f7df48354fa45e417329de41f9a66af5b515d0"
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
#line 1 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor"
using Syncfusion.Blazor.Cards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    public partial class Configuracion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Syncfusion.Blazor.Cards.SfCard>(0);
            __builder.AddAttribute(1, "ID", "BasicCard");
            __builder.AddAttribute(2, "class", "e-card");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardHeader>(4);
                __builder2.AddAttribute(5, "Title", "Filtros de Consulta");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(7);
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(9, "div");
                    __builder3.AddAttribute(10, "class", "container");
                    __builder3.AddMarkupContent(11, "<div class=\"row\"><div class=\"col-sm\"></div>\r\n                <div class=\"col-sm\">Desde</div>\r\n                <div class=\"col-sm\">Hasta</div>\r\n                <div class=\"col-sm\"></div></div>\r\n            ");
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "class", "row");
                    __builder3.AddMarkupContent(14, "<div class=\"col-sm\"></div>\r\n                ");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-sm");
                    __builder3.OpenElement(17, "div");
                    __builder3.AddAttribute(18, "id", "datepicker-control");
                    __builder3.OpenComponent<Syncfusion.Blazor.Calendars.SfDatePicker<DateTime?>>(19);
                    __builder3.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DateTime?>(
#nullable restore
#line 20 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor"
                                                                 fecact

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "Placeholder", "Choose a Date");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(22, "\r\n                ");
                    __builder3.OpenElement(23, "div");
                    __builder3.AddAttribute(24, "class", "col-sm");
                    __builder3.OpenElement(25, "div");
                    __builder3.AddAttribute(26, "id", "datepicker-control");
                    __builder3.OpenComponent<Syncfusion.Blazor.Calendars.SfDatePicker<DateTime?>>(27);
                    __builder3.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DateTime?>(
#nullable restore
#line 25 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor"
                                                                 fecact

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Placeholder", "Choose a Date");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(30, "\r\n                <div class=\"col-sm\"></div>");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(31, "\r\n            ");
                    __builder3.AddMarkupContent(32, "<div class=\"row\"><div class=\"col-sm\">-</div>\r\n                <div class=\"col-sm\">-</div>\r\n                <div class=\"col-sm\">-</div>\r\n                <div class=\"col-sm\">-</div></div>\r\n            ");
                    __builder3.AddMarkupContent(33, "<div class=\"row\"><div class=\"col-sm\">-</div>\r\n                <div class=\"col-sm\">-</div>\r\n                <div class=\"col-sm\">-</div>\r\n                <div class=\"col-sm\">-</div></div>\r\n            ");
                    __builder3.OpenElement(34, "div");
                    __builder3.AddAttribute(35, "class", "row");
                    __builder3.OpenElement(36, "div");
                    __builder3.AddAttribute(37, "class", "col-sm");
                    __builder3.OpenElement(38, "button");
                    __builder3.AddAttribute(39, "class", "btn btn-primary");
                    __builder3.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor"
                                                              IncrementCount

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(41, "Click me");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(42, "\r\n                ");
                    __builder3.OpenElement(43, "div");
                    __builder3.AddAttribute(44, "class", "col-sm");
                    __builder3.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(45);
                    __builder3.AddAttribute(46, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor"
                                         true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor"
                                                         ClickEvent

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(49, "Consultar");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\r\n                ");
                    __builder3.OpenElement(51, "div");
                    __builder3.AddAttribute(52, "class", "col-sm");
                    __builder3.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(53);
                    __builder3.AddAttribute(54, "IsPrimary", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 50 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor"
                                         true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(56, "Salir");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(57, "\r\n                ");
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "col-sm");
                    __builder3.OpenElement(60, "p");
                    __builder3.AddContent(61, "Current count: ");
                    __builder3.AddContent(62, 
#nullable restore
#line 53 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor"
                                       currentCount

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardFooter>(64);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n\r\n");
            __builder.AddMarkupContent(66, "<style>\r\n    .e-card {\r\n        margin: auto;\r\n        width: 50%\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Tabs\Configuracion.razor"
       

    DateTime fecact = DateTime.Now;
    private readonly IJSRuntime JsRuntime;
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
        Console.WriteLine("hooo my good");
    }

    private async void ClickEvent(MouseEventArgs args)
    {
        try
        {
            currentCount++;
            Console.WriteLine("click xd");
            await this.JsRuntime.InvokeVoidAsync("console.log", "xdxdxd");

        }
        catch (Exception e)
        {
            Console.WriteLine("error en el click:"+e);
        }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591