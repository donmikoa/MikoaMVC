using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MikoaMVC.Models;
using MikoaMVC.Dtos;

namespace MikoaMVC.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}