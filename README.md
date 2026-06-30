# Argus.Users

Part of the **Argus** ecosystem.

---

## What is Argus?

In Greek mythology, Argus Panoptes was a giant with a hundred eyes — all-seeing, always watching, present everywhere at once.

This project borrows that name for a different kind of giant: a modular .NET library ecosystem designed to be the invisible backbone of any application. Each module is a self-contained tentacle with a single concern — users, authentication, permissions, and more — working independently but built to fit together seamlessly.

Argus is a C# and .NET case study and portfolio project. The goal is to explore library design patterns, clean architecture, and the discipline of building reusable, well-tested components that can be dropped into any project without friction.

---

## Argus.Users

`Argus.Users` is the first module. It handles everything related to users — creation, validation, and data access — and exposes a clean interface that any consuming application can wire up with a single line:

```csharp
services.AddArgusUsers(connectionString);
```

From that point, the consuming application gets fully managed database migrations and a ready-to-use repository — no configuration, no boilerplate.

---

## Design principles

- **Modular** — each Argus module is an independent library with its own schema, migrations, and concerns. Modules do not depend on each other.
- **Seamless integration** — consumers call one extension method. Migrations run automatically. Nothing leaks into the host application.
- **Rich models** — domain objects carry their own validation and construction logic. An invalid object cannot be created.
- **Dumb repositories** — data access is purely a persistence concern. No business logic lives in the repository layer.
- **SQL-first migrations** — schema changes are plain SQL scripts versioned and embedded in the library, managed by DbUp.

---

## Tech stack

- .NET 10
- DbUp (migrations)
- Dapper (data access)
- PostgreSQL
- xUnit (testing)

---

## Status

Active development. This is a learning and portfolio project — expect evolution in design as patterns are explored and refined.
