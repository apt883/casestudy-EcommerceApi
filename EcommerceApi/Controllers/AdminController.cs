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
    public class AdminController : ControllerBase
    {
        EcommerceDBContext ec;
        public AdminController(EcommerceDBContext _ec)
        {
            ec = _ec;
        }
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            return ec.Admins;
        }
        [HttpPost]
        public string Post([FromBody] Admin admin)
        {
            ec.Admins.Add(admin);
            ec.SaveChanges();
            return "success";
        }
    }
}
