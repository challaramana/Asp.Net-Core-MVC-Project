using NeoSoft.Infrastructure.EF.Models;
using NeoSoft.Infrastructure.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoft_Tarun_Bommadevara.Web.ViewModels
{
    public class EmployeeViewModel
    {
        public int Row_Id { get; set; }

        [Required(ErrorMessage = "please enter EmployeeCode")]
        public string EmployeeCode { get; set; }
        [Required(ErrorMessage = "please enter FirstName")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "please enter EmailAddress")]
        public string EmailAddress { get; set; }
        [Required(ErrorMessage = "please enter MobileNumber")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "please enter PanNumber")]
        public string PanNumber { get; set; }
        [Required(ErrorMessage = "please enter PassportNumber")]
        public string PassportNumber { get; set; }
        public string ProfileImage { get; set; }
        public byte Gender { get; set; }
        [Required(ErrorMessage = "please enter IsActive")]
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "please enter DateOfBirth")]
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfJoinee { get; set; }
        [Required(ErrorMessage = "please enter CreatedDate")]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [Required(ErrorMessage = "please enter IsDeleted")]
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        [Required(ErrorMessage = "please enter StateId")]
        public int StateId { get; set; }
        [Required(ErrorMessage = "please enter CityId")]
        public int CityId { get; set; }
        [Required(ErrorMessage = "please enter CountryId")]
        public int CountryId { get; set; }
        public IEnumerable<State> StateList { get; set; }
        public IEnumerable<Country> CountryList { get; set; }
        public IEnumerable<City> CityList { get; set; }
        public IEnumerable<EmployeeMaster> Employees { get; set; }
        public NeosoftRecord PaginatedData { get; set; }
    }
}
