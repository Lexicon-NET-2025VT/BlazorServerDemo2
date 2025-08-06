
using BlazorServerDemo2.Entities;
using BlazorServerDemo2.Services;

namespace BlazorServerDemo2.Components.Pages
{
    public partial class EmployeeRegister
    {
        private IEnumerable<EmployeeDto> Employees { get; set; }
        public bool Loading { get; set; } = false;

        private int companyId = 1;

        protected override async Task OnInitializedAsync()
        {
            Loading = true;
            Employees = await employeeService.GetEmployees(companyId);
            Loading = false;
        }

    }
}