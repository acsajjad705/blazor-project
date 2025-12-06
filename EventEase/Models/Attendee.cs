using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Attendee
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required, StringLength(80)]
        public string FullName { get; set; } = "";

        [Required, EmailAddress]
        public string Email { get; set; } = "";

        public Guid EventId { get; set; }

        public bool Present { get; set; } = false;
    }
}
