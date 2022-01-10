using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface ICustomerAttributeService
    {
        Task<List<CustomerAttributeModel>> GetAll();
        Task<CustomerAttributeModel> GetOne(int id);
        Task<CustomerAttributeModel> Create(CustomerAttributeModel newCust);
        Task<CustomerAttributeModel> Edit(CustomerAttributeModel editCust);
        Task<CustomerAttributeModel> Delete(int id);
    }
}
