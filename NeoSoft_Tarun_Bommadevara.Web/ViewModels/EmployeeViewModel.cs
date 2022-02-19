using NeoSoft.Infrastructure.EF.Models;
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
        public string EmployeeCode { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
     
        public string EmailAddress { get; set; }
        [Required]
     
        public string MobileNumber { get; set; }
        [Required]
     
        public string PanNumber { get; set; }
        [Required]
     
        public string PassportNumber { get; set; }
        public string ProfileImage { get; set; }
        public byte Gender { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfJoinee { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public IEnumerable<State> StateList { get; set; }
        public IEnumerable<Country> CountryList { get; set; }
        public IEnumerable<City> CityList { get; set; }
        public IEnumerable<EmployeeMaster> Employees { get; set; }
    }
}
