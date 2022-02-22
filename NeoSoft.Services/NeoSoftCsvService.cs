using CsvHelper;
using CsvHelper.Configuration;
using NeoSoft.Infrastructure.EF.DTO;
using NeoSoft.Infrastructure.EF.Models;
using NeoSoft.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace NeoSoft.Services
{
    public class NeoSoftCsvService : INeoSoftCsvService
    {
        public void WriteNewCsvFile(string path, List<EmployeeDTO> csvViewModels)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                NewLine = Environment.NewLine,
            };
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(csvViewModels);
            }
        }

    }
}
