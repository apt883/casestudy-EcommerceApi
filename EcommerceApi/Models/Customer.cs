using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceApi.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
