using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoSoft.Infrastructure.EF.Models
{
    public class NeosoftRecord
    {
        public NeosoftRecord(NeoSoftViewQuery query,IEnumerable<EmployeeMaster> employeeMasters)
        {
            var totalUserCount = employeeMasters.Count();
            var pageCount = (totalUserCount + query.PageSize - 1) / query.PageSize;

            // TODO : This is a hack. EF translates Skip/Take to OFFSET/FETCH in SQL, which is not supported in SQL Server 2008.
            // Furthermore, EF 3.x ended support for the workaround (https://docs.microsoft.com/en-us/ef/core/what-is-new/ef-core-3.0/breaking-changes#urn),
            // citing that SQL Server 2008 itself is no longer supported by Microsoft. On this line, ToList() forces the sql execution 
            // so that Skip/Take is processed here in the app, not on sql server. We need to find a work around for this if we
            // want to use pagination in our apps.
            EmployeeMasters = employeeMasters.ToList().Skip(query.SkipCount).Take(query.PageSize);
            TotalUserCount = totalUserCount;
            CurrentPage = query.Page < 1 ? 1 : query.Page;
            PageCount = pageCount;
        }
        public int TotalUserCount { get; }
        public int PageCount { get; }
        public int CurrentPage { get; } = 1;
        public IEnumerable<EmployeeMaster> EmployeeMasters { get; }

    }
}
