using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NeoSoft.Infrastructure.EF.Models
{
    public class EmployeeMaster
    {
        [Key]
        public int Row_Id { get; set; }
        [MaxLength(8)]
        public string EmployeeCode { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]

        public string EmailAddress { get; set; }
        [Required]
        [MaxLength(15)]

        public string MobileNumber { get; set; }
        [Required]
        [MaxLength(12)]

        public string PanNumber { get; set; }
        [Required]
        [MaxLength(20)]

        public string PassportNumber { get; set; }
        [MaxLength(100)]
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
        public virtual State State { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }

    }
}
