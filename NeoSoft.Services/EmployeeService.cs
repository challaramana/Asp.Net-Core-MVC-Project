using NeoSoft.Infrastructure.EF.Models;
using NeoSoft.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoSoft.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitofWork _unitofWork;
        public EmployeeService(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
        }
        public async Task AddEmployee(EmployeeMaster employeeMaster)
        {
            await _unitofWork.EmployeeRepository.AddAsync(employeeMaster);
            _unitofWork.Save();
        }
        public IEnumerable<City> GetCityDetails()
        {
            return _unitofWork.EmployeeRepository.GetCityDetails();
        }
        public IEnumerable<Country> GetCountryDetails()
        {
            return _unitofWork.EmployeeRepository.GetCountryDetails();
        }
        public IEnumerable<State> GetStateDetails()
        {
            return _unitofWork.EmployeeRepository.GetStateDetails();
        }
        public async Task<IEnumerable<EmployeeMaster>> GetEmployees()
        {
            return await _unitofWork.EmployeeRepository.GetAllAsync(i=>i.Row_Id !=0,includeProperties:"Country,City,State");
        }
        public async Task<EmployeeMaster> GetEmployeRecord(int id)
        {
            return await _unitofWork.EmployeeRepository.GetFirstOrDefaultAsync(i => i.Row_Id ==id);
        }
        public async Task RemoveEmployeRecord(int id)
        {
             await _unitofWork.EmployeeRepository.RemoveAsync(id);
            _unitofWork.Save();
        }
        public async Task UpdateRecord(EmployeeMaster model)
        {
            await _unitofWork.EmployeeRepository.UdpdateAsync(model);
            _unitofWork.Save();
        }
    }
}
