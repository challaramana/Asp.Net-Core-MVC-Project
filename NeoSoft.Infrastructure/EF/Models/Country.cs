using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NeoSoft.Infrastructure.EF.Models
{
    public class Country
    {
        [Key]
        public int Row_Id { get; set; }
        public string CountryName { get; set; }

    }
}
