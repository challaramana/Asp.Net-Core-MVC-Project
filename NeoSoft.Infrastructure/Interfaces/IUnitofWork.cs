using System;
using System.Collections.Generic;
using System.Text;

namespace NeoSoft.Infrastructure.Interfaces
{
    public interface IUnitofWork : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        void Save();
    }
}
