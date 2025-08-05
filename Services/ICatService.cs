using BlazorServerDemo2.Entities;

namespace BlazorServerDemo2.Services
{
    public interface ICatService
    {
        Task<IEnumerable<Cat>> GetCats(string name);
    }
}