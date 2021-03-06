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
#line 12 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Pages\Index.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Pages\Index.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Pages\Index.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\aleja\Desktop\UTIL\blazor\BlazorApp1\Pages\Index.razor"
       
    private string UserName { get; set; } = "";
    private string Password { get; set; } = "";
    private Boolean DisableTab { get; set; } = true;
    private Boolean Disabled { get; set; } = false;
    private int SelectedTab { get; set; } = 0;
    public List<Order> Orders { get; set; }

    protected override void OnInitialized()
    {
        Orders = Enumerable.Range(1, 6).Select(x => new Order()
        {
            OrderID = 1000 + x,
            CustomerID = (new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" })[new Random().Next(5)],
            Freight = 2.1 * x,
            OrderDate = DateTime.Now.AddDays(-x),
        }).ToList();
    }

    private void OnClicked()
    {
        if (this.UserName == "" && this.Password == "")
        {
            Console.WriteLine("clicked");
        }
        else if (this.UserName == "")
        {
            Console.WriteLine("Enter the username");
        }
        else if (this.Password == "")
        {
            Console.WriteLine("Enter the password");
        }
        else if (this.UserName.Length < 4)
        {
            Console.WriteLine("Username must be minimum 4 characters");
        }
        else
        {
            this.UserName = "";
            this.Password = "";
            this.DisableTab = false;
            this.Disabled = true;
            this.SelectedTab = 1;
        }
    }

    public class Order
    {
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Freight { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
