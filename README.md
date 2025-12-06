# EventEase

EventEase is a Blazor Server application designed to manage events, registrations, and attendance.  
It demonstrates clean component design, routing, validation, and simple per-session state management.

---

## Features

- Event Card Component: Two-way bound fields (name, date, location, description) with save/reset actions.
- Routing & Navigation: Pages for Home, Events, Registration, and Attendance with NavLink and NotFound fallback.
- Registration Form: DataAnnotations validation, event selection, and session username persistence.
- Attendance Tracker: Filter attendees by event and toggle presence.
- State Management: Lightweight scoped `SessionState` for per-session UX.
- Performance Optimizations: Validation-first submissions, reduced re-renders, and route error handling.

---

## Tech Stack

- Framework: .NET 8 (Blazor Server)
- Language: C#
- UI: Razor components and built-in Blazor form inputs
- State: Dependency Injection services (`EventService`, `SessionState`)
- Persistence: In-memory lists (ready to swap to EF Core)

---

## Project Structure

EventEase/ ├─ Program.cs ├─ App.razor ├─ _Imports.razor ├─ Shared/ │ ├─ MainLayout.razor │ └─ NavMenu.razor ├─ Models/ │ ├─ Event.cs │ └─ Attendee.cs ├─ Services/ │ ├─ EventService.cs │ └─ SessionState.cs ├─ Components/ │ └─ EventCard.razor ├─ Pages/ │ ├─ Index.razor │ ├─ Events.razor │ ├─ Register.razor │ └─ Attendance.razor └─ wwwroot/ └─ css/site.css

Code

---

## Getting Started

### Prerequisites
- Install [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Git (optional, for cloning and submission)

### Run Locally
```bash
# Clone the repository
git clone https://github.com/your-username/EventEase.git
cd EventEase

# Restore dependencies
dotnet restore

# Run the app
dotnet run
Open the app in your browser at the printed localhost URL (e.g., https://localhost:5001/).

Usage Guide
Routes
/ → Home

/events → List events; create/edit via Event Card

/register → Register attendees for a selected event

/attendance → Review attendees and toggle presence

Typical Flow
Create or select an event on the Events page.

Register attendees on the Register page.

Mark attendance on the Attendance page.

Components & Services
EventCard.razor → Two-way bound inputs with EventCallback<Event> for save actions.

EventService.cs → In-memory data source for events/attendees, CRUD-like operations, and attendance toggling.

SessionState.cs → Stores CurrentUserName and LastSelectedEventId per session.

Performance & Reliability
Validation-first submissions with EditForm + DataAnnotationsValidator.

Reduced re-renders using targeted StateHasChanged().

Routing fallback with NotFound content in App.razor.

Scoped session state to avoid cross-user leakage.

Copilot Assistance Summary
Component scaffolding: Generated the Event Card with bound inputs and save/reset handlers.

Routing & layout: Suggested Router setup, NavLink usage, and NotFound fallback.

Validation & optimization: Proposed EditForm with DataAnnotationsValidator to simplify validation.

Advanced features: Structured Registration form, event selection, Attendance tracker, and introduced SessionState.

Submission Steps (Assignment)
Initialize Git:

bash
git init
git add .
git commit -m "Initial commit"
Create a new public repo on GitHub named EventEase.

Link and push:

bash
git remote add origin https://github.com/your-username/EventEase.git
git branch -M main
git push -u origin main
Submit the repository URL for review.

Future Enhancements
Replace in-memory services with EF Core + SQLite/SQL Server.

Add event details page (/events/{id:guid}).

Use <ErrorBoundary> and toast notifications for better UX.

Integrate authentication/authorization for real user sessions.

Code

Would you like me to also add **badges** (like .NET version, build status, license) at th
