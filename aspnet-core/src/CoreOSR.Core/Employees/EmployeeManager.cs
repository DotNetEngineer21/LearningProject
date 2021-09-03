using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOSR.Employees
{
    public class EmployeeManager : CoreOSRDomainServiceBase, IEmployeeManager
    {
        private readonly IRepository<Employee, long> _employeeRepository;

        public EmployeeManager(IRepository<Employee, long> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [UnitOfWork]
        public async Task<long> CreateEmployeeAsync(Employee employee)
        {
            try
            {
                var result=_employeeRepository.Insert(employee);
                await CurrentUnitOfWork.SaveChangesAsync();
                return result.Id;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
        public async Task<IQueryable<Employee>> GetEmployees()
        {
            try
            {
                var query = _employeeRepository.GetAll();
                return query;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        [UnitOfWork]
        public async Task<long> UpdateEmployeeAsync(Employee employee)
        {
            try
            {
                var result=_employeeRepository.Update(employee);
                await CurrentUnitOfWork.SaveChangesAsync();
                return result.Id;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }
        [UnitOfWork]
        public async Task<Boolean> DeleteEmployeeAsync(Employee employee)
        {
            try
            {
                _employeeRepository.Delete(employee);
                await CurrentUnitOfWork.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        [UnitOfWork]
        public async Task<Employee> GetEmployeeByIdAsync(long employeeId)
        {
            try
            {
                return await _employeeRepository.GetAsync(employeeId);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
