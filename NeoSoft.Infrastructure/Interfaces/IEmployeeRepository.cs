using NeoSoft.Infrastructure.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoSoft.Infrastructure.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<EmployeeMaster>
    {
        IQueryable<Country> GetCountryDetails();
        IQueryable<State> GetStateDetails(int id);
        IQueryable<City> GetCityDetails(int id);
    }
}
