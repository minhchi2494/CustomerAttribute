using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp.Services;
using BlazorApp.Models;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorApp.Pages
{
    public partial class CustomerAttributeView
    {
        [Inject]
        private ICustomerService _services { get; set; }
        private List<CustomerAttributeModel> model;
        private CustomerSearch CustomerSearch = new CustomerSearch();

        protected override async Task OnInitializedAsync()
        {
            model = await _services.getAll(CustomerSearch);
        }

        private async Task SeachForm(EditContext context)
        {
            model = await _services.getAll(CustomerSearch);
        }
    }
}
