# CompuTech

A Windows Forms desktop application for managing customers, items, orders, and users.

## Requirements

- .NET 8.0 or later
- Windows 7 or later
- Visual Studio 2022 or VS Code with C# Dev Kit

## Project Structure

```
CompuTech/
├── Forms/          # Windows Forms UI components
├── Models/         # Business logic and data models
├── Config/         # Configuration and startup files
├── My Project/     # Application settings and resources
└── bin/obj/        # Build output
```

## Building & Running

```bash
dotnet build
dotnet run
```

## Features

- Customer management (add, update, delete, view)
- Item/inventory management
- Order processing and tracking
- User account management
- Order receipt generation

## Database

Uses Access Database (.accdb) located in the bin output directory.

## Technologies

- VB.NET
- Windows Forms
- OleDb for data access
