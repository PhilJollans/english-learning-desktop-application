# EngApp

EngApp is a comprehensive English learning application built with .NET 9.0 and Windows Forms. It is designed to help users improve their vocabulary, grammar, and pronunciation through various interactive modules and games.

## Features

- **Cards (Flashcards)**: Review and memorize new vocabulary efficiently with interactive flashcards.
- **Hangman Game**: A fun way to learn and test your vocabulary knowledge.
- **Irregular Verbs**: Dedicated module to practice and master irregular verbs.
- **Practice Mode**: General practice exercises to reinforce learning.
- **Word Management**: Add, update, and organize your personal vocabulary list.
- **Analytics**: Track your learning progress with visual statistics.
- **Text-to-Speech**: Integrated pronunciation support using `System.Speech`.

## Architecture

The solution is built using a layered architecture to ensure separation of concerns and maintainability:

- **EngApp.UI**: The Windows Forms user interface layer.
- **EngApp.Business**: logic layer handling application rules and processing.
- **EngApp.Data**: Data access layer using Entity Framework Core (SQL Server).
- **EngApp.Core**: Shared models, interfaces, and utilities.

## Technologies

- **Framework**: .NET 9.0
- **UI**: Windows Forms (WinForms)
- **Database**: SQL Server
- **ORM**: Entity Framework Core 9.0
- **Speech**: System.Speech

## Getting Started

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- SQL Server (LocalDB or a full instance)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/ikriyusuf/english-learning-desktop-application.git
   ```

2. **Configure Database**
   Update the connection string in `EngApp.UI/appsettings.json` (or `App.config` if applicable) and `EngApp.Data/appsettings.json` to match your SQL Server environment.

   ```json
   "ConnectionStrings": {
     "EngAppDb": "Server=YOUR_SERVER_ADDRESS;Database=EngApp;User Id=YOUR_USER;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
   }
   ```

3. **Apply Migrations**
   Navigate to the solution directory and apply the Entity Framework migrations to create the database schema:
   ```bash
   dotnet e try database update --project EngApp.Data --startup-project EngApp.UI
   ```
   *(Note: Ensure you have `dotnet-ef` tool installed: `dotnet tool install --global dotnet-ef`)*

4. **Run the Application**
   Open the solution in Visual Studio and press **F5**, or run via CLI:
   ```bash
   dotnet run --project EngApp.UI
   ```

## License

[MIT](LICENSE)
