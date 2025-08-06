using BlazorServerDemo2.Entities;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerDemo2.Entities
{
    public record CompanyDto
    {
        public int Id { get; init; }
        public string? Name { get; init; }
        public string? Address { get; init; }
        // public string? Country { get; init; }

        public IEnumerable<EmployeeDto> Employees { get; init; }
    }
}
