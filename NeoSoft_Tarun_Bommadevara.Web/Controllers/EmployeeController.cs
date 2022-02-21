using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NeoSoft.Infrastructure.EF.Models;
using NeoSoft.Infrastructure.Interfaces;
using NeoSoft_Tarun_Bommadevara.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoft_Tarun_Bommadevara.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;
        public readonly IConfiguration _Configuration;
        private readonly IMapper _mapper;
        // private string apiBaseUrl;
        public EmployeeController(IEmployeeService employeeService, ILogger<EmployeeController> logger,
            IConfiguration Configuration, IMapper mapper)
        {
            _employeeService = employeeService;
            _logger = logger;
            _Configuration = Configuration;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateEmployee(EmployeeViewModel employeeViewModel)
        {
            employeeViewModel.CountryList = _employeeService.GetCountryDetails();
            ModelState.Clear();
            return View(employeeViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployeePost(EmployeeViewModel response)
        {
            if (response.Row_Id == 0)
            {
                var model = _mapper.Map<EmployeeMaster>(response);
                model.CreatedDate = DateTime.Now;
                model.IsActive = response.IsActive == true ? true : false;
                await _employeeService.AddEmployee(model);
                response.CountryList = _employeeService.GetCountryDetails();
                return RedirectToAction("ViewRecords");
            }
            else
            {
                var model = _mapper.Map<EmployeeMaster>(response);
                model.UpdatedDate = DateTime.Now;
                model.IsActive = response.IsActive == true ? true : false;
                await _employeeService.UpdateRecord(model);
                response.CountryList = _employeeService.GetCountryDetails();
                return RedirectToAction("ViewRecords");
            }
        }
        public async Task<IActionResult> ViewRecords()
        {
            EmployeeViewModel response = new EmployeeViewModel();
            response.Employees = await _employeeService.GetEmployees();
            return View(response);
        }
        public async Task<IActionResult> GetRecord(int userId)
        {
            EmployeeViewModel response = new EmployeeViewModel();
            var data = await _employeeService.GetEmployeRecord(userId);
            response = _mapper.Map<EmployeeViewModel>(data);
            return RedirectToAction("CreateEmployee", response);
        }
        public async Task<IActionResult> RemoveRecord(int userId)
        {
            await _employeeService.RemoveEmployeRecord(userId);
            return RedirectToAction("ViewRecords");
        }

        public async Task<IActionResult> GetStateDropdownData(int id)
        {
            var data = await _employeeService.GetStateDropDownData(id);
            return Json(data);
        }

        public async Task<IActionResult> GetCityDropdownData(int id)
        {
            var data = await _employeeService.GetCityDropDownData(id);
            return Json(data);
        }
    }
}
