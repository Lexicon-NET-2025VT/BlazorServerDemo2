using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServerDemo2.Entities
{
    public record EmployeeDto
    {
        public string Id { get; init; }
        public string Name { get; init; }
        public int Age { get; init; }
        public string? Position { get; init; }
    }
}
