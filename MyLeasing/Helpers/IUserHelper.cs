﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}
