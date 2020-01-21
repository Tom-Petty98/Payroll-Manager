using System;
using System.Collections.Generic;
using System.Text;
using Payroll_Manager.Entity;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Payroll_Manager.Services
{
    public interface IEmployeeService
    {
        Task CreateAsync(Employee newEmployee);

        Employee GetById(int employeeId);
        Task UpdateAsync(Employee employee);
        Task UpdateAsync(int id);
        Task Delete(int employeeId);
        decimal UnionFees(int id);
        decimal StudentLoanRepaymentAmount(int id, decimal totalAmount);
        IEnumerable<Employee> GetAll();
        IEnumerable<SelectListItem> GetAllEmployeesForPayroll();
    }
}
