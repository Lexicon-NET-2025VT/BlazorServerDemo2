using BlazorServerDemo2.Entities;

namespace BlazorServerDemo2.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetEmployees(int companyId);
    }
}