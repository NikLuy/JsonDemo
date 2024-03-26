using System.ComponentModel.DataAnnotations.Schema;

namespace JsonDemoApi.Models
{
    public class EnergyDetails
    {
        public DateTimeOffset Timestamp { get; set; }
        public double Energy { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

        [ForeignKey("Header")]
        public Guid HeaderId { get; set; }
        public virtual EnergyHeader Header { get; set; }
    }
}
