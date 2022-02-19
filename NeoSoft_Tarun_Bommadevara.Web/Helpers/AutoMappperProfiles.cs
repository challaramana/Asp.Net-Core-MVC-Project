using AutoMapper;
using NeoSoft.Infrastructure.EF.Models;
using NeoSoft_Tarun_Bommadevara.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoft_Tarun_Bommadevara.Web.Helpers
{
    public class AutoMappperProfiles : Profile
    {
        public AutoMappperProfiles()
        {
            CreateMap<EmployeeViewModel, EmployeeMaster>();
            CreateMap<EmployeeMaster, EmployeeViewModel>();
        }
    }
}
