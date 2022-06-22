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
    public class ProductController : ControllerBase
    {
        EcommerceDBContext ec;
        public ProductController(EcommerceDBContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ec.Products;
        }
        [HttpPost]
        public string Post([FromBody] Product product)
        {
            ec.Products.Add(product);
            ec.SaveChanges();
            return "success";
        }
    }
}
