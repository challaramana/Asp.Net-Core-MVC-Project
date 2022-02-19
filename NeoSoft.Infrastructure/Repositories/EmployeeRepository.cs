using NeoSoft.Infrastructure.EF.Data;
using NeoSoft.Infrastructure.EF.Models;
using NeoSoft.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoSoft.Infrastructure.Repositories
{
    public class EmployeeRepository : GenericRepository<EmployeeMaster>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public IQueryable<Country> GetCountryDetails()
        {
            return _context.Country.AsQueryable();
        }
        public IQueryable<State> GetStateDetails()
        {
            return _context.State.AsQueryable();
        }
        public IQueryable<City> GetCityDetails()
        {
            return _context.City.AsQueryable();
        }

    }
}
