using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NeoSoft.Infrastructure.EF.Models;
using NeoSoft.Infrastructure.Interfaces;
using NeoSoft.Infrastructure.Utility;
using NeoSoft_Tarun_Bommadevara.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoft_Tarun_Bommadevara.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;
        public readonly IConfiguration _Configuration;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;
        // private string apiBaseUrl;
        public EmployeeController(IEmployeeService employeeService, IWebHostEnvironment webHostEnvironment, ILogger<EmployeeController> logger,
            IConfiguration Configuration, IMapper mapper)
        {
            _employeeService = employeeService;
            _logger = logger;
            _Configuration = Configuration;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
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
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;
            if (response.Row_Id == 0)
            {
                var model = _mapper.Map<EmployeeMaster>(response);
                string upload = webRootPath + AppConstants.ImagePath;
                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(files[0].FileName);
                using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                model.ProfileImage = fileName + extension;
                model.CreatedDate = DateTime.Now;
                model.IsActive = response.IsActive == true ? true : false;
                await _employeeService.AddEmployee(model);
                response.CountryList = _employeeService.GetCountryDetails();
                return RedirectToAction("ViewRecords");
            }
            else
            {
                var model = _mapper.Map<EmployeeMaster>(response);
                if (files.Count > 0)
                {
                    string upload = webRootPath + AppConstants.ImagePath;
                    string fileName = Guid.NewGuid().ToString();
                    string extension = Path.GetExtension(files[0].FileName);

                    var oldFile = Path.Combine(upload, response.ProfileImage == null ? "" : response.ProfileImage);

                    if (System.IO.File.Exists(oldFile))
                    {
                        System.IO.File.Delete(oldFile);
                    }

                    using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    model.ProfileImage = fileName + extension;
                }
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
