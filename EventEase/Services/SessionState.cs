namespace EventEase.Services
{
    // Simple per-session user state
    public class SessionState
    {
        public string? CurrentUserName { get; private set; }
        public Guid? LastSelectedEventId { get; private set; }

        public void SetUser(string name) => CurrentUserName = name;
        public void SetLastEvent(Guid id) => LastSelectedEventId = id;
    }
}
