using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required, StringLength(100)]
        public string Name { get; set; } = "";

        [Required]
        public DateTime Date { get; set; } = DateTime.Today.AddDays(1);

        [Required, StringLength(120)]
        public string Location { get; set; } = "";

        [StringLength(500)]
        public string Description { get; set; } = "";
    }
}
