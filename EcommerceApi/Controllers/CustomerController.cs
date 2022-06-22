using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApi.Models;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        EcommerceDBContext ec;
        public CustomerController(EcommerceDBContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return ec.Customers;
        }
        [HttpPost]
        public string Post([FromBody] Customer customer)
        {
            ec.Customers.Add(customer);
            ec.SaveChanges();
            return "success";
        }
    }
}
