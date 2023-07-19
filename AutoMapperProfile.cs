using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Restaurant_Manage_Backened.Dtos.BankDtos;
using Restaurant_Manage_Backened.Models;

namespace Restaurant_Manage_Backened
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddBankDtos, Bank>();
            CreateMap<updateBankDtos, Bank>();
        }
    }
}