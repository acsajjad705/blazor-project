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

