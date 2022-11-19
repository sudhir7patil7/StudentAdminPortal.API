using AutoMapper;
using StudentAdminPortal.API.DomainModels;
using DataModel=StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModel.Student, Student>()
                .ReverseMap();            
            CreateMap<DataModel.Gender, Gender>()
                .ReverseMap();
            CreateMap<DataModel.Address, Address>()
                .ReverseMap();
        }
    }
}
