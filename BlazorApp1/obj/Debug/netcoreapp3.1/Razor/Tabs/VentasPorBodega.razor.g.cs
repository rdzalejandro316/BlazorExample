#pragma checksum "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2778db7ddf42a2146f2b0d70ced2a4fc70464e6a"
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
#line 1 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using BlazorApp1.Tabs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\UTIL\blazor\BlazorApp1\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
using static BlazorApp1.Shared.MainLayout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
using static BlazorApp1.Tabs.TabMain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
using Syncfusion.Blazor.Cards;

#line default
#line hidden
#nullable disable
    public partial class VentasPorBodega : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"titletab\">Analisis de venta por bodega</h3>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Cards.SfCard>(4);
            __builder.AddAttribute(5, "class", "e-card cardpy");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, "<div class=\"container title-cardpy\">Registros</div>\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "\r\n            ");
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "class", "container");
                    __builder3.AddMarkupContent(14, "\r\n                ");
                    __builder3.AddContent(15, 
#nullable restore
#line 14 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                 sFather.bodegaRegistros

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(16, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(17, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Cards.SfCard>(20);
            __builder.AddAttribute(21, "class", "e-card cardpy");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.AddMarkupContent(24, "<div class=\"container title-cardpy\">Cantidad</div>\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(25);
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, "\r\n            ");
                    __builder3.OpenElement(28, "div");
                    __builder3.AddAttribute(29, "class", "container");
                    __builder3.AddMarkupContent(30, "\r\n                ");
                    __builder3.AddContent(31, 
#nullable restore
#line 22 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                 sFather.Cantidades.ToString("N")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Cards.SfCard>(36);
            __builder.AddAttribute(37, "class", "e-card cardpy");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.AddMarkupContent(40, "<div class=\"container title-cardpy\">Subtotal</div>\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(41);
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(43, "\r\n            ");
                    __builder3.OpenElement(44, "div");
                    __builder3.AddAttribute(45, "class", "container");
                    __builder3.AddMarkupContent(46, "\r\n                ");
                    __builder3.AddContent(47, 
#nullable restore
#line 31 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                 sFather.Subtotales.ToString("C")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(48, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(49, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(51, "\r\n\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Cards.SfCard>(52);
            __builder.AddAttribute(53, "class", "e-card cardpy");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.AddMarkupContent(56, "<div class=\"container title-cardpy\">Descuento</div>\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(57);
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(59, "\r\n            ");
                    __builder3.OpenElement(60, "div");
                    __builder3.AddAttribute(61, "class", "container");
                    __builder3.AddMarkupContent(62, "\r\n                ");
                    __builder3.AddContent(63, 
#nullable restore
#line 40 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                 sFather.Descuentos.ToString("C")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(64, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(65, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n\r\n\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Cards.SfCard>(68);
            __builder.AddAttribute(69, "class", "e-card cardpy");
            __builder.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.AddMarkupContent(72, "<div class=\"container title-cardpy\">Iva</div>\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(73);
                __builder2.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(75, "\r\n            ");
                    __builder3.OpenElement(76, "div");
                    __builder3.AddAttribute(77, "class", "container");
                    __builder3.AddMarkupContent(78, "\r\n                ");
                    __builder3.AddContent(79, 
#nullable restore
#line 50 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                 sFather.Iva.ToString("C")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(80, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(81, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Cards.SfCard>(84);
            __builder.AddAttribute(85, "class", "e-card cardpy");
            __builder.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(87, "\r\n        ");
                __builder2.AddMarkupContent(88, "<div class=\"container title-cardpy\">Total</div>\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(89);
                __builder2.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(91, "\r\n            ");
                    __builder3.OpenElement(92, "div");
                    __builder3.AddAttribute(93, "class", "container");
                    __builder3.AddMarkupContent(94, "\r\n                ");
                    __builder3.AddContent(95, 
#nullable restore
#line 59 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                 sFather.Totales.ToString("C")

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(96, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(97, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(98, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(99, "\r\n\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(100);
            __builder.AddAttribute(101, "CssClass", "BtnExport");
            __builder.AddAttribute(102, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                            ExcelExport

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(103, "Content", "Excel");
            __builder.CloseComponent();
            __builder.AddMarkupContent(104, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\r\n");
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfChart>(106);
            __builder.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(108, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartPrimaryXAxis>(109);
                __builder2.AddAttribute(110, "ValueType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ValueType>(
#nullable restore
#line 68 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                  Syncfusion.Blazor.Charts.ValueType.Category

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.ChartSeriesCollection>(112);
                __builder2.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(114, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.ChartSeries>(115);
                    __builder3.AddAttribute(116, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 70 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                  sFather.bodega

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(117, "XName", "nom_bod");
                    __builder3.AddAttribute(118, "YName", "neto");
                    __builder3.AddAttribute(119, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 70 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                     ChartSeriesType.SplineArea

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(120, "\r\n");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(121, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(122, "\r\n\r\n\r\n");
#nullable restore
#line 76 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
 if (sFather.bodega == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "    ");
            __builder.AddMarkupContent(124, "<p>\r\n        no existen bodega\r\n    </p>\r\n");
#nullable restore
#line 81 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "    ");
            __Blazor.BlazorApp1.Tabs.VentasPorBodega.TypeInference.CreateSfGrid_0(__builder, 126, 127, 
#nullable restore
#line 84 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                            sFather.bodega

#line default
#line hidden
#nullable disable
            , 128, 
#nullable restore
#line 84 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                         true

#line default
#line hidden
#nullable disable
            , 129, 
#nullable restore
#line 84 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
            , 130, 
#nullable restore
#line 84 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                                                     true

#line default
#line hidden
#nullable disable
            , 131, (__builder2) => {
                __builder2.AddMarkupContent(132, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(133);
                __builder2.AddAttribute(134, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(135, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(136);
                    __builder3.AddAttribute(137, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 86 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                               nameof(Bodega.cod_bod)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(138, "HeaderText", "Codigo");
                    __builder3.AddAttribute(139, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 86 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                     TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(140, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 86 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                                                        TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(141, "Width", "80");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(142, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(143);
                    __builder3.AddAttribute(144, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                               nameof(Bodega.nom_bod)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(145, "HeaderText", "Bodega");
                    __builder3.AddAttribute(146, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 87 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                     TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(147, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 87 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                                                        TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(148, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(149, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(150);
                    __builder3.AddAttribute(151, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 88 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                               nameof(Bodega.cantidad)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(152, "HeaderText", "Cnt Vta");
                    __builder3.AddAttribute(153, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 88 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                       TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(154, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 88 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                                                          TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(155, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(156, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(157);
                    __builder3.AddAttribute(158, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 89 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                               nameof(Bodega.can_dev)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(159, "HeaderText", "Cnt Dev");
                    __builder3.AddAttribute(160, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 89 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                      TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(161, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 89 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                                                         TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(162, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(163, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(164);
                    __builder3.AddAttribute(165, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 90 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                               nameof(Bodega.neto)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(166, "HeaderText", "Neto");
                    __builder3.AddAttribute(167, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 90 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(168, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 90 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                                                   TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(169, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(170, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(171);
                    __builder3.AddAttribute(172, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 91 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                               nameof(Bodega.subtotal)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(173, "HeaderText", "Subtotal");
                    __builder3.AddAttribute(174, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 91 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                        TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(175, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 91 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                                                           TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(176, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(177, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(178);
                    __builder3.AddAttribute(179, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 92 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                               nameof(Bodega.val_des)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(180, "HeaderText", "Descuento");
                    __builder3.AddAttribute(181, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 92 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                        TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(182, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 92 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                                                           TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(183, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(184, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(185);
                    __builder3.AddAttribute(186, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 93 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                               nameof(Bodega.val_iva)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(187, "HeaderText", "Iva");
                    __builder3.AddAttribute(188, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 93 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                  TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(189, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 93 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                                                     TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(190, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(191, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(192);
                    __builder3.AddAttribute(193, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 94 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                               nameof(Bodega.total)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(194, "HeaderText", "Total");
                    __builder3.AddAttribute(195, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 94 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                  TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(196, "HeaderTextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.TextAlign>(
#nullable restore
#line 94 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                                                                                                                     TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(197, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(198, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(199, "\r\n    ");
            }
            , 200, (__value) => {
#nullable restore
#line 84 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
                  DefaultGrid = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.AddMarkupContent(201, "\r\n");
#nullable restore
#line 97 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(202, "\r\n\r\n\r\n\r\n\r\n");
            __builder.AddMarkupContent(203, @"<style>

    /*tr{
        background: var(--MainColor);
        color: white;
    } */

    .e-columnheader th {
        background-color: whitesmoke !important;
        color: black !important;
    }

    .titletab {
        color: #0078d6;
        margin: 10px;
        font-weight: lighter;
    }

    .e-card-header-title {
        padding-left: 10% !important;
    }

    .container {
        text-align: center;
    }

    .title-cardpy {
        color: var(--MainColor);
        font-weight: bolder;
    }

    .BtnExport {
        height: 50px;
        align-self: center;
        margin-right: 10px;
        background: var(--MainColor);
        color: white;
    }

    .cardpy {
        margin: 5px !important;
        position: inherit
    }

    .card-container {
        display: flex;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "D:\UTIL\blazor\BlazorApp1\Tabs\VentasPorBodega.razor"
       

    [CascadingParameter]
    public Pshared sFather { get; set; }

    public int Registros = 0;
    public decimal Cantidades = 0;


    private SfGrid<TabMain.Bodega> DefaultGrid;


    public async Task ExcelExport()
    {
        ExcelExportProperties ExcelProperties = new ExcelExportProperties();
        ExcelTheme Theme = new ExcelTheme();

        ExcelStyle ThemeStyle = new ExcelStyle()
        {
            FontName = "Segoe UI",
            FontColor = "#666666",
            FontSize = 12
        };

        Theme.Header = ThemeStyle;
        Theme.Record = ThemeStyle;
        Theme.Caption = ThemeStyle;
        ExcelProperties.Theme = Theme;
        await DefaultGrid.ExcelExport(ExcelProperties);
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorApp1.Tabs.VentasPorBodega
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::System.Action<global::Syncfusion.Blazor.Grids.SfGrid<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "AllowSorting", __arg2);
        __builder.AddAttribute(__seq3, "AllowExcelExport", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.AddComponentReferenceCapture(__seq5, (__value) => { __arg5((global::Syncfusion.Blazor.Grids.SfGrid<TValue>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
