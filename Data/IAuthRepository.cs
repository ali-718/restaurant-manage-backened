using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Manage_Backened.Helpers.Response;
using Restaurant_Manage_Backened.Models;

namespace fyp_manage_backened.Data
{
    public interface IAuthRepository
    {
        public Task<ServiceResponse<int>> Register(User user, string password);
        public Task<ServiceResponse<string>> Login(string username, string password);
        public Task<bool> userExists(string username);
    }
}