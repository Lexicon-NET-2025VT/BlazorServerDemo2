using BlazorServerDemo2.Data;
using BlazorServerDemo2.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerDemo2.Services
{
    public class WaterService : IWaterService
    {
        private readonly MyDbContext _db;

        public WaterService(MyDbContext db)
        {
            _db = db;
        }

        public async Task<List<Water>> GetIntakes()
        {
            return await _db.Intakes.ToListAsync();
        }
        public async Task SaveIntake(Water intake)
        {
            _db.Add(intake);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteIntake(int id)
        {
            _db.Intakes.Remove(_db.Intakes.Single(x => x.Id == id));
            await _db.SaveChangesAsync();
        }

        public int GetTodaysIntake()
        {
            return _db.Intakes.Where(i => i.Date.Date == DateTime.Now.Date).Sum(x => x.Amount);
        }

    }
}
