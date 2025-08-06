using BlazorServerDemo2.Entities;

namespace BlazorServerDemo2.Services
{
    public interface IWaterService
    {
        Task DeleteIntake(int id);
        Task<List<Water>> GetIntakes();
        Task SaveIntake(Water intake);
        int GetTodaysIntake();
    }
}