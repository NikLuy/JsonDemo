using System.ComponentModel.DataAnnotations;

namespace JsonDemoApi.Models
{
    public partial class Charger
    {
        [Key]
        public Guid Id { get; set; }
        public int? Id_Subjekt { get; set; }
        public int? Id_Zustelladresse { get; set; }
        public SubjektDto? Subjekt { get; set; }
        public SubjektDto? Zustell_Subjekt { get; set; }
        public DateTime Updated { get; set; }
    }
}
