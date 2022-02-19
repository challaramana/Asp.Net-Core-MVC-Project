using NeoSoft.Infrastructure.EF.Data;
using NeoSoft.Infrastructure.Interfaces;
using NeoSoft.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoSoft.Infrastructure.UnitOfWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly ApplicationDbContext _dbContext;
        public UnitofWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            EmployeeRepository = new EmployeeRepository(_dbContext);
        }

        public IEmployeeRepository EmployeeRepository
        {
            get; private set;
        }
       
        public void Dispose()
        {
            _dbContext.Dispose();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
