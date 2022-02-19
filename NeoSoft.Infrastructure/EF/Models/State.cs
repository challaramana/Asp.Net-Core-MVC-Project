using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NeoSoft.Infrastructure.EF.Models
{
    public class State
    {
        [Key]
        public int Row_Id { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public string StateName { get; set; }
       
    }
}
