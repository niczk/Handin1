#pragma checksum "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f7f2d0c76113b1135d97913067a9227bd1a1bfa"
// <auto-generated/>
#pragma warning disable 1591
namespace Handin1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\_Imports.razor"
using Handin1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\_Imports.razor"
using Handin1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
using Handin1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
using Handin1.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adults")]
    public partial class AdultView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>View Adults</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "width", "100%");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "tr");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "td");
            __builder.AddMarkupContent(7, "\r\n            Filter by First Name:\r\n            ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                                           (arg) => FilterByFirstName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "style", "width:150px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\r\n            Filter by Last Name:\r\n            ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                                           (arg) => FilterByLastName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "style", "width:150px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "td");
            __builder.AddMarkupContent(23, "\r\n            Filter by Job Title:\r\n            ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "type", "text");
            __builder.AddAttribute(26, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                                           (arg) => FilterByJob(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "style", "width:150px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
#nullable restore
#line 24 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
 if (adults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "    ");
            __builder.AddMarkupContent(33, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 29 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
}
else if(!adults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "    ");
            __builder.AddMarkupContent(35, "<p>\r\n        <em>No adults exist. Please add some.</em>\r\n    </p>\r\n");
#nullable restore
#line 35 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "    ");
            __builder.OpenElement(37, "table");
            __builder.AddAttribute(38, "class", "table");
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "thead");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "tr");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.AddMarkupContent(44, "<th>ID</th>\r\n                ");
            __builder.AddMarkupContent(45, "<th>First Name</th>\r\n                ");
            __builder.AddMarkupContent(46, "<th>Last Name</th>\r\n                ");
            __builder.AddMarkupContent(47, "<th>Job Title</th>\r\n                ");
            __builder.AddMarkupContent(48, "<th>Hair Color</th>\r\n                ");
            __builder.AddMarkupContent(49, "<th>Eye Color</th>\r\n                ");
            __builder.AddMarkupContent(50, "<th>Age</th>\r\n                ");
            __builder.AddMarkupContent(51, "<th>Weight</th>\r\n                ");
            __builder.AddMarkupContent(52, "<th>Height</th>\r\n                ");
            __builder.AddMarkupContent(53, "<th>Sex</th>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(54);
            __builder.AddAttribute(55, "Policy", "SecurityLevel1");
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(57, "\r\n                    ");
                __builder2.AddMarkupContent(58, "<th>Remove</th>\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "tbody");
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 57 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
             foreach(var item in adultsFiltered)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "            ");
            __builder.OpenElement(65, "tr");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "td");
            __builder.AddContent(68, 
#nullable restore
#line 60 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "td");
            __builder.AddContent(71, 
#nullable restore
#line 61 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "td");
            __builder.AddContent(74, 
#nullable restore
#line 62 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 63 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                     item.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "td");
            __builder.AddContent(80, 
#nullable restore
#line 64 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 65 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.OpenElement(85, "td");
            __builder.AddContent(86, 
#nullable restore
#line 66 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                ");
            __builder.OpenElement(88, "td");
            __builder.AddContent(89, 
#nullable restore
#line 67 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, " kg");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                ");
            __builder.OpenElement(92, "td");
            __builder.AddContent(93, 
#nullable restore
#line 68 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(94, " cm");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.OpenElement(96, "td");
            __builder.AddContent(97, 
#nullable restore
#line 69 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(99);
            __builder.AddAttribute(100, "Policy", "SecurityLevel1");
            __builder.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(102, "\r\n                    ");
                __builder2.OpenElement(103, "td");
                __builder2.AddMarkupContent(104, "\r\n                        ");
                __builder2.OpenElement(105, "button");
                __builder2.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
                                            () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(107, "\r\n                            <i class=\"oi oi-trash\" style=\"color:red\"></i>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(108, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n");
#nullable restore
#line 78 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(112, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#nullable restore
#line 81 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor"
       

    private IList<Adult> adults;
    private IList<Adult> adultsFiltered;

    string? filterbyFirstName = null;
    string? filterByLastName = null;
    string? filterByJob = null;

    private async Task RemoveAdult(int adultId)
    {
        Adult adultToRemove = adults.First(a => a.Id == adultId);
        await AdultList.RemoveAdult(adultId);
        adults.Remove(adultToRemove);
    }

    private void FilterByFirstName(ChangeEventArgs changeEventArgs)
    {
        filterbyFirstName = null;
        try
        {
            filterbyFirstName = changeEventArgs.Value.ToString();
        }
        catch (Exception e) { }
        ExecuteFilter();
    }

    private void FilterByLastName(ChangeEventArgs changeEventArgs)
    {
        filterByLastName = null;
        try
        {
            filterByLastName = changeEventArgs.Value.ToString();
        }
        catch (Exception e) { }
        ExecuteFilter();
    }

    private void FilterByJob(ChangeEventArgs changeEventArgs)
    {
        filterByJob = null;
        try
        {
            filterByJob = changeEventArgs.Value.ToString();
        }
        catch (Exception e) { }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        adultsFiltered = adults.Where(a =>
            (filterbyFirstName != null && a.FirstName.Contains(filterbyFirstName) || filterbyFirstName == null) &&
            (filterByLastName != null && a.LastName.Contains(filterByLastName) || filterByLastName == null) &&
            (filterByJob != null && a.JobTitle.Contains(filterByJob) || filterByJob == null)
        ).ToList();
    }

    protected override async Task OnInitializedAsync()
    {
        adults = await AdultList.GetAdults();
        adultsFiltered = adults;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultList AdultList { get; set; }
    }
}
#pragma warning restore 1591
