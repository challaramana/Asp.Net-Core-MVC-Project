using NeoSoft.Infrastructure.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSoft.Infrastructure.Interfaces
{
    public interface IEmployeeService
    {
        Task AddEmployee(EmployeeMaster employeeMaster);
        IEnumerable<Country> GetCountryDetails();
        IEnumerable<State> GetStateDetails();
        IEnumerable<City> GetCityDetails();
        Task<IEnumerable<EmployeeMaster>> GetEmployees();
        Task<EmployeeMaster> GetEmployeRecord(int id);
        Task RemoveEmployeRecord(int id);
        Task UpdateRecord(EmployeeMaster model);
    }
}
