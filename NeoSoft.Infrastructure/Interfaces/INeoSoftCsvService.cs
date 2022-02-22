using NeoSoft.Infrastructure.EF.DTO;
using NeoSoft.Infrastructure.EF.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoSoft.Infrastructure.Interfaces
{
    public interface INeoSoftCsvService
    {
        void WriteNewCsvFile(string path, List<EmployeeDTO> csvViewModels);
    }
}
