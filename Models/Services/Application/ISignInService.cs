using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFLogin.Models.ViewModels;
using EFLogin.Models.Entities;

namespace EFLogin.Models.Services.Application
{
    public interface ISignInService
    {
        Task<User> CreateNewUser(string Nome, string Email, string Password, string Country);

    }
}