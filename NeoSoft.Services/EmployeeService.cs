using Microsoft.Extensions.Configuration;
using NeoSoft.Infrastructure.EF.DTO;
using NeoSoft.Infrastructure.EF.Models;
using NeoSoft.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NeoSoft.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitofWork _unitofWork;
        public readonly IConfiguration _Configuration;
        public EmployeeService(IUnitofWork unitofWork, IConfiguration Configuration)
        {
            _unitofWork = unitofWork;
            _Configuration = Configuration;
        }
        public async Task GetCsvData()
        {
            var searchQuery = CreateSearchQuery.True<EmployeeMaster>();
            searchQuery = searchQuery.And(i => i.DeletedDate == null);
            var getData = await _unitofWork.EmployeeRepository.GetAllAsync(searchQuery, includeProperties: "Country,City,State");
            List<EmployeeDTO> employeeDTO = new List<EmployeeDTO>();
            foreach (var item in getData)
            {
                employeeDTO.Add(new EmployeeDTO
                {
                    Row_Id = item.Row_Id,
                    CreatedDate = item.CreatedDate,
                    DeletedDate = item.DeletedDate,
                    IsDeleted = item.IsDeleted,
                    EmailAddress = item.EmailAddress,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    DateOfBirth = item.DateOfBirth,
                    DateOfJoinee = item.DateOfJoinee,
                    EmployeeCode = item.EmployeeCode,
                    Gender = item.Gender,
                    IsActive = item.IsActive,
                    MobileNumber = item.MobileNumber,
                    PanNumber = item.PanNumber,
                    PassportNumber = item.PassportNumber,
                    ProfileImage = item.ProfileImage,
                    StateName = item.State.StateName,
                    UpdatedDate = item.UpdatedDate,
                     CityName = item.City.CityName,
                    CountryName = item.Country.CountryName,
                });

            }

            string FilePath = _Configuration.GetValue<string>("CsvPath");

            NeoSoftCsvService neoSoftCsvService = new NeoSoftCsvService();
            Console.WriteLine("**** Write a CSV file *****");
            neoSoftCsvService.WriteNewCsvFile(FilePath + "New Extract" + " " + DateTime.Now.ToString("MM-dd-yyyy@hh-mm-ss") + ".csv", employeeDTO);

        }
        public async Task AddEmployee(EmployeeMaster employeeMaster)
        {
            await _unitofWork.EmployeeRepository.AddAsync(employeeMaster);
            _unitofWork.Save();
        }
        public IEnumerable<Country> GetCountryDetails()
        {
            return _unitofWork.EmployeeRepository.GetCountryDetails();
        }
        public async Task<NeosoftRecord> GetEmployees(NeoSoftViewQuery query)
        {
            var searchQuery = CreateSearchQuery.True<EmployeeMaster>();
            searchQuery = searchQuery.And(i => i.Row_Id != 0);
            if (!string.IsNullOrEmpty(query.PanNumber))
            {
                searchQuery = searchQuery.And(i => i.PanNumber == query.PanNumber);
            }
            if (!string.IsNullOrEmpty(query.EmailAddress))
            {
                searchQuery = searchQuery.And(i => i.EmailAddress == query.EmailAddress);
            }
            var records = await _unitofWork.EmployeeRepository.GetAllAsync(searchQuery, includeProperties: "Country,City,State");
            return new NeosoftRecord(query, records);
        }
        public async Task<EmployeeMaster> GetEmployeRecord(int id)
        {
            return await _unitofWork.EmployeeRepository.GetFirstOrDefaultAsync(i => i.Row_Id == id);
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

        public async Task<IEnumerable<State>> GetStateDropDownData(int id)
        {
            var stateData = await _unitofWork.StateRepository.GetAllAsync(i => i.CountryId == id);
            return stateData;
        }
        public async Task<IEnumerable<City>> GetCityDropDownData(int id)
        {
            var cityData = await _unitofWork.CityRepository.GetAllAsync(i => i.StateId == id);
            return cityData;
        }
        public async Task<IEnumerable<EmployeeMaster>> GetSearchData(Expression<Func<EmployeeMaster, bool>> searchQuery)
        {
            return await _unitofWork.EmployeeRepository.GetAllAsync(searchQuery, includeProperties: "Country,City,State");
        }

    }
}
