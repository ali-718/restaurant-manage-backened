using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_Manage_Backened.Helpers.Response
{
    public class ServiceResponse<T>
    {
        public T? data { get; set; }
        public bool isSuccess { get; set; } = true;
        public string Message { get; set; } = string.Empty;
        public object? error { get; set; }
    }
}
