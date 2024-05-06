using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFLogin.Models.ViewModels;

namespace EFLogin.Models.Services.Application
{
    public interface ISignInService
    {
        Task<UserDetailViewModel> CreateNewUser();

    }
}