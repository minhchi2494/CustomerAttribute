using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp.Models;

namespace BlazorApp.Services
{
    public interface ICustomerService
    {
        Task<List<CustomerAttributeModel>> getAll();

        Task<CustomerAttributeModel> GetOne(int id);

        Task<CustomerAttributeModel> Create(CustomerAttributeModel newCust);
        Task<CustomerAttributeModel> Edit(CustomerAttributeModel editCust);
        Task<CustomerAttributeModel> Delete(int id);
    }
}
