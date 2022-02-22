﻿using NeoSoft.Infrastructure.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSoft.Infrastructure.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<State>> GetStateDropDownData(int id);
        Task<IEnumerable<City>> GetCityDropDownData(int id);
        Task AddEmployee(EmployeeMaster employeeMaster);
        IEnumerable<Country> GetCountryDetails();
        Task<NeosoftRecord> GetEmployees(NeoSoftViewQuery query);
        Task<EmployeeMaster> GetEmployeRecord(int id);
        Task RemoveEmployeRecord(int id);
        Task UpdateRecord(EmployeeMaster model);
    }
}
