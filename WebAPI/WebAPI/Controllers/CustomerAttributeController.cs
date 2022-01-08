using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Services;
using WebAPI.Models;
namespace CustomerAttributeBlazor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAttributeController : ControllerBase
    {
        private readonly ICustomerAttributeService _service;

        public CustomerAttributeController(ICustomerAttributeService service)
        {
            _service = service;
        }

        [HttpGet]
        public Task<List<CustomerAttributeModel>> getALl()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public Task<CustomerAttributeModel> getOne(int id)
        {
            return _service.GetOne(id);
        }

        [HttpPost]
        public Task<CustomerAttributeModel> create(CustomerAttributeModel newCust)
        {
            return _service.Create(newCust);
        }

        [HttpDelete("{id}")]
        public Task<CustomerAttributeModel> delete(int id)
        {
            return _service.Delete(id);
        }

        [HttpPut]
        public Task<CustomerAttributeModel> edit(CustomerAttributeModel editCust)
        {
            return _service.Edit(editCust);
        }
    }
}
