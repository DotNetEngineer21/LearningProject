using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using CoreOSR.Authorization;
using CoreOSR.Employees.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOSR.Employees
{
    //[AbpAuthorize]
    [AbpAuthorize(AppPermissions.Pages_Datagrid)]
    public class EmployeeAppService : CoreOSRAppServiceBase, IEmployeeAppService
    {
        private readonly IEmployeeManager _employeeManager;
        public EmployeeAppService(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }
        public async Task<long> AddEmployee(EmployeeInput input)
        {
            var employee = ObjectMapper.Map<Employee>(input);
            
            return await _employeeManager.CreateEmployeeAsync(employee);
        }
        public async Task<PagedResultDto<EmployeeListDto>> GetEmployees()
        {
            var employees = await _employeeManager.GetEmployees();
            if (employees.Count() > 0)
            {
                var employeeListDtos = ObjectMapper.Map<List<EmployeeListDto>>(employees);

                return new PagedResultDto<EmployeeListDto>(
                employeeListDtos.Count(),
                employeeListDtos
                );
            }
            return null;
        }
        public async Task<long> UpdateEmployee(EmployeeInput input)
        {
            var employee = await _employeeManager.GetEmployeeByIdAsync(input.Id);

            ObjectMapper.Map(input, employee);
            return await _employeeManager.UpdateEmployeeAsync(employee);
        }
        public async Task<Boolean> DeleteEmployee(EntityDto<long> employeeId)
        {
            var employee = await _employeeManager.GetEmployeeByIdAsync(employeeId.Id);
            return await _employeeManager.DeleteEmployeeAsync(employee);
        }
    }
}
