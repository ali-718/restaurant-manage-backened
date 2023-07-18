using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Manage_Backened.Dtos.BankDtos;

namespace Restaurant_Manage_Backened.Services.BankServices
{
    public interface IBankService
    {
        public Task<ServiceResponse<string>> addBankDetails(AddBankDtos bankDetails);
        public Task<ServiceResponse<string>> deleteBankDetails(int bankId);
        public Task<ServiceResponse<string>> updateBankDetails(updateBankDtos bankDetails);
    }
}