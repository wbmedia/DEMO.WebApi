# DEMO.WebApi

A simple ASP.NET Web API demo project.

Repository: https://github.com/wbmedia/DEMO.WebApi

## Tech Stack

- C# / .NET (ASP.NET Web API)

## Getting Started

### Prerequisites
- .NET SDK (version depends on the project target framework)
- An IDE such as Visual Studio / VS Code / Rider

### Run the API
1. Clone the repository:
   - `git clone https://github.com/wbmedia/DEMO.WebApi.git`
2. Open the solution:
   - `DEMO.WebApi.slnx` (or open the `DEMO.WebApi` folder in your IDE)
3. Restore dependencies (if needed):
   - `dotnet restore`
4. Run the project:
   - `dotnet run --project DEMO.WebApi`

When running locally, the API will listen on a local URL shown in the console output.

## Usage

Once running, you can test endpoints using:
- A browser (for GET endpoints)
- Postman / Insomnia
- `curl`

If Swagger/OpenAPI is enabled in the project, navigate to the Swagger UI URL (commonly `/swagger`) from the local base address.

## License

AGPL-3.0 — see `LICENSE.txt`.
