using JsonDemoApi.Data;
using JsonDemoApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace JsonDemoApi.Service
{
    public class ChargerService
    {
        private readonly AppDbContext _context;
        public ChargerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> UpSert(Charger charger)
        {
            try
            {
                var objFromDb = await _context.Chargers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == charger.Id);

                if (objFromDb != null)
                {

                    _context.Chargers.Update(charger);
                    await _context.SaveChangesAsync();

                    return true;
                }
                else
                {
                    await _context.AddAsync(charger);
                    await _context.SaveChangesAsync();
                    return false;
                }
            }  
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
