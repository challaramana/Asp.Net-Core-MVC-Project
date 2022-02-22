using System;
using System.Collections.Generic;
using System.Text;

namespace NeoSoft.Infrastructure.EF.Models
{
    public class NeoSoftViewQuery : PaginatedQuery
    {
        public string EmailAddress { get; set; }
        public string PanNumber { get; set; }
        public string PassportNumber { get; set; }
        public string ProfileImage { get; set; }
        public bool IsActive { get; set; }
        public byte Gender { get; set; }
        public int StateId { get; set; }  
        public int CountryId { get; set; }
        public int CityId { get; set; }

        public NeoSoftViewQuery DefaultQuery ()
        {
            Page = 1;
            PageSize = 3;            
            return this;
        }
    }
}
