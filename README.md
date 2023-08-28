# Wagenpark demo applicatie

## Applicatie draaien
Dit project is gebouwd op .NET 7, dus de [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download) is benodigd om het project te kunnen draaien.

Om het project te draaien kun je de repo clonen of downloaden, en vervolgens de solution openen in een IDE naar keuze.

open een terminal, en voer de volgende commando's uit.
```
dotnet tool update --global dotnet-ef
dotnet ef database update
```

Het project maakt gebruik van SQLite voor makkelijke overdraagbaarheid, hierdoor is geen configuratie nodig om de database aan de praat te krijgen. het `dotnet ef database update` commando maakt een bestand aan op de volgende locatie: `%localappdata%\carpark.db` (dat wordt geregeld vanuit de constructor van de CarparkContext class in het `Carpark.Database` project). Dit bestand kun je na het reviewen van de demo applicatie verwijderen.

Start in de gekozen IDE het Carpark.Api project. Swagger UI zou automatisch moeten openen met een overzicht van de API endpoints. Gebeurt dat niet, dan kun je naar /swagger browsen om de UI te openen.

## Beschrijving van het project
Het project is opgezet met een gelaagde architectuur, API, Business, Database en Domain. lagen communiceren naar beneden door afhankelijkheden te injecteren met de ingebouwde Dependency Injection container van .NET Core. Communicatie omhoog gaat middels returns en exceptions.

De solution van beneden naar boven bestaat uit de volgende onderdelen:

- Domain - bevat domein informatie, in dit geval wat een auto is en welke statussen een auto kan hebben.

- Database - Bevat de database modellen en repositories. De repositories doen het vertaalwerk tussen domein modellen en database entiteiten. Dit project maakt gebruikt van [Entity Framework Core](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore) en [Bogus](https://www.nuget.org/packages/Bogus/) voor het genereren van 100 dummy auto's.

- Business - bevat de business logica. de CarService die voorwaarden test en logica doorvoert, een integratie die met OpenData communiceert, en verschillende soorten Excepties.

- Api - Bevat de HTTP bindingen, met Response en Request modellen in een apart Api.Contracts project. De controller maakt de vertaalslag tussen request/response en domein modellen. De controller bevat zelf geen business logica en doet ook geen validatie, maar geeft opdrachten door aan de `CarService` in het business project. Wanneer validatie mislukt gooit de `CarService` een exceptie die in de controller opgevangen wordt en omgezet in een JSON problem details response. Dit zorgt ervoor dat later ook gemakkelijk andere interfaces gekoppeld kunnen worden, zoals een CLI.

Tot slot is er een unit test project aanwezig in de vorm van `Carpark.Business.UnitTests`. Dit project bevat tests om te controleren dat de business logica en validatie goed gaan. Hiervoor wordt gebruik gemaakt van [NUnit](https://www.nuget.org/packages/NUnit) voor de tests zelf en van [Moq](https://www.nuget.org/packages/Moq) voor het mocken van interfaces.




