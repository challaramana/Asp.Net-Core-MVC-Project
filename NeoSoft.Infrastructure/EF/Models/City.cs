using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NeoSoft.Infrastructure.EF.Models
{
    public class City
    {
        [Key]
        public int Row_Id { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
        public string CityName { get; set; }
       
    }
}
