// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages
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
#line 2 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Pages\Index.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Pages\Index.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Pages\Index.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Pages\Index.razor"
      

    public class LineChartData
    {
        public DateTime xValue { get; set; }
        public double yValue { get; set; }
        public double yValue1 { get; set; }
    }
    public List<LineChartData> ChartData = new List<LineChartData>
{
        new LineChartData { xValue = new DateTime(2005, 01, 01), yValue = 21, yValue1 = 28 },
        new LineChartData { xValue = new DateTime(2006, 01, 01), yValue = 24, yValue1 = 44 },
        new LineChartData { xValue = new DateTime(2007, 01, 01), yValue = 36, yValue1 = 48 },
        new LineChartData { xValue = new DateTime(2008, 01, 01), yValue = 38, yValue1 = 50 },
        new LineChartData { xValue = new DateTime(2009, 01, 01), yValue = 54, yValue1 = 66 },
        new LineChartData { xValue = new DateTime(2010, 01, 01), yValue = 57, yValue1 = 78 },
        new LineChartData { xValue = new DateTime(2011, 01, 01), yValue = 70, yValue1 = 84 },
    };


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
