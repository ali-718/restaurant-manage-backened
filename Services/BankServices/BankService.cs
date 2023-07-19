using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Restaurant_Manage_Backened.Dtos.BankDtos;

namespace Restaurant_Manage_Backened.Services.BankServices
{
    public class BankService : IBankService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public BankService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<ServiceResponse<string>> addBankDetails(AddBankDtos bankDetails)
        {
            var response = new ServiceResponse<string>();
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == bankDetails.userId);
                if (user is null)
                {
                    throw new Exception("User not found");
                }
                var mapped = _mapper.Map<Bank>(bankDetails);
                mapped.User = user;
                _context.Banks.Add(mapped);
                await _context.SaveChangesAsync();
                response.data = "Bank details added successfully";
            }
            catch (System.Exception e)
            {
                response.isSuccess = false;
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<string>> deleteBankDetails(int bankId)
        {
            var response = new ServiceResponse<string>();
            var bank = await _context.Banks.FirstOrDefaultAsync(b => b.Id == bankId);
            if (bank is null)
            {
                response.isSuccess = false;
                response.Message = "Invalid Bank Id";
                return response;
            }
            _context.Banks.Remove(bank);
            await _context.SaveChangesAsync();
            response.data = "Data deleted successfully";
            return response;
        }

        public async Task<ServiceResponse<string>> updateBankDetails(updateBankDtos bankDetails)
        {
            var response = new ServiceResponse<string>();
            try
            {
                var bank = await _context.Banks.FirstOrDefaultAsync(b => b.Id == bankDetails.Id && b!.User!.Id == bankDetails.UserId);
                if (bank is null)
                {
                    throw new Exception("Invalid bank details");
                }
                _mapper.Map(bankDetails, bank);
                await _context.SaveChangesAsync();
                response.data = "Bank updated";
            }
            catch (System.Exception e)
            {
                response.isSuccess = false;
                response.Message = e.Message;
            }
            return response;
        }
    }
}