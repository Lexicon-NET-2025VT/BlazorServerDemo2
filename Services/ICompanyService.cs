using BlazorServerDemo2.Entities;

namespace BlazorServerDemo2.Services
{
    public interface ICompanyService
    {
        Task<(IEnumerable<CompanyDto>, MetaData)> GetCompanies(bool includeEmployees, int pageNumber, int pageSize);
    }
}