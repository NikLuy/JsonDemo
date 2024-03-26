using Azure;
using JsonDemo.Data;
using JsonDemo.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace JsonDemo.Service
{
    public class ChargerService
    {
        private readonly AppDbContext _context;
        public ChargerService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> UpSert(string chargerJson)
        {
            if (chargerJson == null) { return false; }

            var charger = JsonConvert.DeserializeObject<Charger>(chargerJson);
            return await UpSert(charger);
        }

        public async Task<bool> UpSert(Charger chargerDto)
        {
            try
            {
                var objFromDb = await _context.Chargers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == chargerDto.Id);

                if (objFromDb != null)
                {
                    //if(objFromDb.Subjekt != null && chargerDto.Subjekt == null)
                    //{
                    //    chargerDto.Subjekt = new SubjektDto();
                    //}
                    //if (objFromDb.Zustell_Subjekt != null && chargerDto.Zustell_Subjekt == null)
                    //{
                    //    chargerDto.Zustell_Subjekt = new SubjektDto();
                    //}
                    var charger = chargerDto;
                    //objFromDb.Subjekt = charger.Subjekt;
                    _context.Chargers.Update(charger);
                    await _context.SaveChangesAsync();

                    return true;
                }
                else
                {
                    await _context.AddAsync(chargerDto);
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
