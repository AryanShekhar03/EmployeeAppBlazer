#pragma checksum "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Delete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "743d02213d02e0ca7175eb4c4398aed3355567c2"
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
#line 3 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Delete.razor"
using CommonLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Delete.razor"
using BusinessLayer.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Delete/{empid}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<header class=""header-content header"">
    <div class=""logo-content"">
        <h2>Delete</h2>
        <a href> <img src=""/IMG/logo.png alt="" logo image""></a>
        <div>
            <span class=""emp-text"">EMPLOYEE</span><br>
            <span class=""emp-text emp-payroll"">PAYROLL  </span>
        </div>
    </div>
</header>
");
            __builder.AddMarkupContent(1, "<h3>Are you sure you want to delete employee?</h3>\r\n<br>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-content");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 22 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Delete.razor"
                      empM

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row-content");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.AddMarkupContent(12, "<label> ID:</label>\r\n            ");
                __builder2.OpenElement(13, "label");
                __builder2.AddContent(14, 
#nullable restore
#line 25 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Delete.razor"
                    empM.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "row-content");
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddMarkupContent(20, "<label>Name:</label>\r\n            ");
                __builder2.OpenElement(21, "label");
                __builder2.AddContent(22, 
#nullable restore
#line 29 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Delete.razor"
                    empM.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "row-content");
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.AddMarkupContent(28, "<label>Gender:</label>\r\n            ");
                __builder2.OpenElement(29, "label");
                __builder2.AddContent(30, 
#nullable restore
#line 33 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Delete.razor"
                    empM.Gender

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "row-content");
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.AddMarkupContent(36, "<label>Department:</label>\r\n            ");
                __builder2.OpenElement(37, "label");
                __builder2.AddContent(38, 
#nullable restore
#line 37 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Delete.razor"
                    empM.Department

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "row-content");
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.AddMarkupContent(44, "<label>Notes:</label>\r\n            ");
                __builder2.OpenElement(45, "label");
                __builder2.AddContent(46, 
#nullable restore
#line 41 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Delete.razor"
                    empM.Notes

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "button-content");
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.AddMarkupContent(52, "<a href=\"/emphome\" class=\"add-button\">Cancel</a>\r\n            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "submit-reset");
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.OpenElement(56, "input");
                __builder2.AddAttribute(57, "type", "button");
                __builder2.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Delete.razor"
                                                 x=>DeleteEmp(@empM.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(59, "class", "btn btn-primary");
                __builder2.AddAttribute(60, "value", "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(64, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\Shivam Shekhar\source\EmpWageDemoBlazer\EmpWageDemoBlazer\Pages\Delete.razor"
       

    EmployeeModel empM = new EmployeeModel();

    [Parameter]
    public string empid { get; set; }
    protected void DeleteEmp(long Id)
    {
        registerBL.DeleteEmployee(Id);
        navigate.NavigateTo("Dashboard");

    }

    protected override async Task OnInitializedAsync()
    {

        empM = await Task.Run(() => registerBL.GetEmployeeData(Convert.ToInt32(empid)));

    }
    void Cancel()
    {
        navigate.NavigateTo("Dashboard");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRegisterBL registerBL { get; set; }
    }
}
#pragma warning restore 1591