using System;
using System.Collections.Generic;
using System.Text;

namespace NeoSoft.Infrastructure.Interfaces
{
    public interface IUnitofWork : IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        IStateRepository StateRepository { get; }
        ICityRepository CityRepository { get; }
        
        void Save();
    }
}
