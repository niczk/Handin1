#pragma checksum "C:\Users\Nick\OneDrive\Documents\School\3. semester\DNP\handin\Handin1\Pages\AdultView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f7f2d0c76113b1135d97913067a9227bd1a1bfa"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
