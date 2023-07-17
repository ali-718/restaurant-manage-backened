using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant_Manage_Backened.Helpers.Response
{
    public class ActionResponse : ControllerBase
    {
        public ActionResult<ServiceResponse<T>> GetActionResult<T>(ServiceResponse<T> response)
        {
            if (response.isSuccess is false)
            {
                return BadRequest(response);
            }
            return Ok(response);
        }
    }
}