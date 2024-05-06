using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFLogin.Models.Entities;
using EFLogin.Models.ViewModels;
using EFLogin.Models.Services.Infrastructure;


namespace EFLogin.Models.Services.Application
{
    public class SignInService : ISignInService
    {
        private readonly UserDbContext dbContext;


        public SignInService(UserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


       public async Task<UserDetailViewModel> CreateNewUser()
       {



       }

    }
}