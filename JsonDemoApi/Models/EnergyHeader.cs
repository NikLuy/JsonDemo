using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JsonDemoApi.Models
{
    public class EnergyHeader
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Charger")]
        public Guid? ChargerId { get; set; }
        public virtual Charger? Charger { get; set; }
         
        public DateTimeOffset StartDateTime { get; set; }
        public DateTimeOffset? EndDateTime { get; set; }
        public double Energy { get; set; }

        public int? CommitMetadata { get; set; }
        public DateTimeOffset? CommitEndDateTime { get; set; }

        public string? UserFullName { get; set; }
        public string? UserEmail { get; set; }
        public Guid? UserId { get; set; }
        public string? TokenName { get; set; }
        public string? ExternalId { get; set; }
        public bool ExternallyEnded { get; set; }
        public IList<EnergyDetails>? EnergyDetails { get; set; }
        public string? SignedSession { get; set; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
        public DateTimeOffset? ModifiedAt { get; set; }
    }
}
