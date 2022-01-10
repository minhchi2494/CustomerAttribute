using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp.Services;
using BlazorApp.Models;

using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class CustomerAttributeView
    {
        [Inject]
        private ICustomerService _services { get; set; }
        private List<CustomerAttributeModel> model { set; get; }

        protected override async Task OnInitializedAsync()
        {
            model = await _services.getAll();
        }


        /*public async Task Edit_ClickAsync(int id)
        {
            navigation.NavigateTo("/details/" + id);
        }*/

    }
}
