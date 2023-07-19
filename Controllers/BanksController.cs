using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Manage_Backened.Dtos.BankDtos;

namespace Restaurant_Manage_Backened.Data
{
    [ApiController]
    [Route("api/[controller]")]
    public class BanksController : ControllerBase
    {
        private readonly BankService _bankService;
        private readonly ActionResponse _response;
        public BanksController(BankService bankService, ActionResponse actionResponse)
        {
            _bankService = bankService;
            _response = actionResponse;
        }

        [HttpPost("addBank")]
        public async Task<ActionResult<ServiceResponse<string>>> addBankDetails(AddBankDtos bankDetails)
        {
            var response = await _bankService.addBankDetails(bankDetails);
            return _response.GetActionResult(response);
        }

        [HttpPost("updateBank")]
        public async Task<ActionResult<ServiceResponse<string>>> updateBankDetails(updateBankDtos bankDetails)
        {
            var response = await _bankService.updateBankDetails(bankDetails);
            return _response.GetActionResult(response);
        }

        [HttpDelete("deleteBank")]
        public async Task<ActionResult<ServiceResponse<string>>> deleteBankDetails(int bankId)
        {
            var response = await _bankService.deleteBankDetails(bankId);
            return _response.GetActionResult(response);
        }
    }
}