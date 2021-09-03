using Abp.Application.Services.Dto;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOSR.Employees
{
    public interface IEmployeeManager : IDomainService
    {
        Task<long> CreateEmployeeAsync(Employee employee);
        Task<IQueryable<Employee>> GetEmployees();
        Task<long> UpdateEmployeeAsync(Employee employee);
        Task<Boolean> DeleteEmployeeAsync(Employee employee);
        Task<Employee> GetEmployeeByIdAsync(long employeeId);
    }
}
