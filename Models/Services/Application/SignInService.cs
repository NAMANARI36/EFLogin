using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFLogin.Models.Entities;
using EFLogin.Models.ViewModels;
//using EFLogin.Models.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;



namespace EFLogin.Models.Services.Application
{
    public class SignInService : ISignInService
    {
        private readonly UserDbContext dbContext;


        public SignInService(UserDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<User> CreateNewUser(string Nome, string Email, string Password, string Country)
        {

            await dbContext.Users.InsertOnSubmit(user => new User
            {
                user.Name = Nome,
                user.Email = Email,
                user.Password = Password,
                user.Country = Country
            });
            dbContext.SubmitChanges();

            

        }

    }
}