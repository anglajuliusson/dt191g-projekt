# Bokningshanteringssystem

## Projektbeskrivning
Detta projekt är en webbaserad applikation utvecklad i **ASP.NET Core**. Syftet med systemet är att visa information om idrottsföreningar, lokaler och bokningar i **Arvidsjaur kommun**.

Applikationen innehåller både publika och skyddade delar:

- **Publika sidor**
  - Visa idrottsföreningar
  - Visa lokaler som finns att hyra
  - Visa aktuella bokningar

- **Skyddade sidor (inloggade användare)**
  - Skapa, rediger och ta bort föreningar
  - Skapa, redigera och ta bort lokaler lokaler
  - Skapa, redigera och ta bort bokningar

Applikationen använder **ASP.NET Identity** för autentisering och **SQLite** som databas.

---

## Installation och körning

### 1. Klona projektet
```bash
git clone https://github.com/ditt-användarnamn/projektnamn.git
cd projektnamn
```

### 2. Öppna projektet
Projektet kan öppnas i:
- Visual Studio
eller
- Visual Studio Code

### 3. Installera beroenden
Om det behövs kan NuGet-paket återställas med:
```bash
dotnet restore
```

### 4. Starta applikationen
Kör projektet med:
```bash
dotnet run
```

Applikationen startar normalt på:
http://localhost:5086

---

## Databas
Projektet använder SQLite som databas.

Databasen skapas automatiskt via Entity Framework Core migrations när projektet startas första gången.

Skapa databasen manuellt

Om migrations behöver köras manuellt:
```bash
dotnet ef database update
```

Detta skapar SQLite-databasen baserat på projektets modeller.

---

## Seed-data

Projektet kan innehålla seed-data för att fylla databasen med exempeldata såsom:

- idrottsföreningar
- lokaler
- bokningar

Seedningen sker automatiskt vid uppstart av applikationen (om databasen är tom).

---

## Beroenden

Projektet använder följande huvudsakliga tekniker och bibliotek:

- ASP.NET Core
- Entity Framework Core
- SQLite
- ASP.NET Identity
- Razor Pages / MVC

NuGet-paket installeras automatiskt via projektfilen (.csproj).

---

## Konfiguration
Viss konfiguration sker i följande filer:

appsettings.json

Här definieras bland annat databaskopplingen.

Exempel:
```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=app.db"
}
```

Program.cs

Här konfigureras:
- databaskoppling
- Identity
- routing

---

## Publicering

Projektet kan publiceras till exempelvis Azure App Service.

Publicering kan göras via:

- Visual Studio
- Visual Studio Code
- dotnet publish
