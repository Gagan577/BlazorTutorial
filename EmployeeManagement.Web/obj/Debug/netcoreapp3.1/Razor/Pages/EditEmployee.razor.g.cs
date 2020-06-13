#pragma checksum "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f1a43c553f8614ce90a438658cef0461f42ff26"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Atip.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editemployee/{id}")]
    public partial class EditEmployee : EditEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                      Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.AddMarkupContent(4, "<h3>Edit Employee</h3>\r\n        <hr>\r\n        ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-group row");
                __builder2.AddMarkupContent(7, "\r\n            ");
                __builder2.AddMarkupContent(8, "<label for=\"firstName\" class=\"col-sm-2 col-form-label\">\r\n                First Name\r\n            </label>\r\n            ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-sm-10");
                __builder2.AddMarkupContent(11, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "firstName");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "placeholder", "First Name");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                        Employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group row");
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.AddMarkupContent(25, "<label for=\"lastName\" class=\"col-sm-2 col-form-label\">\r\n                Last Name\r\n            </label>\r\n            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-sm-10");
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "id", "lastName");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "placeholder", "Last Name");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                        Employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group row");
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.AddMarkupContent(42, "<label for=\"email\" class=\"col-sm-2 col-form-label\">\r\n                Email\r\n            </label>\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-sm-10");
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "id", "email");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "placeholder", "Email");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                        Employee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Email = __value, Employee.Email))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group row");
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.AddMarkupContent(59, "<label for=\"department\" class=\"col-sm-2 col-form-label\">\r\n                Department\r\n            </label>\r\n            ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-sm-10");
                __builder2.AddMarkupContent(62, "\r\n                ");
                __Blazor.EmployeeManagement.Web.Pages.EditEmployee.TypeInference.CreateCustomInputSelect_0(__builder2, 63, 64, "department", 65, "form-control", 66, 
#nullable restore
#line 41 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                                                Employee.DepartmentId

#line default
#line hidden
#nullable disable
                , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.DepartmentId = __value, Employee.DepartmentId)), 68, () => Employee.DepartmentId, 69, (__builder3) => {
                    __builder3.AddMarkupContent(70, "\r\n");
#nullable restore
#line 42 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                     foreach(var dept in Departments)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(71, "                        ");
                    __builder3.OpenElement(72, "option");
                    __builder3.AddAttribute(73, "value", 
#nullable restore
#line 44 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                        dept.DepartmentId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(74, 
#nullable restore
#line 44 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                                                            dept.DepartmentName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(75, "\r\n");
#nullable restore
#line 45 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EditEmployee.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(76, "                ");
                }
                );
                __builder2.AddMarkupContent(77, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.EmployeeManagement.Web.Pages.EditEmployee
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Atip.Components.CustomInputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
