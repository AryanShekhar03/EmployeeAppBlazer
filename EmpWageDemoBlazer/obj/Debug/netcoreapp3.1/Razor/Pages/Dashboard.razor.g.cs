#pragma checksum "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3d30e75ce5323358abaeb1484f994a86529376d"
// <auto-generated/>
#pragma warning disable 1591
namespace EmpWageDemoBlazer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\_Imports.razor"
using EmpWageDemoBlazer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\_Imports.razor"
using EmpWageDemoBlazer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
using CommonLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
using BusinessLayer.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dashboard")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "Reg");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Add New\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>Employee Details</h1>\r\n");
#nullable restore
#line 13 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
 if (employeeModels == null) //IF Emp data not found it will show loading
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 16 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, @"<thead>
            <tr>
                <th>Id</th>
                <th>Name</th>
                <th>Gender</th>
                <th>Department</th>
                <th>ProfileIMG</th>
                <th>Notes</th>
                <th>Action</th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 32 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
             foreach (var empM in employeeModels)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 35 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
                     empM.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 36 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
                     empM.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 37 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
                     empM.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 38 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
                     empM.Department

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 39 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
                     empM.ProfileImg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 40 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
                     empM.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                \r\n                ");
            __builder.OpenElement(37, "td");
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "/Update/" + (
#nullable restore
#line 43 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
                                                       empM.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\r\n                        <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span> Edit\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "href", "/Delete/" + (
#nullable restore
#line 46 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
                                                       empM.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "\r\n                        <span class=\"oi oi-trash\" aria-hidden=\"true\"></span> Delete\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 51 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 54 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Dashboard.razor"
       
    EmployeeModel empM = new EmployeeModel();
    IEnumerable<EmployeeModel> employeeModels;
    protected override async Task OnInitializedAsync()//TO Reduce loading time
    {
        
         employeeModels= await Task.Run(() => registerBL.GetAllEmployees());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRegisterBL registerBL { get; set; }
    }
}
#pragma warning restore 1591
