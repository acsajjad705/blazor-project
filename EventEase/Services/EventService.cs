using EventEase.Models;

namespace EventEase.Services
{
    public class EventService
    {
        private readonly List<Event> _events = new()
        {
            new Event { Name = "Tech Meetup", Date = DateTime.Today.AddDays(2), Location = "Community Hall", Description = "Networking and talks." },
            new Event { Name = "Blazor Workshop", Date = DateTime.Today.AddDays(5), Location = "Virtual", Description = "Hands-on Blazor." }
        };

        private readonly List<Attendee> _attendees = new();

        public IReadOnlyList<Event> GetEvents() => _events;

        public Event? GetEvent(Guid id) => _events.FirstOrDefault(e => e.Id == id);

        public void AddEvent(Event e) => _events.Add(e);

        public void UpdateEvent(Event updated)
        {
            var idx = _events.FindIndex(x => x.Id == updated.Id);
            if (idx >= 0) _events[idx] = updated;
        }

        public void AddAttendee(Attendee a) => _attendees.Add(a);

        public IReadOnlyList<Attendee> GetAttendeesForEvent(Guid eventId) =>
            _attendees.Where(a => a.EventId == eventId).ToList();

        public void MarkAttendance(Guid attendeeId, bool present)
        {
            var a = _attendees.FirstOrDefault(x => x.Id == attendeeId);
            if (a is not null) a.Present = present;
        }
    }
}
