### Description

A Windows Forms application for managing products — supporting full CRUD operations backed by SQL Server stored procedures.

### Features

- View all products in a sortable data grid
- Add new products
- Edit existing products
- Delete products with confirmation
- SQL Server integration via Stored Procedures

### Tech Stack

- Language: C# (.NET WinForms)
- Database: SQL Server (SQLEXPRESS)
- ORM: None — raw ADO.NET with Microsoft.Data.SqlClient
- IDE: Visual Studio (preferred)

## Getting Started

### Pre-Requisites

- Visual Studio (2026 preferred)
- SQL Server Express
- SQL Server Management Studio (SSMS)
- .NET 9 (preferred)

### Project Setup

1. Clone the repository.

```bash
git clone <your_repo_link>
cd <your_repo_name>
```

2. Open the solution in Visual Studio. Double-click WinFormsApp1.sln
3. Update the connection string in Repositories/ProductRepository.cs:

```bash
private readonly string connectionString = <your_connection_string>;
```

4. Restore NuGet packages (In Visual Studio: Tools → NuGet Package Manager → Restore NuGet Packages)

Or via CLI:

```bash
dotnet restore
dotnet run
```

### Database and Stored Procedured Setup

- Follow instructions in queries.sql file
