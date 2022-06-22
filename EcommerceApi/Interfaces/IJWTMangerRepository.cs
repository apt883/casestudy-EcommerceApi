using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApi.ViewModels;

namespace EcommerceApi.Interfaces
{
    public interface IJWTMangerRepository
    {
        Tokens Authenicate(LoginViewModel users, bool IsRegister);
    }
}
