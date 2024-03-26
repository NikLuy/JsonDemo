using JsonDemoApi.Data;
using JsonDemoApi.Models;
using JsonDemoApi.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JsonDemoApi.Controllers
{
    [ApiController]
    [Route("api/Charger")]
    public class ChargerController : ControllerBase
    {
        private readonly ChargerService _chargerService;
        public ChargerController(ChargerService chargerService)
        {
            _chargerService = chargerService;
        }

        [HttpGet( "InitObject")]
        public async Task InitObject()
        {
            Charger charger = new() { Id = new Guid("AA4DF729-AD63-4C75-3429-08DC4CEFA063"), Id_Subjekt = 65355, Id_Zustelladresse = 1233 };
            charger.Updated = DateTime.Now; 
            await _chargerService.UpSert(charger);
        }

        [HttpGet( "UpdateWithSubject")]
        public async Task UpdateWithSubject()
        {
            Charger charger = new() { Id = new Guid("AA4DF729-AD63-4C75-3429-08DC4CEFA063"), Id_Subjekt = 65355, Id_Zustelladresse = 1233 };
            charger.Subjekt = new SubjektDto() { Vorname = "Nik", Name = "Lussy", Adresse = "MyAddress 12" };
            charger.Updated = DateTime.Now;

            await _chargerService.UpSert(charger);
        }

        [HttpGet( "UpdateWithSubject2")]
        public async Task UpdateWithSubject2()
        {
            Charger charger = new() { Id = new Guid("AA4DF729-AD63-4C75-3429-08DC4CEFA063"), Id_Subjekt = 65355, Id_Zustelladresse = 1233 };
            charger.Subjekt = new SubjektDto() { Vorname = "Another", Name = "Name", Adresse = "HisAddress 65" };
            charger.Updated = DateTime.Now;

            await _chargerService.UpSert(charger);
        }

        [HttpGet( "UpdateWithNull")]
        public async Task UpdateWithNull()
        {
            Charger charger = new() { Id = new Guid("AA4DF729-AD63-4C75-3429-08DC4CEFA063"), Id_Subjekt = 65355, Id_Zustelladresse = 1233 };
            charger.Subjekt = null;
            charger.Updated = DateTime.Now;

            await _chargerService.UpSert(charger);
        }
    }
}
